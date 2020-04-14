// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class SetCorsRuleListRequest extends TeaModel {
    @NameInMap("cors_rule_list")
    @Validation(required = true)
    public java.util.List<CorsRule> corsRuleList;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static SetCorsRuleListRequest build(java.util.Map<String, ?> map) throws Exception {
        SetCorsRuleListRequest self = new SetCorsRuleListRequest();
        return TeaModel.build(map, self);
    }

}
