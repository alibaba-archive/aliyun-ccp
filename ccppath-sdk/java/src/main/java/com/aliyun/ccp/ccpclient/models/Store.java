// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class Store extends TeaModel {
    @NameInMap("accelerate_endpoint")
    public String accelerateEndpoint;

    @NameInMap("base_path")
    public String basePath;

    @NameInMap("bucket")
    @Validation(required = true)
    public String bucket;

    @NameInMap("customized_endpoint")
    public String customizedEndpoint;

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

}
