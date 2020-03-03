// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPCreateFileRequest extends TeaModel {
    @NameInMap("header")
    public CCPCreateFileRequestHeader header;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("name")
    @Validation(pattern = "[a-z0-9.-_]{1,1000}")
    public String name;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("size")
    public Long size;

    @NameInMap("type")
    public String type;

    @NameInMap("auto_rename")
    public Boolean autoRename;

    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    public String fileId;

    @NameInMap("hidden")
    public Boolean hidden;

    @NameInMap("labels")
    public java.util.List<String> labels;

    @NameInMap("meta")
    public String meta;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9]{1,50}")
    public String parentFileId;

    @NameInMap("pre_hash")
    public String preHash;

    public static CCPCreateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPCreateFileRequest self = new CCPCreateFileRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPCreateFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPCreateFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPCreateFileRequestHeader self = new CCPCreateFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
