// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListUserRequest extends TeaModel {
    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static ListUserRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserRequest self = new ListUserRequest();
        return TeaModel.build(map, self);
    }

}
