// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CompleteFileRequest extends TeaModel {
    @NameInMap("header")
    public CompleteFileRequestHeader header;

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

    public static CompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CompleteFileRequest self = new CompleteFileRequest();
        return TeaModel.build(map, self);
    }

    public static class BaseCompleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseCompleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseCompleteFileRequestHeader self = new BaseCompleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class CCPCompleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPCompleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPCompleteFileRequestHeader self = new CCPCompleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class CompleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CompleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CompleteFileRequestHeader self = new CompleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class OSSCompleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSCompleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSCompleteFileRequestHeader self = new OSSCompleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
