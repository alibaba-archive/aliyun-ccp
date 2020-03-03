// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteFileRequest extends TeaModel {
    @NameInMap("header")
    public DeleteFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("permanently")
    public Boolean permanently;

    @NameInMap("share_id")
    public String shareId;

    public static DeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFileRequest self = new DeleteFileRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPDeleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPDeleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPDeleteFileRequestHeader self = new CCPDeleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class DeleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DeleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteFileRequestHeader self = new DeleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class OSSDeleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSDeleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSDeleteFileRequestHeader self = new OSSDeleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
