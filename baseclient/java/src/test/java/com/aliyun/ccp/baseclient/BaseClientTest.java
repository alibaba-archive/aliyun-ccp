package com.aliyun.ccp.baseclient;

import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

import com.aliyun.ccp.baseclient.credentials.AccessTokenCredential;
import com.aliyun.credentials.AccessKeyCredential;
import com.aliyun.credentials.StsCredential;
import org.junit.Assert;
import org.junit.Test;

public class BaseClientTest {

    @Test
    public void setCredentialTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        BaseClient baseClient = new BaseClient(map);
        Class clazz = baseClient.getClass();
        Method setCredential = clazz.getDeclaredMethod("setCredential", Map.class);
        setCredential.setAccessible(true);
        map.put("securityToken", "testSecurityToken");
        setCredential.invoke(baseClient, map);
        Assert.assertEquals("testSecurityToken", baseClient._stsCredential.getSecurityToken());

        map.put("accessToken", "testAccessToken");
        setCredential.invoke(baseClient, map);
        Assert.assertEquals("testAccessToken", baseClient._accessTokenCredential.getAccessToken());

        map.put("accessKeyId", "testAccessKeyId");
        map.put("accessKeySecret", "testAccessKeyId");
        setCredential.invoke(baseClient, map);
        Assert.assertEquals("testAccessKeyId", baseClient._accessKeyCredential.getAccessKeyId());
    }


    @Test
    public void getSetTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        BaseClient baseClient = new BaseClient(map);
        baseClient._setAccessKeyId("");
        Assert.assertNull(baseClient._getAccessKeyId());
        baseClient._setAccessKeySecret("");
        Assert.assertNull(baseClient._getAccessKeySecret());
        baseClient._setSecurityToken("");
        Assert.assertNull(baseClient._getSecurityToken());
        baseClient._stsCredential =  new StsCredential("1", "2", "3");
        baseClient._setAccessKeyId("key");
        Assert.assertEquals("key", baseClient._getAccessKeyId());
        baseClient._setAccessKeySecret("Secret");
        Assert.assertEquals("Secret", baseClient._getAccessKeySecret());
        baseClient._setSecurityToken("Token");
        Assert.assertEquals("Token", baseClient._getSecurityToken());

        baseClient._accessKeyCredential = new AccessKeyCredential("ak", "ak");
        Assert.assertEquals("ak", baseClient._getAccessKeyId());
        Assert.assertEquals("ak", baseClient._getAccessKeySecret());

        baseClient._setAccessToken("");
        Assert.assertNull(baseClient._getAccessToken());
        baseClient._setExpireTime("");
        Assert.assertNull(baseClient._getExpireTime());
        baseClient._setRefreshToken("");
        Assert.assertNull(baseClient._getRefreshToken());
        baseClient._accessTokenCredential =  new AccessTokenCredential(new HashMap<>());
        baseClient._setAccessToken("token");
        Assert.assertEquals("token",baseClient._getAccessToken());
        baseClient._setExpireTime("12345");
        Assert.assertEquals("12345",baseClient._getExpireTime());
        baseClient._setRefreshToken("refresh");
        Assert.assertEquals("refresh",baseClient._getRefreshToken());
    }

    @Test
    public void _getRFC2616Date() {
        BaseClient base = new BaseClient(new HashMap<String, Object>() {
            /**
             *
             */
            private static final long serialVersionUID = 1L;

            {
                put("accessKeyId", "fakeAccessKeyId");
                put("accessKeySecret", "fakeAccessKeySecret");
            }
        });
        String date = base._getRFC2616Date();
        // 'Mon, 30 Sep 2019 06:55:50 GMT'
        Assert.assertEquals(date.length(), 29);
        Assert.assertTrue(base._getRFC2616Date().matches("\\w{3}, \\d{2} \\w{3} \\d{4} \\d{2}:\\d{2}:\\d{2} GMT"));
    }
}
