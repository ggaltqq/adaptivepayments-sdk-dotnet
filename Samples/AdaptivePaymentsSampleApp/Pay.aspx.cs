using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace AdaptivePaymentsSampleApp
{
    public partial class Pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            string currentPath = System.Web.HttpContext.Current.Request.Url.OriginalString;
            this.returnUrl.Value = currentPath;
            this.cancelUrl.Value = currentPath;
        }
    }
}
