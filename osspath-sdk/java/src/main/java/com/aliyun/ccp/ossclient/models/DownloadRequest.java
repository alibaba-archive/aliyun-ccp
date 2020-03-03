// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DownloadRequest extends TeaModel {
    @NameInMap("header")
    public DownloadRequestHeader header;

    @NameInMap("DriveID")
    @Validation(required = true, pattern = "[0-9]+")
    public String DriveID;

    @NameInMap("FileID")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String FileID;

    @NameInMap("ImageProcess")
    public String ImageProcess;

    @NameInMap("ShareID")
    public String ShareID;

    public static DownloadRequest build(java.util.Map<String, ?> map) throws Exception {
        DownloadRequest self = new DownloadRequest();
        return TeaModel.build(map, self);
    }

    public static class DownloadRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DownloadRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DownloadRequestHeader self = new DownloadRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
