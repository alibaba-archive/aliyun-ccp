// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetDownloadUrlResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("method")
    public String method;

    @NameInMap("url")
    public String url;

    public static CCPGetDownloadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPGetDownloadUrlResponse self = new CCPGetDownloadUrlResponse();
        return TeaModel.build(map, self);
    }

}
