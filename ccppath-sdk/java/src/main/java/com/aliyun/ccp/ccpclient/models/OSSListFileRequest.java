// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSListFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("limit")
    @Validation(pattern = "[0-9]{1,3}")
    public Long limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("parent_file_path")
    @Validation(required = true)
    public String parentFilePath;

    @NameInMap("share_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String shareId;

}

