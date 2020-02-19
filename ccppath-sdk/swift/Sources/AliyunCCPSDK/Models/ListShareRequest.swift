// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class ListShareRequest : TeaModel {
    @objc public var creator:String = "";

    @objc public var limit:Int = 0;

    @objc public var marker:String = "";

    @objc public var owner:String = "";

    public override init() {
        super.init();
        self.__name["creator"] = "creator";
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["owner"] = "owner";
        self.__required["creator"] = true;
        self.__required["limit"] = true;
        self.__required["owner"] = true;
    }
}
