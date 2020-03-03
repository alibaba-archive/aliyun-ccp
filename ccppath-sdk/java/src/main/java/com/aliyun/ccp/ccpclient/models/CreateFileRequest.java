// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateFileRequest extends TeaModel {
    @NameInMap("header")
    public CreateFileRequestHeader header;

    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    @Validation(required = true)
    public String contentType;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("hidden")
    public Boolean hidden;

    @NameInMap("meta")
    public String meta;

    @NameInMap("name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String name;

    @NameInMap("parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9]{1,50}")
    public String parentFileId;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("pre_hash")
    public String preHash;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("size")
    @Validation(required = true)
    public Long size;

    @NameInMap("tags")
    public java.util.Map<String, Object> tags;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static CreateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFileRequest self = new CreateFileRequest();
        return TeaModel.build(map, self);
    }

    public static class BaseCreateFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseCreateFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseCreateFileRequestHeader self = new BaseCreateFileRequestHeader();
            return TeaModel.build(map, self);
        }

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

    public static class CreateFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CreateFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CreateFileRequestHeader self = new CreateFileRequestHeader();
            return TeaModel.build(map, self);
        }

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
