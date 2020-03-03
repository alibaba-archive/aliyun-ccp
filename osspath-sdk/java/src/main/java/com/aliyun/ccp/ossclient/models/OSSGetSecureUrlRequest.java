// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetSecureUrlRequest extends TeaModel {
    @NameInMap("header")
    public OSSGetSecureUrlRequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_name")
    public String fileName;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("secure_ip")
    public String secureIp;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-z-]+")
    public String shareId;

    public static OSSGetSecureUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSGetSecureUrlRequest self = new OSSGetSecureUrlRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSGetSecureUrlRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSGetSecureUrlRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSGetSecureUrlRequestHeader self = new OSSGetSecureUrlRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
