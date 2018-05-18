using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdrachten_State_Management
{
    #region "Opdracht 8"
    public partial class result_querystring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Haal de text uit de QueryString.
            string input = Request.QueryString["txt_input"];

            //Check of de QueryString wel text bevat.
            if(string.IsNullOrEmpty(input) == false)
            {
                this.lbl_result.Text = input;
            }
        }
    }
    #endregion
}