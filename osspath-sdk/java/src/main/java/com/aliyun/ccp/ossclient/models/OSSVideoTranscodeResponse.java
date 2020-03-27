// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 转码接口response
 */
public class OSSVideoTranscodeResponse extends TeaModel {
    @NameInMap("hls_time")
    public Long hlsTime;

    @NameInMap("resolution_list")
    public java.util.List<String> resolutionList;

    public static OSSVideoTranscodeResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoTranscodeResponse self = new OSSVideoTranscodeResponse();
        return TeaModel.build(map, self);
    }

}
