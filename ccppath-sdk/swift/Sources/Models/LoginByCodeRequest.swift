// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class LoginByCodeRequest : TeaModel {
    @objc public var accessToken:String = "";

    @objc public var appId:String = "";

    @objc public var authCode:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["accessToken"] = "access_token";
        self.__name["appId"] = "app_id";
        self.__name["authCode"] = "auth_code";
        self.__name["type"] = "type";
        self.__required["appId"] = true;
        self.__required["type"] = true;
    }
}
