// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPDeleteFilesResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var deletedFileIdList:[String:Any] = [String:NSObject]();

    @objc public var domainId:String = "";

    @objc public var driveId:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["deletedFileIdList"] = "deleted_file_id_list";
        self.__name["domainId"] = "domain_id";
        self.__name["driveId"] = "drive_id";
    }
}
