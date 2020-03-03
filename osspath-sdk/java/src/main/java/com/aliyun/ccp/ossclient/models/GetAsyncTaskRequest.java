// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetAsyncTaskRequest extends TeaModel {
    @NameInMap("header")
    public GetAsyncTaskRequestHeader header;

    @NameInMap("async_task_id")
    public String asyncTaskId;

    public static GetAsyncTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncTaskRequest self = new GetAsyncTaskRequest();
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

    public static class GetAsyncTaskRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetAsyncTaskRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetAsyncTaskRequestHeader self = new GetAsyncTaskRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
