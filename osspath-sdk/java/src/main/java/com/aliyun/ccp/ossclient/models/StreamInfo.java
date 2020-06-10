// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class StreamInfo extends TeaModel {
    @NameInMap("crc64_hash")
    public String crc64Hash;

    @NameInMap("download_url")
    public String downloadUrl;

    @NameInMap("thumbnail")
    public String thumbnail;

    @NameInMap("url")
    public String url;

    public static StreamInfo build(java.util.Map<String, ?> map) throws Exception {
        StreamInfo self = new StreamInfo();
        return TeaModel.build(map, self);
    }

}
