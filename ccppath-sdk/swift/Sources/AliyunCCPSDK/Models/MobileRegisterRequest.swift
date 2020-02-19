// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class MobileRegisterRequest : TeaModel {
    @objc public var appId:String = "";

    @objc public var phoneNumber:String = "";

    @objc public var smsCode:String = "";

    @objc public var smsCodeId:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["phoneNumber"] = "phone_number";
        self.__name["smsCode"] = "sms_code";
        self.__name["smsCodeId"] = "sms_code_id";
        self.__required["appId"] = true;
        self.__required["phoneNumber"] = true;
        self.__required["smsCode"] = true;
        self.__required["smsCodeId"] = true;
    }
}
