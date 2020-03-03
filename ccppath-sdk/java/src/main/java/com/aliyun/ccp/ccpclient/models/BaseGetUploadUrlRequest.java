// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class BaseGetUploadUrlRequest extends TeaModel {
    @NameInMap("header")
    public BaseGetUploadUrlRequestHeader header;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("upload_id")
    @Validation(required = true)
    public String uploadId;

    public static BaseGetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseGetUploadUrlRequest self = new BaseGetUploadUrlRequest();
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

}
