// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * List image tags request
 */
public class ListImageTagsRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    public static ListImageTagsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListImageTagsRequest self = new ListImageTagsRequest();
        return TeaModel.build(map, self);
    }

}
