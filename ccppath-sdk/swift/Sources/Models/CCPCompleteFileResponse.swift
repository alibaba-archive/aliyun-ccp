// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CCPCompleteFileResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var category:String = "";

    @objc public var contentHash:String = "";

    @objc public var contentHashName:String = "";

    @objc public var contentType:String = "";

    @objc public var crc64Hash:String = "";

    @objc public var createdAt:String = "";

    @objc public var description_:String = "";

    @objc public var domainId:String = "";

    @objc public var downloadUrl:String = "";

    @objc public var driveId:String = "";

    @objc public var fileExtension:String = "";

    @objc public var fileId:String = "";

    @objc public var hidden:Bool = true;

    @objc public var imageMediaMetadata:ImageMediaResponse? = nil;

    @objc public var labels:[String:Any] = [String:NSObject]();

    @objc public var meta:String = "";

    @objc public var name:String = "";

    @objc public var parentFileId:String = "";

    @objc public var size:Int64 = 0;

    @objc public var starred:Bool = true;

    @objc public var status:String = "";

    @objc public var thumbnail:String = "";

    @objc public var trashedAt:String = "";

    @objc public var type:String = "";

    @objc public var updatedAt:String = "";

    @objc public var uploadId:String = "";

    @objc public var url:String = "";

    @objc public var crc:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["category"] = "category";
        self.__name["contentHash"] = "content_hash";
        self.__name["contentHashName"] = "content_hash_name";
        self.__name["contentType"] = "content_type";
        self.__name["crc64Hash"] = "crc64_hash";
        self.__name["createdAt"] = "created_at";
        self.__name["description_"] = "description";
        self.__name["domainId"] = "domain_id";
        self.__name["downloadUrl"] = "download_url";
        self.__name["driveId"] = "drive_id";
        self.__name["fileExtension"] = "file_extension";
        self.__name["fileId"] = "file_id";
        self.__name["hidden"] = "hidden";
        self.__name["imageMediaMetadata"] = "image_media_metadata";
        self.__name["labels"] = "labels";
        self.__name["meta"] = "meta";
        self.__name["name"] = "name";
        self.__name["parentFileId"] = "parent_file_id";
        self.__name["size"] = "size";
        self.__name["starred"] = "starred";
        self.__name["status"] = "status";
        self.__name["thumbnail"] = "thumbnail";
        self.__name["trashedAt"] = "trashed_at";
        self.__name["type"] = "type";
        self.__name["updatedAt"] = "updated_at";
        self.__name["uploadId"] = "upload_id";
        self.__name["url"] = "url";
        self.__name["crc"] = "crc";
    }
}
