// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class AddStoreRequest : TeaModel {
    @objc public var basePath:String = "";

    @objc public var bucket:String = "";

    @objc public var domainId:String = "";

    @objc public var endpoint:String = "";

    @objc public var ownership:String = "";

    @objc public var roleArn:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["basePath"] = "base_path";
        self.__name["bucket"] = "bucket";
        self.__name["domainId"] = "domain_id";
        self.__name["endpoint"] = "endpoint";
        self.__name["ownership"] = "ownership";
        self.__name["roleArn"] = "role_arn";
        self.__name["type"] = "type";
        self.__required["domainId"] = true;
        self.__required["endpoint"] = true;
        self.__required["type"] = true;
    }
}
