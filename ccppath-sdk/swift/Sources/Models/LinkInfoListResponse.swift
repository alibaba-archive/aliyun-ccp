// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class LinkInfoListResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var items:[String:Any] = [String:NSObject]();

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["items"] = "items";
        self.__required["items"] = true;
    }
}
