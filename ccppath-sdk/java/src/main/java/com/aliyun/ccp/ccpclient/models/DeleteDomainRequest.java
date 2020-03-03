// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DeleteDomainRequest extends TeaModel {
    @NameInMap("header")
    public DeleteDomainRequestHeader header;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static DeleteDomainRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDomainRequest self = new DeleteDomainRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteDomainRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DeleteDomainRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteDomainRequestHeader self = new DeleteDomainRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
