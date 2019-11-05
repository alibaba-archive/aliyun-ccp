// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPListFileRequest extends TeaModel {
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

    @NameInMap("Starred")
    @Validation(pattern = "", maxLength = 0)
    public boolean Starred;

    @NameInMap("category")
    @Validation(pattern = "", maxLength = 0)
    public String category;

    @NameInMap("custom_index_key")
    @Validation(pattern = "", maxLength = 0)
    public String customIndexKey;

    @NameInMap("order_direction")
    @Validation(pattern = "", maxLength = 0)
    public String orderDirection;

    @NameInMap("status")
    @Validation(pattern = "", maxLength = 0)
    public String status;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

    @NameInMap("all")
    @Validation(pattern = "", maxLength = 0)
    public boolean all;

    @NameInMap("order_by")
    @Validation(pattern = "", maxLength = 0)
    public String orderBy;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String parentFileId;

}

