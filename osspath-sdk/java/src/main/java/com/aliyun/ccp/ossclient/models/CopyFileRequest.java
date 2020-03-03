// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CopyFileRequest extends TeaModel {
    @NameInMap("header")
    public CopyFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("new_name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String newName;

    @NameInMap("overwrite")
    public Boolean overwrite;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("to_drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String toDriveId;

    @NameInMap("to_parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String toParentFileId;

    @NameInMap("to_parent_file_path")
    public String toParentFilePath;

    @NameInMap("to_share_id")
    public String toShareId;

    public static CopyFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyFileRequest self = new CopyFileRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPCopyFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPCopyFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPCopyFileRequestHeader self = new CCPCopyFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class CopyFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CopyFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CopyFileRequestHeader self = new CopyFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class OSSCopyFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSCopyFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSCopyFileRequestHeader self = new OSSCopyFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
