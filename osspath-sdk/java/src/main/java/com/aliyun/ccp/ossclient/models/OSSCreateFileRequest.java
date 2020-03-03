// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSCreateFileRequest extends TeaModel {
    @NameInMap("header")
    public OSSCreateFileRequestHeader header;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("name")
    public String name;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("size")
    public Long size;

    @NameInMap("type")
    public String type;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("share_id")
    public String shareId;

    public static OSSCreateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSCreateFileRequest self = new OSSCreateFileRequest();
        return TeaModel.build(map, self);
    }

    public static class OSSCreateFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSCreateFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSCreateFileRequestHeader self = new OSSCreateFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
