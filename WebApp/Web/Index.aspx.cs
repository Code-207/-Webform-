using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Web
{
    public partial class index : System.Web.UI.Page
    {
        private readonly NewsService newsSvc = new NewsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            this.RepNewsList.DataSource = newsSvc.GetNewsTopFour();
            this.RepNewsList.DataBind();

        }
    }
}