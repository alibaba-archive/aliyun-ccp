// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class TokenRequest : TeaModel {
    @objc public var appId:String = "";

    @objc public var grantType:String = "";

    @objc public var refreshToken:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["grantType"] = "grant_type";
        self.__name["refreshToken"] = "refresh_token";
        self.__required["appId"] = true;
        self.__required["grantType"] = true;
        self.__required["refreshToken"] = true;
    }
}
