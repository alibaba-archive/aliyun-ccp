// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class MobileCheckExistResponse extends TeaModel {
    @NameInMap("is_exist")
    @Validation(required = true)
    public Boolean isExist;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    public static MobileCheckExistResponse build(java.util.Map<String, ?> map) throws Exception {
        MobileCheckExistResponse self = new MobileCheckExistResponse();
        return TeaModel.build(map, self);
    }

}
