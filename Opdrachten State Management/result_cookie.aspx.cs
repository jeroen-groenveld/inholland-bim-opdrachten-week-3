using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdrachten_State_Management
{
    #region "Opdrahct 9"
    public partial class result_cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check of het cookie wel bestaat
            if(Request.Cookies["txt_input"] != null)
            {
                this.lbl_result.Text = Request.Cookies["txt_input"].Value;
            }
        }
    }
    #endregion
}