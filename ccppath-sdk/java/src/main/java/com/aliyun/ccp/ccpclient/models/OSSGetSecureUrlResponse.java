// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取secure url response
 */
public class OSSGetSecureUrlResponse extends TeaModel {
    @NameInMap("expiration")
    public String expiration;

    @NameInMap("url")
    public String url;

    public static OSSGetSecureUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSGetSecureUrlResponse self = new OSSGetSecureUrlResponse();
        return TeaModel.build(map, self);
    }

}
