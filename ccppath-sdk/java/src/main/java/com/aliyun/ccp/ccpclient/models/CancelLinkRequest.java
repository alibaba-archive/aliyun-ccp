// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CancelLinkRequest extends TeaModel {
    @NameInMap("header")
    public CancelLinkRequestHeader header;

    @NameInMap("temporary_token")
    @Validation(required = true)
    public String temporaryToken;

    public static CancelLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelLinkRequest self = new CancelLinkRequest();
        return TeaModel.build(map, self);
    }

    public static class CancelLinkRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CancelLinkRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CancelLinkRequestHeader self = new CancelLinkRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
