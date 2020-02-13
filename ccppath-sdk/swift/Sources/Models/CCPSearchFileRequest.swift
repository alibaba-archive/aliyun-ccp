// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPSearchFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var imageThumbnailProcess:String = "";

    @objc public var imageUrlProcess:String = "";

    @objc public var limit:Int = 0;

    @objc public var marker:String = "";

    @objc public var orderBy:String = "";

    @objc public var query:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["imageThumbnailProcess"] = "image_thumbnail_process";
        self.__name["imageUrlProcess"] = "image_url_process";
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["orderBy"] = "order_by";
        self.__name["query"] = "query";
        self.__required["driveId"] = true;
    }
}
