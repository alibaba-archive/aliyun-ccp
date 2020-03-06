// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Create share response
 */
public class CreateShareResponse extends TeaModel {
    @NameInMap("domain_id")
    public String domainId;

    @NameInMap("share_id")
    public String shareId;

    public static CreateShareResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateShareResponse self = new CreateShareResponse();
        return TeaModel.build(map, self);
    }

}
