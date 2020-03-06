// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListUploadedPartsModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSListUploadedPartResponse body;

    public static ListUploadedPartsModel build(java.util.Map<String, ?> map) throws Exception {
        ListUploadedPartsModel self = new ListUploadedPartsModel();
        return TeaModel.build(map, self);
    }

}
