package com.aliyun.ccpcredentials;

import com.aliyun.ccpcredentials.models.Config;
import com.aliyun.tea.Tea;
import com.aliyun.tea.TeaResponse;
import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.powermock.api.mockito.PowerMockito;
import org.powermock.core.classloader.annotations.PrepareForTest;
import org.powermock.modules.junit4.PowerMockRunner;

import static org.mockito.Matchers.any;

@RunWith(PowerMockRunner.class)
@PrepareForTest({Tea.class})
public class ClientTest {
    @Test
    public void getHostTest() {
        Client client = new Client(new Config());
        Assert.assertEquals("domain", client.getHost(null, "domain"));
        Assert.assertEquals("endpoint", client.getHost("endpoint", null));
        Assert.assertEquals("domain", client.getHost("", "domain"));
    }

    @Test
    public void constructorTest() throws Exception {
        Config config = new Config();
        config.refreshToken = "refreshToken";
        config.accessToken = "accessToken";
        config.expireTime = "4000-01-01T12:12:12Z";
        Client client = new Client(config);
        Assert.assertEquals("4000-01-01T12:12:12Z", client.getExpireTime());
        Assert.assertEquals("refreshToken", client.getRefreshToken());
        Assert.assertEquals("accessToken", client.getAccessToken());
    }

    @Test
    public void getSetTest() throws Exception {
        Client client = new Client(new Config());
        try {
            client.getAccessToken();
            Assert.fail();
        } catch (Exception e) {
            Assert.assertEquals("accessToken is null", e.getMessage());
        }

        client.setAccessToken("test");
        Assert.assertEquals("test", client.getAccessToken());

        client.setExpireTime("1");
        Assert.assertEquals("1", client.getExpireTime());

        client.setRefreshToken("token");
        Assert.assertEquals("token", client.getRefreshToken());
    }

    @Test
    public void shouldRefreshTest() throws Exception {
        Config config = new Config();
        Client client = new Client(config);
        Assert.assertFalse(client.shouldRefresh(1000L));

        config.expireTime = "2000-01-01T12:12:12Z";
        client = new Client(config);
        Assert.assertFalse(client.shouldRefresh(1000L));

        config.refreshToken = "test";
        client = new Client(config);
        Assert.assertTrue(client.shouldRefresh(1572509376182L));
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
        Client client = new Client(new Config());
        client.refreshAccessToken();
        Assert.assertEquals("test", client.getAccessToken());
        Assert.assertEquals("test", client.getAccessToken());
        Assert.assertEquals("test", client.getRefreshToken());
        Assert.assertEquals("2000-01-01T12:12:12Z", client.getExpireTime());

        response.statusCode = 500;
        try {
            client.refreshAccessToken();
            Assert.fail();
        } catch (Exception e) {
            Assert.assertEquals("test", e.getMessage());
        }
    }
}
