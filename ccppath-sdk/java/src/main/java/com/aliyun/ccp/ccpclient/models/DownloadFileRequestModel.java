// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DownloadFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("query")
    @Validation(required = true)
    public DownloadFileQuery query;

    public static DownloadFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DownloadFileRequestModel self = new DownloadFileRequestModel();
        return TeaModel.build(map, self);
    }

}
