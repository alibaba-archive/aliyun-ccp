// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPListUploadedPartRequest extends TeaModel {
    @NameInMap("header")
    public CCPListUploadedPartRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("limit")
    @Validation(required = true, pattern = "[0-9]+")
    public Long limit;

    @NameInMap("part_number_marker")
    @Validation(pattern = "[0-9]+")
    public Long partNumberMarker;

    @NameInMap("upload_id")
    public String uploadId;

    public static CCPListUploadedPartRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPListUploadedPartRequest self = new CCPListUploadedPartRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPListUploadedPartRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPListUploadedPartRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPListUploadedPartRequestHeader self = new CCPListUploadedPartRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
