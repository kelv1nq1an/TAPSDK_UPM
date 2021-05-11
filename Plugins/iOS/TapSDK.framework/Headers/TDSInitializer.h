//
//  TDSInitializer.h
//  TapSDK
//
//  Created by Insomnia on 2020/12/1.
//

#import <Foundation/Foundation.h>
#import <TapSDK/TDSConfig.h>

NS_ASSUME_NONNULL_BEGIN

@interface TDSInitializer : NSObject

+ (instancetype)new NS_UNAVAILABLE;
- (instancetype)init NS_UNAVAILABLE;

+ (instancetype)shareInstance;

/// 统一初始化
/// @param config 配置项
+ (void)initWithConfig:(TDSConfig *)config;

/// 开启TapDB,默认关闭 IDFA 收集
/// @param channel 分包渠道名称，可为空
/// @param gameVersion 游戏版本，可为空，为空时，自动获取游戏安装包的版本（Xcode配置中的Version）
+ (void)enableTapDBWithChannel:(nullable NSString *)channel gameVersion:(nullable NSString *)gameVersion;


/// 开启TapDB
/// @param channel 分包渠道名称，可为空
/// @param gameVersion 游戏版本，可为空，为空时，自动获取游戏安装包的版本（Xcode配置中的Version）
/// @param enable 是否开启 IDFA 收集
+ (void)enableTapDBWithChannel:(nullable NSString *)channel gameVersion:(nullable NSString *)gameVersion enableAdvertiserIDCollection:(BOOL)enable;

/// 开启动态
+ (void)enableMoment;

@end

NS_ASSUME_NONNULL_END
