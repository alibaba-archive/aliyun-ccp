package com.aliyun.ccp.baseclient;

import com.aliyun.ccp.baseclient.credentials.AccessTokenCredential;
import com.aliyun.credentials.AccessKeyCredential;
import com.aliyun.credentials.StsCredential;
import com.aliyun.tea.TeaRequest;
import com.aliyun.tea.TeaResponse;
import com.aliyun.tea.utils.StringUtils;
import com.google.gson.Gson;

import javax.crypto.Mac;
import javax.crypto.spec.SecretKeySpec;
import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import java.text.SimpleDateFormat;
import java.util.*;
import java.util.Map.Entry;

public class BaseClient {
    public final static String URL_ENCODING = "UTF-8";
    private static final String ALGORITHM_NAME = "HmacSHA1";
    protected String _domainId;
    protected String _protocol;
    protected Object _endpoint;
    protected Map<String, Object> _config;
    protected AccessKeyCredential _accessKeyCredential;
    protected AccessTokenCredential _accessTokenCredential;
    protected StsCredential _stsCredential;

    public BaseClient(Map<String, Object> config) {
        this._domainId = (String) config.get("domainId");
        this._protocol = (String) config.get("protocol");
        this._endpoint = (String) config.get("endpoint");
        setCredential(config);
        this._config = config;
    }

    private void setCredential(Map<String, Object> config) {
        if (!StringUtils.isEmpty(config.get("securityToken"))) {
            _stsCredential = new StsCredential((String) config.get("accessKeyId"),
                    (String) config.get("accessKeySecret"), (String) config.get("securityToken"));
        } else if (!StringUtils.isEmpty(config.get("accessToken"))) {
            _accessTokenCredential = new AccessTokenCredential(config);
        } else if (!StringUtils.isEmpty(config.get("accessKeyId"))) {
            _accessKeyCredential = new AccessKeyCredential((String) config.get("accessKeyId"),
                    (String) config.get("accessKeySecret"));
        }
    }

    public String _getRFC2616Date() {
        SimpleDateFormat df = new SimpleDateFormat("EEE, dd MMM yyyy HH:mm:ss z", Locale.US);
        df.setTimeZone(TimeZone.getTimeZone("GMT"));
        return df.format(new Date());
    }

    public String _getUserAgent() {
        return "";
    }

