// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPListFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
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

    @NameInMap("Starred")
    public boolean Starred;

    @NameInMap("category")
    public String category;

    @NameInMap("custom_index_key")
    public String customIndexKey;

    @NameInMap("order_direction")
    public String orderDirection;

    @NameInMap("status")
    public String status;

    @NameInMap("type")
    public String type;

    @NameInMap("all")
    public boolean all;

    @NameInMap("order_by")
    public String orderBy;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}")
    public String parentFileId;

}
