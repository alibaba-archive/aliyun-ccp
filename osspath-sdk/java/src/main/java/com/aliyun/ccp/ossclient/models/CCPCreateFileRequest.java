// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPCreateFileRequest extends TeaModel {
    @NameInMap("content_md5")
    @Validation(pattern = "", maxLength = 0)
    public String contentMd5;

    @NameInMap("content_type")
    @Validation(pattern = "", maxLength = 0)
    public String contentType;

    @NameInMap("name")
    @Validation(pattern = "[a-z0-9.-_]{1,1024}", maxLength = 0)
    public String name;

    @NameInMap("part_info_list")
    @Validation(pattern = "", maxLength = 0)
    public UploadPartInfo[] partInfoList;

    @NameInMap("size")
    @Validation(pattern = "", maxLength = 0)
    public Long size;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

    @NameInMap("content_hash")
    @Validation(pattern = "", maxLength = 0)
    public String contentHash;

    @NameInMap("content_hash_name")
    @Validation(pattern = "", maxLength = 0)
    public String contentHashName;

    @NameInMap("description")
    @Validation(pattern = "", maxLength = 0)
    public String description;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("hidden")
    @Validation(pattern = "", maxLength = 0)
    public boolean hidden;

    @NameInMap("meta")
    @Validation(pattern = "", maxLength = 0)
    public String meta;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String parentFileId;

    @NameInMap("pre_hash")
    @Validation(pattern = "", maxLength = 0)
    public String preHash;

    @NameInMap("tags")
    @Validation(pattern = "", maxLength = 0)
    public java.util.Map<String, Object> tags;

}

