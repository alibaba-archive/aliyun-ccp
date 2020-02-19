// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPListUploadedPartResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var fileId:String = "";

    @objc public var nextPartNumberMarker:String = "";

    @objc public var uploadId:String = "";

    @objc public var uploadedParts:[String:Any] = [String:NSObject]();

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["fileId"] = "file_id";
        self.__name["nextPartNumberMarker"] = "next_part_number_marker";
        self.__name["uploadId"] = "upload_id";
        self.__name["uploadedParts"] = "uploaded_parts";
    }
}
