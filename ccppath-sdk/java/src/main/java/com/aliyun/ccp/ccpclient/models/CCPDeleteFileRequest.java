// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFileRequest extends TeaModel {
    @NameInMap("header")
    public CCPDeleteFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("permanently")
    public Boolean permanently;

    public static CCPDeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFileRequest self = new CCPDeleteFileRequest();
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

}
