// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * list domain cors response
 */
public class ListDomainCORSRuleResponse extends TeaModel {
    @NameInMap("cors_rule_list")
    public java.util.List<CorsRule> corsRuleList;

    @NameInMap("domain_id")
    public String domainId;

    public static ListDomainCORSRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDomainCORSRuleResponse self = new ListDomainCORSRuleResponse();
        return TeaModel.build(map, self);
    }

}
