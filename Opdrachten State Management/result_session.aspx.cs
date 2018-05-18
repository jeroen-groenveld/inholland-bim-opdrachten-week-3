using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdrachten_State_Management
{
    #region "opdracht 10"
    public partial class result_session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Kijk of de variable wel bestaat in de sessie
            if(Session["txt_input"] != null)
            {
                this.lbl_result.Text = (string)Session["txt_input"];
            }
        }
    }
    #endregion
}