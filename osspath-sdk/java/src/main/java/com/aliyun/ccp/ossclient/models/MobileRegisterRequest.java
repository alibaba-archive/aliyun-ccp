// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileRegisterRequest extends TeaModel {
    @NameInMap("header")
    public MobileRegisterRequestHeader header;

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

    public static class MobileRegisterRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static MobileRegisterRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            MobileRegisterRequestHeader self = new MobileRegisterRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
