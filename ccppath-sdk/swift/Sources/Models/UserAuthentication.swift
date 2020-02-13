// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class UserAuthentication : TeaModel {
    @objc public var AuthenticationType:String = "";

    @objc public var CreatedAt:Int64 = 0;

    @objc public var Detail:String = "";

    @objc public var DomainID:String = "";

    @objc public var Identity:String = "";

    @objc public var LastLoginTime:Int64 = 0;

    @objc public var Status:String = "";

    @objc public var UserID:String = "";

    public override init() {
        super.init();
        self.__name["AuthenticationType"] = "AuthenticationType";
        self.__name["CreatedAt"] = "CreatedAt";
        self.__name["Detail"] = "Detail";
        self.__name["DomainID"] = "DomainID";
        self.__name["Identity"] = "Identity";
        self.__name["LastLoginTime"] = "LastLoginTime";
        self.__name["Status"] = "Status";
        self.__name["UserID"] = "UserID";
        self.__required["AuthenticationType"] = true;
        self.__required["CreatedAt"] = true;
        self.__required["Detail"] = true;
        self.__required["DomainID"] = true;
        self.__required["Identity"] = true;
        self.__required["LastLoginTime"] = true;
        self.__required["Status"] = true;
        self.__required["UserID"] = true;
    }
}
