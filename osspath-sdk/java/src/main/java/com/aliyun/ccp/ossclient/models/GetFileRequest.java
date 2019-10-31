// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9.-_]{1, 50}", maxLength = 0)
    public String fileId;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("image_thumbnail_process")
    @Validation(pattern = "", maxLength = 0)
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    @Validation(pattern = "", maxLength = 0)
    public String imageUrlProcess;

    @NameInMap("share_id")
    @Validation(pattern = "", maxLength = 0)
    public String shareId;

}

