// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPBatchRequest : TeaModel {
    @objc public var requests:[String:Any] = [String:NSObject]();

    @objc public var resource:String = "";

    public override init() {
        super.init();
        self.__name["requests"] = "requests";
        self.__name["resource"] = "resource";
        self.__required["requests"] = true;
        self.__required["resource"] = true;
    }
}
