// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSDeleteFileRequest extends TeaModel {
    @NameInMap("header")
    public OSSDeleteFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("permanently")
    public Boolean permanently;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    public static OSSDeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSDeleteFileRequest self = new OSSDeleteFileRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSDeleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSDeleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSDeleteFileRequestHeader self = new OSSDeleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
