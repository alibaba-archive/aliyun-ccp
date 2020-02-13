// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class AccountAccessTokenResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var accessToken:String = "";

    @objc public var avatar:String = "";

    @objc public var defaultDriveId:String = "";

    @objc public var existLink:[String:Any] = [String:NSObject]();

    @objc public var expireTime:String = "";

    @objc public var expiresIn:Int64 = 0;

    @objc public var needLink:Bool = true;

    @objc public var nickName:String = "";

    @objc public var refreshToken:String = "";

    @objc public var role:String = "";

    @objc public var state:String = "";

    @objc public var tokenType:String = "";

    @objc public var userId:String = "";

    @objc public var userName:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["accessToken"] = "access_token";
        self.__name["avatar"] = "avatar";
        self.__name["defaultDriveId"] = "default_drive_id";
        self.__name["existLink"] = "exist_link";
        self.__name["expireTime"] = "expire_time";
        self.__name["expiresIn"] = "expires_in";
        self.__name["needLink"] = "need_link";
        self.__name["nickName"] = "nick_name";
        self.__name["refreshToken"] = "refresh_token";
        self.__name["role"] = "role";
        self.__name["state"] = "state";
        self.__name["tokenType"] = "token_type";
        self.__name["userId"] = "user_id";
        self.__name["userName"] = "user_name";
        self.__required["accessToken"] = true;
        self.__required["needLink"] = true;
    }
}
