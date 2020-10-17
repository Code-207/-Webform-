using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Roles
{
    public partial class Roles_Add : System.Web.UI.Page
    {
        private readonly RolesService rolesSvc = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            var res = rolesSvc.Add(new Model.Roles()
            {
                Roles_Title = txtName.Text.Trim()
            });
            //if (res > 0)
            //{
            //    Response.Write("<script>alert('新增成功');location.href='Roles_List.aspx'</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('新增失败');'</script>");
            //}

            ReturnMsg<Model.Roles> rm  = res > 0
                  ? new ReturnMsg<Model.Roles>()
                  {
                      Code = StatusCode.Ok,
                      Message = "新增权限成功",
                      Data = null
                  }
                  : new ReturnMsg<Model.Roles>()
                  {
                      Code = StatusCode.Error,
                      Message = "新增权限失败",
                      Data = null
                  };

            Session["Msg"] = rm; //用于传递执行信息的
            Response.Redirect("Roles_List.aspx"); 

        }

        protected void btnReset_OnClick(object sender, EventArgs e)
        {
            this.txtName.Text = "";
        }
    }
}