// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class UrlInfo extends TeaModel {
    @NameInMap("download_url")
    public String downloadUrl;

    @NameInMap("thumbnail")
    public String thumbnail;

    @NameInMap("url")
    public String url;

    public static UrlInfo build(java.util.Map<String, ?> map) throws Exception {
        UrlInfo self = new UrlInfo();
        return TeaModel.build(map, self);
    }

}
