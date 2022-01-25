using System;
using System.Web.Mvc;
using WebApp_Usuf.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebApp_Usuf.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var lib = new Lib()
            {
                ChugLit_Si = 1.26,
                ChugLit_Mn = 0.68,
                ChugLit_Sto = 75.5,
                ChugLit_Min = 24,
                ChugLit_Max = 50,

                ChugPer_Si = 1.08,
                ChugPer_Mn = 0.26,
                ChugPer_Sto = 60,
                ChugPer_Min = 24,
                ChugPer_Max = 50,

                ChugZer_Si = 1.64,
                ChugZer_Mn = 1.57,
                ChugZer_Sto = 97,

                LomChug_Si = 1.5,
                LomChug_Mn = 0.7,
                LomChug_Sto = 36.2,

                LomSta_Si = 0.5,
                LomSta_Mn = 0.5,
                LomSta_Sto = 34.3,
                LomSta_Min = 8,
                LomSta_Max = 12,

                Vozr_Si = 0.4,
                Vozr_Mn = 0.65,
                Vozr_Sto = 36.2,
                Vozr_Min = 20,
                Vozr_Max = 40,

                Ferr_Si = 52.02,
                Ferr_Mn = 0.44,
                Ferr_Sto = 120,

                SiT_Min = 2.47,
                SiT_Max = 2.54,

                MnT_Min = 0.37,
                MnT_Max = 1
            };
            return View(lib);
        }

        [HttpPost]
        public ActionResult Index(Lib lib)
        {
            Excel.Application objExcel = null;
            Excel.Workbook WorkBook = null;

            objExcel = new Excel.Application();
            try
            {
                string fileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Book.xlsm");

                WorkBook = objExcel.Workbooks.Open(fileName, 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, 0, true, false, false);

                Excel.Worksheet WorkSheet = (Excel.Worksheet)WorkBook.Sheets["Data"];

                WorkSheet.Range["C5"].Value2 = lib.ChugLit_Si;
                WorkSheet.Range["D5"].Value2 = lib.ChugLit_Mn;
                WorkSheet.Range["E5"].Value2 = lib.ChugLit_Sto;
                WorkSheet.Range["G24"].Value2 = lib.ChugLit_Min;
                WorkSheet.Range["H24"].Value2 = lib.ChugLit_Max;

                WorkSheet.Range["C6"].Value2 = lib.ChugPer_Si;
                WorkSheet.Range["D6"].Value2 = lib.ChugPer_Mn;
                WorkSheet.Range["E6"].Value2 = lib.ChugPer_Sto;
                WorkSheet.Range["G25"].Value2 = lib.ChugPer_Min;
                WorkSheet.Range["H25"].Value2 = lib.ChugPer_Max;

                WorkSheet.Range["C7"].Value2 = lib.ChugZer_Si;
                WorkSheet.Range["D7"].Value2 = lib.ChugZer_Mn;
                WorkSheet.Range["E7"].Value2 = lib.ChugZer_Sto;
                WorkSheet.Range["G26"].Value2 = lib.ChugZer_Min;
                WorkSheet.Range["H26"].Value2 = lib.ChugZer_Max;

                WorkSheet.Range["C8"].Value2 = lib.LomChug_Si;
                WorkSheet.Range["D8"].Value2 = lib.LomChug_Mn;
                WorkSheet.Range["E8"].Value2 = lib.LomChug_Sto;
                WorkSheet.Range["G27"].Value2 = lib.LomChug_Min;
                WorkSheet.Range["H27"].Value2 = lib.LomChug_Max;

                WorkSheet.Range["C9"].Value2 = lib.LomSta_Si;
                WorkSheet.Range["D9"].Value2 = lib.LomSta_Mn;
                WorkSheet.Range["E9"].Value2 = lib.LomSta_Sto;
                WorkSheet.Range["G28"].Value2 = lib.LomSta_Min;
                WorkSheet.Range["H28"].Value2 = lib.LomSta_Max;

                WorkSheet.Range["C10"].Value2 = lib.Vozr_Si;
                WorkSheet.Range["D10"].Value2 = lib.Vozr_Mn;
                WorkSheet.Range["E10"].Value2 = lib.Vozr_Sto;
                WorkSheet.Range["G29"].Value2 = lib.Vozr_Min;
                WorkSheet.Range["H29"].Value2 = lib.Vozr_Max;

                WorkSheet.Range["C11"].Value2 = lib.Ferr_Si;
                WorkSheet.Range["D11"].Value2 = lib.Ferr_Mn;
                WorkSheet.Range["E11"].Value2 = lib.Ferr_Sto;
                WorkSheet.Range["G30"].Value2 = lib.Ferr_Min;
                WorkSheet.Range["H30"].Value2 = lib.Ferr_Max;

                WorkSheet.Range["D33"].Value2 = lib.SiT_Min;
                WorkSheet.Range["D34"].Value2 = lib.SiT_Max;

                WorkSheet.Range["E33"].Value2 = lib.MnT_Min;
                WorkSheet.Range["E34"].Value2 = lib.MnT_Max;

                objExcel.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod,
                null, objExcel, new Object[] { "Макрос1" });
                lib.ChugLit_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C24"].Value), 2);
                lib.ChugPer_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C25"].Value), 2);
                lib.ChugZer_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C26"].Value), 2);
                lib.LomChug_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C27"].Value), 2);
                lib.LomSta_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C28"].Value), 2);
                lib.Vozr_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C29"].Value), 2);
                lib.Ferr_VsegT = Math.Round(Convert.ToDouble(WorkSheet.Range["C30"].Value), 2);

                lib.isShow = true;
            }
            finally
            {
                if (WorkBook != null)
                    WorkBook.Close(0);
                objExcel.Quit();
            }
            return View(lib);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}