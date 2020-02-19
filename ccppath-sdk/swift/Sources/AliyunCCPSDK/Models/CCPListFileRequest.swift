// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CCPListFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var imageThumbnailProcess:String = "";

    @objc public var imageUrlProcess:String = "";

    @objc public var limit:Int64 = 0;

    @objc public var marker:String = "";

    @objc public var Starred:Bool = true;

    @objc public var all:Bool = true;

    @objc public var category:String = "";

    @objc public var orderBy:String = "";

    @objc public var orderDirection:String = "";

    @objc public var parentFileId:String = "";

    @objc public var status:String = "";

    @objc public var type:String = "";

    @objc public var customIndexKey:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["imageThumbnailProcess"] = "image_thumbnail_process";
        self.__name["imageUrlProcess"] = "image_url_process";
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["Starred"] = "Starred";
        self.__name["all"] = "all";
        self.__name["category"] = "category";
        self.__name["orderBy"] = "order_by";
        self.__name["orderDirection"] = "order_direction";
        self.__name["parentFileId"] = "parent_file_id";
        self.__name["status"] = "status";
        self.__name["type"] = "type";
        self.__name["customIndexKey"] = "custom_index_key";
    }
}
