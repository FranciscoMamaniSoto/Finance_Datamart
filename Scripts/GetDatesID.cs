public override void Input0_ProcessInputRow(Input0Buffer Row)
{
    UniqueID = Convert.ToInt32(Variables.MonthMAX);

    Row.UniqueID = UniqueID + looper;
    looper += 1;

    if (Row.Month == 1)
    {
        Row.FiscalMonth = 7;
    }
    else if (Row.Month == 2)
    {
        Row.FiscalMonth = 8;
    }
    else if (Row.Month == 3)
    {
        Row.FiscalMonth = 9;
    }
    else if (Row.Month == 4)
    {
        Row.FiscalMonth = 10;
    }
    else if (Row.Month == 5)
    {
        Row.FiscalMonth = 11;
    }
    else if (Row.Month == 6)
    {
        Row.FiscalMonth = 12;
    }
    else if (Row.Month == 7)
    {
        Row.FiscalMonth = 1;
    }
    else if (Row.Month == 8)
    {
        Row.FiscalMonth = 2;
    }
    else if (Row.Month == 9)
    {
        Row.FiscalMonth = 3;
    }
    else if (Row.Month == 10)
    {
        Row.FiscalMonth = 4;
    }
    else if (Row.Month == 11)
    {
        Row.FiscalMonth = 5;
    }
    else if (Row.Month == 12)
    {
        Row.FiscalMonth = 6;
    }

    if (Row.Month == 1)
    {
        Row.MonthName = "January";
    }
    else if (Row.Month == 2)
    {
        Row.MonthName = "February";
    }
    else if (Row.Month == 3)
    {
        Row.MonthName = "March";
    }
    else if (Row.Month == 4)
    {
        Row.MonthName = "April";
    }
    else if (Row.Month == 5)
    {
        Row.MonthName = "May";
    }
    else if (Row.Month == 6)
    {
        Row.MonthName = "June";
    }
    else if (Row.Month == 7)
    {
        Row.MonthName = "July";
    }
    else if (Row.Month == 8)
    {
        Row.MonthName = "August";
    }
    else if (Row.Month == 9)
    {
        Row.MonthName = "September";
    }
    else if (Row.Month == 10)
    {
        Row.MonthName = "October";
    }
    else if (Row.Month == 11)
    {
        Row.MonthName = "November";
    }
    else if (Row.Month == 12)
    {
        Row.MonthName = "December";
    }

    if (Row.Month == 1 || Row.Month == 2 || Row.Month == 3)
    {
        Row.Quarter = "Q1";
        Row.FiscalQuarter = "Q3";
    }
    else if (Row.Month == 4 || Row.Month == 5 || Row.Month == 6)
    {
        Row.Quarter = "Q2";
        Row.Quarter = "Q4";
    }
    else if (Row.Month == 7 || Row.Month == 8 || Row.Month == 9)
    {
        Row.Quarter = "Q3";
        Row.Quarter = "Q1";
    }
    else if (Row.Month == 10 || Row.Month == 11 || Row.Month == 12)
    {
        Row.Quarter = "Q4";
        Row.Quarter = "Q2";
    }


    if (Row.Month > 6)
    {
        Row.FiscalYear = Convert.ToInt32(Row.Year) + 1;
        FYHolder = Convert.ToString(Row.Year + 1);
    }
    else
    {
        Row.FiscalYear = Convert.ToInt32(Row.Year);
        FYHolder = Convert.ToString(Row.Year);
    }

    Row.FiscalYearID = "FY" + FYHolder.Substring(1, 2);

}