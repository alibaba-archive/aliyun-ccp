// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileSendSmsCodeRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("captcha_id")
    public String captchaId;

    @NameInMap("captcha_text")
    public String captchaText;

    @NameInMap("phone_number")
    @Validation(required = true)
    public String phoneNumber;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

}
