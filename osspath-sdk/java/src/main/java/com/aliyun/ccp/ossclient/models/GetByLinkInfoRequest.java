// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetByLinkInfoRequest extends TeaModel {
    @NameInMap("header")
    public GetByLinkInfoRequestHeader header;

    @NameInMap("identity")
    @Validation(required = true)
    public String identity;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static GetByLinkInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetByLinkInfoRequest self = new GetByLinkInfoRequest();
        return TeaModel.build(map, self);
    }

    public static class GetByLinkInfoRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetByLinkInfoRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetByLinkInfoRequestHeader self = new GetByLinkInfoRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
