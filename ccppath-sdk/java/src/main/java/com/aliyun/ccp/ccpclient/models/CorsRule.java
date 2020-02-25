// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CorsRule extends TeaModel {
    @NameInMap("allowed_header")
    public String[] allowedHeader;

    @NameInMap("allowed_method")
    public String[] allowedMethod;

    @NameInMap("allowed_origin")
    public String[] allowedOrigin;

    @NameInMap("expose_header")
    public String[] exposeHeader;

    @NameInMap("max_age_seconds")
    public Long maxAgeSeconds;

    public static CorsRule build(java.util.Map<String, ?> map) throws Exception {
        CorsRule self = new CorsRule();
        return TeaModel.build(map, self);
    }

}
