// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSGetFileRequest extends TeaModel {
    @NameInMap("header")
    public OSSGetFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String filePath;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    public static OSSGetFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSGetFileRequest self = new OSSGetFileRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSGetFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSGetFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSGetFileRequestHeader self = new OSSGetFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
