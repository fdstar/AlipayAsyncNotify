using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.version.audit.apply
    /// </summary>
    public class AlipayOpenMiniVersionAuditApplyRequest : IAopUploadRequest<AlipayOpenMiniVersionAuditApplyResponse>
    {
        /// <summary>
        /// 小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FifthScreenShot { get; set; }

        /// <summary>
        /// 小程序第一张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FirstScreenShot { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FourthScreenShot { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 小程序服务区域类型，GLOBLE-全球，CHINA-中国，LOCATION-指定区域
        /// </summary>
        public string RegionType { get; set; }

        /// <summary>
        /// 小程序第二张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem SecondScreenShot { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        public string ServicePhone { get; set; }

        /// <summary>
        /// 省市区信息，当区域类型为LOCATION时，不能为空，province_code不能为空，当填写city_code时，province_code不能为空，当填写area_code时，province_code和city_code不能为空
        /// </summary>
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 小程序第三张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem ThirdScreenShot { get; set; }

        /// <summary>
        /// 小程序版本描述
        /// </summary>
        public string VersionDesc { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

    	 public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

		public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.mini.version.audit.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("app_category_ids", this.AppCategoryIds);
            parameters.Add("app_desc", this.AppDesc);
            parameters.Add("app_english_name", this.AppEnglishName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_slogan", this.AppSlogan);
            parameters.Add("app_version", this.AppVersion);
            parameters.Add("memo", this.Memo);
            parameters.Add("region_type", this.RegionType);
            parameters.Add("service_email", this.ServiceEmail);
            parameters.Add("service_phone", this.ServicePhone);
            parameters.Add("service_region_info", this.ServiceRegionInfo);
            parameters.Add("version_desc", this.VersionDesc);
            return parameters;
        }
		
		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("app_logo", this.AppLogo);
            parameters.Add("fifth_screen_shot", this.FifthScreenShot);
            parameters.Add("first_screen_shot", this.FirstScreenShot);
            parameters.Add("fourth_screen_shot", this.FourthScreenShot);
            parameters.Add("second_screen_shot", this.SecondScreenShot);
            parameters.Add("third_screen_shot", this.ThirdScreenShot);
            return parameters;
        }

        #endregion
    }
}
