// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPSearchFileRequest extends TeaModel {
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
    @Validation(pattern = "", maxLength = 0)
    public Integer limit;

    @NameInMap("marker")
    @Validation(pattern = "", maxLength = 0)
    public String marker;

    @NameInMap("order_by")
    @Validation(pattern = "", maxLength = 0)
    public String orderBy;

    @NameInMap("query")
    @Validation(pattern = "", maxLength = 0)
    public String query;

}

