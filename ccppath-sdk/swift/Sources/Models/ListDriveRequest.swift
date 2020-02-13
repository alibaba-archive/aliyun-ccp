// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea.Swift

open class ListDriveRequest : TeaModel {
    @objc public var limit:Int = 0;

    @objc public var marker:String = "";

    @objc public var owner:String = "";

    public override init() {
        super.init();
        self.__name["limit"] = "limit";
        self.__name["marker"] = "marker";
        self.__name["owner"] = "owner";
    }
}
