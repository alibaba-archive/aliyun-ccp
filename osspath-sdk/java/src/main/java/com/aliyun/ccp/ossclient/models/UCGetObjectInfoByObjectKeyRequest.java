// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UCGetObjectInfoByObjectKeyRequest extends TeaModel {
    @NameInMap("header")
    public UCGetObjectInfoByObjectKeyRequestHeader header;

    @NameInMap("object_key")
    public String objectKey;

    public static UCGetObjectInfoByObjectKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        UCGetObjectInfoByObjectKeyRequest self = new UCGetObjectInfoByObjectKeyRequest();
        return TeaModel.build(map, self);
    }

    public static class UCGetObjectInfoByObjectKeyRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static UCGetObjectInfoByObjectKeyRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UCGetObjectInfoByObjectKeyRequestHeader self = new UCGetObjectInfoByObjectKeyRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
