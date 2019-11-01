// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPBatchResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("responses")
    @Validation(pattern = "", maxLength = 0)
    public BatchSubResponse[] responses;

}

