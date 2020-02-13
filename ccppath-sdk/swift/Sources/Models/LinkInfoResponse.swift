// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class LinkInfoResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var authenticationType:String = "";

    @objc public var createdAt:Int64 = 0;

    @objc public var domainId:String = "";

    @objc public var identity:String = "";

    @objc public var lastLoginTime:Int64 = 0;

    @objc public var status:String = "";

    @objc public var userId:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["authenticationType"] = "authentication_type";
        self.__name["createdAt"] = "created_at";
        self.__name["domainId"] = "domain_id";
        self.__name["identity"] = "identity";
        self.__name["lastLoginTime"] = "last_login_time";
        self.__name["status"] = "status";
        self.__name["userId"] = "user_id";
        self.__required["authenticationType"] = true;
        self.__required["createdAt"] = true;
        self.__required["domainId"] = true;
        self.__required["identity"] = true;
        self.__required["lastLoginTime"] = true;
        self.__required["status"] = true;
        self.__required["userId"] = true;
    }
}
