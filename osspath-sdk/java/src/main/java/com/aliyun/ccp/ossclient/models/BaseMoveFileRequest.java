// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseMoveFileRequest extends TeaModel {
    @NameInMap("header")
    public BaseMoveFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("new_name")
    @Validation(pattern = ".{1,1000}")
    public String newName;

    @NameInMap("overwrite")
    public Boolean overwrite;

    public static BaseMoveFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseMoveFileRequest self = new BaseMoveFileRequest();
        return TeaModel.build(map, self);
    }

    public static class BaseMoveFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseMoveFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseMoveFileRequestHeader self = new BaseMoveFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
