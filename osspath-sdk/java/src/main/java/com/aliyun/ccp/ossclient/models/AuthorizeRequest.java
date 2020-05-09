// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class AuthorizeRequest extends TeaModel {
    @NameInMap("ClientID")
    @Validation(required = true)
    public String ClientID;

    @NameInMap("LoginType")
    public String LoginType;

    @NameInMap("RedirectUri")
    @Validation(required = true)
    public String RedirectUri;

    @NameInMap("ResponseType")
    @Validation(required = true)
    public String ResponseType;

    @NameInMap("Scope")
    public java.util.List<String> Scope;

    @NameInMap("State")
    public String State;

    public static AuthorizeRequest build(java.util.Map<String, ?> map) throws Exception {
        AuthorizeRequest self = new AuthorizeRequest();
        return TeaModel.build(map, self);
    }

}
