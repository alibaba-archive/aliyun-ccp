// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DownloadFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetDownloadUrlRequest body;

    public static DownloadFileModel build(java.util.Map<String, ?> map) throws Exception {
        DownloadFileModel self = new DownloadFileModel();
        return TeaModel.build(map, self);
    }

}
