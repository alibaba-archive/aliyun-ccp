package com.aliyun.ccp.baseclient;

import com.aliyun.ccp.baseclient.credentials.AccessTokenCredential;
import com.aliyun.credentials.AccessKeyCredential;
import com.aliyun.credentials.StsCredential;
import com.aliyun.tea.TeaRequest;
import com.aliyun.tea.TeaResponse;
import org.junit.Assert;
import org.junit.Test;
import org.mockito.Mockito;

import java.io.IOException;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

public class BaseClientTest {

    @Test
    public void setCredentialTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        BaseClient baseClient = new BaseClient(map);
        Class clazz = baseClient.getClass();
        Method setCredential = clazz.getDeclaredMethod("setCredential", Map.class);
        setCredential.setAccessible(true);

        map.put("accessKeyId", "testAccessKeyId");
        map.put("accessKeySecret", "testAccessKeyId");
        setCredential.invoke(baseClient, map);
        Assert.assertEquals("testAccessKeyId", baseClient._accessKeyCredential.getAccessKeyId());

        map.put("accessToken", "testAccessToken");
        setCredential.invoke(baseClient, map);
        Assert.assertEquals("testAccessToken", baseClient._accessTokenCredential.getAccessToken());

        map.put("securityToken", "testSecurityToken");
        setCredential.invoke(baseClient, map);
        Assert.assertEquals("testSecurityToken", baseClient._stsCredential.getSecurityToken());
    }

    @Test
    public void _getPathnameTest() {
        Map<String, Object> map = new HashMap<>();
        BaseClient baseClient = new BaseClient(map);
        String path = baseClient._getPathname("", "/test");
        Assert.assertEquals("/test", path);

        path = baseClient._getPathname("nickname", "/test");
        Assert.assertEquals("/nickname/test", path);
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
        baseClient._stsCredential = new StsCredential("1", "2", "3");
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
        baseClient._accessTokenCredential = new AccessTokenCredential(new HashMap<>());
        baseClient._setAccessToken("token");
        Assert.assertEquals("token", baseClient._getAccessToken());
        baseClient._setExpireTime("12345");
        Assert.assertEquals("12345", baseClient._getExpireTime());
        baseClient._setRefreshToken("refresh");
        Assert.assertEquals("refresh", baseClient._getRefreshToken());
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

    @Test
    public void toJSONStringTest() {
        Map<String, Object> map = new HashMap<>();
        map.put("test", "1");
        BaseClient baseClient = new BaseClient(map);
        String json = baseClient._toJSONString(map);
        Assert.assertEquals("{\"test\":\"1\"}", json);
    }

    @Test
    public void userAgentTest() {
        Map<String, Object> map = new HashMap<>();
        BaseClient baseClient = new BaseClient(map);
        Assert.assertTrue(BaseClient._defaultUserAgent.contains("AlibabaCloud"));
        Assert.assertTrue(baseClient._getUserAgent().contains("Java"));

        baseClient._setUserAgent("test/test");
        Assert.assertTrue(baseClient._getUserAgent().endsWith("test/test"));

        baseClient._appendUserAgent("test1/test1");
        Assert.assertTrue(baseClient._getUserAgent().endsWith("test/test test1/test1"));
    }

    @Test
    public void _toQueryTest() {
        Map<String, Object> map = new HashMap<>();
        map.put("test", 1);
        BaseClient baseClient = new BaseClient(map);
        Map<String, String> result = baseClient._toQuery(map);
        Assert.assertEquals("1", result.get("test"));
    }

    @Test
    public void _defaultTest() {
        BaseClient baseClient = new BaseClient(new HashMap<>());
        String result = baseClient._default(1, "3");
        Assert.assertEquals("1", result);

        result = baseClient._default(null, "3");
        Assert.assertEquals("3", result);
    }

    @Test
    public void _defaultNumberTest() {
        BaseClient baseClient = new BaseClient(new HashMap<>());
        int result = baseClient._defaultNumber(1, 3);
        Assert.assertEquals(1, result);

        result = baseClient._defaultNumber(-1, 3);
        Assert.assertEquals(3, result);

        result = baseClient._defaultNumber(null, 3);
        Assert.assertEquals(3, result);

        TeaResponse response = new TeaResponse();
        response.statusCode = 200;
        Assert.assertTrue(baseClient._isStatusCode(response, 200));
        Assert.assertFalse(baseClient._isStatusCode(response, 500));
    }

    @Test
    public void _readAsJSONTest() throws IOException {
        BaseClient baseClient = new BaseClient(new HashMap<>());
        TeaResponse response = Mockito.mock(TeaResponse.class);
        Mockito.doReturn("{\"test\":\"1\"}").when(response).getResponseBody();
        Map<String, Object> map = baseClient._readAsJSON(response);
        Assert.assertEquals("1", map.get("test"));
    }

    @Test
    public void getMethodTest() throws Exception {
        BaseClient baseClient = new BaseClient(new HashMap<>());
        Assert.assertFalse(baseClient._notEmpty(null));
        Assert.assertFalse(baseClient._notEmpty("null"));
        Assert.assertFalse(baseClient._notEmpty(""));
        Assert.assertTrue(baseClient._notEmpty("1234"));

        Assert.assertEquals("getHost", baseClient._getHost("null", "getHost"));
        Assert.assertEquals("endpoint", baseClient._getHost("endpoint", "getHost"));

        Assert.assertEquals("_getProtocol", baseClient._getProtocol("null", "_getProtocol"));
        Assert.assertEquals("http", baseClient._getProtocol("http", "getHost"));

        Assert.assertNull(baseClient.percentEncode(null));
        Assert.assertEquals("%2B%2A%257E", baseClient.percentEncode("+*%7E"));
    }

    @Test
    public void getCanonicalizedResourceTest() {
        BaseClient baseClient = new BaseClient(new HashMap<>());
        Map<String, String> query = new HashMap<>();
        Assert.assertEquals("www.aliyun.com", baseClient.getCanonicalizedResource("www.aliyun.com",
                query));
        query.put("test", "1");
        Assert.assertEquals("www.aliyun.com?test=1",
                baseClient.getCanonicalizedResource("www.aliyun.com", query));
    }

    @Test
    public void getCanonicalizedHeadersTest() {
        BaseClient baseClient = new BaseClient(new HashMap<>());
        Map<String, String> header = new HashMap<>();
        header.put("test", "1");
        header.put("x-acs-z", "test-z");
        header.put("x-acs-a", "test-a");
        Assert.assertEquals("x-acs-a:test-a\nx-acs-z:test-z", baseClient.getCanonicalizedHeaders(header));
    }

    @Test
    public void _getSignatureTest() throws Exception {
        Map<String, Object> config = new HashMap<>();
        config.put("accessKeySecret", "test");
        BaseClient baseClient = new BaseClient(config);
        TeaRequest request = new TeaRequest();
        Assert.assertEquals("hD/QuFdv131xEuE0McZ/8dZi6ZQ=", baseClient._getSignature(request));

        Map<String, String> requestMap = new HashMap<>();
        requestMap.put("x-acs-security-token", "test");
        requestMap.put("accept", "accept");
        requestMap.put("content-md5", "content-md5");
        requestMap.put("content-type", "content-type");
        requestMap.put("date", "date");
        request.headers = requestMap;
        StsCredential credential = new StsCredential("ak", "sk", "tk");
        baseClient._stsCredential = credential;
        Assert.assertEquals("XJzZgM6z1UQKZxnX2We8TaLr+P4=", baseClient._getSignature(request));
    }
}
