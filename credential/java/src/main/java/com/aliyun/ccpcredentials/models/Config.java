// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccpcredentials.models;

import com.aliyun.tea.*;

public class Config extends TeaModel {
    @NameInMap("endpoint")
    public String endpoint;

    @NameInMap("domainId")
    @Validation(required = true)
    public String domainId;

    @NameInMap("clientId")
    public String clientId;

    @NameInMap("refreshToken")
    public String refreshToken;

    @NameInMap("clientSecret")
    public String clientSecret;

    @NameInMap("accessToken")
    public String accessToken;

    @NameInMap("expireTime")
    public String expireTime;

    public static Config build(java.util.Map<String, ?> map) throws Exception {
        Config self = new Config();
        return TeaModel.build(map, self);
    }

}
