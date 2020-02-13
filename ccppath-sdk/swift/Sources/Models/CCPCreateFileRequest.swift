// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPCreateFileRequest : TeaModel {
    @objc public var contentMd5:String = "";

    @objc public var contentType:String = "";

    @objc public var name:String = "";

    @objc public var partInfoList:[String:Any] = [String:NSObject]();

    @objc public var size:Int64 = 0;

    @objc public var type:String = "";

    @objc public var autoRename:Bool = true;

    @objc public var contentHash:String = "";

    @objc public var contentHashName:String = "";

    @objc public var description_:String = "";

    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var hidden:Bool = true;

    @objc public var labels:[String:Any] = [String:NSObject]();

    @objc public var meta:String = "";

    @objc public var parentFileId:String = "";

    @objc public var preHash:String = "";

    public override init() {
        super.init();
        self.__name["contentMd5"] = "content_md5";
        self.__name["contentType"] = "content_type";
        self.__name["name"] = "name";
        self.__name["partInfoList"] = "part_info_list";
        self.__name["size"] = "size";
        self.__name["type"] = "type";
        self.__name["autoRename"] = "auto_rename";
        self.__name["contentHash"] = "content_hash";
        self.__name["contentHashName"] = "content_hash_name";
        self.__name["description_"] = "description";
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["hidden"] = "hidden";
        self.__name["labels"] = "labels";
        self.__name["meta"] = "meta";
        self.__name["parentFileId"] = "parent_file_id";
        self.__name["preHash"] = "pre_hash";
    }
}
