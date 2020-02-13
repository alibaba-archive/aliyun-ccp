// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPMoveFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var newName:String = "";

    @objc public var overwrite:Bool = true;

    @objc public var fileId:String = "";

    @objc public var toParentFileId:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["newName"] = "new_name";
        self.__name["overwrite"] = "overwrite";
        self.__name["fileId"] = "file_id";
        self.__name["toParentFileId"] = "to_parent_file_id";
    }
}
