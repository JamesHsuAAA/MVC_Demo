using System;
using System.Web;

namespace MVC_Demo.Models
{
    public class MyModule1 : IHttpModule
    {
        /// <summary>
        /// 您將需要在您 Web 的 Web.config 檔中設定此模組，
        /// 並且向 IIS 註冊該處理程式，才能使用它。如需詳細資訊，
        /// 請參閱下列連結: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //清理程式碼在這裡。
        }

        public void Init(HttpApplication context)
        {
            // 以下是您能夠如何處理 LogRequest 事件的範例，並提供
            // 它的自訂記錄實作
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //自動記錄邏輯在這裡
        }
    }
}
