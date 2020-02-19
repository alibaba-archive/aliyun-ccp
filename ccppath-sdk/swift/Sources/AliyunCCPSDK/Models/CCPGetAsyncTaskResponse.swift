// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPGetAsyncTaskResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var asyncTaskId:String = "";

    @objc public var message:String = "";

    @objc public var state:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["asyncTaskId"] = "async_task_id";
        self.__name["message"] = "message";
        self.__name["state"] = "state";
    }
}
