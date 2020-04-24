// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SearchAddressGroupsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchImageAddressGroupsRequest body;

    public static SearchAddressGroupsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        SearchAddressGroupsRequestModel self = new SearchAddressGroupsRequestModel();
        return TeaModel.build(map, self);
    }

}
