// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class DownloadFileRequest : TeaModel {
    @objc public var DriveID:String = "";

    @objc public var FileID:String = "";

    @objc public var ImageProcess:String = "";

    public override init() {
        super.init();
        self.__name["DriveID"] = "DriveID";
        self.__name["FileID"] = "FileID";
        self.__name["ImageProcess"] = "ImageProcess";
        self.__required["DriveID"] = true;
        self.__required["FileID"] = true;
    }
}
