// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteUserRequest extends TeaModel {
    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static DeleteUserRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteUserRequest self = new DeleteUserRequest();
        return TeaModel.build(map, self);
    }

}
