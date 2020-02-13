// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class MobileSendSmsCodeRequest : TeaModel {
    @objc public var appId:String = "";

    @objc public var captchaId:String = "";

    @objc public var captchaText:String = "";

    @objc public var phoneNumber:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["captchaId"] = "captcha_id";
        self.__name["captchaText"] = "captcha_text";
        self.__name["phoneNumber"] = "phone_number";
        self.__name["type"] = "type";
        self.__required["appId"] = true;
        self.__required["phoneNumber"] = true;
        self.__required["type"] = true;
    }
}
