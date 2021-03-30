using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 6;
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += 1;
                }
            }
            if (sum == 7)
            {
                Response.Write("Yes");
            }
            else
            {
                Response.Write("No");
            }
        }
    }
}