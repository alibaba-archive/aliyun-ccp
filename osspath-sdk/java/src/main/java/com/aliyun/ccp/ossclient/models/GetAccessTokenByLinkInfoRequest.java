// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class GetAccessTokenByLinkInfoRequest extends TeaModel {
    @NameInMap("identity")
    @Validation(required = true)
    public String identity;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static GetAccessTokenByLinkInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenByLinkInfoRequest self = new GetAccessTokenByLinkInfoRequest();
        return TeaModel.build(map, self);
    }

}
