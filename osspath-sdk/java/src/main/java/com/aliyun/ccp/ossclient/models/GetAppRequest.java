// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetAppRequest extends TeaModel {
    @NameInMap("header")
    public GetAppRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    public static GetAppRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAppRequest self = new GetAppRequest();
        return TeaModel.build(map, self);
    }

    public static class GetAppRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetAppRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetAppRequestHeader self = new GetAppRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
