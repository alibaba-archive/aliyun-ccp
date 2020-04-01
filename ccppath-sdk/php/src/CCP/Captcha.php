<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class Captcha extends Model
{
    public $captcha;
    public $captchaFormat;
    public $captchaId;
    protected $_required = [
        'captcha'       => true,
        'captchaFormat' => true,
        'captchaId'     => true,
    ];
    protected $_name = [
        'captcha'       => 'captcha',
        'captchaFormat' => 'captcha_format',
        'captchaId'     => 'captcha_id',
    ];
    protected $_description = [
        'captcha'       => '图片验证码，base64格式',
        'captchaFormat' => '图片格式',
        'captchaId'     => '图片验证码ID',
    ];
    protected $_example = [
        'captcha'       => 'iVBORw0KGgoAAAANSUhEUgAAAFAAAAAaCAIAAACvsEzwAAABRElEQVR42t3YsQ4CIQwA0CZ+i36Bg5uTo1/gqquDTvf1JwkJqRR7vZYCJ2HClOMBVw5h/i7P9yvU+X8LFFsju728wRNhcQR+gyj27G2GtQGHxy5USaN6PV1n2Qt8Ou6ZKllPJ/MQ4PN0CzXrs9i4jS2dIelKMuBse18vd1zdweHZdnC2V3kwDsm0OnYHMDVLtnQICbZ0XuIpqAamaaMjmGbvOAV0Fmqew7XAmXlV0kqButcYhDs5PqYiGA9dDm6atCK7bpbGx5Jknxszlj5pYR5t8QMX8b5gLMSVCZGfw4svdtHsDqZmPooHJxte5NTCnx3twKvKIhgLcaXrSbP0iGBhIK/99aXlnrQst1/7BajDt7Txxl/rrqvuBOaGJY3Szt4GOBuoka2LhQYw/ic1eyww/5eV95x229IDmqHlS1vdrOjkA5iK2BYUhM2zAAAAAElFTkSuQmCC',
        'captchaFormat' => 'png',
        'captchaId'     => 'f4690fc255e2fb24c10ede079d3802b4cClRimRh67Q',
    ];
}
