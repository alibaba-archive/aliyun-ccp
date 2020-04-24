// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 展示地点分组列表
 */
public class SearchImageAddressGroupsResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<ImageAddressResponse> items;

    public static SearchImageAddressGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchImageAddressGroupsResponse self = new SearchImageAddressGroupsResponse();
        return TeaModel.build(map, self);
    }

}
