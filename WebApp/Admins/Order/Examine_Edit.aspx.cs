using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Order
{
    public partial class Examine_Edit : System.Web.UI.Page
    {
        private readonly OrderService orderSvc = new OrderService();
        private readonly ExamineService examineSvc = new ExamineService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }


        public void Bind()
        {
            var id = Request.Params["action"] == null ? Guid.Empty : Guid.Parse(Request.Params["action"]);
            var data = examineSvc.GetExamineByOrderId(id);
            if (data != null)
            {
                //这个是代表我们审核信息是存在的,我们进行正常的绑定
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            if (this.hfExamineId.Value == "")
            {
                //新增
            }
            else
            {
                //执行修改
            }
        }

        protected void btnReset_OnClick(object sender, EventArgs e)
        {
            
        }
    }
}