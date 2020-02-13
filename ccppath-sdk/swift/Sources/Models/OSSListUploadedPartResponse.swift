// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class OSSListUploadedPartResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var filePath:String = "";

    @objc public var nextPartNumberMarker:String = "";

    @objc public var uploadId:String = "";

    @objc public var uploadedParts:[String:Any] = [String:NSObject]();

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["filePath"] = "file_path";
        self.__name["nextPartNumberMarker"] = "next_part_number_marker";
        self.__name["uploadId"] = "upload_id";
        self.__name["uploadedParts"] = "uploaded_parts";
    }
}
