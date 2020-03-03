// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetDomainRequest extends TeaModel {
    @NameInMap("header")
    public GetDomainRequestHeader header;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static GetDomainRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDomainRequest self = new GetDomainRequest();
        return TeaModel.build(map, self);
    }

    public static class GetDomainRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetDomainRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetDomainRequestHeader self = new GetDomainRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
