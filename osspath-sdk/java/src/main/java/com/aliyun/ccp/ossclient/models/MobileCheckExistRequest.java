// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileCheckExistRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    public static MobileCheckExistRequest build(java.util.Map<String, ?> map) throws Exception {
        MobileCheckExistRequest self = new MobileCheckExistRequest();
        return TeaModel.build(map, self);
    }

}
