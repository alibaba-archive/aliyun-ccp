// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class GetByLinkInfoRequest extends TeaModel {
    @NameInMap("identity")
    @Validation(required = true)
    public String identity;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static GetByLinkInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetByLinkInfoRequest self = new GetByLinkInfoRequest();
        return TeaModel.build(map, self);
    }

}
