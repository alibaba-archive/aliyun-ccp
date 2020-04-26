// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class GetAppResponse extends TeaModel {
    @NameInMap("ali_owner_id")
    @Validation(required = true)
    public String aliOwnerId;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("app_name")
    @Validation(required = true, pattern = "[0-9a-zA-Z]+")
    public String appName;

    @NameInMap("app_secret")
    @Validation(required = true)
    public String appSecret;

    @NameInMap("created_at")
    @Validation(required = true)
    public String createdAt;

    @NameInMap("description")
    @Validation(required = true)
    public String description;

    @NameInMap("logo")
    @Validation(required = true)
    public String logo;

    @NameInMap("provider")
    @Validation(required = true)
    public String provider;

    @NameInMap("redirect_uri")
    @Validation(required = true)
    public String redirectUri;

    @NameInMap("scope")
    @Validation(required = true)
    public java.util.List<String> scope;

    @NameInMap("screenshots")
    @Validation(required = true)
    public java.util.List<String> screenshots;

    @NameInMap("stage")
    @Validation(required = true)
    public String stage;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    @NameInMap("updated_at")
    @Validation(required = true)
    public String updatedAt;

    public static GetAppResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAppResponse self = new GetAppResponse();
        return TeaModel.build(map, self);
    }

}
