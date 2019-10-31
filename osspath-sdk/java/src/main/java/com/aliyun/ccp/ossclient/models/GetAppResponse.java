// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetAppResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("ali_owner_id")
    @Validation(pattern = "", maxLength = 0)
    public String aliOwnerId;

    @NameInMap("app_id")
    @Validation(pattern = "", maxLength = 0)
    public String appId;

    @NameInMap("app_name")
    @Validation(pattern = "[0-9a-zA-Z]+", maxLength = 0)
    public String appName;

    @NameInMap("app_secret")
    @Validation(pattern = "", maxLength = 0)
    public String appSecret;

    @NameInMap("created_at")
    @Validation(pattern = "", maxLength = 0)
    public String createdAt;

    @NameInMap("description")
    @Validation(pattern = "", maxLength = 0)
    public String description;

    @NameInMap("logo")
    @Validation(pattern = "", maxLength = 0)
    public String logo;

    @NameInMap("provider")
    @Validation(pattern = "", maxLength = 0)
    public String provider;

    @NameInMap("redirect_uri")
    @Validation(pattern = "", maxLength = 0)
    public String redirectUri;

    @NameInMap("scope")
    @Validation(pattern = "", maxLength = 0)
    public String[] scope;

    @NameInMap("screenshots")
    @Validation(pattern = "", maxLength = 0)
    public String[] screenshots;

    @NameInMap("stage")
    @Validation(pattern = "", maxLength = 0)
    public String stage;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

    @NameInMap("updated_at")
    @Validation(pattern = "", maxLength = 0)
    public String updatedAt;

}

