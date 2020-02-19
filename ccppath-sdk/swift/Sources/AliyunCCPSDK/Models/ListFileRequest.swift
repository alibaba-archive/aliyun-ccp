// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class ListFileRequest : TeaModel {
    @objc public var all:Bool = true;

    @objc public var driveId:String = "";

    @objc public var imageThumbnailProcess:String = "";

    @objc public var imageUrlProcess:String = "";

    @objc public var limit:Int64 = 0;

    @objc public var marker:String = "";

    @objc public var parentFileId:String = "";

    @objc public var parentFilePath:String = "";

    @objc public var shareId:String = "";

    @objc public var status:String = "";

    public override init() {
        super.init();
        self.__name["all"] = "all";
        self.__name["driveId"] = "drive_id";
        self.__name["imageThumbnailProcess"] = "image_thumbnail_process";
        self.__name["imageUrlProcess"] = "image_url_process";
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["parentFileId"] = "parent_file_id";
        self.__name["parentFilePath"] = "parent_file_path";
        self.__name["shareId"] = "share_id";
        self.__name["status"] = "status";
        self.__required["driveId"] = true;
        self.__required["parentFileId"] = true;
    }
}
