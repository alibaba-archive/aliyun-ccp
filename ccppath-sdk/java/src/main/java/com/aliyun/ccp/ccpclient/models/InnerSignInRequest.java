// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class InnerSignInRequest extends TeaModel {
    @NameInMap("key_pair_id")
    public String keyPairId;

    @NameInMap("password")
    public String password;

    @NameInMap("phone_number")
    public String phoneNumber;

    @NameInMap("phone_region")
    public String phoneRegion;

    @NameInMap("sign_in_type")
    public String signInType;

    @NameInMap("sms_code")
    public String smsCode;

    @NameInMap("sms_code_id")
    public String smsCodeId;

    public static InnerSignInRequest build(java.util.Map<String, ?> map) throws Exception {
        InnerSignInRequest self = new InnerSignInRequest();
        return TeaModel.build(map, self);
    }

}
