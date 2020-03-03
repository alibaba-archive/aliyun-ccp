// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetShareRequest extends TeaModel {
    @NameInMap("header")
    public GetShareRequestHeader header;

    @NameInMap("share_id")
    public String shareId;

    public static GetShareRequest build(java.util.Map<String, ?> map) throws Exception {
        GetShareRequest self = new GetShareRequest();
        return TeaModel.build(map, self);
    }

    public static class GetShareRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetShareRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetShareRequestHeader self = new GetShareRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
