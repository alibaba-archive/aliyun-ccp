// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class PreHashCheckSuccessResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var code:String = "";

    @objc public var fileName:String = "";

    @objc public var message:String = "";

    @objc public var parentFileId:String = "";

    @objc public var preHash:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["code"] = "code";
        self.__name["fileName"] = "file_name";
        self.__name["message"] = "message";
        self.__name["parentFileId"] = "parent_file_id";
        self.__name["preHash"] = "pre_hash";
        self.__required["parentFileId"] = true;
    }
}
