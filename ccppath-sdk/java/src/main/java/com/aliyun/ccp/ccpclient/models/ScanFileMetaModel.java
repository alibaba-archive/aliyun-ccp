// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ScanFileMetaModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPScanFileMetaResponse body;

    public static ScanFileMetaModel build(java.util.Map<String, ?> map) throws Exception {
        ScanFileMetaModel self = new ScanFileMetaModel();
        return TeaModel.build(map, self);
    }

}
