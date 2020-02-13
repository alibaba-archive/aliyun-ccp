// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class BaseDriveResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var creator:String = "";

    @objc public var description_:String = "";

    @objc public var domainId:String = "";

    @objc public var driveId:String = "";

    @objc public var driveName:String = "";

    @objc public var driveType:String = "";

    @objc public var owner:String = "";

    @objc public var relativePath:String = "";

    @objc public var status:String = "";

    @objc public var storeId:String = "";

    @objc public var totalSize:Int64 = 0;

    @objc public var usedSize:Int64 = 0;

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["creator"] = "creator";
        self.__name["description_"] = "description";
        self.__name["domainId"] = "domain_id";
        self.__name["driveId"] = "drive_id";
        self.__name["driveName"] = "drive_name";
        self.__name["driveType"] = "drive_type";
        self.__name["owner"] = "owner";
        self.__name["relativePath"] = "relative_path";
        self.__name["status"] = "status";
        self.__name["storeId"] = "store_id";
        self.__name["totalSize"] = "total_size";
        self.__name["usedSize"] = "used_size";
    }
}
