// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetAsyncTaskRequest extends TeaModel {
    @NameInMap("header")
    public CCPGetAsyncTaskRequestHeader header;

    @NameInMap("async_task_id")
    public String asyncTaskId;

    public static CCPGetAsyncTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPGetAsyncTaskRequest self = new CCPGetAsyncTaskRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPGetAsyncTaskRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPGetAsyncTaskRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPGetAsyncTaskRequestHeader self = new CCPGetAsyncTaskRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
