// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPGetFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("category")
    public String category;

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

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String fileId;

    @NameInMap("hidden")
    public Boolean hidden;

    @NameInMap("image_media_metadata")
    public ImageMediaResponse imageMediaMetadata;

    @NameInMap("labels")
    public java.util.List<String> labels;

    @NameInMap("meta")
    public String meta;

    @NameInMap("name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}")
    public String name;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String parentFileId;

    @NameInMap("size")
    public Long size;

    @NameInMap("starred")
    public Boolean starred;

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

    public static CCPGetFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPGetFileResponse self = new CCPGetFileResponse();
        return TeaModel.build(map, self);
    }

}
