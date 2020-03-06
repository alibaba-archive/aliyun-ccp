// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取云照片个数结果
 */
public class GetImageCountResponse extends TeaModel {
    @NameInMap("image_count")
    public Long imageCount;

    public static GetImageCountResponse build(java.util.Map<String, ?> map) throws Exception {
        GetImageCountResponse self = new GetImageCountResponse();
        return TeaModel.build(map, self);
    }

}
