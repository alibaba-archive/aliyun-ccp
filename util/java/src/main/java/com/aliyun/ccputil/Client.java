// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccputil;

import com.aliyun.tea.*;
import com.aliyun.tea.utils.StringUtils;

import javax.crypto.Mac;
import javax.crypto.spec.SecretKeySpec;
import java.util.*;


public class Client {

    private static final String ALGORITHM_NAME = "HmacSHA1";

    public static String getPathname(String nickName, String path) throws Exception {
        if (StringUtils.isEmpty(nickName)) {
            return path;
        }
        return "/" + nickName + path;
    }

    public static java.util.Map<String, String> toQuery(Map<String, ?> model) throws Exception {
        Map<String, String> map = new HashMap<String, String>();
        for (Map.Entry<String, ?> entry : model.entrySet()) {
            map.put(entry.getKey(), String.valueOf(entry.getValue()));
        }
        return map;
    }

    public static String getSignature(TeaRequest request, String secret) throws Exception {
        String method = request.method;
        String pathname = request.pathname;
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
        mac.init(new SecretKeySpec(secret.getBytes("UTF-8"), ALGORITHM_NAME));
        byte[] signData = mac.doFinal(stringToSign.getBytes("UTF-8"));
        return Base64.getEncoder().encodeToString(signData);
    }

    protected static String getCanonicalizedHeaders(Map<String, String> headers) {
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

    protected static String getCanonicalizedResource(String pathname, Map<String, String> query) {
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

    public static String getUserAgent(String userAgent) throws Exception {
        return com.aliyun.teautil.Common.getUserAgent(userAgent);
    }
}
