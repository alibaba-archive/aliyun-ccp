// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class MobileCheckExistResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var isExist:Bool = true;

    @objc public var phoneNumber:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["isExist"] = "is_exist";
        self.__name["phoneNumber"] = "phone_number";
        self.__required["isExist"] = true;
        self.__required["phoneNumber"] = true;
    }
}
