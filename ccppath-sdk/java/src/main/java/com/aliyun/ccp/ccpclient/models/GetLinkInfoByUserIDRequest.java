// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLinkInfoByUserIDRequest extends TeaModel {
    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static GetLinkInfoByUserIDRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLinkInfoByUserIDRequest self = new GetLinkInfoByUserIDRequest();
        return TeaModel.build(map, self);
    }

}
