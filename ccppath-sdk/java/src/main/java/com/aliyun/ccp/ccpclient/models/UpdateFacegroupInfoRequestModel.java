// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateFacegroupInfoRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateFaceGroupInfoRequest body;

    public static UpdateFacegroupInfoRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateFacegroupInfoRequestModel self = new UpdateFacegroupInfoRequestModel();
        return TeaModel.build(map, self);
    }

}
