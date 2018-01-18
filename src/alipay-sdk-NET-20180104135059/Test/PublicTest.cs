using System;
using System.Collections.Generic;
using System.Text;
using Aop.Api.Util;
using Aop.Api.Request;
using Aop.Api.Response;
using Jayrock.Json;

namespace Aop.Api.Test
{
    class PublicTest
    {
        [STAThread]
        //static void Main()
        //{
        //    // ���ںŲ˵���ѯ
        //    //MenuGet();

        //    // ���ں�֪ͨ��Ϣǩ����֤
        //    //CheckSign();

        //    // ���ں���ǩ&����
        //    CheckSignAndDecrypt();

        //    // ���ںż���&��ǩ
        //    EncryptAndSign();
        //}

        private static void CheckSign()
        {
            IDictionary<string, string> paramsMap = new Dictionary<string, string>();
            paramsMap.Add("appId", "2013092500031084");
            string privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
            string sign = AlipaySignature.RSASign(paramsMap, privateKeyPem, null,"RSA");
            paramsMap.Add("sign", sign);
            string publicKey = GetCurrentPath() + "public-key.pem";
            bool checkSign = AlipaySignature.RSACheckV2(paramsMap, publicKey);
            System.Console.Write("---------���ں�֪ͨ��Ϣǩ����֤--------" + "\n\r");
            System.Console.Write("checkSign:" + checkSign + "\n\r");
        }

        private static void MenuGet()
        {
            IAopClient client = GetAlipayClient();
            //AlipayMobilePublicMenuGetRequest req = new AlipayMobilePublicMenuGetRequest();
            //AlipayMobilePublicMenuGetResponse res = client.Execute(req);
            System.Console.Write("-------------���ںŲ˵���ѯ-------------" + "\n\r");
           // System.Console.Write("Body:" + res.Body + "\n\r");
        }

        private static IAopClient GetAlipayClient()
        {
            //֧�������ص�ַ
            // -----ɳ���ַ-----
            string serverUrl = "http://openapi.alipaydev.com/gateway.do";
            // -----���ϵ�ַ-----
            // string serverUrl = "https://openapi.alipay.com/gateway.do";
            //Ӧ��ID
            string appId = "2013092500031084";
            //�̻�˽Կ
            string privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";

            IAopClient client = new DefaultAopClient(serverUrl, appId, privateKeyPem);

            return client;
        }

        private static string GetCurrentPath()
        {
            string basePath = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            return basePath + "/Test/";
        }

        public static void CheckSignAndDecrypt()
        {
            // ��������
            string charset = "UTF-8";
            string bizContent = "<XML><AppId><![CDATA[2013082200024893]]></AppId><FromUserId><![CDATA[2088102122485786]]></FromUserId><CreateTime>1377228401913</CreateTime><MsgType><![CDATA[click]]></MsgType><EventType><![CDATA[event]]></EventType><ActionParam><![CDATA[authentication]]></ActionParam><AgreementId><![CDATA[201308220000000994]]></AgreementId><AccountNo><![CDATA[null]]></AccountNo><UserInfo><![CDATA[{\"logon_id\":\"15858179811\",\"user_name\":\"����\"}]]></UserInfo></XML>";
            string publicKeyPem = GetCurrentPath() + "public-key.pem";
            string privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
            IDictionary<string, string> paramsMap = new Dictionary<string, string>();
            paramsMap.Add("biz_content", AlipaySignature.RSAEncrypt(bizContent, publicKeyPem, charset));
            paramsMap.Add("charset", charset);
            paramsMap.Add("service", "alipay.mobile.public.message.notify");
            paramsMap.Add("sign_type", "RSA");
            paramsMap.Add("sign", AlipaySignature.RSASign(paramsMap, privateKeyPem,null,"RSA"));

            // ��ǩ&����
            string resultContent = AlipaySignature.CheckSignAndDecrypt(paramsMap, publicKeyPem, privateKeyPem, true, true);
            System.Console.Write("resultContent=" + resultContent+ "\n\r");
        }

        public static void EncryptAndSign()
        {
            // ��������
            string bizContent = "<XML><ToUserId><![CDATA[2088102122494786]]></ToUserId><AppId><![CDATA[2013111100036093]]></AppId><AgreementId><![CDATA[20131111000001895078]]></AgreementId>"
                            + "<CreateTime>12334349884</CreateTime>"
                            + "<MsgType><![CDATA[image-text]]></MsgType>"
                            + "<ArticleCount>1</ArticleCount>"
                            + "<Articles>"
                            + "<Item>"
                            + "<Title><![CDATA[[�ظ����Լ��ܽ���]]></Title>"
                            + "<Desc><![CDATA[���Լ��ܽ���]]></Desc>"
                            + "<Url><![CDATA[http://m.taobao.com]]></Url>"
                            + "<ActionName><![CDATA[����ǰ��]]></ActionName>"
                            + "</Item>"
                            + "</Articles>" + "<Push><![CDATA[false]]></Push>" + "</XML>";
            string publicKeyPem = GetCurrentPath() + "public-key.pem";
            string privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
            string responseContent = AlipaySignature.encryptAndSign(bizContent, publicKeyPem, privateKeyPem,"UTF-8",true,true);
            System.Console.Write("resultContent=" + responseContent + "\n\r");
        }
    }

}
