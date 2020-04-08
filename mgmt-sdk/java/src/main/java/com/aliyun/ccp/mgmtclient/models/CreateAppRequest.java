// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class CreateAppRequest extends TeaModel {
    @NameInMap("app_name")
    @Validation(required = true)
    public String appName;

    @NameInMap("description")
    public String description;

    @NameInMap("is_third_party")
    public Boolean isThirdParty;

    @NameInMap("logo")
    @Validation(required = true)
    public String logo;

    @NameInMap("redirect_uri")
    public String redirectUri;

    @NameInMap("scope")
    @Validation(required = true)
    public java.util.List<String> scope;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static CreateAppRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAppRequest self = new CreateAppRequest();
        return TeaModel.build(map, self);
    }

}
