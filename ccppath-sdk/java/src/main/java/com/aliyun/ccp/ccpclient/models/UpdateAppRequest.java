// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateAppRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("app_name")
    @Validation(required = true, pattern = "[0-9a-zA-Z]+")
    public String appName;

    @NameInMap("description")
    public String description;

    @NameInMap("is_third_party")
    @Validation(required = true)
    public boolean isThirdParty;

    @NameInMap("logo")
    @Validation(required = true)
    public String logo;

    @NameInMap("redirect_uri")
    @Validation(required = true)
    public String redirectUri;

    @NameInMap("scope")
    @Validation(required = true)
    public String[] scope;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

}
