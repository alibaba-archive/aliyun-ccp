// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class BatchSubRequest : TeaModel {
    @objc public var body:[String:AnyObject]? = nil;

    @objc public var headers:[String:AnyObject]? = nil;

    @objc public var id:String = "";

    @objc public var method:String = "";

    @objc public var url:String = "";

    public override init() {
        super.init();
        self.__name["body"] = "body";
        self.__name["headers"] = "headers";
        self.__name["id"] = "id";
        self.__name["method"] = "method";
        self.__name["url"] = "url";
        self.__required["id"] = true;
        self.__required["method"] = true;
        self.__required["url"] = true;
    }
}
