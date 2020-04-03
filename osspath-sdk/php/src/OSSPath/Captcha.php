<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class Captcha extends Model
{
    /**
     * @description 图片验证码，base64格式
     *
     * @example iVBORw0KGgoAAAANSUhEUgAAAFAAAAAaCAIAAACvsEzwAAABRElEQVR42t3YsQ4CIQwA0CZ+i36Bg5uTo1/gqquDTvf1JwkJqRR7vZYCJ2HClOMBVw5h/i7P9yvU+X8LFFsju728wRNhcQR+gyj27G2GtQGHxy5USaN6PV1n2Qt8Ou6ZKllPJ/MQ4PN0CzXrs9i4jS2dIelKMuBse18vd1zdweHZdnC2V3kwDsm0OnYHMDVLtnQICbZ0XuIpqAamaaMjmGbvOAV0Fmqew7XAmXlV0kqButcYhDs5PqYiGA9dDm6atCK7bpbGx5Jknxszlj5pYR5t8QMX8b5gLMSVCZGfw4svdtHsDqZmPooHJxte5NTCnx3twKvKIhgLcaXrSbP0iGBhIK/99aXlnrQst1/7BajDt7Txxl/rrqvuBOaGJY3Szt4GOBuoka2LhQYw/ic1eyww/5eV95x229IDmqHlS1vdrOjkA5iK2BYUhM2zAAAAAElFTkSuQmCC
     *
     * @var string
     */
    public $captcha;
    /**
     * @description 图片格式
     *
     * @example png
     *
     * @var string
     */
    public $captchaFormat;
    /**
     * @description 图片验证码ID
     *
     * @example f4690fc255e2fb24c10ede079d3802b4cClRimRh67Q
     *
     * @var string
     */
    public $captchaId;
    protected $_name = [
        'captcha'       => 'captcha',
        'captchaFormat' => 'captcha_format',
        'captchaId'     => 'captcha_id',
    ];

    public function validate()
    {
        Model::validateRequired('captcha', $this->captcha, true);
        Model::validateRequired('captchaFormat', $this->captchaFormat, true);
        Model::validateRequired('captchaId', $this->captchaId, true);
    }

    public function toMap()
    {
        $res                   = [];
        $res['captcha']        = $this->captcha;
        $res['captcha_format'] = $this->captchaFormat;
        $res['captcha_id']     = $this->captchaId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return Captcha
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['captcha'])) {
            $model->captcha = $map['captcha'];
        }
        if (isset($map['captcha_format'])) {
            $model->captchaFormat = $map['captcha_format'];
        }
        if (isset($map['captcha_id'])) {
            $model->captchaId = $map['captcha_id'];
        }

        return $model;
    }
}
