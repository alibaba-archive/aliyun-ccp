// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class UpdateShareRequest : TeaModel {
    @objc public var description_:String = "";

    @objc public var expiration:String = "";

    @objc public var permissions:[String:Any] = [String:NSObject]();

    @objc public var shareId:String = "";

    @objc public var shareName:String = "";

    @objc public var status:String = "";

    public override init() {
        super.init();
        self.__name["description_"] = "description";
        self.__name["expiration"] = "expiration";
        self.__name["permissions"] = "permissions";
        self.__name["shareId"] = "share_id";
        self.__name["shareName"] = "share_name";
        self.__name["status"] = "status";
        self.__required["shareId"] = true;
    }
}
