// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class Captcha extends TeaModel {
    @NameInMap("captcha")
    @Validation(required = true)
    public String captcha;

    @NameInMap("captcha_format")
    @Validation(required = true)
    public String captchaFormat;

    @NameInMap("captcha_id")
    @Validation(required = true)
    public String captchaId;

    public static Captcha build(java.util.Map<String, ?> map) throws Exception {
        Captcha self = new Captcha();
        return TeaModel.build(map, self);
    }

}
