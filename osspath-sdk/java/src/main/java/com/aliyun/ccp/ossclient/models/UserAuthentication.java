// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class UserAuthentication extends TeaModel {
    @NameInMap("AuthenticationType")
    @Validation(required = true)
    public String AuthenticationType;

    @NameInMap("CreatedAt")
    @Validation(required = true)
    public Long CreatedAt;

    @NameInMap("Detail")
    @Validation(required = true)
    public String Detail;

    @NameInMap("DomainID")
    @Validation(required = true)
    public String DomainID;

    @NameInMap("Identity")
    @Validation(required = true)
    public String Identity;

    @NameInMap("LastLoginTime")
    @Validation(required = true)
    public Long LastLoginTime;

    @NameInMap("Status")
    @Validation(required = true)
    public String Status;

    @NameInMap("UserID")
    @Validation(required = true)
    public String UserID;

    public static UserAuthentication build(java.util.Map<String, ?> map) throws Exception {
        UserAuthentication self = new UserAuthentication();
        return TeaModel.build(map, self);
    }

}
