using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using System.Configuration;

namespace PDEng
{
    public partial class Quotation : Form
    {
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        private DataTable TBCustomer;
        private DataTable TBQuo;
        private DataTable TBQuoDetail;
        private QuotationDataBinding quoBinding;
        public Quotation()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.quoBinding = new QuotationDataBinding();
            InitTable();
            InitData();
            InitEvent();
            
           
        }

        private void InitTable()
        {
            this.TBCustomer = new DataTable();
            this.TBCustomer.Columns.Add("Code", typeof(string));
            this.TBCustomer.Columns.Add("CustomerName", typeof(string));
            this.TBCustomer.Columns.Add("Address", typeof(string));
            this.TBCustomer.Columns.Add("Phone", typeof(string));
            this.TBCustomer.Columns.Add("TaxID", typeof(string));



            this.TBQuo = new DataTable();

            this.TBQuoDetail = new DataTable();

            this.TBQuo.Columns.Add("QuoNo", typeof(string));
            this.TBQuo.Columns.Add("QuoDate", typeof(string));
            this.TBQuo.Columns.Add("CustomerName", typeof(string));
            this.TBQuo.Columns.Add("CustomerAddress", typeof(string));
            this.TBQuo.Columns.Add("CustomerPhone", typeof(string));         
            this.TBQuo.Columns.Add("SalesName", typeof(string));
            this.TBQuo.Columns.Add("ValidityDate", typeof(string));





            this.TBQuoDetail.Columns.Add("Description");
            this.TBQuoDetail.Columns.Add("Qty");
            this.TBQuoDetail.Columns.Add("UnitPrice");
            this.TBQuoDetail.Columns.Add("TotalAmount");
        }

