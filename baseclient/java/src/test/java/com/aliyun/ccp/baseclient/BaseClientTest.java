package com.aliyun.ccp.baseclient;

import java.util.HashMap;

import org.junit.Assert;
import org.junit.Test;

public class BaseClientTest {

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
