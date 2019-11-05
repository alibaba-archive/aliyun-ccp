// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateAppRequest extends TeaModel {
    @NameInMap("app_name")
    @Validation(required = true)
    public String appName;

    @NameInMap("description")
    public String description;

    @NameInMap("is_third_party")
    public boolean isThirdParty;

    @NameInMap("logo")
    @Validation(required = true)
    public String logo;

    @NameInMap("redirect_uri")
    public String redirectUri;

    @NameInMap("scope")
    @Validation(required = true)
    public String[] scope;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

}

