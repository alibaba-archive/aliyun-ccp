// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetDownloadUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetDownloadUrlRequest body;

    public static CCPGetDownloadUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPGetDownloadUrlRequestModel self = new CCPGetDownloadUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
