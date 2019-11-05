// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPBatchRequest extends TeaModel {
    @NameInMap("requests")
    @Validation(required = true)
    public BatchSubRequest[] requests;

    @NameInMap("resource")
    @Validation(required = true)
    public String resource;

}

