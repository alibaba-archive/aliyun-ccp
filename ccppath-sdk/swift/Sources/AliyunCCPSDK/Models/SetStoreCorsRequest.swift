// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class SetStoreCorsRequest : TeaModel {
    @objc public var corsRule:CorsRule? = nil;

    @objc public var domainId:String = "";

    @objc public var storeId:String = "";

    public override init() {
        super.init();
        self.__name["corsRule"] = "cors_rule";
        self.__name["domainId"] = "domain_id";
        self.__name["storeId"] = "store_id";
        self.__required["corsRule"] = true;
        self.__required["domainId"] = true;
        self.__required["storeId"] = true;
    }
}
