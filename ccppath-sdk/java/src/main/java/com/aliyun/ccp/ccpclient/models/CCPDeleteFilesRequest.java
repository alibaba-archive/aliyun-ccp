// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFilesRequest extends TeaModel {
    @NameInMap("header")
    public CCPDeleteFilesRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id_list")
    @Validation(required = true)
    public java.util.List<String> fileIdList;

    public static CCPDeleteFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFilesRequest self = new CCPDeleteFilesRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPDeleteFilesRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPDeleteFilesRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPDeleteFilesRequestHeader self = new CCPDeleteFilesRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
