// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class OSSGetUploadUrlResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var createAt:String = "";

    @objc public var domainId:String = "";

    @objc public var driveId:String = "";

    @objc public var filePath:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var uploadId:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["createAt"] = "create_at";
        self.__name["domainId"] = "domain_id";
        self.__name["driveId"] = "drive_id";
        self.__name["filePath"] = "file_path";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["uploadId"] = "upload_id";
    }
}
