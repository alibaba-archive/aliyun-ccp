// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CopyFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var filePath:String = "";

    @objc public var newName:String = "";

    @objc public var overwrite:Bool = true;

    @objc public var shareId:String = "";

    @objc public var toDriveId:String = "";

    @objc public var toParentFileId:String = "";

    @objc public var toParentFilePath:String = "";

    @objc public var toShareId:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["filePath"] = "file_path";
        self.__name["newName"] = "new_name";
        self.__name["overwrite"] = "overwrite";
        self.__name["shareId"] = "share_id";
        self.__name["toDriveId"] = "to_drive_id";
        self.__name["toParentFileId"] = "to_parent_file_id";
        self.__name["toParentFilePath"] = "to_parent_file_path";
        self.__name["toShareId"] = "to_share_id";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
        self.__required["newName"] = true;
        self.__required["toDriveId"] = true;
        self.__required["toParentFileId"] = true;
    }
}
