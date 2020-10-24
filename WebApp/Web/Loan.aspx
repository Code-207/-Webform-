<%@ Page Title="" Language="C#" MasterPageFile="~/Web/shared/Frontend.Master" AutoEventWireup="true" CodeBehind="Loan.aspx.cs" Inherits="WebApp.Web.Loan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>XX贷款</title>
    <script>
        $(function () {
            //当我们参数对应的是信用贷款的时候,对应的下标值为1
            //当我们参数对应的是房产贷款的时候,对应的下标值为2
            //当我们参数对应的是车辆贷款的时候,对应的下标值为3
            //当我们参数对应的是企业贷款的时候,对应的下标值为4
            //当我们参数对应的是我要贷款的时候,对应的下标值为5

            $(".nav_r>ul>li:eq(1)").addClass("cur");
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="xydk1">
        <p>信用贷款</p>
        <div class="xydk1_2">Credit loan</div>
    </div>
    <div class="xydk2">
        <div class="xydk21">
            <p>1.产品介绍</p>
            <span>Product introduction</span>
        </div>
        <div class="xydk22">
            <p>无抵押贷款，又称无担保贷款，或者是信用贷款，是不需要任何抵押物，只需身份证明，收入证明，住址证明等材料（具体证明材料要看是什么银行）即可向银行申请的贷款。信用贷款具有无担保、时间快、手续简单等特点。获得放款之前，申请人只需要提供相关资料，不需要投入任何贷前费用。</p>
        </div>
        <div class="clear"></div>
    </div>
    <div class="xydk3">
        <p>2.贷款条件</p>
        <span>Loan conditions</span>
    </div>
    <ul class="xydk4">
        <li>
            <div class="xydk4_1">
                <img src="assets/images/xydk41.png" width="86" height="10" /></div>
            <div>
                <div class="xydk4_21">1</div>
                <div class="xydk4_3">
                    <p class="wordwrap">是企业客户信用等级至少在AA-(含)级以上的，经国有商业银行省级分行审批可以发放信用贷款；</p>
                </div>
                <div class="clear"></div>
            </div>
            <div class="xydk4_1">
                <img src="assets/images/xydk42.png" width="86" height="10" /></div>
        </li>
        <li>
            <div class="xydk4_1">
                <img src="assets/images/xydk43.png" width="86" height="10" /></div>
            <div>
                <div class="xydk4_22">2</div>
                <div class="xydk4_3">
                    <p class="wordwrap">是企业客户信用等级至少在AA-(含)级以上的，经国有商业银行省级分行审批可以发放信用贷款；</p>
                </div>
                <div class="clear"></div>
            </div>
            <div class="xydk4_1">
                <img src="assets/images/xydk44.png" width="86" height="10" /></div>
        </li>
        <li>
            <div class="xydk4_1">
                <img src="assets/images/xydk45.png" width="86" height="10" /></div>
            <div>
                <div class="xydk4_23">3</div>
                <div class="xydk4_3">
                    <p class="wordwrap">是企业客户信用等级至少在AA-(含)级以上的，经国有商业银行省级分行审批可以发放信用贷款；</p>
                </div>
                <div class="clear"></div>
            </div>
            <div class="xydk4_1">
                <img src="assets/images/xydk46.png" width="86" height="10" /></div>
        </li>
        <li>
            <div class="xydk4_1">
                <img src="assets/images/xydk47.png" width="86" height="10" /></div>
            <div>
                <div class="xydk4_24">4</div>
                <div class="xydk4_3">
                    <p class="wordwrap">是企业客户信用等级至少在AA-(含)级以上的，经国有商业银行省级分行审批可以发放信用贷款；</p>
                </div>
                <div class="clear"></div>
            </div>
            <div class="xydk4_1">
                <img src="assets/images/xydk48.png" width="86" height="10" /></div>
        </li>
        <div class="clear"></div>
    </ul>
    <script type="text/javascript">
        $(function () {
            $(".xydk4_3").hover(function () {
                var _pw = $(this).find(".wordwrap").width();
                if (_pw > 735) {
                    $(this).find(".wordwrap").stop(true, true).animate({ "left": 735 - _pw }, 2000);
                }
            }, function () {
                $(this).find(".wordwrap").stop(true, true).animate({ "left": 0 }, 2000);
            })
        })
    </script>
    <div class="xydk5">
        <div class="xydk5_l">
            <p>3.申请资料</p>
            <span>Application materials</span>
        </div>
        <ul class="xydk5_r">
            <li><span>1</span>身份证复印件</li>
            <li><span>2</span>工资卡银行流水</li>
            <li><span>3</span>央行信用报告</li>
            <div class="clear"></div>
        </ul>
        <div class="clear"></div>
    </div>
    <div class="xydk6">
        <p>费用说明</p>
        <span>Explanation of cost</span>
    </div>
    <div class="xydk7">
        <p>平台服务费即平台向借款人收取的服务总费用，其中包含前期服务费、分期服务费两部分。信用资质良好的用户可免收分期服务费。</p>
        <p>前期服务费：借款人通过审核后放款前会一次性扣除的服务费为前期服务费。</p>
        <p>分期服务费：借款人除前期服务费以外需要按月缴纳的服务费。</p>
        <p>&nbsp;</p>
        <p>其他费用：</p>
        <p>
            身份验证费用：借款人身份验证7次不通过则需收取5元/次的身份验证费用。<p>
                <p>审核费用：借款人提交借款申请单后需支付15元/单的信用审核费用。</p>
            </p>
    </div>
</asp:Content>
