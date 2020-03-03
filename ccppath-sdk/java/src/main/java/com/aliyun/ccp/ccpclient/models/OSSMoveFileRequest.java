// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSMoveFileRequest extends TeaModel {
    @NameInMap("header")
    public OSSMoveFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("new_name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String newName;

    @NameInMap("overwrite")
    public Boolean overwrite;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    @NameInMap("to_parent_file_path")
    public String toParentFilePath;

    public static OSSMoveFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSMoveFileRequest self = new OSSMoveFileRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSMoveFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSMoveFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSMoveFileRequestHeader self = new OSSMoveFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
