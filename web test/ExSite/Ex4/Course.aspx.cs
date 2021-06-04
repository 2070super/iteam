﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ex4_Course : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindYear();
            BindTerm();
            BindCollege();
            BindTeacher();
        }
    }
    protected void BindYear()
    {
        ddlYear.Items.Clear();
        int startYear = DateTime.Now.Year - 10;
        int currentYear = DateTime.Now.Year;
        for (int i = startYear; i <= currentYear; i++)
        {
            ddlYear.Items.Add(new ListItem((i - 1).ToString() + "-" + i.ToString()));
        }
        ddlYear.SelectedValue = (currentYear - 1).ToString() + "-" + currentYear.ToString();
    }
    protected void BindTerm()
    {
        ddlTerm.Items.Clear();
        for (int i = 1; i <= 2; i++)
        {
            ddlTerm.Items.Add(i.ToString());
        }
    }
    protected void BindCollege()
    {
        ddlCollege.Items.Clear();
        ddlCollege.Items.Add(new ListItem("aa学院"));
        ddlCollege.Items.Add(new ListItem("bb学院"));
        ddlCollege.Items.Add(new ListItem("cc学院"));
    }
    protected void DdlCollege_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTeacher();
    }
    protected void BindTeacher()
    {
        ddlTeacher.Items.Clear();
        switch (ddlCollege.SelectedValue)
        {
            case "计算机学院":
                ddlTeacher.Items.Add(new ListItem("a"));
                ddlTeacher.Items.Add(new ListItem("b"));
                ddlTeacher.Items.Add(new ListItem("c"));
                break;
            case "外国语学院":
                ddlTeacher.Items.Add(new ListItem("d"));
                ddlTeacher.Items.Add(new ListItem("e"));
                break;
            case "机电学院":
                ddlTeacher.Items.Add(new ListItem("f"));
                ddlTeacher.Items.Add(new ListItem("g"));
                break;
        }
    }


}