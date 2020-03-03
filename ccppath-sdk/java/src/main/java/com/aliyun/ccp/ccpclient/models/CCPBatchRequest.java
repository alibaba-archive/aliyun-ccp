// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPBatchRequest extends TeaModel {
    @NameInMap("header")
    public CCPBatchRequestHeader header;

    @NameInMap("requests")
    @Validation(required = true)
    public java.util.List<BatchSubRequest> requests;

    @NameInMap("resource")
    @Validation(required = true)
    public String resource;

    public static CCPBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPBatchRequest self = new CCPBatchRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPBatchRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPBatchRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPBatchRequestHeader self = new CCPBatchRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
