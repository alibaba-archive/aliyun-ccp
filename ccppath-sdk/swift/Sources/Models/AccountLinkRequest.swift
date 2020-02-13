// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class AccountLinkRequest : TeaModel {
    @objc public var detail:String = "";

    @objc public var identity:String = "";

    @objc public var status:String = "";

    @objc public var type:String = "";

    @objc public var userId:String = "";

    public override init() {
        super.init();
        self.__name["detail"] = "detail";
        self.__name["identity"] = "identity";
        self.__name["status"] = "status";
        self.__name["type"] = "type";
        self.__name["userId"] = "user_id";
        self.__required["identity"] = true;
        self.__required["type"] = true;
        self.__required["userId"] = true;
    }
}
