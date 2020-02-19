// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class UploadPartInfo : TeaModel {
    @objc public var etag:String = "";

    @objc public var partNumber:Int64 = 0;

    @objc public var partSize:Int64 = 0;

    @objc public var uploadUrl:String = "";

    public override init() {
        super.init();
        self.__name["etag"] = "etag";
        self.__name["partNumber"] = "part_number";
        self.__name["partSize"] = "part_size";
        self.__name["uploadUrl"] = "upload_url";
    }
}
