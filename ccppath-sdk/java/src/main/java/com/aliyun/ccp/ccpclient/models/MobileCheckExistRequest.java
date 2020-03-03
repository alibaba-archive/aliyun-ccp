// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileCheckExistRequest extends TeaModel {
    @NameInMap("header")
    public MobileCheckExistRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    public static MobileCheckExistRequest build(java.util.Map<String, ?> map) throws Exception {
        MobileCheckExistRequest self = new MobileCheckExistRequest();
        return TeaModel.build(map, self);
    }

    public static class MobileCheckExistRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static MobileCheckExistRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            MobileCheckExistRequestHeader self = new MobileCheckExistRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
