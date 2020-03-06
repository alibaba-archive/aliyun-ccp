// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListImageAddressGroupsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageAddressGroupsRequest body;

    public static ListImageAddressGroupsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListImageAddressGroupsRequestModel self = new ListImageAddressGroupsRequestModel();
        return TeaModel.build(map, self);
    }

}
