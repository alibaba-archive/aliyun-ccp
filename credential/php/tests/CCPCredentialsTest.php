<?php

namespace Aliyun\CCP\Credentials\Tests;

use Aliyun\CCP\Credentials\CCPCredentials;
use Aliyun\CCP\Credentials\CCPCredentials\Config;
use GuzzleHttp\Handler\MockHandler;
use GuzzleHttp\HandlerStack;
use GuzzleHttp\Psr7\Response;
use GuzzleHttp\Psr7\Stream;
use PHPUnit\Framework\TestCase;

/**
 * @internal
 * @coversNothing
 */
class CCPCredentialsTest extends TestCase
{
    public function testConstruct()
    {
        $config               = new Config();
        $config->refreshToken = 'refreshToken';
        $config->accessToken  = 'accessToken';
        $config->expireTime   = '4000-01-01T12:12:12Z';

        $credentials = new CCPCredentials($config);
        $this->assertEquals('refreshToken', $credentials->getRefreshToken());
        $this->assertEquals('accessToken', $credentials->getAccessToken());
        $this->assertEquals('4000-01-01T12:12:12Z', $credentials->getExpireTime());
    }

    public function testGetSet()
    {
        $credentials = new CCPCredentials(new Config());

        $credentials->setAccessToken('test');
        $this->assertEquals('test', $credentials->getAccessToken());

        $credentials->setRefreshToken('token');
        $this->assertEquals('token', $credentials->getRefreshToken());

        $credentials->setExpireTime('1');
        $this->assertEquals('1', $credentials->getExpireTime());

        // throw exception when accessToken is null
        $credentials = new CCPCredentials(new Config());
        $this->expectException(\RuntimeException::class);
        $this->expectExceptionMessage('AccessToken is null');

        $credentials->getAccessToken();
    }

    public function testShouldRefresh()
    {
        $config      = new Config();
        $credentials = new CCPCredentials($config);
        $this->assertFalse($credentials->shouldRefresh(1000));

        $config->expireTime = '2000-01-01T12:12:12Z';
        $credentials        = new CCPCredentials($config);
        $this->assertFalse($credentials->shouldRefresh(1000));

        $config->refreshToken = 'test';
        $credentials          = new CCPCredentials($config);
        $this->assertTrue($credentials->shouldRefresh(1572509376182));
    }

    public function testRefreshAccessToken()
    {
        $newExpireTime = gmdate('Y-m-d\\TH:i:s\\Z', time() + 1000);
        $stream        = new Stream(
            fopen('data://text/plain;base64,' .
                base64_encode(\GuzzleHttp\json_encode([
                    'expire_time'   => $newExpireTime,
                    'access_token'  => 'NewAccessToken',
                    'refresh_token' => 'NewRefreshToken',
                ])), 'r+')
        );
        $stream->rewind();
        $mock                    = new MockHandler([new Response(200, ['X-Foo' => 'Bar'], $stream)]);
        $handlerStack            = HandlerStack::create($mock);
        $config                  = new Config();
        $config->accessToken     = 'initAccessToken';
        $config->refreshToken    = 'initRefreshToken';
        $config->clientId        = '12345';
        $config->expireTime      = gmdate('Y-m-d\\TH:i:s\\Z', time() - 1000); // had expired
        $credentials             = new CCPCredentials($config);
        $credentials->httpConfig = [
            'handler' => $handlerStack,
        ];

        $this->assertTrue($credentials->shouldRefresh(time()));

        $this->assertEquals($config->expireTime, $credentials->getExpireTime());
        $this->assertEquals('NewAccessToken', $credentials->getAccessToken());
        $this->assertEquals($newExpireTime, $credentials->getExpireTime());
    }
}
