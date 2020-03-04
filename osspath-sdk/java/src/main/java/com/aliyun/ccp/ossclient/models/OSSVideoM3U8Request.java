// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSVideoM3U8Request extends TeaModel {
    @NameInMap("header")
    public OSSVideoM3U8RequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-z-]+")
    public String shareId;

    @NameInMap("sign_token")
    @Validation(required = true)
    public String signToken;

    public static OSSVideoM3U8Request build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoM3U8Request self = new OSSVideoM3U8Request();
        return TeaModel.build(map, self);
    }

    public static class OSSVideoM3U8RequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSVideoM3U8RequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSVideoM3U8RequestHeader self = new OSSVideoM3U8RequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
