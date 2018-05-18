using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdrachten_State_Management
{
    public partial class master : System.Web.UI.MasterPage
    {
        #region "Opdracht 13"
        protected void Page_Load(object sender, EventArgs e)
        {
            if(AlOpPaginaGeweest() == false)
            {
                VoegPaginaToeAanCookie();
            } else
            {
                this.lbl_Visited.Text = "U bent hier al eerder geweest.";
            }
        }

        private void VoegPaginaToeAanCookie()
        {
            string huidige_pagina = GetCurrentPageName();

            if (Request.Cookies["paginas_geweest"] != null && AlOpPaginaGeweest() == false)
            {
                List<string> paginas = Request.Cookies["paginas_geweest"].Value.Split(',').ToList<string>();
                paginas.Add(huidige_pagina);

                Response.Cookies["paginas_geweest"].Value = String.Join(",", paginas);
            } else
            {
                Response.Cookies["paginas_geweest"].Value = huidige_pagina;
            }
        }

        private bool AlOpPaginaGeweest()
        {
            if(Request.Cookies["paginas_geweest"] == null)
            {
                return false;
            }
            String[] paginas = Request.Cookies["paginas_geweest"].Value.Split(',');
            return paginas.Contains(GetCurrentPageName());
        }


        // https://stackoverflow.com/questions/1874532/better-way-to-get-page-name
        public string GetCurrentPageName()
        {
            string sPath = Request.Url.AbsolutePath;
            System.IO.FileInfo oInfo = new System.IO.FileInfo(sPath);
            string sRet = oInfo.Name;
            return sRet;
        }
        #endregion
    }
}