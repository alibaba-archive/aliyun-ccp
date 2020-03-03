// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListShareRequest extends TeaModel {
    @NameInMap("header")
    public ListShareRequestHeader header;

    @NameInMap("creator")
    @Validation(required = true)
    public String creator;

    @NameInMap("limit")
    @Validation(required = true)
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("owner")
    @Validation(required = true)
    public String owner;

    public static ListShareRequest build(java.util.Map<String, ?> map) throws Exception {
        ListShareRequest self = new ListShareRequest();
        return TeaModel.build(map, self);
    }

    public static class ListShareRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListShareRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListShareRequestHeader self = new ListShareRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
