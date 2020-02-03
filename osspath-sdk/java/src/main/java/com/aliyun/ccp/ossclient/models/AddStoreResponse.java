// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AddStoreResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("accelerate_endpoint")
    public String accelerateEndpoint;

    @NameInMap("base_path")
    public String basePath;

    @NameInMap("bucket")
    @Validation(required = true)
    public String bucket;

    @NameInMap("customized_endpoint")
    public String customizedEndpoint;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    @NameInMap("endpoint")
    @Validation(required = true)
    public String endpoint;

    @NameInMap("internal_endpoint")
    public String internalEndpoint;

    @NameInMap("ownership")
    @Validation(required = true)
    public String ownership;

    @NameInMap("policy")
    @Validation(required = true)
    public String policy;

    @NameInMap("role_arn")
    public String roleArn;

    @NameInMap("store_id")
    @Validation(required = true)
    public String storeId;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static AddStoreResponse build(java.util.Map<String, ?> map) throws Exception {
        AddStoreResponse self = new AddStoreResponse();
        return TeaModel.build(map, self);
    }

}
