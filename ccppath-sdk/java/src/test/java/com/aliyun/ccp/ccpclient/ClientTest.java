package com.aliyun.ccp.ccpclient;

import com.aliyun.ccp.ccpclient.models.*;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ClientTest {

    private static Client client;

    @Before
    public void createClient() throws Exception {
        Config config = new Config();
        config.domainId = "sz16";
        config.protocol = "http";
        config.accessKeyId = System.getenv("RAMAccessKeyId");
        config.accessKeySecret = System.getenv("RAMAccessKeySecret");
        client = new Client(config);
    }

    @Test
    public void listDrives() throws Exception {
        ListDriveRequestModel requestModel = new ListDriveRequestModel();
        ListDriveRequest request = new ListDriveRequest();
        requestModel.body = request;
        RuntimeOptions runtime = new RuntimeOptions();
        ListDrivesModel result = client.listDrives(requestModel, runtime);
        assertEquals(2, result.body.items.size());
        assertEquals("", result.body.nextMarker);
    }
}
