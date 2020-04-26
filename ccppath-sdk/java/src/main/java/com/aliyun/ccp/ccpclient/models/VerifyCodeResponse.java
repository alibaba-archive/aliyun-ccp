// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class VerifyCodeResponse extends TeaModel {
    @NameInMap("state")
    @Validation(required = true)
    public String state;

    public static VerifyCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        VerifyCodeResponse self = new VerifyCodeResponse();
        return TeaModel.build(map, self);
    }

}
