// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class MobileSendSmsCodeResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var smsCodeId:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["smsCodeId"] = "sms_code_id";
        self.__required["smsCodeId"] = true;
    }
}
