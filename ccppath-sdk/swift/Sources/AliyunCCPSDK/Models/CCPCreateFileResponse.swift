// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPCreateFileResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var domainId:String = "";

    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var parentFileId:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var rapidUpload:Bool = true;

    @objc public var type:String = "";

    @objc public var uploadId:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["domainId"] = "domain_id";
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["parentFileId"] = "parent_file_id";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["rapidUpload"] = "rapid_upload";
        self.__name["type"] = "type";
        self.__name["uploadId"] = "upload_id";
    }
}
