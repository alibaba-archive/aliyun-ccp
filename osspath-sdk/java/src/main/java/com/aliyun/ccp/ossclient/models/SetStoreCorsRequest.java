// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class SetStoreCorsRequest extends TeaModel {
    @NameInMap("cors_rule")
    @Validation(pattern = "", maxLength = 0)
    public CorsRule[] corsRule;

    @NameInMap("domain_id")
    @Validation(pattern = "", maxLength = 0)
    public String domainId;

    @NameInMap("store_id")
    @Validation(pattern = "", maxLength = 0)
    public String storeId;

}

