// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CorsRule extends TeaModel {
    @NameInMap("allowed_header")
    @Validation(pattern = "", maxLength = 0)
    public String[] allowedHeader;

    @NameInMap("allowed_method")
    @Validation(pattern = "", maxLength = 0)
    public String[] allowedMethod;

    @NameInMap("allowed_origin")
    @Validation(pattern = "", maxLength = 0)
    public String[] allowedOrigin;

    @NameInMap("expose_header")
    @Validation(pattern = "", maxLength = 0)
    public String[] exposeHeader;

    @NameInMap("max_age_seconds")
    @Validation(pattern = "", maxLength = 0)
    public Long maxAgeSeconds;

}

