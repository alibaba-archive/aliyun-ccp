// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetUploadUrlRequest extends TeaModel {
    @NameInMap("header")
    public CCPGetUploadUrlRequestHeader header;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1,50}")
    public String fileId;

    public static CCPGetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPGetUploadUrlRequest self = new CCPGetUploadUrlRequest();
        return TeaModel.build(map, self);
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

}
