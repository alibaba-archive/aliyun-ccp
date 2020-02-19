// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class UpdateDriveRequest : TeaModel {
    @objc public var description_:String = "";

    @objc public var driveId:String = "";

    @objc public var driveName:String = "";

    @objc public var status:String = "";

    @objc public var totalSize:Int64 = 0;

    public override init() {
        super.init();
        self.__name["description_"] = "description";
        self.__name["driveId"] = "drive_id";
        self.__name["driveName"] = "drive_name";
        self.__name["status"] = "status";
        self.__name["totalSize"] = "total_size";
        self.__required["driveId"] = true;
    }
}
