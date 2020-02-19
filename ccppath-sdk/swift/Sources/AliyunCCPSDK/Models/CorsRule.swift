// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class CorsRule : TeaModel {
    @objc public var allowedHeader:[String:Any] = [String:NSObject]();

    @objc public var allowedMethod:[String:Any] = [String:NSObject]();

    @objc public var allowedOrigin:[String:Any] = [String:NSObject]();

    @objc public var exposeHeader:[String:Any] = [String:NSObject]();

    @objc public var maxAgeSeconds:Int64 = 0;

    public override init() {
        super.init();
        self.__name["allowedHeader"] = "allowed_header";
        self.__name["allowedMethod"] = "allowed_method";
        self.__name["allowedOrigin"] = "allowed_origin";
        self.__name["exposeHeader"] = "expose_header";
        self.__name["maxAgeSeconds"] = "max_age_seconds";
    }
}
