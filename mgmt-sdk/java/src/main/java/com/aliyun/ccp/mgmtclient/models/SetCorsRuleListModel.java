// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class SetCorsRuleListModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDomainCORSRuleResponse body;

    public static SetCorsRuleListModel build(java.util.Map<String, ?> map) throws Exception {
        SetCorsRuleListModel self = new SetCorsRuleListModel();
        return TeaModel.build(map, self);
    }

}
