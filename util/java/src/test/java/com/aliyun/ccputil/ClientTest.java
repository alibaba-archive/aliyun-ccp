package com.aliyun.ccputil;

import com.aliyun.tea.TeaRequest;
import org.junit.Assert;
import org.junit.Test;

import java.util.HashMap;
import java.util.Map;

public class ClientTest {

    @Test
    public void _getPathnameTest() throws Exception{
        new Client();
        String path = Client.getPathname("", "/test");
        Assert.assertEquals("/test", path);

        path = Client.getPathname("nickname", "/test");
        Assert.assertEquals("/nickname/test", path);
    }

    @Test
    public void _toQueryTest() throws Exception{
        Map<String, String> map = new HashMap<>();
        map.put("test", "1");
        Map<String, String> result = Client.toQuery(map);
        Assert.assertEquals("1", result.get("test"));
    }

    @Test
    public void _getSignatureTest() throws Exception {
        TeaRequest request = new TeaRequest();
        Assert.assertEquals("hD/QuFdv131xEuE0McZ/8dZi6ZQ=", Client.getSignature(request, "test"));

        Map<String, String> requestMap = new HashMap<>();
        requestMap.put("x-acs-security-token", "test");
        requestMap.put("x-acs-security-test", "test");
        requestMap.put("accept", "accept");
        requestMap.put("content-md5", "content-md5");
        requestMap.put("content-type", "content-type");
        requestMap.put("date", "date");
        request.headers = requestMap;
        request.query = requestMap;
        request.pathname = "/test";
        Assert.assertEquals("Y69tKBaO0Z1WEKuDhYnUiltV23s=", Client.getSignature(request, "test"));
    }

    @Test
    public void getUserAgentTest() throws Exception {
        Assert.assertTrue(Client.getUserAgent(null).contains("tea-util"));
        Assert.assertTrue(Client.getUserAgent("test").contains("test"));
    }
}
