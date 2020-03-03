// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AccountLinkRequest extends TeaModel {
    @NameInMap("header")
    public AccountLinkRequestHeader header;

    @NameInMap("detail")
    public String detail;

    @NameInMap("identity")
    @Validation(required = true)
    public String identity;

    @NameInMap("status")
    public String status;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static AccountLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        AccountLinkRequest self = new AccountLinkRequest();
        return TeaModel.build(map, self);
    }

    public static class AccountLinkRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static AccountLinkRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            AccountLinkRequestHeader self = new AccountLinkRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
