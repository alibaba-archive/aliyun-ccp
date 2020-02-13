// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class StoreFile : TeaModel {
    @objc public var domainId:String = "";

    @objc public var name:String = "";

    @objc public var parentFilePath:String = "";

    @objc public var storeId:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["domainId"] = "domain_id";
        self.__name["name"] = "name";
        self.__name["parentFilePath"] = "parent_file_path";
        self.__name["storeId"] = "store_id";
        self.__name["type"] = "type";
    }
}
