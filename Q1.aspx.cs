using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



//TODO 當tb_Account被按下enter判斷Text有沒有出現在s_Idset陣列,如果有出現就把lb_Tybe改成"複診",else改成"初診".pl_Msg.Visible=False

//TODO if tb_Account=null,btn_Submit.Visivle=False,else,btn_Submit.Visivle=True

//TODO if tb_Account != null,btn_Submit.Visivle=True, if btn_Submit被點擊,pl_Mas.Visivle = True.lb_Msg.Text = 完成掛號 and if tb_Email.Text !=null,lb_Msg+=tb_Email.Text
namespace _111_1MIDDEMO1 {
    public partial class Q1 : System.Web.UI.Page {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tb_Account_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < s_IdSet.Length; i++)
            {
                if (tb_Account.Text == s_IdSet[i] && tb_Account.Text != "")
                {
                    lb_Type.Text = "複診";
                    btn_Submit.Visible = true;
                    break;
                }
                else if(tb_Account.Text != s_IdSet[i] && tb_Account.Text != "")
                {
                    lb_Type.Text = "初診";
                    btn_Submit.Visible = true;

                }
                else
                {
                    btn_Submit.Visible = false;
                    lb_Type.Text = "初診";
                }
            }
            pl_Msg.Visible = false;
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            pl_Msg.Visible = true;
            lb_Msg.Text = "";
            if (tb_Email.Text == "")
            {
                lb_Msg.Text += lb_Type.Text + "<br />" + tb_Account.Text + "先生/小姐，已完成掛號。" + "<br />" + "<br />";
            }
            else
            {
                lb_Msg.Text += lb_Type.Text + "<br />" + tb_Account.Text + "先生/小姐，已完成掛號。" + "<br />" + "已寄信至信箱" + tb_Email.Text + "<br />" + "<br />";
            }
        }
    }
}