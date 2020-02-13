// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class SearchUserRequest : TeaModel {
    @objc public var email:String = "";

    @objc public var limit:Int = 0;

    @objc public var marker:String = "";

    @objc public var nickName:String = "";

    @objc public var phone:String = "";

    @objc public var role:String = "";

    @objc public var status:String = "";

    @objc public var userName:String = "";

    public override init() {
        super.init();
        self.__name["email"] = "email";
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["nickName"] = "nick_name";
        self.__name["phone"] = "phone";
        self.__name["role"] = "role";
        self.__name["status"] = "status";
        self.__name["userName"] = "user_name";
    }
}
