//
// Created by Axios on 2020/2/19.
//

import Foundation
import Tea
import CryptoSwift

open class BaseClient {
    var sdkVersion = "0.0.1";

    var accessKeyId: String = "";
    var accessKeySecret: String = "";
    var accessToken: String = "";
    var _userAgent: String = "";

    var _protocol: String = "https";
    var _endpoint: String = "";
    var _domainId: String = "";
    var _nickname: String = "";
    var config: [String: Any];

    static var _defaultUserAgent: String = "";

    init(_ config: [String: Any]) {
        self._domainId = config["domainId"] as! String;
        self._protocol = config["protocol_"] as! String;
        self._endpoint = config["endpoint"] as! String;
        self._nickname = config["nickname"] as! String;
        self.accessKeyId = config["accessKeyId"] as! String;
        self.accessKeySecret = config["accessKeySecret"] as! String;
        self.config = config;
    }

    private func _getDefaultUserAgent() -> String {
        if BaseClient._defaultUserAgent.count > 0 {
            return BaseClient._defaultUserAgent;
        }
        let os = ProcessInfo().operatingSystemVersion;
        let OSVersion: String = String(os.majorVersion) + "." + String(os.minorVersion) + "." + String(os.patchVersion);
        BaseClient._defaultUserAgent = "Alibaba Cloud (" + OSVersion + ") ";
        BaseClient._defaultUserAgent += " Tea-iOS-SDK/" + self.sdkVersion;
        return BaseClient._defaultUserAgent;
    }

    public func _getPathname(_ nickname: String, _ path: String) -> String {
        if (nickname.isEmpty) {
            return path;
        }
        return "/" + nickname + path;
    }

    public func _getUserAgent() -> String {
        if !self._userAgent.isEmpty {
            return self._getDefaultUserAgent() + " " + self._userAgent;
        }
        return self._getDefaultUserAgent();
    }

    public func _default(_ str: String, _ defaultStr: String) -> String {
        if str.isEmpty {
            return defaultStr;
        }
        return str;
    }

    public func _notEmpty(_ s: Any?) -> Bool {
        if s == nil {
            return false
        } else if s as? Int == 0 {
            return false
        }
        let str: String = s as! String;
        return str.count > 0 ? true : false;
    }

    public func _toJSONString(_ dict: [TeaModel]) -> String {
        var dic: [[String: Any]] = [[String: Any]]();
        for model in dict {
            dic.append(model.toMap());
        }
        guard let data = try? JSONSerialization.data(withJSONObject: dic, options: []) else {
            return "";
        }
        let json = String(data: data, encoding: String.Encoding.utf8)!;
        return json;
    }

    public func _defaultNumber(_ number: CLong, _ defaultNumber: CLong) -> CLong {
        if number > 0 {
            return number;
        }
        return defaultNumber;
    }

    public func _readAsJSON(_ response: TeaResponse) -> [String: AnyObject] {
        guard let data = try? JSONSerialization.jsonObject(with: response.data, options: .mutableContainers) as? [String: AnyObject] else {
            return [String: AnyObject]();
        }
        return data
    }

    public func _getAccessKeyId() -> String {
        return self.accessKeyId;
    }

    public func _getAccessKeySecret() -> String {
        return self.accessKeySecret;
    }

    public func _getAccessToken() -> String {
        return self.accessToken;
    }

    public func _getProtocol(_ protocol: String, _ defaultProtocol: String) -> String {
        if self._protocol.isEmpty {
            return defaultProtocol;
        }
        return self._protocol;
    }

    public func _getRFC2616Date() -> String {
        let curr = Date();
        let formatter = DateFormatter();
        formatter.locale = Locale(identifier: "en_US");
        formatter.timeZone = TimeZone(identifier: "GMT");
        formatter.dateFormat = "EEE, dd MMM yyyy HH:mm:ss";
        return formatter.string(from: curr) + " GMT";
    }

    public func _getHost(_ endpoint: String, _ domain: String) -> String {
        if self._endpoint.isEmpty {
            return domain;
        }
        return self._endpoint;
    }

    public func _getSignature(_ request: TeaRequest) -> String {
        let stringToSign: String = self._getStringToSign(request)
        let r = try! HMAC(key: self.accessKeySecret, variant: .sha1).authenticate(stringToSign.bytes)
        return r.toBase64() ?? "";
    }

    public func _getStringToSign(_ request: TeaRequest) -> String {
        let method: String = request.method;
        let pathname: String = request.pathname;
        let headers: [String: String] = request.headers;
        let query: [String: Any] = request.query;

        let accept = headers["accept"] ?? "";
        let contentMD5 = headers["content-md5"] ?? "";
        let contentType = headers["content-type"] ?? "";
        let date = headers["date"] ?? "";

        let headerStr = String(method) + "\n" + String(accept) + "\n" + String(contentMD5) + "\n" + String(contentType) + "\n" + String(date);
        let canonicalizedHeaders: String = self.getCanonicalizedHeaders(headers: headers);
        let canonicalizedResource: String = getCanonicalizedResource(pathname: pathname, query: query);
        return headerStr + "\n" + canonicalizedHeaders + "\n" + canonicalizedResource;
    }

    public func getCanonicalizedHeaders(headers: [String: String]) -> String {
        let prefix: String = "x-acs-";
        var canonicalizedKeys: [String] = [String]();
        for (key, _) in headers {
            if (key.hasPrefix(prefix)) {
                canonicalizedKeys.append(key);
            }
        }
        canonicalizedKeys.sort();
        var result: String = "";
        var n = 0;
        for key in canonicalizedKeys {
            if n != 0 {
                result.append(contentsOf: "\n");
            }
            result.append(contentsOf: key);
            result.append(contentsOf: ":");
            result.append(contentsOf: headers[key]?.trimmingCharacters(in: .whitespacesAndNewlines) ?? "");
            n += 1;
        }
        return result;
    }

    public func getCanonicalizedResource(pathname: String, query: [String: Any]) -> String {
        if (query.count <= 0) {
            return pathname;
        }
        var keys: [String] = [String]();
        for (key, _) in query {
            keys.append(key);
        }
        keys.sort();
        var result: String = pathname + "?";
        for key in keys {
            result.append(key);
            result.append("=");
            result.append(query[key] as! String);
        }
        return result;
    }

    public func _isStatusCode(_ response: TeaResponse?, _ status: Int) -> Bool {
        return Int(response?.statusCode ?? "") == status;
    }
}