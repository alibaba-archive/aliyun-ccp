// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * delete domain request
 */
public class DeleteDomainRequest extends TeaModel {
    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static DeleteDomainRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDomainRequest self = new DeleteDomainRequest();
        return TeaModel.build(map, self);
    }

}
