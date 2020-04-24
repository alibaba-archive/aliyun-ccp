// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class ImageFaceGroupResponse extends TeaModel {
    @NameInMap("created_at")
    public String createdAt;

    @NameInMap("face_count")
    public Long faceCount;

    @NameInMap("group_cover_url")
    public String groupCoverUrl;

    @NameInMap("group_id")
    public String groupId;

    @NameInMap("group_name")
    public String groupName;

    @NameInMap("image_count")
    public Long imageCount;

    @NameInMap("updated_at")
    public String updatedAt;

    public static ImageFaceGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        ImageFaceGroupResponse self = new ImageFaceGroupResponse();
        return TeaModel.build(map, self);
    }

}
