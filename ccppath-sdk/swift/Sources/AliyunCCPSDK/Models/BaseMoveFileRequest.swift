// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class BaseMoveFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var newName:String = "";

    @objc public var overwrite:Bool = true;

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["newName"] = "new_name";
        self.__name["overwrite"] = "overwrite";
        self.__required["driveId"] = true;
    }
}
