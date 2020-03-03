// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateAppRequest extends TeaModel {
    @NameInMap("header")
    public CreateAppRequestHeader header;

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

    public static class CreateAppRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CreateAppRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CreateAppRequestHeader self = new CreateAppRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
