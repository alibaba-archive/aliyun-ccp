<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class VideoMediaResponse extends Model
{
    /**
     * @description address_line
     *
     * @example 北京市昌平区白各庄新村路
     *
     * @var string
     */
    public $addressLine;
    /**
     * @description city
     *
     * @example 杭州
     *
     * @var string
     */
    public $city;
    /**
     * @description country
     *
     * @example 中国
     *
     * @var string
     */
    public $country;
    /**
     * @description district
     *
     * @example 余杭区
     *
     * @var string
     */
    public $district;
    /**
     * @description duration 单位 秒
     *
     * @example "7704.573000"
     *
     * @var string
     */
    public $duration;
    /**
     * @description location
     *
     * @example 40.110333,116.349311
     *
     * @var string
     */
    public $location;
    /**
     * @description province
     *
     * @example 浙江省
     *
     * @var string
     */
    public $province;
    /**
     * @description time
     *
     * @var string
     */
    public $time;
    /**
     * @description township
     *
     * @example 沙河镇
     *
     * @var string
     */
    public $township;
    protected $_name = [
        'addressLine' => 'address_line',
        'city'        => 'city',
        'country'     => 'country',
        'district'    => 'district',
        'duration'    => 'duration',
        'location'    => 'location',
        'province'    => 'province',
        'time'        => 'time',
        'township'    => 'township',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                 = [];
        $res['address_line'] = $this->addressLine;
        $res['city']         = $this->city;
        $res['country']      = $this->country;
        $res['district']     = $this->district;
        $res['duration']     = $this->duration;
        $res['location']     = $this->location;
        $res['province']     = $this->province;
        $res['time']         = $this->time;
        $res['township']     = $this->township;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VideoMediaResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address_line'])) {
            $model->addressLine = $map['address_line'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['country'])) {
            $model->country = $map['country'];
        }
        if (isset($map['district'])) {
            $model->district = $map['district'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['township'])) {
            $model->township = $map['township'];
        }

        return $model;
    }
}
