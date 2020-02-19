import Foundation
import XCTest
import AlamofirePromiseKit
import Alamofire
import AwaitKit
import Tea
@testable import AliyunCCPSDK

final class AlibabaCloudCommonsTests: XCTestCase {

   func testLiveDrives() {
       let config = Config()
       config.domainId = "sz16"
       config.protocol_ = "http"
       config.accessKeyId = ProcessInfo.processInfo.environment["ACCESS_KEY_ID"] ?? ""
       config.accessKeySecret = ProcessInfo.processInfo.environment["ACCESS_KEY_SECRET"] ?? ""
       let request = ListDriveRequestModel()
       request.owner = "123"
       let client = Client(config: config)
       let runtime = RuntimeOptions()
       runtime.connectTimeout = 10000
       runtime.readTimeout = 10000
       XCTAssertThrowsError(try client.listDrives(request: request, runtime: runtime)) { error in
           let err = error as! TeaException
           switch err {
           case .Error(_):
               XCTAssertTrue(false)
           case .Unretryable(let request):
               XCTAssertEqual("sz16.api.alicloudccp.com", request?.headers["host"])
           case .ValidateError(_):
               XCTAssertTrue(false)
           }
       }
   }

    static var allTests = [
        ("test", test)
    ]
}
