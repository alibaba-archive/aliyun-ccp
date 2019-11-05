// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListFileRequest extends TeaModel {
    @NameInMap("all")
    @Validation(pattern = "", maxLength = 0)
    public boolean all;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("image_thumbnail_process")
    @Validation(pattern = "", maxLength = 0)
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    @Validation(pattern = "", maxLength = 0)
    public String imageUrlProcess;

    @NameInMap("limit")
    @Validation(pattern = "[0-9]{1, 3}", maxLength = 0)
    public Long limit;

    @NameInMap("marker")
    @Validation(pattern = "", maxLength = 0)
    public String marker;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String parentFileId;

    @NameInMap("parent_file_path")
    @Validation(pattern = "", maxLength = 0)
    public String parentFilePath;

    @NameInMap("share_id")
    @Validation(pattern = "", maxLength = 0)
    public String shareId;

    @NameInMap("status")
    @Validation(pattern = "", maxLength = 0)
    public String status;

}

