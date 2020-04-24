// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 转码接口response
 */
public class OSSVideoTranscodeResponse extends TeaModel {
    @NameInMap("definition_list")
    public java.util.List<String> definitionList;

    @NameInMap("duration")
    public Long duration;

    @NameInMap("hls_time")
    public Long hlsTime;

    public static OSSVideoTranscodeResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoTranscodeResponse self = new OSSVideoTranscodeResponse();
        return TeaModel.build(map, self);
    }

}