    public String getCanonicalizedHeaders(Map<String, String> headers) {
        String prefix = "x-acs-";
        Set<String> keys = headers.keySet();
        List<String> canonicalizedKeys = new ArrayList<>();
        for (String key : keys) {
            if (key.startsWith(prefix)) {
                canonicalizedKeys.add(key);
            }
        }
        String[] canonicalizedKeysArray = canonicalizedKeys.toArray(new String[canonicalizedKeys.size()]);
        Arrays.sort(canonicalizedKeysArray);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < canonicalizedKeysArray.length; i++) {
            if (i > 0) {
                result.append("\n");
            }
            String key = canonicalizedKeysArray[i];
            result.append(key);
            result.append(":");
            result.append(headers.get(key).trim());
        }
        return result.toString();
    }

    public String getCanonicalizedResource(String pathname, Map<String, String> query) {
        String[] keys = query.keySet().toArray(new String[query.size()]);
        if (keys.length <= 0) {
            return pathname;
        }
        StringBuilder result = new StringBuilder(pathname);
        result.append("?");
        String key;
        for (int i = 0; i < keys.length; i++) {
            key = keys[i];
            result.append(key);
            result.append("=");
            result.append(query.get(key));
        }
        return result.toString();
    }


    public String _getSignature(TeaRequest request) throws UnsupportedEncodingException, NoSuchAlgorithmException, InvalidKeyException {
        String method = request.method;
        String pathname = request.pathname;
        if (null != this._getSecurityToken()) {
            request.headers.put("x-acs-security-token", this._getSecurityToken());
        }
        Map<String, String> headers = request.headers;
        Map<String, String> query = request.query;
        String accept = headers.get("accept") == null ? "" : headers.get("accept");
        String contentMD5 = headers.get("content-md5") == null ? "" : headers.get("content-md5");
        String contentType = headers.get("content-type") == null ? "" : headers.get("content-type");
        String date = headers.get("date") == null ? "" : headers.get("date");
        String header = method + "\n" + accept + "\n" + contentMD5 + "\n" + contentType + "\n" + date;
        String canonicalizedHeaders = getCanonicalizedHeaders(headers);
        String canonicalizedResource = getCanonicalizedResource(pathname, query);
        String stringToSign = header + "\n" + canonicalizedHeaders + "\n" + canonicalizedResource;
        Mac mac = Mac.getInstance(ALGORITHM_NAME);
        mac.init(new SecretKeySpec(((String) _config.get("accessKeySecret")).getBytes(URL_ENCODING), ALGORITHM_NAME));
        byte[] signData = mac.doFinal(stringToSign.getBytes(URL_ENCODING));
        return Base64.getEncoder().encodeToString(signData);
    }

    public String percentEncode(String value) throws UnsupportedEncodingException {
        return value != null
                ? URLEncoder.encode(value, URL_ENCODING).replace("+", "%20").replace("*", "%2A").replace("%7E", "~")
                : null;
    }

    protected String _getProtocol(String protocol, String https) {
        if (_notEmpty(protocol)) {
            return protocol;
        }
        return https;
    }

    protected Object _getHost(Object endpoint, String s) {
        if (_notEmpty(String.valueOf(endpoint))) {
            return endpoint;
        }
        return s;
    }

    protected boolean _notEmpty(String str) {
        if (null == str || "null".equals(str.trim())) {
            return false;
        }
        if (str.trim().length() <= 0) {
            return false;
        }
        return true;
    }

    protected String _toJSONString(Object request) {
        return new Gson().toJson(request);
    }

    protected boolean _isStatusCode(TeaResponse response_, int code) {
        return response_.statusCode == code;
    }

    @SuppressWarnings("unchecked")
    protected Map<String, Object> _readAsJSON(TeaResponse response_) throws IOException {
        String body = response_.getResponseBody();
        Gson gson = new Gson();
        Map<String, Object> map = gson.fromJson(body, Map.class);
        return map;
    }

    public Map<String, String> _toQuery(Map<String, Object> request) {
        Map<String, String> map = new HashMap<String, String>();
        for (Entry<String, Object> entry : request.entrySet()) {
            map.put(entry.getKey(), entry.getValue().toString());
        }
        return map;
    }

    public int _defaultNumber(Integer maxAttempts, int defaultNumber) {
        if (maxAttempts != null && maxAttempts >= 0) {
            return maxAttempts;
        }
        return defaultNumber;
    }

    public String _default(Object maxAttempts, String defaultStr) {
        if (null != maxAttempts) {
            return String.valueOf(maxAttempts);
        }
        return defaultStr;
    }

    public String _getAccessKeyId() {
        if (null != this._accessKeyCredential) {
            return this._accessKeyCredential.getAccessKeyId();
        } else if (null != this._stsCredential) {
            return this._stsCredential.getAccessKeyId();
        }
        return null;
    }

    public String _getAccessKeySecret() {
        if (null != this._accessKeyCredential) {
            return this._accessKeyCredential.getAccessKeySecret();
        } else if (null != this._stsCredential) {
            return this._stsCredential.getAccessKeySecret();
        }
        return null;
    }

    public void _setAccessKeyId(String accessKeyId) {
        if (null != this._stsCredential) {
            this._stsCredential.setAccessKeyId(accessKeyId);
        }
    }

    public void _setAccessKeySecret(String accessKeySecret) {
        if (null != this._stsCredential) {
            this._stsCredential.setAccessKeySecret(accessKeySecret);
        }
    }

    public String _getSecurityToken() {
        if (null != this._stsCredential) {
            return this._stsCredential.getSecurityToken();
        }
        return null;
    }

    public void _setSecurityToken(String securityToken) {
        if (null != this._stsCredential) {
            this._stsCredential.setSecurityToken(securityToken);
        }
    }

    public String _getAccessToken() throws Exception {
        if (null != _accessTokenCredential) {
            return this._accessTokenCredential.getAccessToken();
        }
        return null;
    }

    public void _setAccessToken(String accessToken) {
        if (null != _accessTokenCredential) {
            this._accessTokenCredential.setAccessToken(accessToken);
        }
    }

    public void _setRefreshToken(String refreshToken) {
        if (null != _accessTokenCredential) {
            this._accessTokenCredential.setRefreshToken(refreshToken);
        }
    }

    public void _setExpireTime(String expireTime) {
        if (null != _accessTokenCredential) {
            this._accessTokenCredential.setExpireTime(expireTime);
        }
    }

    public String _getRefreshToken() {
        if (null != _accessTokenCredential) {
            return this._accessTokenCredential.getRefreshToken();
        }
        return null;
    }

    public String _getExpireTime() {
        if (null != _accessTokenCredential) {
            return this._accessTokenCredential.getExpireTime();
        }
        return null;
    }
}