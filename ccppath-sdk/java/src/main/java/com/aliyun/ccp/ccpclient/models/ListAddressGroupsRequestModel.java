// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListAddressGroupsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageAddressGroupsRequest body;

    public static ListAddressGroupsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListAddressGroupsRequestModel self = new ListAddressGroupsRequestModel();
        return TeaModel.build(map, self);
    }

}
