// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetDownloadUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetDownloadUrlRequest body;

    public static OSSGetDownloadUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSGetDownloadUrlRequestModel self = new OSSGetDownloadUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
