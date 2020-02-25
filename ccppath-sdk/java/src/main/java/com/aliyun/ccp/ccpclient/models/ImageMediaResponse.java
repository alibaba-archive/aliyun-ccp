// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ImageMediaResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("height")
    public Long height;

    @NameInMap("time")
    public String time;

    @NameInMap("width")
    public Long width;

    public static ImageMediaResponse build(java.util.Map<String, ?> map) throws Exception {
        ImageMediaResponse self = new ImageMediaResponse();
        return TeaModel.build(map, self);
    }

}
