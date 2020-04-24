// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetDownloadUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetDownloadUrlRequest body;

    public static GetDownloadUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadUrlRequestModel self = new GetDownloadUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
