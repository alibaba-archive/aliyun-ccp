// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class GetShareResponse : TeaModel {
    @objc public var requestId:String = "";

    @objc public var createdAt:String = "";

    @objc public var creator:String = "";

    @objc public var description_:String = "";

    @objc public var domainId:String = "";

    @objc public var driveId:String = "";

    @objc public var expiration:String = "";

    @objc public var expired:Bool = true;

    @objc public var owner:String = "";

    @objc public var permissions:[String:Any] = [String:NSObject]();

    @objc public var shareFilePath:String = "";

    @objc public var shareId:String = "";

    @objc public var shareName:String = "";

    @objc public var status:String = "";

    @objc public var updatedAt:String = "";

    public override init() {
        super.init();
        self.__name["requestId"] = "requestId";
        self.__name["createdAt"] = "created_at";
        self.__name["creator"] = "creator";
        self.__name["description_"] = "description";
        self.__name["domainId"] = "domain_id";
        self.__name["driveId"] = "drive_id";
        self.__name["expiration"] = "expiration";
        self.__name["expired"] = "expired";
        self.__name["owner"] = "owner";
        self.__name["permissions"] = "permissions";
        self.__name["shareFilePath"] = "share_file_path";
        self.__name["shareId"] = "share_id";
        self.__name["shareName"] = "share_name";
        self.__name["status"] = "status";
        self.__name["updatedAt"] = "updated_at";
    }
}
