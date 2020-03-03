// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequest extends TeaModel {
    @NameInMap("header")
    public GetUploadUrlRequestHeader header;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("upload_id")
    @Validation(required = true)
    public String uploadId;

    public static GetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlRequest self = new GetUploadUrlRequest();
        return TeaModel.build(map, self);
    }

    public static class BaseGetUploadUrlRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseGetUploadUrlRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseGetUploadUrlRequestHeader self = new BaseGetUploadUrlRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class CCPGetUploadUrlRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPGetUploadUrlRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPGetUploadUrlRequestHeader self = new CCPGetUploadUrlRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class GetUploadUrlRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetUploadUrlRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetUploadUrlRequestHeader self = new GetUploadUrlRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class OSSGetUploadUrlRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSGetUploadUrlRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSGetUploadUrlRequestHeader self = new OSSGetUploadUrlRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
