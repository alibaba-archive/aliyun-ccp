// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPGetFileRequest : TeaModel {
    @objc public var driveId:String = "";

    @objc public var fileId:String = "";

    @objc public var imageThumbnailProcess:String = "";

    @objc public var imageUrlProcess:String = "";

    public override init() {
        super.init();
        self.__name["driveId"] = "drive_id";
        self.__name["fileId"] = "file_id";
        self.__name["imageThumbnailProcess"] = "image_thumbnail_process";
        self.__name["imageUrlProcess"] = "image_url_process";
        self.__required["driveId"] = true;
        self.__required["fileId"] = true;
    }
}
