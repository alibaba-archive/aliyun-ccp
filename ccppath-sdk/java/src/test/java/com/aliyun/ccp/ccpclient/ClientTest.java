package com.aliyun.ccp.ccpclient;

import com.aliyun.ccp.ccpclient.models.*;
import com.aliyun.tea.TeaException;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.fail;

public class ClientTest {

    private static Client client;

    @Before
    public void createClient() throws Exception {
        Config config = new Config();
        config.domainId = "sz16";
        config.protocol = "http";
        config.accessKeyId = System.getenv("accessKeyId");
        config.accessKeySecret = System.getenv("accessKeySecret");
        client = new Client(config);
    }
    @Test
    public void getAsyncTaskInfo() throws Exception {
        CCPGetAsyncTaskRequest request = new CCPGetAsyncTaskRequest();
        request.asyncTaskId = "test";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.getAsyncTaskInfo(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("Header Authorization is not valid. OnlySupportAccessToken", e.getMessage());
        }
    }

    @Test
    public void createDrive() throws Exception {
        CreateDriveRequest request = new CreateDriveRequest();
        request.driveName = "testDrive";
        request.owner = "testOwner";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.createDrive(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("The input parameter owner is not valid. owner testOwner is not exist ", e.getMessage());
        }
    }

    @Test
    public void updateDrive() throws Exception {
        UpdateDriveRequest request = new UpdateDriveRequest();
        request.driveName = "testDrive";
        request.driveId = "test";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.updateDrive(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("The resource Drive cannot be found. Please check. drive_id is test", e.getMessage());
        }
    }

    @Test
    public void listDrives() throws Exception {
        ListDriveRequest request = new ListDriveRequest();
        RuntimeOptions runtime = new RuntimeOptions();
        ListDriveResponse result = client.listDrives(request, runtime);
        assertEquals(2, result.items.length);
        assertEquals("", result.nextMarker);
    }

    @Test
    public void listMyDrives() throws Exception {
        ListMyDriveRequest request = new ListMyDriveRequest();
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.listMyDrives(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("Header Authorization is not valid. OnlySupportAccessToken", e.getMessage());
        }
    }

    @Test
    public void listUploadedParts() throws Exception {
        CCPListUploadedPartRequest request = new CCPListUploadedPartRequest();
        request.fileId = "111";
        request.driveId = "123";
        request.uploadId = "123";
        request.limit = 10L;
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.listUploadedParts(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("The resource drive cannot be found. Please check. Drive does not exist. drive_id is 123",
                    e.getMessage());
        }
    }

    @Test
    public void deleteDrive() throws Exception {
        DeleteDriveRequest request = new DeleteDriveRequest();
        request.driveId = "123";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.deleteDrive(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("The resource drive cannot be found. Please check. drive does not exist. drive_id is 123",
                    e.getMessage());
        }
    }

    @Test
    public void getDrive() throws Exception {
        GetDriveRequest request = new GetDriveRequest();
        request.driveId = "123";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.getDrive(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("The resource drive cannot be found. Please check. Drive does not exist. drive_id is 123",
                    e.getMessage());
        }
    }

