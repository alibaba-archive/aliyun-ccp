package com.aliyun.ccp.baseclient.credentials;

import com.aliyun.ccp.baseclient.utils.TimeUtils;
import com.aliyun.credentials.exception.CredentialException;
import com.aliyun.tea.*;
import com.aliyun.tea.utils.StringUtils;
import com.google.gson.Gson;

import java.io.IOException;
import java.net.URISyntaxException;
import java.security.KeyManagementException;
import java.security.NoSuchAlgorithmException;
import java.text.ParseException;
import java.util.HashMap;
import java.util.Map;

public class AccessTokenCredential {
    private String accessToken;
    private String expireTime;
    private String refreshToken;
    private String domainId;
    private String clientId;
    private String clientSecret;

    public AccessTokenCredential(Map<String, Object> config) {
        this.refreshToken = (String) config.get("refresh_token");
        this.domainId = (String) config.get("domainId");
        this.clientId = (String) config.get("clientId");
        this.clientSecret = (String) config.get("clientSecret");
        this.accessToken = (String) config.get("accessToken");
        this.expireTime = (String) config.get("expireTime");
    }

    public void refreshAccessToken() throws NoSuchAlgorithmException, IOException, KeyManagementException,
            IllegalAccessException, URISyntaxException, TeaException {
        TeaRequest request_ = new TeaRequest();
        request_.protocol = "http";
        request_.method = "POST";
        request_.pathname = "/v2/oauth/token";
        request_.headers = TeaConverter.buildMap(
                new TeaPair("host", this.domainId + ".api.alicloudccp.com"),
                new TeaPair("content-type", "application/x-www-form-urlencoded; charset=utf-8"),
                new TeaPair("date", TimeUtils._getGMTDate()),
                new TeaPair("accept", "application/json"),
                new TeaPair("x-acs-signature-method", "HMAC-SHA1"),
                new TeaPair("x-acs-signature-version", "1.0")
        );
        request_.body = String.format("grant_type=refresh_token&refresh_token=%s&client_id=%s&client_secret=%s",
                this.refreshToken, this.clientId, this.clientSecret);
        TeaResponse response_ = Tea.doAction(request_, new HashMap<>());
        String body = response_.getResponseBody();
        Gson gson = new Gson();
        Map<String, Object> map = gson.fromJson(body, Map.class);
        if (response_.statusCode == 200) {
            this.expireTime = (String) map.get("expire_time");
            this.accessToken = (String) map.get("access_token");
            this.refreshToken = (String) map.get("refresh_token");
        } else {
            throw new TeaException(map);
        }
    }

    public String getAccessToken() throws Exception {
        if (null == this.accessToken) {
            throw new CredentialException("accessToken is null");
        }
        if (shouldRefresh(System.currentTimeMillis())) {
            refreshAccessToken();
        }
        return this.accessToken;
    }

    private boolean shouldRefresh(long now) throws ParseException {
        if (StringUtils.isEmpty(this.expireTime) || StringUtils.isEmpty(this.refreshToken)) {
            return false;
        }
        return now >= (TimeUtils._getTime(this.expireTime) - 5000);
    }

    public void setAccessToken(String accessToken) {
        this.accessToken = accessToken;
    }

    public String getExpireTime() {
        return expireTime;
    }

    public void setExpireTime(String expireTime) {
        this.expireTime = expireTime;
    }

    public String getRefreshToken() {
        return refreshToken;
    }

    public void setRefreshToken(String refreshToken) {
        this.refreshToken = refreshToken;
    }
}
