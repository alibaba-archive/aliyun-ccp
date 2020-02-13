// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPListUploadedPartRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var limit:Int64 = 0;

    @objc public var partNumberMarker:Int64 = 0;

    @objc public var uploadId:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["limit"] = "limit";
        self.__name["partNumberMarker"] = "part_number_marker";
        self.__name["uploadId"] = "upload_id";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
        self.__required["limit"] = true;
    }
}
