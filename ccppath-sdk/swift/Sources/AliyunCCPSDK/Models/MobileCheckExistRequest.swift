// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class MobileCheckExistRequest : TeaModel {
    @objc public var appId:String = "";

    @objc public var phoneNumber:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["phoneNumber"] = "phone_number";
        self.__required["appId"] = true;
        self.__required["phoneNumber"] = true;
    }
}
