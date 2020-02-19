// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPDeleteFilesRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var fileIdList:[String:Any] = [String:NSObject]();

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["fileIdList"] = "file_id_list";
        self.__required["driveId"] = true;
        self.__required["fileIdList"] = true;
    }
}
