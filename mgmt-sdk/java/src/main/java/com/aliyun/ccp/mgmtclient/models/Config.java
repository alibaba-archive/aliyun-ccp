// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class Config extends TeaModel {
    @NameInMap("endpoint")
    public String endpoint;

    @NameInMap("region")
    public String region;

    @NameInMap("domainId")
    @Validation(required = true)
    public String domainId;

    @NameInMap("protocol")
    public String protocol;

    @NameInMap("type")
    public String type;

    @NameInMap("securityToken")
    public String securityToken;

    @NameInMap("accessKeyId")
    public String accessKeyId;

    @NameInMap("accessKeySecret")
    public String accessKeySecret;

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

    @NameInMap("nickname")
    public String nickname;

    @NameInMap("userAgent")
    public String userAgent;

    public static Config build(java.util.Map<String, ?> map) throws Exception {
        Config self = new Config();
        return TeaModel.build(map, self);
    }

}
