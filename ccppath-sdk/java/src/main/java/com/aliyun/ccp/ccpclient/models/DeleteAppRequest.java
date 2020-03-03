// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DeleteAppRequest extends TeaModel {
    @NameInMap("header")
    public DeleteAppRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    public static DeleteAppRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteAppRequest self = new DeleteAppRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteAppRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DeleteAppRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteAppRequestHeader self = new DeleteAppRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
