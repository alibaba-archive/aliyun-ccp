// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPCopyFileRequest extends TeaModel {
    @NameInMap("header")
    public CCPCopyFileRequestHeader header;

    @NameInMap("auto_rename")
    public Boolean autoRename;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("new_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String newName;

    @NameInMap("to_drive_id")
    @Validation(pattern = "[0-9]+")
    public String toDriveId;

    @NameInMap("to_parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String toParentFileId;

    public static CCPCopyFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPCopyFileRequest self = new CCPCopyFileRequest();
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

}
