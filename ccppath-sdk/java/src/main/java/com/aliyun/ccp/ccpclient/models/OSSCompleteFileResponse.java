// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSCompleteFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("crc64_hash")
    public String crc64Hash;

    @NameInMap("created_at")
    public String createdAt;

    @NameInMap("description")
    public String description;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String domainId;

    @NameInMap("download_url")
    public String downloadUrl;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_extension")
    public String fileExtension;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}")
    public String name;

    @NameInMap("parent_file_path")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String parentFilePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+")
    public String shareId;

    @NameInMap("size")
    public Long size;

    @NameInMap("status")
    public String status;

    @NameInMap("thumbnail")
    public String thumbnail;

    @NameInMap("trashed_at")
    public String trashedAt;

    @NameInMap("type")
    public String type;

    @NameInMap("updated_at")
    public String updatedAt;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("url")
    public String url;

    @NameInMap("crc")
    public String crc;

    public static OSSCompleteFileResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSCompleteFileResponse self = new OSSCompleteFileResponse();
        return TeaModel.build(map, self);
    }

}
