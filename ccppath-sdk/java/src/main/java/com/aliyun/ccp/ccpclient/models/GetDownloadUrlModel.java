// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetDownloadUrlModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetDownloadUrlResponse body;

    public static GetDownloadUrlModel build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadUrlModel self = new GetDownloadUrlModel();
        return TeaModel.build(map, self);
    }

}
