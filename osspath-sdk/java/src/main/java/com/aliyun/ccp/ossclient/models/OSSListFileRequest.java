// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSListFileRequest extends TeaModel {
    @NameInMap("header")
    public OSSListFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("limit")
    @Validation(pattern = "[0-9]{1,3}")
    public Long limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("parent_file_path")
    @Validation(required = true)
    public String parentFilePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    @NameInMap("url_expire_sec")
    public Long urlExpireSec;

    @NameInMap("video_thumbnail_process")
    public String videoThumbnailProcess;

    public static OSSListFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSListFileRequest self = new OSSListFileRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSListFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSListFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSListFileRequestHeader self = new OSSListFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
