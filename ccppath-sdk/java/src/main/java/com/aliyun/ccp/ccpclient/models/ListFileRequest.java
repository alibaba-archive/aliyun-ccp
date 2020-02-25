// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFileRequest extends TeaModel {
    @NameInMap("all")
    public boolean all;

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

    @NameInMap("parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String parentFileId;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("status")
    public String status;

    public static ListFileRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFileRequest self = new ListFileRequest();
        return TeaModel.build(map, self);
    }

}
