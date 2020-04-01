<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * create domain request
 */
class CreateDomainRequest extends Model{
    protected $_name = [
        "authAlipayAppId" => "auth_alipay_app_id",
        "authAlipayEnbale" => "auth_alipay_enbale",
        "authAlipayPrivateKey" => "auth_alipay_private_key",
        "authConfig" => "auth_config",
        "authDingdingAppId" => "auth_dingding_app_id",
        "authDingdingAppSecret" => "auth_dingding_app_secret",
        "authDingdingEnable" => "auth_dingding_enable",
        "authEndpointEnable" => "auth_endpoint_enable",
        "authRamAppId" => "auth_ram_app_id",
        "authRamAppSecret" => "auth_ram_app_secret",
        "authRamEnable" => "auth_ram_enable",
        "dataHashName" => "data_hash_name",
        "description" => "description",
        "domainName" => "domain_name",
        "eventFilenameMatches" => "event_filename_matches",
        "eventMnsEndpoint" => "event_mns_endpoint",
        "eventMnsTopic" => "event_mns_topic",
        "eventNames" => "event_names",
        "eventRoleArn" => "event_role_arn",
        "initDriveEnable" => "init_drive_enable",
        "initDriveSize" => "init_drive_size",
        "pathType" => "path_type",
        "publishedAppAccessStrategy" => "published_app_access_strategy",
        "sharable" => "sharable",
        "storeLevel" => "store_level",
        "storeRegionList" => "store_region_list",
    ];
    protected $_description = [
        "authAlipayAppId" => "支付宝 App Id",
        "authAlipayEnbale" => "启用支付宝认证",
        "authAlipayPrivateKey" => "支付宝 App Secret",
        "authConfig" => "登录相关信息",
        "authDingdingAppId" => "钉钉 App Id",
        "authDingdingAppSecret" => "钉钉 App Secret",
        "authDingdingEnable" => "启用钉钉认证",
        "authRamAppId" => "RAM App Id",
        "authRamAppSecret" => "RAM App Secret",
        "authRamEnable" => "启用 RAM 认证",
        "dataHashName" => "数据 Hash 算法",
        "description" => "Domain 描述",
        "domainName" => "Domain 名称",
        "eventFilenameMatches" => "事件通知 MNS 匹配文件名",
        "eventMnsEndpoint" => "事件通知 MNS Endpoint",
        "eventMnsTopic" => "事件通知 MNS Topic",
        "eventNames" => "事件名列表",
        "eventRoleArn" => "事件通知 Role Arn",
        "initDriveEnable" => "开启自动初始化 Drive",
        "initDriveSize" => "自动初始化 Drive 大小",
        "pathType" => "Domain 类型",
        "sharable" => "开启分享",
        "storeLevel" => "存储级别",
        "storeRegionList" => "存储 Region 列表",
    ];
    protected $_example = [
        "authAlipayAppId" => "abc",
        "authAlipayEnbale" => "true",
        "authAlipayPrivateKey" => "abc",
        "authConfig" => "{}",
        "authDingdingAppId" => "abc",
        "authDingdingAppSecret" => "abc",
        "authDingdingEnable" => "true",
        "authRamAppId" => "abc",
        "authRamAppSecret" => "abc",
        "authRamEnable" => "true",
        "dataHashName" => "sha1",
        "description" => "my test domain",
        "domainName" => "test_domain",
        "eventFilenameMatches" => "abc",
        "eventMnsEndpoint" => "http://abc.mns.cn-shenzhen.aliyuncs.com",
        "eventMnsTopic" => "abc",
        "eventNames" => "abc",
        "initDriveEnable" => "true",
        "initDriveSize" => 1024,
        "pathType" => "CCPPath",
        "sharable" => "true",
        "storeLevel" => "Standard",
        "storeRegionList" => "cn-hangzhou",
    ];
    protected $_additionalProperties = [
        "authConfig" => "{"$ref":"#/definitions/AuthConfig"}",
    ];
    protected $_required = [
        "domainName" => true,
        "pathType" => true,
        "storeRegionList" => true,
    ];
    protected $_items = [
        "eventNames" => "{"type":"string"}",
        "storeRegionList" => "{"type":"string"}",
    ];
    protected $_format = [
        "initDriveSize" => "int64",
    ];
    protected $_$ref = [
        "publishedAppAccessStrategy" => "#/definitions/AppAccessStrategy",
    ];
    public $authAlipayAppId;
    public $authAlipayEnbale;
    public $authAlipayPrivateKey;
    public $authConfig;
    public $authDingdingAppId;
    public $authDingdingAppSecret;
    public $authDingdingEnable;
    public $authEndpointEnable;
    public $authRamAppId;
    public $authRamAppSecret;
    public $authRamEnable;
    public $dataHashName;
    public $description;
    public $domainName;
    public $eventFilenameMatches;
    public $eventMnsEndpoint;
    public $eventMnsTopic;
    public $eventNames;
    public $eventRoleArn;
    public $initDriveEnable;
    public $initDriveSize;
    public $pathType;
    public $publishedAppAccessStrategy;
    public $sharable;
    public $storeLevel;
    public $storeRegionList;
}
