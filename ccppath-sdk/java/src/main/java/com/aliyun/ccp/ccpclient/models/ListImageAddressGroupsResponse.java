// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 展示地点分组集合
 */
public class ListImageAddressGroupsResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<ImageAddressResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListImageAddressGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListImageAddressGroupsResponse self = new ListImageAddressGroupsResponse();
        return TeaModel.build(map, self);
    }

}
