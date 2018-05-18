using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdrachten_State_Management
{
    public partial class result_postbackurl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check of the PreviousPage object wel bestaat
            if (PreviousPage != null)
            {
                TextBox input = (TextBox)PreviousPage.FindControl("txt_Input");

                //Check of the Textbox "txt_Input" van de vorige pagina("default.aspx") wel bestaat.
                if (input != null)
                {
                    this.lbl_result.Text = input.Text;
                }
                else
                {
                    this.lbl_result.Text = "Kan de Textbox \"txt_Input\" niet vinden in het PreviousPage object.";
                }

            }
            else
            {
                this.lbl_result.Text = "Het PreviousPage object bestaat niet.";
            }
        }
    }
}