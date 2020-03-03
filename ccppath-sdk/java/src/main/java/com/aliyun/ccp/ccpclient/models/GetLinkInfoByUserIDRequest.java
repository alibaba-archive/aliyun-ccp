// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLinkInfoByUserIDRequest extends TeaModel {
    @NameInMap("header")
    public GetLinkInfoByUserIDRequestHeader header;

    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static GetLinkInfoByUserIDRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLinkInfoByUserIDRequest self = new GetLinkInfoByUserIDRequest();
        return TeaModel.build(map, self);
    }

    public static class GetLinkInfoByUserIDRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetLinkInfoByUserIDRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetLinkInfoByUserIDRequestHeader self = new GetLinkInfoByUserIDRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
