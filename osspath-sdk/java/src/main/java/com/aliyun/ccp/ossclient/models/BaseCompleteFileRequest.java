// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseCompleteFileRequest extends TeaModel {
    @NameInMap("header")
    public BaseCompleteFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    public static BaseCompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseCompleteFileRequest self = new BaseCompleteFileRequest();
        return TeaModel.build(map, self);
    }

    public static class BaseCompleteFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseCompleteFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseCompleteFileRequestHeader self = new BaseCompleteFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
