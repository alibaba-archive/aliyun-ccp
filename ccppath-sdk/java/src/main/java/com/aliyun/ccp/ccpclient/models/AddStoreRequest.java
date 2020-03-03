// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class AddStoreRequest extends TeaModel {
    @NameInMap("header")
    public AddStoreRequestHeader header;

    @NameInMap("base_path")
    public String basePath;

    @NameInMap("bucket")
    public String bucket;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    @NameInMap("endpoint")
    @Validation(required = true)
    public String endpoint;

    @NameInMap("ownership")
    public String ownership;

    @NameInMap("role_arn")
    public String roleArn;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static AddStoreRequest build(java.util.Map<String, ?> map) throws Exception {
        AddStoreRequest self = new AddStoreRequest();
        return TeaModel.build(map, self);
    }

    public static class AddStoreRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static AddStoreRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            AddStoreRequestHeader self = new AddStoreRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
