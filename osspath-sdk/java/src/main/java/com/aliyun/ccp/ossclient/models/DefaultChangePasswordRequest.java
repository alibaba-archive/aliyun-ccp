// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class DefaultChangePasswordRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("encrypted_key")
    @Validation(required = true)
    public String encryptedKey;

    @NameInMap("new_password")
    @Validation(required = true)
    public String newPassword;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    @NameInMap("phone_region")
    public String phoneRegion;

    @NameInMap("state")
    @Validation(required = true)
    public String state;

    public static DefaultChangePasswordRequest build(java.util.Map<String, ?> map) throws Exception {
        DefaultChangePasswordRequest self = new DefaultChangePasswordRequest();
        return TeaModel.build(map, self);
    }

}
