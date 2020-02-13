// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class ListStoreFileRequest : TeaModel {
    @objc public var limit:Int64 = 0;

    @objc public var marker:String = "";

    @objc public var parentFilePath:String = "";

    @objc public var storeId:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["parentFilePath"] = "parent_file_path";
        self.__name["storeId"] = "store_id";
        self.__name["type"] = "type";
    }
}
