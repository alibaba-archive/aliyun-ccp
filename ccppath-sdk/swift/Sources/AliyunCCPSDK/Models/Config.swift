// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class Config : TeaModel {
    @objc public var endpoint:String = "";

    @objc public var domainId:String = "";

    @objc public var protocol_:String = "";

    @objc public var credentialType:String = "";

    @objc public var securityToken:String = "";

    @objc public var accessKeyId:String = "";

    @objc public var accessKeySecret:String = "";

    @objc public var clientId:String = "";

    @objc public var refreshToken:String = "";

    @objc public var clientSecret:String = "";

    @objc public var accessToken:String = "";

    @objc public var expireTime:String = "";

    @objc public var nickname:String = "";

    public override init() {
        super.init();
        self.__required["domainId"] = true;
    }
}
