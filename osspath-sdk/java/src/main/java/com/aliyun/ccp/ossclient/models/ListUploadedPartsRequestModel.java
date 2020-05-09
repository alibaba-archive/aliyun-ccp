// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListUploadedPartsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSListUploadedPartRequest body;

    public static ListUploadedPartsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListUploadedPartsRequestModel self = new ListUploadedPartsRequestModel();
        return TeaModel.build(map, self);
    }

}
