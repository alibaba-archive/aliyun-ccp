// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class DeleteFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var filePath:String = "";

    @objc public var permanently:Bool = true;

    @objc public var shareId:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["filePath"] = "file_path";
        self.__name["permanently"] = "permanently";
        self.__name["shareId"] = "share_id";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
    }
}
