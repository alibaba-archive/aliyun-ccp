// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLinkInfoModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public LinkInfoResponse body;

    public static GetLinkInfoModel build(java.util.Map<String, ?> map) throws Exception {
        GetLinkInfoModel self = new GetLinkInfoModel();
        return TeaModel.build(map, self);
    }

}
