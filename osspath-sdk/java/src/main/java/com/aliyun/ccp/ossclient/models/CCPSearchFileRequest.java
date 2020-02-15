// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPSearchFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("order_by")
    public String orderBy;

    @NameInMap("query")
    public String query;

    @NameInMap("url_expire_sec")
    public Long urlExpireSec;

    @NameInMap("video_thumbnail_process")
    public String videoThumbnailProcess;

    public static CCPSearchFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPSearchFileRequest self = new CCPSearchFileRequest();
        return TeaModel.build(map, self);
    }

}
