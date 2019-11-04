package com.aliyun.ccp.baseclient.utils;

import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Test;

import java.text.ParseException;

public class TimeUtilsTest {

    @AfterClass
    public static void timeUtilsTest() {
        new TimeUtils();
    }

    @Test
    public void getTimeTest() throws ParseException {
        long time = TimeUtils._getTime("1970-01-01T00:00:00Z");
        Assert.assertEquals(0, time);
    }

    @Test
    public void getGMTDateTest() throws ParseException {
        String time = TimeUtils._getGMTDate();
        Assert.assertNotNull(time);
    }
}
