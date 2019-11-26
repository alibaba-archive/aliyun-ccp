// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSCreateFileRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("name")
    @Validation(pattern = "[a-z0-9.-_]{1,1000}")
    public String name;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

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

}
