// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class ImageTagResponse extends TeaModel {
    @NameInMap("count")
    public Long count;

    @NameInMap("cover_url")
    public String coverUrl;

    @NameInMap("name")
    public String name;

    public static ImageTagResponse build(java.util.Map<String, ?> map) throws Exception {
        ImageTagResponse self = new ImageTagResponse();
        return TeaModel.build(map, self);
    }

}
