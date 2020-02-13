// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CompleteFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var filePath:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var shareId:String = "";

    @objc public var uploadId:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["filePath"] = "file_path";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["shareId"] = "share_id";
        self.__name["uploadId"] = "upload_id";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
        self.__required["uploadId"] = true;
    }
}
