// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetPhotoCountRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetImageCountRequest body;

    public static GetPhotoCountRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetPhotoCountRequestModel self = new GetPhotoCountRequestModel();
        return TeaModel.build(map, self);
    }

}
