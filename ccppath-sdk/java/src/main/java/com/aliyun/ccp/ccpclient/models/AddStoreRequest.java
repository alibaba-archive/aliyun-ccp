// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class AddStoreRequest extends TeaModel {
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

}

