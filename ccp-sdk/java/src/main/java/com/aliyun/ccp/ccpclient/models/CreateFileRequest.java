// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateFileRequest extends TeaModel {
    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    public String driveId;

    @NameInMap("hidden")
    public boolean hidden;

    @NameInMap("meta")
    public String meta;

    @NameInMap("name")
    public String name;

    @NameInMap("parent_file_id")
    public String parentFileId;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("pre_hash")
    public String preHash;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("size")
    public long size;

    @NameInMap("tags")
    public java.util.Map<String, Object> tags;

    @NameInMap("type")
    public String type;

}

