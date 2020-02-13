// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPUpdateFileMetaRequest : TeaModel {
    @objc public var customIndexKey:String = "";

    @objc public var description_:String = "";

    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var hidden:Bool = true;

    @objc public var labels:[String:Any] = [String:NSObject]();

    @objc public var meta:String = "";

    @objc public var name:String = "";

    @objc public var starred:Bool = true;

    public override init() {
        super.init();
        self.__name["customIndexKey"] = "custom_index_key";
        self.__name["description_"] = "description";
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["hidden"] = "hidden";
        self.__name["labels"] = "labels";
        self.__name["meta"] = "meta";
        self.__name["name"] = "name";
        self.__name["starred"] = "starred";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
    }
}
