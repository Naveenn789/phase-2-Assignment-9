using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConAppAssignment9
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LblMsg.Visible = false;
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Registration Done !!!" + "<br />" + "Welcome          : " + TxtName.Text + "<br />";
                LblMsg.Text += "Your Mobile     : " + TxtMobile.Text + "<br>";
                LblMsg.Text += "Your Email      : " + TxtEmail.Text + "<br>";
                LblMsg.Text += "Your Password is: " + TxtCustPwd.Text + "<br />";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string i = args.Value;
            args.IsValid = i.Length>=6;
        }

    }
}