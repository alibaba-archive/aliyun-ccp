// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SearchAddressGroupsModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchImageAddressGroupsResponse body;

    public static SearchAddressGroupsModel build(java.util.Map<String, ?> map) throws Exception {
        SearchAddressGroupsModel self = new SearchAddressGroupsModel();
        return TeaModel.build(map, self);
    }

}
