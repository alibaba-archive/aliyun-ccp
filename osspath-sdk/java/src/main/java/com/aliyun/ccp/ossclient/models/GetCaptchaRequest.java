// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetCaptchaRequest extends TeaModel {
    @NameInMap("header")
    public GetCaptchaRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    public static GetCaptchaRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCaptchaRequest self = new GetCaptchaRequest();
        return TeaModel.build(map, self);
    }

    public static class GetCaptchaRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetCaptchaRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetCaptchaRequestHeader self = new GetCaptchaRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
