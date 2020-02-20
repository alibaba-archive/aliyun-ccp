// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccpcredentials;

import com.aliyun.ccpcredentials.models.Config;
import com.aliyun.tea.*;
import com.aliyun.tea.utils.StringUtils;
import com.google.gson.Gson;

import javax.security.auth.login.CredentialException;
import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.security.KeyManagementException;
import java.security.NoSuchAlgorithmException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

public class Client {

    private String accessToken;
    private String expireTime;
    private String refreshToken;
    private String domainId;
    private String clientId;
    private String clientSecret;
    private String endpoint;

    public Client(Config config) {
        this.refreshToken = config.refreshToken;
        this.domainId = config.domainId;
        this.endpoint = config.endpoint;
        this.clientId = config.clientId;
        this.clientSecret = config.clientSecret;
        this.accessToken = config.accessToken;
        this.expireTime = config.expireTime;
    }


    public void setExpireTime(String expireTime) throws Exception {
        this.expireTime = expireTime;
    }

    public String getExpireTime() throws Exception {
        return this.expireTime;
    }

    public String getRefreshToken() throws Exception {
        return this.refreshToken;
    }

    public void setRefreshToken(String refreshToken) throws Exception {
        this.refreshToken = refreshToken;
    }

    public void setAccessToken(String accessToken) throws Exception {
        this.accessToken = accessToken;
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

    protected boolean shouldRefresh(long now) throws ParseException {
        if (StringUtils.isEmpty(this.expireTime) || StringUtils.isEmpty(this.refreshToken)) {
            return false;
        }
        return now >= (getTime(this.expireTime) - 5000);
    }

    public long getTime(String date) throws ParseException {
        SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss'Z'");
        df.setTimeZone(TimeZone.getTimeZone("GMT"));
        return df.parse(date).getTime();
    }

    public static String getGMTDate() {
        SimpleDateFormat df = new SimpleDateFormat("EEE, dd MMM yyyy HH:mm:ss z", Locale.US);
        df.setTimeZone(TimeZone.getTimeZone("GMT"));
        return df.format(new Date());
    }

    public String getHost(String endpoint, String domain) {
        if (null != endpoint && endpoint.trim().length() > 0) {
            return endpoint;
        } else {
            return domain;
        }
    }

    public void refreshAccessToken() throws NoSuchAlgorithmException, IOException, KeyManagementException,
            TeaException {
        TeaRequest request_ = new TeaRequest();
        request_.protocol = "http";
        request_.method = "POST";
        request_.pathname = "/v2/oauth/token";
        request_.headers = TeaConverter.buildMap(
                new TeaPair("host", getHost(this.endpoint, this.domainId + ".api.alicloudccp.com")),
                new TeaPair("content-type", "application/x-www-form-urlencoded; charset=utf-8"),
                new TeaPair("date", getGMTDate()),
                new TeaPair("accept", "application/json"),
                new TeaPair("x-acs-signature-method", "HMAC-SHA1"),
                new TeaPair("x-acs-signature-version", "1.0")
        );
        String bodyString = String.format("grant_type=refresh_token&refresh_token=%s&client_id=%s&client_secret=%s",
                this.refreshToken, this.clientId, this.clientSecret);
        request_.body = new ByteArrayInputStream(bodyString.getBytes("UTF-8"));
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
}
