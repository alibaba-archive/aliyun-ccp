// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class AuthConfig : TeaModel {
    @objc public var appId:String = "";

    @objc public var appSecret:String = "";

    @objc public var enable:Bool = true;

    @objc public var endpoint:String = "";

    @objc public var enterpriseId:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["appSecret"] = "app_secret";
        self.__name["enable"] = "enable";
        self.__name["endpoint"] = "endpoint";
        self.__name["enterpriseId"] = "enterprise_id";
    }
}
