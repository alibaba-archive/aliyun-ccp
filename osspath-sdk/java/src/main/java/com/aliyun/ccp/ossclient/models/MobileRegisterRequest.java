// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileRegisterRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(pattern = "", maxLength = 0)
    public String appId;

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

