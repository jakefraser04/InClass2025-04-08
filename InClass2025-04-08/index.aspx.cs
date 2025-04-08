using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass2025_04_08
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmdOK.Click += cmdOK_OnClick; //Hooks the event to our code
        }
        protected void cmdOK_OnClick(object sender, EventArgs e)
        {
            //call your .cs file code here
            lblResult.Text = "You clicked!";
            // 1. Compute the # of days between the two calendar controls
            // 2. Multiply that value by $200 (per day)
            // 3. Apply 15% sales tax to that total
            // 4. Dispaly the total with tax in our label
            DateTime date1 = calCheckInDate.SelectedDate;
            DateTime date2 = calCheckOutDate.SelectedDate;

            int daysDifference = (date2 - date1).Days;

            lblResult.Text = "Total: " + ((daysDifference * 200) + ((daysDifference * 200) * 0.15));
        }

    }
}