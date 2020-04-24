using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System;
using Application = System.Windows.Forms.Application;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEng
{
    public class Excel
    {
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        string path;

        public Excel(string path,int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public void WriteToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }
        public bool saveAS(string path, ref string ErrMsg)
        {
            try
            {
                wb.SaveAs(path);
                return true;
            }
            catch (Exception e)
            {
                ErrMsg = e.Message;
                return false;
            }

        }
        public void Save()
        {
            wb.Save();
            
        }
        public void Close()
        {
            wb.Close();
        }
        public string readExcel(int i,int j,string fileName)
        {
            string strFolderPath = String.Format(Application.StartupPath + "\\Document\\{0}.xlsx", fileName);
            Workbook wb = excel.Workbooks.Open(strFolderPath);
            Worksheet ws = wb.Worksheets[1];
            return ReadCell(i, j,ws);
        }

        public string ReadCell(int i, int j,Worksheet ws)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
            {
                string resultText = "";
                var result = ws.Cells[i, j].Value2;
                if (result.GetType() == typeof(double))
                {

                }
                else resultText = result;
                return result.ToString();
            }
            else return "";
        }
        public int FindIndexEmpty(string fileName)
        {
            
            //Workbook wbIndex = excel.Workbooks.Open(fileName);
            //Worksheet wsIndex = wb.Worksheets[1];
            int i = 1;
            try
            {
                string result = "data";
               
                do
                {
                    if (ws.Cells[i, 1] != null)
                    {
                        result = ws.Cells[i, 1].Value2;
                        i++;
                    }

                  
                    
                   
                } while (result != null || result == "");

                i=i-2;
                return i;
            }
            catch (Exception e)
            {
                return i;
                
            }
            

        }
    }
}
