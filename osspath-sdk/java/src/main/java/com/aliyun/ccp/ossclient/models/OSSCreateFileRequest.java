// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * create file request
 */
public class OSSCreateFileRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("content_type")
    public String contentType;

    @NameInMap("name")
    public String name;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

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
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    public static OSSCreateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSCreateFileRequest self = new OSSCreateFileRequest();
        return TeaModel.build(map, self);
    }

}
