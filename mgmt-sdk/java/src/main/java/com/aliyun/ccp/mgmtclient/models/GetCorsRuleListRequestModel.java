// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class GetCorsRuleListRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorsRuleListRequest body;

    public static GetCorsRuleListRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetCorsRuleListRequestModel self = new GetCorsRuleListRequestModel();
        return TeaModel.build(map, self);
    }

}
