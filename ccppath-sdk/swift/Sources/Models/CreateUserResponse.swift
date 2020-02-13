// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CreateUserResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var avatar:String = "";

    @objc public var createdAt:Int64 = 0;

    @objc public var defaultDriveId:String = "";

    @objc public var description_:String = "";

    @objc public var domainId:String = "";

    @objc public var email:String = "";

    @objc public var nickName:String = "";

    @objc public var phone:String = "";

    @objc public var role:String = "";

    @objc public var status:String = "";

    @objc public var updatedAt:Int64 = 0;

    @objc public var userId:String = "";

    @objc public var userName:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["avatar"] = "avatar";
        self.__name["createdAt"] = "created_at";
        self.__name["defaultDriveId"] = "default_drive_id";
        self.__name["description_"] = "description";
        self.__name["domainId"] = "domain_id";
        self.__name["email"] = "email";
        self.__name["nickName"] = "nick_name";
        self.__name["phone"] = "phone";
        self.__name["role"] = "role";
        self.__name["status"] = "status";
        self.__name["updatedAt"] = "updated_at";
        self.__name["userId"] = "user_id";
        self.__name["userName"] = "user_name";
    }
}
