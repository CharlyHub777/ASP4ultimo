﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP4Ultimo
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnCreateArray_Click(object sender, EventArgs e)
        {
            String[] txtCategoryArray = new string[5];
            txtCategoryArray[0] = "Footwear - Men's";
            txtCategoryArray[1] = "Clothing - Men's";
            txtCategoryArray[2] = "Racquets";
            txtCategoryArray[3] = "Footwear - Women's";
            txtCategoryArray[4] = "Clothing - Women's";

            Session["txtCategoryArray"] = txtCategoryArray;

            // Go to the next page.
            Response.Redirect("WebForm2.aspx");

        }
    }
}