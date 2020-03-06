// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListAddressGroupsModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageAddressGroupsResponse body;

    public static ListAddressGroupsModel build(java.util.Map<String, ?> map) throws Exception {
        ListAddressGroupsModel self = new ListAddressGroupsModel();
        return TeaModel.build(map, self);
    }

}
