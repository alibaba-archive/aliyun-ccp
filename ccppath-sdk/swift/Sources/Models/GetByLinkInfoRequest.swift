// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class GetByLinkInfoRequest : TeaModel {
    @objc public var identity:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["identity"] = "identity";
        self.__name["type"] = "type";
        self.__required["identity"] = true;
        self.__required["type"] = true;
    }
}
