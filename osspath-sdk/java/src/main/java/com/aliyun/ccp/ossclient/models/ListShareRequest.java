// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListShareRequest extends TeaModel {
    @NameInMap("creator")
    @Validation(required = true)
    public String creator;

    @NameInMap("limit")
    @Validation(required = true)
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("owner")
    @Validation(required = true)
    public String owner;

}
