// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CheckExistRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileCheckExistRequest body;

    public static CheckExistRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CheckExistRequestModel self = new CheckExistRequestModel();
        return TeaModel.build(map, self);
    }

}
