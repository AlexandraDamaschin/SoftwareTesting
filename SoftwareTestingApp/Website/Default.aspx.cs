using SoftwareTestingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(Request.Form["Age"]);
            string gender = String.Format("{0}", Request.Form["Gender"]).ToLower();

            Insurance ins = new Insurance();
            double output = ins.CalcPremium(age, gender);

            Label1.Text= Convert.ToString(output);
        }
    }
}