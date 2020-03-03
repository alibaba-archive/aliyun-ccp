// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class BatchSubRequest extends TeaModel {
    @NameInMap("header")
    public BatchSubRequestHeader header;

    @NameInMap("body")
    public java.util.Map<String, Object> body;

    @NameInMap("headers")
    public java.util.Map<String, Object> headers;

    @NameInMap("id")
    @Validation(required = true)
    public String id;

    @NameInMap("method")
    @Validation(required = true)
    public String method;

    @NameInMap("url")
    @Validation(required = true)
    public String url;

    public static BatchSubRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSubRequest self = new BatchSubRequest();
        return TeaModel.build(map, self);
    }

    public static class BatchSubRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BatchSubRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BatchSubRequestHeader self = new BatchSubRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
