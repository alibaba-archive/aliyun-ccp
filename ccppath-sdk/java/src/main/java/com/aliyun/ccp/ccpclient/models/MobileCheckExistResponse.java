// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileCheckExistResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("is_exist")
    @Validation(required = true)
    public boolean isExist;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

}
