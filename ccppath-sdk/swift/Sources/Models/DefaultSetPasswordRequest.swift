// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class DefaultSetPasswordRequest : TeaModel {
    @objc public var appId:String = "";

    @objc public var newPassword:String = "";

    @objc public var state:String = "";

    public override init() {
        super.init();
        self.__name["appId"] = "app_id";
        self.__name["newPassword"] = "new_password";
        self.__name["state"] = "state";
        self.__required["appId"] = true;
        self.__required["newPassword"] = true;
        self.__required["state"] = true;
    }
}
