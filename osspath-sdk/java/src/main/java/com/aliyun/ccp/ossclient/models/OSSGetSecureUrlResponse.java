// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetSecureUrlResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("method")
    public String method;

    @NameInMap("url")
    public String url;

    public static OSSGetSecureUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSGetSecureUrlResponse self = new OSSGetSecureUrlResponse();
        return TeaModel.build(map, self);
    }

}
