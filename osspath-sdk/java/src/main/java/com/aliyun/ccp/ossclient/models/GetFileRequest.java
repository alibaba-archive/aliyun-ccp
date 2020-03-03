// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetFileRequest extends TeaModel {
    @NameInMap("header")
    public GetFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("share_id")
    public String shareId;

    public static GetFileRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileRequest self = new GetFileRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPGetFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPGetFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPGetFileRequestHeader self = new CCPGetFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class GetFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetFileRequestHeader self = new GetFileRequestHeader();
            return TeaModel.build(map, self);
        }

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
