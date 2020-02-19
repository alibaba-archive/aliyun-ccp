// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CreateShareRequest : TeaModel {
    @objc public var description_:String = "";

    @objc public var driveId:String = "";

    @objc public var expiration:String = "";

    @objc public var owner:String = "";

    @objc public var permissions:[String:Any] = [String:NSObject]();

    @objc public var shareFilePath:String = "";

    @objc public var shareName:String = "";

    @objc public var status:String = "";

    public override init() {
        super.init();
        self.__name["description_"] = "description";
        self.__name["driveId"] = "drive_id";
        self.__name["expiration"] = "expiration";
        self.__name["owner"] = "owner";
        self.__name["permissions"] = "permissions";
        self.__name["shareFilePath"] = "share_file_path";
        self.__name["shareName"] = "share_name";
        self.__name["status"] = "status";
        self.__required["driveId"] = true;
        self.__required["owner"] = true;
        self.__required["shareFilePath"] = true;
    }
}
