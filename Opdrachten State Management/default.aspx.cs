using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdrachten_State_Management
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["viewIndex"] != null && IsPostBack == false)
            {
                int viewIndex = int.Parse(Request.Cookies["viewIndex"].Value);
                this.MultiView1.ActiveViewIndex = viewIndex;
                this.DropDownList1.SelectedIndex = viewIndex;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MultiView1.ActiveViewIndex = this.DropDownList1.SelectedIndex;

            HttpCookie viewIndex = new HttpCookie("viewIndex");
            viewIndex.Value = this.DropDownList1.SelectedIndex.ToString();
            viewIndex.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(viewIndex);
        }

        protected void btn_QueryString_Click(object sender, EventArgs e)
        {
            //Check of de textbox wel text bevat
            if(string.IsNullOrEmpty(this.txt_Input.Text) == false)
            {
                //Haal de spaties uit de text en vervangd ze met een laag streepje.
                string input = this.txt_Input.Text.Trim().Replace(' ', '_');

                //Navigeer naar de "result_querystring.aspx" pagina met de input als query string.
                Response.Redirect("result_querystring.aspx?txt_input=" + input);
            }
        }

        protected void btn_Cookie_Click(object sender, EventArgs e)
        {
            //Maak cookie en geef hem mee aan de response.
            HttpCookie cookie = new HttpCookie("txt_input");
            cookie.Value = this.txt_Input.Text;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);

            //Navigeer naar de "result_cookie.aspx" pagina.
            Response.Redirect("result_cookie.aspx");
        }

        protected void btn_Session_Click(object sender, EventArgs e)
        {
            //Maak de variable aan in de huide sessie
            Session["txt_input"] = this.txt_Input.Text;

            //Navigeer naar de "result_session.aspx" pagina.
            Response.Redirect("result_session.aspx");
        }
    }
}