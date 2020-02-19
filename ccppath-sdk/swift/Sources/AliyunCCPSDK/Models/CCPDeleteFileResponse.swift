// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPDeleteFileResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var asyncTaskId:String = "";

    @objc public var domainId:String = "";

    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["asyncTaskId"] = "async_task_id";
        self.__name["domainId"] = "domain_id";
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
    }
}
