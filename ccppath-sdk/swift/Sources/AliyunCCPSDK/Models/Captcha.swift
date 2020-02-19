// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class Captcha : TeaModel {
    @objc public var captcha:String = "";

    @objc public var captchaFormat:String = "";

    @objc public var captchaId:String = "";

    public override init() {
        super.init();
        self.__name["captcha"] = "captcha";
        self.__name["captchaFormat"] = "captcha_format";
        self.__name["captchaId"] = "captcha_id";
        self.__required["captcha"] = true;
        self.__required["captchaFormat"] = true;
        self.__required["captchaId"] = true;
    }
}
