// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class UpdateFileMetaRequest : TeaModel {
    @objc public var description_:String = "";

    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var hidden:Bool = true;

    @objc public var meta:String = "";

    @objc public var name:String = "";

    @objc public var shareId:String = "";

    @objc public var starred:Bool = true;

    @objc public var tags:[String:AnyObject]? = nil;

    public override init() {
        super.init();
        self.__name["description_"] = "description";
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["hidden"] = "hidden";
        self.__name["meta"] = "meta";
        self.__name["name"] = "name";
        self.__name["shareId"] = "share_id";
        self.__name["starred"] = "starred";
        self.__name["tags"] = "tags";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
        self.__required["name"] = true;
    }
}
