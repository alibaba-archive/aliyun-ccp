// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPCopyFileRequest : TeaModel {
    @objc public var autoRename:Bool = true;

    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var newName:String = "";

    @objc public var toDriveId:String = "";

    @objc public var toParentFileId:String = "";

    public override init() {
        super.init();
        self.__name["autoRename"] = "auto_rename";
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["newName"] = "new_name";
        self.__name["toDriveId"] = "to_drive_id";
        self.__name["toParentFileId"] = "to_parent_file_id";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
        self.__required["toParentFileId"] = true;
    }
}
