
            �q�����������������������������������������������r
    ����������           ֧��������ʾ���ṹ˵��             ����������
            �t�����������������������������������������������s 
��                                                                  
	 Visual studio �汾��2010
	 Framework3.5���ϰ汾
         ��    Ȩ��֧�������й������缼�����޹�˾

������������������
 1����Ҫ���ļ�����˵��
������������������
��������������������������������������������������������������
DefaultAopClient.cs

public DefaultAopClient(string serverUrl, string appId, string privateKeyPem)
���ܣ����췽��
���룺serverUrl �ǿգ������������ַ�����ԣ�http://openapi.alipaydev.com/gateway.do ���ϣ�https://openapi.alipay.com/gateway.do ��
      appId �ǿգ�Ӧ��ID
      privateKeyPem �ǿգ�˽Կ
��������ÿͻ���ʵ������


public T Execute<T>(IAopRequest<T> request) where T : AopResponse
���ܣ�ִ��������ã������ڲ���Ҫ��Ȩ�ӿڵ��ã�
���룺request �ӿ��������
�����T ���󷵻ض���

public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
���ܣ�ִ��������ã���������Ҫ��Ȩ�ӿڵ��ã�
���룺request �ӿ��������
      accessToken ��Ȩ����
�����T ���󷵻ض���

������������������
 2������ʾ��
������������������
��������������������������������������������������������������
��ο��� Aop.Api.Test.PublicTest.cs

��������������������������������������������������������������

������������������
 3��ǩ�������
������������������
��������������������������������������������������������������

Aop.Api.Util.AlipaySignature.cs

public static string RSASign(IDictionary<string, string> parameters, string privateKeyPem)
���ܣ�RSAǩ��
���룺parameters ��ǩ������map
      privateKeyPem ˽Կ
�����ǩ�����

public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem)
���ܣ�RSA��ǩ
���룺parameters ǩ����������map
      publicKeyPem ��Կ
�������ǩ���

public static bool RSACheckContent(string signContent, string sign, string publicKeyPem)
���ܣ�RSA��ǩ
���룺signContent ǩ�����������ַ���
      sign ǩ��
      publicKeyPem ��Կ
�������ǩ���

��������������������������������������������������������������