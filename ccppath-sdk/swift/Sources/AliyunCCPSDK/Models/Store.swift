// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class Store : TeaModel {
    @objc public var accelerateEndpoint:String = "";

    @objc public var basePath:String = "";

    @objc public var bucket:String = "";

    @objc public var customizedEndpoint:String = "";

    @objc public var endpoint:String = "";

    @objc public var internalEndpoint:String = "";

    @objc public var ownership:String = "";

    @objc public var policy:String = "";

    @objc public var roleArn:String = "";

    @objc public var storeId:String = "";

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["accelerateEndpoint"] = "accelerate_endpoint";
        self.__name["basePath"] = "base_path";
        self.__name["bucket"] = "bucket";
        self.__name["customizedEndpoint"] = "customized_endpoint";
        self.__name["endpoint"] = "endpoint";
        self.__name["internalEndpoint"] = "internal_endpoint";
        self.__name["ownership"] = "ownership";
        self.__name["policy"] = "policy";
        self.__name["roleArn"] = "role_arn";
        self.__name["storeId"] = "store_id";
        self.__name["type"] = "type";
        self.__required["bucket"] = true;
        self.__required["endpoint"] = true;
        self.__required["ownership"] = true;
        self.__required["policy"] = true;
        self.__required["storeId"] = true;
        self.__required["type"] = true;
    }
}
