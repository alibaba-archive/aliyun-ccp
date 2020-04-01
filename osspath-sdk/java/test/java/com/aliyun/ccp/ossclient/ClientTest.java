package com.aliyun.ccp.ossclient;

import com.aliyun.ccp.ossclient.models.*;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;
import static org.junit.Assert.fail;

public class ClientTest {

    private static Client client;

    @Before
    public void createClient() throws Exception {
        Config config = new Config();
        config.domainId = "sz16";
        config.protocol = "http";
        config.accessKeyId = System.getenv("ACCESS_KEY_ID");
        config.accessKeySecret = System.getenv("ACCESS_KEY_SECRET");
        client = new Client(config);
    }

    @Test
    public void listDrives() throws Exception {
        Config config = new Config();
        config.domainId = "sz16";
        config.protocol = "http";
        config.accessKeyId = System.getenv("RAMAccessKeyId");
        config.accessKeySecret = System.getenv("RAMAccessKeySecret");
        Client client = new Client(config);
        ListDriveRequestModel requestModel = new ListDriveRequestModel();
        ListDriveRequest request = new ListDriveRequest();
        requestModel.body = request;
        RuntimeOptions runtime = new RuntimeOptions();
        ListDrivesModel result = client.listDrives(requestModel, runtime);
        assertEquals(2, result.body.items.size());
        assertTrue(result.body.items.get(0) instanceof BaseDriveResponse);
        assertEquals("", result.body.nextMarker);
    }


}
