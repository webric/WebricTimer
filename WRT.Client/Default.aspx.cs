﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WRT.Core.BLL;
using WRT.Core.Util;

namespace WRT.Client
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void BtnExistingRaceSid_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("/race.aspx?race=" + txtExistingRaceSid.Text);
        }

        protected void BtnNewRace_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("/newrace.aspx");
        }
    }
}