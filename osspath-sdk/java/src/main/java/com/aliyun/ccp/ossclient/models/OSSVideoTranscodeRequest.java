// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSVideoTranscodeRequest extends TeaModel {
    @NameInMap("header")
    public OSSVideoTranscodeRequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-z-]+")
    public String shareId;

    public static OSSVideoTranscodeRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoTranscodeRequest self = new OSSVideoTranscodeRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSVideoTranscodeRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSVideoTranscodeRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSVideoTranscodeRequestHeader self = new OSSVideoTranscodeRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
