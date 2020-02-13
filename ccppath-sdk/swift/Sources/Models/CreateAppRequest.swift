// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class CreateAppRequest : TeaModel {
    @objc public var appName:String = "";

    @objc public var description_:String = "";

    @objc public var isThirdParty:Bool = true;

    @objc public var logo:String = "";

    @objc public var redirectUri:String = "";

    @objc public var scope:[String:Any] = [String:NSObject]();

    @objc public var type:String = "";

    public override init() {
        super.init();
        self.__name["appName"] = "app_name";
        self.__name["description_"] = "description";
        self.__name["isThirdParty"] = "is_third_party";
        self.__name["logo"] = "logo";
        self.__name["redirectUri"] = "redirect_uri";
        self.__name["scope"] = "scope";
        self.__name["type"] = "type";
        self.__required["appName"] = true;
        self.__required["logo"] = true;
        self.__required["scope"] = true;
        self.__required["type"] = true;
    }
}
