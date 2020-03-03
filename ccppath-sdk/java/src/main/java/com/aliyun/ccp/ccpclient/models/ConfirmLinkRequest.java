// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ConfirmLinkRequest extends TeaModel {
    @NameInMap("header")
    public ConfirmLinkRequestHeader header;

    @NameInMap("temporary_token")
    @Validation(required = true)
    public String temporaryToken;

    public static ConfirmLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmLinkRequest self = new ConfirmLinkRequest();
        return TeaModel.build(map, self);
    }

    public static class ConfirmLinkRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ConfirmLinkRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ConfirmLinkRequestHeader self = new ConfirmLinkRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
