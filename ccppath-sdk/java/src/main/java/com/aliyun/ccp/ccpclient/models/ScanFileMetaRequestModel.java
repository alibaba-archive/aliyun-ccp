// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ScanFileMetaRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPScanFileMetaRequest body;

    public static ScanFileMetaRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ScanFileMetaRequestModel self = new ScanFileMetaRequestModel();
        return TeaModel.build(map, self);
    }

}
