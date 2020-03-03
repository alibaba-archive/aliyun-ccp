// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetDownloadUrlRequest extends TeaModel {
    @NameInMap("header")
    public CCPGetDownloadUrlRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String fileName;

    public static CCPGetDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPGetDownloadUrlRequest self = new CCPGetDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPGetDownloadUrlRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPGetDownloadUrlRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPGetDownloadUrlRequestHeader self = new CCPGetDownloadUrlRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
