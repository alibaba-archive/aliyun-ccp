// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class SetCorsRuleListRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SetCorsRuleListRequest body;

    public static SetCorsRuleListRequestModel build(java.util.Map<String, ?> map) throws Exception {
        SetCorsRuleListRequestModel self = new SetCorsRuleListRequestModel();
        return TeaModel.build(map, self);
    }

}