    @Test
    public void getDefaultDrive() throws Exception {
        GetDefaultDriveRequest request = new GetDefaultDriveRequest();
        request.userId = "test";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.getDefaultDrive(request, runtime);
            fail();
        } catch (TeaException e) {
            assertEquals("The resource user cannot be found. Please check. user id is test", e.getMessage());
        }
    }

    @Test
    public void  setPassword(){
        DefaultSetPasswordRequest request = new DefaultSetPasswordRequest();
        request.appId = "test";
        request.newPassword = "test";
        request.state = "success";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.setPassword(request,runtime);
            fail();
        } catch (Exception e) {
            Assert.assertEquals("sz16.auth.alicloudccp.com", e.getMessage());
        }
    }
    @Test
    public void checkExistTest(){
        MobileCheckExistRequest request = new MobileCheckExistRequest();
        request.appId = "test";
        request.phoneNumber = "13933584688";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.checkExist(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("sz16.auth.alicloudccp.com",e.getMessage());
        }
    }
    @Test
    public void loginTest(){
        MobileLoginRequest request = new MobileLoginRequest();
        request.appId = "test";
        request.captchaId = "1234";
        request.captchaText = "test1";
        request.password = "password";
        request.phoneNumber = "13933584688";
        request.smsCode = "123";
        request.smsCodeId = "456";
        RuntimeOptions runtime = new RuntimeOptions();
        try{
            client.login(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("sz16.auth.alicloudccp.com",e.getMessage());
        }
    }
    @Test
    public void registerTest(){
        MobileRegisterRequest request = new MobileRegisterRequest();
        request.appId = "testAppId";
        request.phoneNumber = "1329834765";
        request.smsCode = "testSms";
        request.smsCodeId = "testSmsId";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.register(request,runtime);
        }catch (Exception e){
            Assert.assertEquals("sz16.auth.alicloudccp.com",e.getMessage());
        }
    }
    @Test
    public void mobileSendSmsCodeTest(){
        MobileSendSmsCodeRequest request = new MobileSendSmsCodeRequest();
        request.appId = "testAppId";
        request.captchaId = "testCapId";
        request.captchaText = "testCapText";
        request.phoneNumber = "12346789097";
        request.type = "testType";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.mobileSendSmsCode(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("sz16.auth.alicloudccp.com",e.getMessage());
        }
    }
    @Test
    public void tokenTest(){
        TokenRequest request = new TokenRequest();
        request.appId = "testApp";
        request.grantType = "testType";
        request.refreshToken = "TestToken";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.token(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("sz16.auth.alicloudccp.com",e.getMessage());
        }
    }
    @Test
    public void  createUserTest(){
        CreateUserRequest request = new CreateUserRequest();
        request.avatar = "test";
        request.description = "test";
        request.email = "41523131@1aliyun.com";
        request.nickName = "test";
        request.phone = "123456";
        request.role = "test";
        request.status = "success";
        request.userId = "1456";
        request.userName = "testUser";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            CreateUserResponse response = client.createUser(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("The input parameter role is not valid. role range is user or admin or superadmin",
                    e.getMessage());
        }
    }
    @Test
    public void deleteUserTest(){
        DeleteUserRequest request = new DeleteUserRequest();
        request.userId = "testUser";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.deleteUser(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("The resource user cannot be found. Please check. user_id is testUser",
                    e.getMessage());
        }
    }
    @Test
    public void getUserTest(){
        GetUserRequest request = new GetUserRequest();
        request.userId = "testUser";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.getUser(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("The resource user cannot be found. Please check. user id is testUser",
                    e.getMessage());
        }
    }
    @Test
    public void listUsersTest(){
        ListUserRequest request = new ListUserRequest();
        request.limit = 10 ;
        request.marker = "test";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.listUsers(request,runtime);
        }catch (Exception e){
            Assert.assertEquals("The request has been failed due to some unknown error. Please try again later.",
                    e.getMessage());
        }
    }
    @Test
    public void searchUserTest(){
        SearchUserRequest request = new SearchUserRequest();
        request.email = "2131@aliyun.com";
        request.limit = 2 ;
        request.marker = "test";
        request.nickName = "testNick";
        request.phone = "13933377213";
        request.role = "testRole";
        request.status = "success";
        request.userName = "testUser";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.searchUser(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("The input parameter role is not valid. role range is user or admin or superadmin",
                    e.getMessage());
        }
    }
    @Test
    public void updateUserTest(){
        UpdateUserRequest request = new UpdateUserRequest();
        request.avatar = "test";
        request.description = "test12";
        request.email = "4152313@aliyun.com";
        request.nickName = "testNick";
        request.phone = "123123425";
        request.role = "testRole";
        request.status = "success";
        request.userId = "1234";
        RuntimeOptions runtime = new RuntimeOptions();
        try {
            client.updateUser(request,runtime);
            fail();
        }catch (Exception e){
            Assert.assertEquals("The input parameter status is not valid. status range is enable or disabled",
                    e.getMessage());
        }
    }

}
