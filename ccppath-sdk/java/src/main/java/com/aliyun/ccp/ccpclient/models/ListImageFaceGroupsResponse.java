// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 展示人脸分组集合
 */
public class ListImageFaceGroupsResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<ImageFaceGroupResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListImageFaceGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListImageFaceGroupsResponse self = new ListImageFaceGroupsResponse();
        return TeaModel.build(map, self);
    }

}
