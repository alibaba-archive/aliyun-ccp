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

    @NameInMap("auto_rename")
    public boolean autoRename;

    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("encrypt_mode")
    public String encryptMode;

    @NameInMap("file_id")
    public String fileId;

    @NameInMap("hidden")
    public boolean hidden;

    @NameInMap("labels")
    public String[] labels;

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

}
