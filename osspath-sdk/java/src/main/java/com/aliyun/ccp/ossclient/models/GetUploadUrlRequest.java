// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("upload_id")
    @Validation(required = true)
    public String uploadId;

}

