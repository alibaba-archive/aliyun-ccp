// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class BatchSubResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var body:[String:AnyObject]? = nil;

    @objc public var id:String = "";

    @objc public var status:Int64 = 0;

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["body"] = "body";
        self.__name["id"] = "id";
        self.__name["status"] = "status";
    }
}
