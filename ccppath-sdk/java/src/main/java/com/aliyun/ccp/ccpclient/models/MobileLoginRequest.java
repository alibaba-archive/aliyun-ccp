// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileLoginRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(pattern = "", maxLength = 0)
    public String appId;

    @NameInMap("auto_register")
    @Validation(pattern = "", maxLength = 0)
    public boolean autoRegister;

    @NameInMap("captcha_id")
    @Validation(pattern = "", maxLength = 0)
    public String captchaId;

    @NameInMap("captcha_text")
    @Validation(pattern = "", maxLength = 0)
    public String captchaText;

    @NameInMap("password")
    @Validation(pattern = "", maxLength = 0)
    public String password;

    @NameInMap("phone_number")
    @Validation(pattern = "", maxLength = 0)
    public String phoneNumber;

    @NameInMap("sms_code")
    @Validation(pattern = "", maxLength = 0)
    public String smsCode;

    @NameInMap("sms_code_id")
    @Validation(pattern = "", maxLength = 0)
    public String smsCodeId;

}

