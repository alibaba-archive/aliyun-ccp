package com.aliyun.ccp.baseclient.cerdentials;

import com.aliyun.ccp.baseclient.credentials.AccessTokenCredential;
import org.junit.Assert;
import org.junit.Test;

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

public class AccessTokenCredentialTest {

    @Test
    public void constructorTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        map.put("refresh_token", "refresh_token");
        map.put("accessToken", "accessToken");
        map.put("expireTime", "4000-01-01T12:12:12Z");
        AccessTokenCredential credential = new AccessTokenCredential(map);
        Assert.assertEquals("4000-01-01T12:12:12Z", credential.getExpireTime());
        Assert.assertEquals("refresh_token", credential.getRefreshToken());
        Assert.assertEquals("accessToken", credential.getAccessToken());
    }

    @Test
    public void getSetTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        AccessTokenCredential credential = new AccessTokenCredential(map);
        credential.setAccessToken("test");
        Assert.assertEquals("test", credential.getAccessToken());
    }

    @Test
    public void shouldRefreshTest() throws NoSuchMethodException, InvocationTargetException, IllegalAccessException {
        Method shouldRefresh = AccessTokenCredential.class.getDeclaredMethod("shouldRefresh", long.class);
        shouldRefresh.setAccessible(true);
        Map<String, Object> map = new HashMap<>();
        AccessTokenCredential credential = new AccessTokenCredential(map);
        Assert.assertFalse((boolean) shouldRefresh.invoke(credential, 1000L));

        credential.setExpireTime("2000-01-01T12:12:12Z");
        Assert.assertFalse((boolean) shouldRefresh.invoke(credential, 1000L));

        credential.setRefreshToken("test");
        Assert.assertTrue((boolean) shouldRefresh.invoke(credential, 1572509376182L));
    }
}
