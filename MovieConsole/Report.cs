using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    //internal - can access within same assembly
    public abstract class Report
    {
        public abstract string ExcelGenerateReport();
       // {
            //string reportStatus = "";
            //if (type == "Gold")
            //{
            //    reportStatus = "Display all details";

            //}
            //else if (type == "Silver")
            //{
            //    reportStatus = "50% details";
            //}
            //else if (type == "Plantinum")
            //{
            //    reportStatus = "75% details";
            //}
            //string excelReport = "Report details";//ReportID,ReportId
            //return excelReport;
       // }
        public string DocGenerateReport()
        {
            string docReport = "DocReport";//ReportId,Name,ReportDate
            return docReport;
        }
    }
    public class GoldCustomer : Report
    {
        public override string ExcelGenerateReport()
        {
            //logic
            return "Gold customer";
        }
    }
    public class SilverCustomer:Report 
    {
        public override string ExcelGenerateReport() 
        {
            return "silver customer";
        }
    }
    public class PlantinumCustomer : Report
    {
        public override string ExcelGenerateReport() 
        {
            return "Plantinum customers";
        }
    }
    public class Client
    {
        public void RunClient()
        {
            GoldCustomer goldObj = new GoldCustomer();
            AccessCustomers(goldObj);
            SilverCustomer silverObj = new SilverCustomer();
            AccessCustomers(silverObj);

            Report reportObj = new GoldCustomer();
            AccessCustomers(reportObj);
        }
        public void AccessCustomers(Report report)
        {
            report.ExcelGenerateReport();
            report.DocGenerateReport();
        }
        //public void AccessCustomers(GoldCustomer goldObj)
        //{
        //}
        //public void AccessCustomers(SilverCustomer silverObj) 
        //{
        //}
    }
}
