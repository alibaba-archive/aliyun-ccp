// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSVideoDefinitionRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoDefinitionRequest body;

    public static OSSVideoDefinitionRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoDefinitionRequestModel self = new OSSVideoDefinitionRequestModel();
        return TeaModel.build(map, self);
    }

}
