// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetPhotoCountModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetImageCountResponse body;

    public static GetPhotoCountModel build(java.util.Map<String, ?> map) throws Exception {
        GetPhotoCountModel self = new GetPhotoCountModel();
        return TeaModel.build(map, self);
    }

}
