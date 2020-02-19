// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class RuntimeOptions : TeaModel {
    @objc public var autoretry:Bool = true;

    @objc public var ignoreSSL:Bool = true;

    @objc public var maxAttempts:Int = 0;

    @objc public var backoffPolicy:String = "";

    @objc public var backoffPeriod:Int = 0;

    @objc public var readTimeout:Int = 0;

    @objc public var connectTimeout:Int = 0;

    @objc public var httpProxy:String = "";

    @objc public var httpsProxy:String = "";

    @objc public var noProxy:String = "";

    @objc public var maxIdleConns:Int = 0;

    @objc public var localAddr:String = "";

    @objc public var socks5Proxy:String = "";

    @objc public var socks5NetWork:String = "";

    public override init() {
        super.init();
        self.__name["autoretry"] = "autoretry";
        self.__name["ignoreSSL"] = "ignoreSSL";
        self.__name["maxAttempts"] = "maxAttempts";
        self.__name["backoffPolicy"] = "backoffPolicy";
        self.__name["backoffPeriod"] = "backoffPeriod";
        self.__name["readTimeout"] = "readTimeout";
        self.__name["connectTimeout"] = "connectTimeout";
        self.__name["httpProxy"] = "httpProxy";
        self.__name["httpsProxy"] = "httpsProxy";
        self.__name["noProxy"] = "noProxy";
        self.__name["maxIdleConns"] = "maxIdleConns";
        self.__name["localAddr"] = "localAddr";
        self.__name["socks5Proxy"] = "socks5Proxy";
        self.__name["socks5NetWork"] = "socks5NetWork";
    }
}
