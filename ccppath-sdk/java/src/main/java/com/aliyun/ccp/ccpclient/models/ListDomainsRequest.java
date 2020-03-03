// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListDomainsRequest extends TeaModel {
    @NameInMap("header")
    public ListDomainsRequestHeader header;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static ListDomainsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDomainsRequest self = new ListDomainsRequest();
        return TeaModel.build(map, self);
    }

    public static class ListDomainsRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListDomainsRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListDomainsRequestHeader self = new ListDomainsRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
