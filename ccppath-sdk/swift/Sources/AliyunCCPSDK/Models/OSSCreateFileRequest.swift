// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class OSSCreateFileRequest : TeaModel {
    @objc public var contentMd5:String = "";

    @objc public var contentType:String = "";

    @objc public var name:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var size:Int64 = 0;

    @objc public var type:String = "";

    @objc public var driveId:String = "";

    @objc public var parentFilePath:String = "";

    @objc public var shareId:String = "";

    public override init() {
        super.init();
        self.__name["contentMd5"] = "content_md5";
        self.__name["contentType"] = "content_type";
        self.__name["name"] = "name";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["size"] = "size";
        self.__name["type"] = "type";
        self.__name["driveId"] = "drive_id";
        self.__name["parentFilePath"] = "parent_file_path";
        self.__name["shareId"] = "share_id";
    }
}
