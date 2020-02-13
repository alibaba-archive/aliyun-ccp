// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class UpdateUserRequest : TeaModel {
    @objc public var avatar:String = "";

    @objc public var description_:String = "";

    @objc public var email:String = "";

    @objc public var nickName:String = "";

    @objc public var phone:String = "";

    @objc public var role:String = "";

    @objc public var status:String = "";

    @objc public var userId:String = "";

    public override init() {
        super.init();
        self.__name["avatar"] = "avatar";
        self.__name["description_"] = "description";
        self.__name["email"] = "email";
        self.__name["nickName"] = "nick_name";
        self.__name["phone"] = "phone";
        self.__name["role"] = "role";
        self.__name["status"] = "status";
        self.__name["userId"] = "user_id";
        self.__required["userId"] = true;
    }
}
