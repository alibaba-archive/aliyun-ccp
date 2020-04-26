// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class VerifyCodeRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    @NameInMap("phone_region")
    public String phoneRegion;

    @NameInMap("sms_code")
    @Validation(required = true)
    public String smsCode;

    @NameInMap("sms_code_id")
    @Validation(required = true)
    public String smsCodeId;

    @NameInMap("verify_type")
    public String verifyType;

    public static VerifyCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        VerifyCodeRequest self = new VerifyCodeRequest();
        return TeaModel.build(map, self);
    }

}
