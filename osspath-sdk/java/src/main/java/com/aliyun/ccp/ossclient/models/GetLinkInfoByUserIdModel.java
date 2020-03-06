// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetLinkInfoByUserIdModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public LinkInfoListResponse body;

    public static GetLinkInfoByUserIdModel build(java.util.Map<String, ?> map) throws Exception {
        GetLinkInfoByUserIdModel self = new GetLinkInfoByUserIdModel();
        return TeaModel.build(map, self);
    }

}
