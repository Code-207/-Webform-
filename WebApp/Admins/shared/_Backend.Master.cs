using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Admins.shared
{
    public partial class _Backend : System.Web.UI.MasterPage
    {
        public string msg = "initial";
        public int code = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            object ob = Session["Msg"];
            if (ob != null)
            {
                var res = ob as ReturnMsg<Model.Roles>;
                msg = res.Message;
                code = (int)res.Code;


            }
        }
    }
}