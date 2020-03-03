// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateDomainRequest extends TeaModel {
    @NameInMap("header")
    public CreateDomainRequestHeader header;

    @NameInMap("auth_alipay_app_id")
    public String authAlipayAppId;

    @NameInMap("auth_alipay_enbale")
    public Boolean authAlipayEnbale;

    @NameInMap("auth_alipay_private_key")
    public String authAlipayPrivateKey;

    @NameInMap("auth_config")
    public java.util.Map<String, Object> authConfig;

    @NameInMap("auth_dingding_app_id")
    public String authDingdingAppId;

    @NameInMap("auth_dingding_app_secret")
    public String authDingdingAppSecret;

    @NameInMap("auth_dingding_enable")
    public Boolean authDingdingEnable;

    @NameInMap("auth_endpoint_enable")
    public Boolean authEndpointEnable;

    @NameInMap("auth_ram_app_id")
    public String authRamAppId;

    @NameInMap("auth_ram_app_secret")
    public String authRamAppSecret;

    @NameInMap("auth_ram_enable")
    public Boolean authRamEnable;

    @NameInMap("data_hash_name")
    public String dataHashName;

    @NameInMap("description")
    public String description;

    @NameInMap("domain_name")
    @Validation(required = true)
    public String domainName;

    @NameInMap("event_filename_matches")
    public String eventFilenameMatches;

    @NameInMap("event_mns_endpoint")
    public String eventMnsEndpoint;

    @NameInMap("event_mns_topic")
    public String eventMnsTopic;

    @NameInMap("event_names")
    public java.util.List<String> eventNames;

    @NameInMap("event_role_arn")
    public String eventRoleArn;

    @NameInMap("init_drive_enable")
    public Boolean initDriveEnable;

    @NameInMap("init_drive_size")
    public Long initDriveSize;

    @NameInMap("path_type")
    @Validation(required = true)
    public String pathType;

    @NameInMap("published_app_access_strategy")
    public AppAccessStrategy publishedAppAccessStrategy;

    @NameInMap("sharable")
    public Boolean sharable;

    @NameInMap("store_level")
    public String storeLevel;

    @NameInMap("store_region_list")
    @Validation(required = true)
    public java.util.List<String> storeRegionList;

    public static CreateDomainRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDomainRequest self = new CreateDomainRequest();
        return TeaModel.build(map, self);
    }

    public static class CreateDomainRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CreateDomainRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CreateDomainRequestHeader self = new CreateDomainRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
