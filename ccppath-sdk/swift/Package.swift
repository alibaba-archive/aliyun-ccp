// swift-tools-version:5.1
// The swift-tools-version declares the minimum version of Swift required to build this package.

import PackageDescription

let package = Package(
    name: "AliyunCCPSDK",
    products: [
        .library(
            name: "AliyunCCPSDK",
            targets: ["AliyunCCPSDK"])
    ],
    dependencies: [
        .package(url: "https://github.com/aliyun/tea-swift.git", from: "0.1.1"),
        .package(url: "https://github.com/krzyzanowskim/CryptoSwift.git", from: "1.3.0")
    ],
    targets: [
        .target(
            name: "AliyunCCPSDK",
            dependencies: ["Tea", "CryptoSwift"]),
        .testTarget(
            name: "AliyunCCPSDKTests",
            dependencies: ["AliyunCCPSDK", "Tea", "CryptoSwift"])
    ]
)
