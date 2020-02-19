// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class DownloadRequest : TeaModel {
    @objc public var DriveID:String = "";

    @objc public var FileID:String = "";

    @objc public var ImageProcess:String = "";

    @objc public var ShareID:String = "";

    public override init() {
        super.init();
        self.__name["DriveID"] = "DriveID";
        self.__name["FileID"] = "FileID";
        self.__name["ImageProcess"] = "ImageProcess";
        self.__name["ShareID"] = "ShareID";
        self.__required["DriveID"] = true;
        self.__required["FileID"] = true;
    }
}
