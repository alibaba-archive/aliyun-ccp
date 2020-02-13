// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class MobileLoginRequest : TeaModel {
    @objc public var appId:String = "";

    @objc public var autoRegister:Bool = true;

    @objc public var captchaId:String = "";

    @objc public var captchaText:String = "";

    @objc public var password:String = "";

    @objc public var phoneNumber:String = "";

    @objc public var smsCode:String = "";

    @objc public var smsCodeId:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["autoRegister"] = "auto_register";
        self.__name["captchaId"] = "captcha_id";
        self.__name["captchaText"] = "captcha_text";
        self.__name["password"] = "password";
        self.__name["phoneNumber"] = "phone_number";
        self.__name["smsCode"] = "sms_code";
        self.__name["smsCodeId"] = "sms_code_id";
        self.__required["appId"] = true;
        self.__required["phoneNumber"] = true;
    }
}
