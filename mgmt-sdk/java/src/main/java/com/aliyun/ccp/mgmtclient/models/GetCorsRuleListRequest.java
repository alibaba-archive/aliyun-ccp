// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class GetCorsRuleListRequest extends TeaModel {
    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static GetCorsRuleListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCorsRuleListRequest self = new GetCorsRuleListRequest();
        return TeaModel.build(map, self);
    }

}
