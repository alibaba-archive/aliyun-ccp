// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class UpdateDomainRequest : TeaModel {
    @objc public var authAlipayAppId:String = "";

    @objc public var authAlipayEnbale:Bool = true;

    @objc public var authAlipayPrivateKey:String = "";

    @objc public var authConfig:[String:AnyObject]? = nil;

    @objc public var authDingdingAppId:String = "";

    @objc public var authDingdingAppSecret:String = "";

    @objc public var authDingdingEnable:Bool = true;

    @objc public var authEndpointEnable:Bool = true;

    @objc public var authRamAppId:String = "";

    @objc public var authRamAppSecret:String = "";

    @objc public var authRamEnable:Bool = true;

    @objc public var dataHashName:String = "";

    @objc public var description_:String = "";

    @objc public var domainId:String = "";

    @objc public var domainName:String = "";

    @objc public var eventFilenameMatches:String = "";

    @objc public var eventMnsEndpoint:String = "";

    @objc public var eventMnsTopic:String = "";

    @objc public var eventNames:[String:Any] = [String:NSObject]();

    @objc public var eventRoleArn:String = "";

    @objc public var initDriveEnable:Bool = true;

    @objc public var initDriveSize:Int64 = 0;

    @objc public var initDriveStoreId:String = "";

    @objc public var publishedAppAccessStrategy:AppAccessStrategy? = nil;

    @objc public var sharable:Bool = true;

    public override init() {
        super.init();
        self.__name["authAlipayAppId"] = "auth_alipay_app_id";
        self.__name["authAlipayEnbale"] = "auth_alipay_enbale";
        self.__name["authAlipayPrivateKey"] = "auth_alipay_private_key";
        self.__name["authConfig"] = "auth_config";
        self.__name["authDingdingAppId"] = "auth_dingding_app_id";
        self.__name["authDingdingAppSecret"] = "auth_dingding_app_secret";
        self.__name["authDingdingEnable"] = "auth_dingding_enable";
        self.__name["authEndpointEnable"] = "auth_endpoint_enable";
        self.__name["authRamAppId"] = "auth_ram_app_id";
        self.__name["authRamAppSecret"] = "auth_ram_app_secret";
        self.__name["authRamEnable"] = "auth_ram_enable";
        self.__name["dataHashName"] = "data_hash_name";
        self.__name["description_"] = "description";
        self.__name["domainId"] = "domain_id";
        self.__name["domainName"] = "domain_name";
        self.__name["eventFilenameMatches"] = "event_filename_matches";
        self.__name["eventMnsEndpoint"] = "event_mns_endpoint";
        self.__name["eventMnsTopic"] = "event_mns_topic";
        self.__name["eventNames"] = "event_names";
        self.__name["eventRoleArn"] = "event_role_arn";
        self.__name["initDriveEnable"] = "init_drive_enable";
        self.__name["initDriveSize"] = "init_drive_size";
        self.__name["initDriveStoreId"] = "init_drive_store_id";
        self.__name["publishedAppAccessStrategy"] = "published_app_access_strategy";
        self.__name["sharable"] = "sharable";
        self.__required["domainId"] = true;
    }
}
