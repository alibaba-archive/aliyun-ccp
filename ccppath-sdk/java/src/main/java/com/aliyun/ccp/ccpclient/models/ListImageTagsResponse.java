// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 展示标签集合
 */
public class ListImageTagsResponse extends TeaModel {
    @NameInMap("tags")
    public java.util.List<ImageTagResponse> tags;

    public static ListImageTagsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListImageTagsResponse self = new ListImageTagsResponse();
        return TeaModel.build(map, self);
    }

}
