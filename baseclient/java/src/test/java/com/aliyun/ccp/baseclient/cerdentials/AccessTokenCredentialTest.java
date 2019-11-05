package com.aliyun.ccp.baseclient.cerdentials;

import com.aliyun.ccp.baseclient.credentials.AccessTokenCredential;
import com.aliyun.tea.Tea;
import com.aliyun.tea.TeaResponse;
import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.powermock.api.mockito.PowerMockito;
import org.powermock.core.classloader.annotations.PrepareForTest;
import org.powermock.modules.junit4.PowerMockRunner;

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

import static org.mockito.Matchers.any;

@RunWith(PowerMockRunner.class)
@PrepareForTest({Tea.class})
public class AccessTokenCredentialTest {
    @Test
    public void getHostTest() {
        Map<String, Object> map = new HashMap<>();
        AccessTokenCredential credential = new AccessTokenCredential(map);
        Assert.assertEquals("domain", credential.getHost(null, "domain"));
        Assert.assertEquals("endpoint", credential.getHost("endpoint", null));
        Assert.assertEquals("domain", credential.getHost("", "domain"));
    }

    @Test
    public void constructorTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        map.put("refreshToken", "refreshToken");
        map.put("accessToken", "accessToken");
        map.put("expireTime", "4000-01-01T12:12:12Z");
        AccessTokenCredential credential = new AccessTokenCredential(map);
        Assert.assertEquals("4000-01-01T12:12:12Z", credential.getExpireTime());
        Assert.assertEquals("refreshToken", credential.getRefreshToken());
        Assert.assertEquals("accessToken", credential.getAccessToken());
    }

    @Test
    public void getSetTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        AccessTokenCredential credential = new AccessTokenCredential(map);
        try {
            credential.getAccessToken();
            Assert.fail();
        } catch (Exception e) {
            Assert.assertEquals("accessToken is null", e.getMessage());
        }

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

    @Test
    public void refreshAccessTokenTest() throws Exception {
        TeaResponse response = PowerMockito.spy(new TeaResponse());
        response.statusCode = 200;
        Mockito.doReturn("{\n" +
                "  \"expire_time\":\"2000-01-01T12:12:12Z\",\n" +
                " \"access_token\":\"test\",\n" +
                " \"refresh_token\":\"test\",\n" +
                " \"message\":\"test\"}").when(response).getResponseBody();
        PowerMockito.mockStatic(Tea.class);
        PowerMockito.when(Tea.doAction(any(), any())).thenReturn(response);
        AccessTokenCredential credential = new AccessTokenCredential(new HashMap<>());
        credential.refreshAccessToken();
        Assert.assertEquals("test", credential.getAccessToken());
        Assert.assertEquals("test", credential.getAccessToken());
        Assert.assertEquals("test", credential.getRefreshToken());
        Assert.assertEquals("2000-01-01T12:12:12Z", credential.getExpireTime());

        response.statusCode = 500;
        try {
            credential.refreshAccessToken();
            Assert.fail();
        } catch (Exception e) {
            Assert.assertEquals("test", e.getMessage());
        }
    }
}
