// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileCheckExistRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileCheckExistRequest body;

    public static MobileCheckExistRequestModel build(java.util.Map<String, ?> map) throws Exception {
        MobileCheckExistRequestModel self = new MobileCheckExistRequestModel();
        return TeaModel.build(map, self);
    }

}