        private void InitData()
        {
            
            string ErrMsg = "";
            bool pass = GetExcelToTB("Customer",this.TBCustomer, ref ErrMsg);
            if(!pass)
            {
                MessageBox.Show(ErrMsg);
            }
            pass = GetExcelToTB("QT",this.TBQuo, ref ErrMsg);
            if (!pass)
            {
                MessageBox.Show(ErrMsg);
            }
            else
            {
                gridViewQT.DataSource = this.TBQuo;
            }

            //this.txtCustomer.DataBindings.Add("Text", this.TBQuo, "CustomerName", true);
            //this.txtCustomerAddress.DataBindings.Add("Text", this.TBQuo, "CustomerAddress", true);
            //this.txtCustomerPhone.DataBindings.Add("Text", this.TBQuo, "CustomerPhone", true);
            //this.dtValidity.DataBindings.Add("Value", this.TBQuo, "ValidityDate", true);
            //this.txtSalesName.DataBindings.Add("Text", this.TBQuo, "SalesName", true);

            this.dtQtDate.DataBindings.Add("Value", this.quoBinding, "QuoDate", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtCustomer.DataBindings.Add("Text", this.quoBinding, "CustomerName", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtCustomerAddress.DataBindings.Add("Text", this.quoBinding, "CustomerAddress", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtCustomerPhone.DataBindings.Add("Text", this.quoBinding, "CustomerPhone", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dtValidity.DataBindings.Add("Value", this.quoBinding, "ValidityDate",true,DataSourceUpdateMode.OnPropertyChanged);
            this.txtSalesName.DataBindings.Add("Text", this.quoBinding, "SalesName", false, DataSourceUpdateMode.OnPropertyChanged);

           

        }
        public bool GetExcelToTB(string fileName,DataTable TB,ref string ErrMsg)
        {
            string strFolderPath = String.Format(Application.StartupPath + "\\Document\\{0}.xlsx", fileName);
            wb = excel.Workbooks.Open(strFolderPath);
            ws = wb.Worksheets[1];

            
            bool pass = GetDataExcel(ref TB, ref ErrMsg);
            wb.Close();
            if (!pass)
            {
               
                return false;
            }
            return true;
        }
        private void InitEvent()
        {
            btnFetchCustomer.Click += BtnFetchCustomer_Click;
            btnAddDetail.Click += BtnAddDetail_Click;
            gridQTDetail.CellContentClick += GridQTDetail_CellContentClick;
            menuSave.Click += MenuSave_Click;
           
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
           if(this.TBQuoDetail.Rows.Count>0)
            {
               
                string fileName = "QT";
                string strFolderPath = String.Format(Application.StartupPath + "\\Document\\{0}.xlsx", fileName);



                Excel excel = new Excel(strFolderPath, 1);


                int i = 0;
                

               
                foreach (DataColumn data in TBQuo.Columns)
                {
                    excel.WriteToCell(0, i, data.ColumnName);
                    i++;
                }
                int startIndex = excel.FindIndexEmpty(strFolderPath);

                string quoNo = Helper.GetQuotNoNumber(quoBinding.QuoDate.Value);
                excel.WriteToCell(startIndex, 0, quoNo);
                excel.WriteToCell(startIndex, 1, this.quoBinding.QuoDate.Value.ToString());
                excel.WriteToCell(startIndex, 2, this.quoBinding.CustomerName);
                excel.WriteToCell(startIndex, 3, this.quoBinding.CustomerAddress);
                excel.WriteToCell(startIndex, 4, this.quoBinding.CustomerPhone);             
                excel.WriteToCell(startIndex, 5, this.quoBinding.SalesName);
                excel.WriteToCell(startIndex, 6, this.quoBinding.ValidityDate.ToString());




                excel.Save();
                excel.Close();
                MessageBox.Show("Complete");

                string ErrMsg = "";
                this.TBQuo.Clear();
                bool pass = GetExcelToTB("QT", this.TBQuo, ref ErrMsg);
                if (!pass)
                {
                    MessageBox.Show(ErrMsg);
                }
                else
                {
                    gridViewQT.DataSource = this.TBQuo;
                }

            }
        }

        private void GridQTDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                    if (gridQTDetail.Rows[e.RowIndex].DataBoundItem == null) return;
                    DataRow rowdel = (gridQTDetail.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
                    rowdel.Delete();
                    gridQTDetail.DataSource = this.TBQuoDetail;
            }
        }

        private void BtnAddDetail_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text!="" && spnQuantity.Value >= 0 && spnUnitPrice.Value >= 0)
            {
                DataRow rowNew = this.TBQuoDetail.NewRow();
          
                rowNew["Description"] = txtDescription.Text;
                rowNew["Qty"] = spnQuantity.Value.ToString();
                rowNew["UnitPrice"] = spnUnitPrice.Value.ToString();
                rowNew["TotalAmount"] = spnUnitPrice.Value * spnQuantity.Value;

                this.TBQuoDetail.Rows.Add(rowNew);

                gridQTDetail.DataSource = this.TBQuoDetail;

            }
        }

        private void BtnFetchCustomer_Click(object sender, EventArgs e)
        {
            
            PopupCustomer popupCustomer = new PopupCustomer
                (this.TBCustomer,this.quoBinding);
            popupCustomer.Show();
        }


        public string ReadCell(int i, int j)
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
        public bool GetDataExcel(ref DataTable TB, ref string ErrMsg)
        {
            try
            {
                int i = 0;
                int j = 0;
                string result = "";
                do
                {

                    //if (j == 0)
                    //{
                    //    bool isAddColums = false;
                    //    while (!isAddColums)
                    //    {
                    //        result = ReadCell(j, i);
                    //        if (result != "")
                    //            TB.Columns.Add(result, typeof(string));
                    //        else isAddColums = true;
                    //        i++;
                    //    }
                    //    i = 0;
                    //}
                    if(j>0)
                    {
                        DataRow newRow = TB.NewRow();
                        bool isAddRow = false;
                        while (!isAddRow)
                        {
                            string rows = ReadCell(j, i);
                            string columns = ReadCell(0, i);

                            if (columns != "") { newRow[columns] = rows; }

                            else isAddRow = true;
                            i++;
                        }

                        i = 0;
                        TB.Rows.Add(newRow);
                    }
                    result = ReadCell(j, 0);
                    j++;
                } while (result != "");
               
                return true;
            }
            catch (Exception e)
            {
                ErrMsg = e.Message;
                return false;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
