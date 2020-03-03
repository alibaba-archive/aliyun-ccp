// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetAccessTokenByLinkInfoRequest extends TeaModel {
    @NameInMap("header")
    public GetAccessTokenByLinkInfoRequestHeader header;

    @NameInMap("identity")
    @Validation(required = true)
    public String identity;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static GetAccessTokenByLinkInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenByLinkInfoRequest self = new GetAccessTokenByLinkInfoRequest();
        return TeaModel.build(map, self);
    }

    public static class GetAccessTokenByLinkInfoRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetAccessTokenByLinkInfoRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetAccessTokenByLinkInfoRequestHeader self = new GetAccessTokenByLinkInfoRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
