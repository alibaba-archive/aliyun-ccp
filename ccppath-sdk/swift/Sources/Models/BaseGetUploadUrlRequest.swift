// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class BaseGetUploadUrlRequest : TeaModel {
    @objc public var contentMd5:String = "";

    @objc public var driveId:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var uploadId:String = "";

    public override init() {
        super.init();
        self.__name["contentMd5"] = "content_md5";
        self.__name["driveId"] = "drive_id";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["uploadId"] = "upload_id";
        self.__required["driveId"] = true;
        self.__required["uploadId"] = true;
    }
}
