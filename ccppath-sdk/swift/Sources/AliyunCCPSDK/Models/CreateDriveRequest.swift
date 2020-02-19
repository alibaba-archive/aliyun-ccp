// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CreateDriveRequest : TeaModel {
    @objc public var default_:Bool = true;

    @objc public var description_:String = "";

    @objc public var driveName:String = "";

    @objc public var driveType:String = "";

    @objc public var owner:String = "";

    @objc public var relativePath:String = "";

    @objc public var status:String = "";

    @objc public var storeId:String = "";

    @objc public var totalSize:Int64 = 0;

    public override init() {
        super.init();
        self.__name["default_"] = "default";
        self.__name["description_"] = "description";
        self.__name["driveName"] = "drive_name";
        self.__name["driveType"] = "drive_type";
        self.__name["owner"] = "owner";
        self.__name["relativePath"] = "relative_path";
        self.__name["status"] = "status";
        self.__name["storeId"] = "store_id";
        self.__name["totalSize"] = "total_size";
        self.__required["driveName"] = true;
        self.__required["owner"] = true;
    }
}
