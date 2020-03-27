// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 转码接口response
 */
public class OSSVideoResolutionResponse extends TeaModel {
    @NameInMap("resolution_list")
    public java.util.List<String> resolutionList;

    public static OSSVideoResolutionResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoResolutionResponse self = new OSSVideoResolutionResponse();
        return TeaModel.build(map, self);
    }

}
