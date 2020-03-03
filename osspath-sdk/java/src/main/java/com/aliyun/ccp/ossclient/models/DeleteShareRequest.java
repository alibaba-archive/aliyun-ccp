// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteShareRequest extends TeaModel {
    @NameInMap("header")
    public DeleteShareRequestHeader header;

    @NameInMap("share_id")
    @Validation(required = true)
    public String shareId;

    public static DeleteShareRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteShareRequest self = new DeleteShareRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteShareRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DeleteShareRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteShareRequestHeader self = new DeleteShareRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
