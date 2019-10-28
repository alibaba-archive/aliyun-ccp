// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPCreateFileRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("name")
    public String name;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("size")
    public Long size;

    @NameInMap("type")
    public String type;

    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    public String driveId;

    @NameInMap("hidden")
    public boolean hidden;

    @NameInMap("meta")
    public String meta;

    @NameInMap("parent_file_id")
    public String parentFileId;

    @NameInMap("pre_hash")
    public String preHash;

    @NameInMap("tags")
    public java.util.Map<String, Object> tags;

}

