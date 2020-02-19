// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPGetDownloadUrlRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var expireSec:Int64 = 0;

    @objc public var fileId:String = "";

    @objc public var fileName:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["expireSec"] = "expire_sec";
        self.__name["fileId"] = "file_id";
        self.__name["fileName"] = "file_name";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
    }
}
