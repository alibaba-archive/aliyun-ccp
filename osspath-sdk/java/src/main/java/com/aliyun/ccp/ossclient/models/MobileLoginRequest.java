// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileLoginRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("auto_register")
    public boolean autoRegister;

    @NameInMap("captcha_id")
    public String captchaId;

    @NameInMap("captcha_text")
    public String captchaText;

    @NameInMap("password")
    public String password;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    @NameInMap("sms_code")
    public String smsCode;

    @NameInMap("sms_code_id")
    public String smsCodeId;

    public static MobileLoginRequest build(java.util.Map<String, ?> map) throws Exception {
        MobileLoginRequest self = new MobileLoginRequest();
        return TeaModel.build(map, self);
    }

}
