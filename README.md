# AlipayAsyncNotify
支付宝新版支付支付后的异步回调，对应 面对面扫码支付、App支付、手机网站支付、PC支付

## 解决方案构成说明
`AopSdk`为支付宝提供的Net版服务端Sdk,下载地址为： https://docs.open.alipay.com/54/103419/  
`AlipayAsyncNotify`为支付的异步回调辅助类  
`AlipayAsyncNotifyWeb`为支付异步回调项目例子，包含MVC及WebApi的接入例子

### 修改及测试说明
要想正确运行Web项目，需先修改配置信息，具体位置如下：`AlipayAsyncNotifyWeb\Utils\NotifyHelper`，修改文件内的第14、15行，如是沙箱测试，则还需修改第16行的验证地址
```csharp
public static string AppId = "你的AppId";
public static string AlipayPublicKey = "你的支付宝公钥";
public static string MapiUrl = "https://mapi.alipay.com/gateway.do";
```
修改完成后，可以在VS中调试  
以 http://localhost:52192/AlipayMvcNotify/Notify 测试MVC下的支付宝异步通知  
以 http://localhost:52192/api/AlipayWebApiNotify 测试WebApi下的支付宝异步通知  
PS:端口号请自行修改 
