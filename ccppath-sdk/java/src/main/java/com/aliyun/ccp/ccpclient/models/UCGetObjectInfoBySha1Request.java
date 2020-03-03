// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UCGetObjectInfoBySha1Request extends TeaModel {
    @NameInMap("header")
    public UCGetObjectInfoBySha1RequestHeader header;

    @NameInMap("sha1")
    public String sha1;

    public static UCGetObjectInfoBySha1Request build(java.util.Map<String, ?> map) throws Exception {
        UCGetObjectInfoBySha1Request self = new UCGetObjectInfoBySha1Request();
        return TeaModel.build(map, self);
    }

    public static class UCGetObjectInfoBySha1RequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static UCGetObjectInfoBySha1RequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UCGetObjectInfoBySha1RequestHeader self = new UCGetObjectInfoBySha1RequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
