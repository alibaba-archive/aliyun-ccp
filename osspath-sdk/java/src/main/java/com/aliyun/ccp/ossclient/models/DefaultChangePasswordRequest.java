// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DefaultChangePasswordRequest extends TeaModel {
    @NameInMap("header")
    public DefaultChangePasswordRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("new_password")
    @Validation(required = true)
    public String newPassword;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    @NameInMap("sms_code")
    @Validation(required = true)
    public String smsCode;

    @NameInMap("sms_code_id")
    @Validation(required = true)
    public String smsCodeId;

    public static DefaultChangePasswordRequest build(java.util.Map<String, ?> map) throws Exception {
        DefaultChangePasswordRequest self = new DefaultChangePasswordRequest();
        return TeaModel.build(map, self);
    }

    public static class DefaultChangePasswordRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DefaultChangePasswordRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DefaultChangePasswordRequestHeader self = new DefaultChangePasswordRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
