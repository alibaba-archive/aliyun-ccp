// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateDomainRequest extends TeaModel {
    @NameInMap("auth_alipay_app_id")
    @Validation(pattern = "", maxLength = 0)
    public String authAlipayAppId;

    @NameInMap("auth_alipay_enbale")
    @Validation(pattern = "", maxLength = 0)
    public boolean authAlipayEnbale;

    @NameInMap("auth_alipay_private_key")
    @Validation(pattern = "", maxLength = 0)
    public String authAlipayPrivateKey;

    @NameInMap("auth_config")
    @Validation(pattern = "", maxLength = 0)
    public java.util.Map<String, Object> authConfig;

    @NameInMap("auth_dingding_app_id")
    @Validation(pattern = "", maxLength = 0)
    public String authDingdingAppId;

    @NameInMap("auth_dingding_app_secret")
    @Validation(pattern = "", maxLength = 0)
    public String authDingdingAppSecret;

    @NameInMap("auth_dingding_enable")
    @Validation(pattern = "", maxLength = 0)
    public boolean authDingdingEnable;

    @NameInMap("auth_endpoint_enable")
    @Validation(pattern = "", maxLength = 0)
    public boolean authEndpointEnable;

    @NameInMap("auth_ram_app_id")
    @Validation(pattern = "", maxLength = 0)
    public String authRamAppId;

    @NameInMap("auth_ram_app_secret")
    @Validation(pattern = "", maxLength = 0)
    public String authRamAppSecret;

    @NameInMap("auth_ram_enable")
    @Validation(pattern = "", maxLength = 0)
    public boolean authRamEnable;

    @NameInMap("data_hash_name")
    @Validation(pattern = "", maxLength = 0)
    public String dataHashName;

    @NameInMap("description")
    @Validation(pattern = "", maxLength = 0)
    public String description;

    @NameInMap("domain_name")
    @Validation(pattern = "", maxLength = 0)
    public String domainName;

    @NameInMap("event_filename_matches")
    @Validation(pattern = "", maxLength = 0)
    public String eventFilenameMatches;

    @NameInMap("event_mns_endpoint")
    @Validation(pattern = "", maxLength = 0)
    public String eventMnsEndpoint;

    @NameInMap("event_mns_topic")
    @Validation(pattern = "", maxLength = 0)
    public String eventMnsTopic;

    @NameInMap("event_names")
    @Validation(pattern = "", maxLength = 0)
    public String[] eventNames;

    @NameInMap("event_role_arn")
    @Validation(pattern = "", maxLength = 0)
    public String eventRoleArn;

    @NameInMap("init_drive_enable")
    @Validation(pattern = "", maxLength = 0)
    public boolean initDriveEnable;

    @NameInMap("init_drive_size")
    @Validation(pattern = "", maxLength = 0)
    public Long initDriveSize;

    @NameInMap("path_type")
    @Validation(pattern = "", maxLength = 0)
    public String pathType;

    @NameInMap("published_app_access_strategy")
    @Validation(pattern = "", maxLength = 0)
    public AppAccessStrategy[] publishedAppAccessStrategy;

    @NameInMap("sharable")
    @Validation(pattern = "", maxLength = 0)
    public boolean sharable;

    @NameInMap("store_level")
    @Validation(pattern = "", maxLength = 0)
    public String storeLevel;

    @NameInMap("store_region_list")
    @Validation(pattern = "", maxLength = 0)
    public String[] storeRegionList;

}

