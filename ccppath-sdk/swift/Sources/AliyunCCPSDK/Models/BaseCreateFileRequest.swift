// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class BaseCreateFileRequest : TeaModel {
    @objc public var contentMd5:String = "";

    @objc public var contentType:String = "";

    @objc public var name:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var size:Int64 = 0;

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["contentMd5"] = "content_md5";
        self.__name["contentType"] = "content_type";
        self.__name["name"] = "name";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["size"] = "size";
        self.__name["type"] = "type";
        self.__required["contentMd5"] = true;
        self.__required["contentType"] = true;
        self.__required["name"] = true;
        self.__required["size"] = true;
        self.__required["type"] = true;
    }
}
