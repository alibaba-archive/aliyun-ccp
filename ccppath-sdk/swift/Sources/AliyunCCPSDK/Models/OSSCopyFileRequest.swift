// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class OSSCopyFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var filePath:String = "";

    @objc public var newName:String = "";

    @objc public var overwrite:Bool = true;

    @objc public var shareId:String = "";

    @objc public var toDriveId:String = "";

    @objc public var toParentFilePath:String = "";

    @objc public var toShareId:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["filePath"] = "file_path";
        self.__name["newName"] = "new_name";
        self.__name["overwrite"] = "overwrite";
        self.__name["shareId"] = "share_id";
        self.__name["toDriveId"] = "to_drive_id";
        self.__name["toParentFilePath"] = "to_parent_file_path";
        self.__name["toShareId"] = "to_share_id";
        self.__required["toDriveId"] = true;
        self.__required["toParentFilePath"] = true;
    }
}
