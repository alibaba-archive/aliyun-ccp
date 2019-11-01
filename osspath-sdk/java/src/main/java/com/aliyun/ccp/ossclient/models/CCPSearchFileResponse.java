// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPSearchFileResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("items")
    @Validation(pattern = "", maxLength = 0)
    public BaseCCPFileResponse[] items;

    @NameInMap("next_marker")
    @Validation(pattern = "", maxLength = 0)
    public String nextMarker;

}

