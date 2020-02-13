// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class RemoveStoreRequest : TeaModel {
    @objc public var domainId:String = "";

    @objc public var storeId:String = "";

    public override init() {
        super.init();
        self.__name["domainId"] = "domain_id";
        self.__name["storeId"] = "store_id";
        self.__required["domainId"] = true;
        self.__required["storeId"] = true;
    }
}
