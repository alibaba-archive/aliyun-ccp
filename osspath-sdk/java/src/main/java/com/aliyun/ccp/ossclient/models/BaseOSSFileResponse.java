// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseOSSFileResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("content_hash")
    @Validation(pattern = "", maxLength = 0)
    public String contentHash;

    @NameInMap("content_hash_name")
    @Validation(pattern = "", maxLength = 0)
    public String contentHashName;

    @NameInMap("content_type")
    @Validation(pattern = "", maxLength = 0)
    public String contentType;

    @NameInMap("crc64_hash")
    @Validation(pattern = "", maxLength = 0)
    public String crc64Hash;

    @NameInMap("created_at")
    @Validation(pattern = "", maxLength = 0)
    public String createdAt;

    @NameInMap("description")
    @Validation(pattern = "", maxLength = 0)
    public String description;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+", maxLength = 0)
    public String domainId;

    @NameInMap("download_url")
    @Validation(pattern = "", maxLength = 0)
    public String downloadUrl;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_extension")
    @Validation(pattern = "", maxLength = 0)
    public String fileExtension;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}", maxLength = 0)
    public String name;

    @NameInMap("parent_file_path")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String parentFilePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String shareId;

    @NameInMap("size")
    @Validation(pattern = "", maxLength = 0)
    public Long size;

    @NameInMap("status")
    @Validation(pattern = "", maxLength = 0)
    public String status;

    @NameInMap("thumbnail")
    @Validation(pattern = "", maxLength = 0)
    public String thumbnail;

    @NameInMap("trashed_at")
    @Validation(pattern = "", maxLength = 0)
    public String trashedAt;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

    @NameInMap("updated_at")
    @Validation(pattern = "", maxLength = 0)
    public String updatedAt;

    @NameInMap("upload_id")
    @Validation(pattern = "", maxLength = 0)
    public String uploadId;

    @NameInMap("url")
    @Validation(pattern = "", maxLength = 0)
    public String url;

}

