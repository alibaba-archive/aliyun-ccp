// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class ListUserResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var items:[String:Any] = [String:NSObject]();

    @objc public var nextMarker:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["items"] = "items";
        self.__name["nextMarker"] = "next_marker";
    }
}
