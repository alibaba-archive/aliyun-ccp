// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * get domain request
 */
public class GetDomainRequest extends TeaModel {
    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static GetDomainRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDomainRequest self = new GetDomainRequest();
        return TeaModel.build(map, self);
    }

}
