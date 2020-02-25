// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileRegisterRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    @NameInMap("sms_code")
    @Validation(required = true)
    public String smsCode;

    @NameInMap("sms_code_id")
    @Validation(required = true)
    public String smsCodeId;

    public static MobileRegisterRequest build(java.util.Map<String, ?> map) throws Exception {
        MobileRegisterRequest self = new MobileRegisterRequest();
        return TeaModel.build(map, self);
    }

}
