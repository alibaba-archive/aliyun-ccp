// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUserRequest extends TeaModel {
    @NameInMap("header")
    public GetUserRequestHeader header;

    @NameInMap("user_id")
    public String userId;

    public static GetUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserRequest self = new GetUserRequest();
        return TeaModel.build(map, self);
    }

    public static class GetUserRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetUserRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetUserRequestHeader self = new GetUserRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
