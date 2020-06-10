// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class ImageMediaMetadata extends TeaModel {
    @NameInMap("height")
    public Long height;

    @NameInMap("width")
    public Long width;

    public static ImageMediaMetadata build(java.util.Map<String, ?> map) throws Exception {
        ImageMediaMetadata self = new ImageMediaMetadata();
        return TeaModel.build(map, self);
    }

}
