using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace PDEng
{
    public partial class PopupCustomer : Form
    {
        private DataTable TBCustomer = new DataTable();
        private DataTable TBQuot;
        QuotationDataBinding quotationBinding;


        public PopupCustomer(DataTable TBCustomer,QuotationDataBinding quotationBinding)
        {
            this.quotationBinding = quotationBinding;
            this.TBCustomer = TBCustomer;
           
    
            InitializeComponent();
        }

        private void PopupCustomer_Load(object sender, EventArgs e)
        {
            InitData();
            InitEvent();
        }

        private void InitEvent()
        {
            gridCustomer.CellClick += GridCustomer_CellClick;
        }

        private void GridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {

                gridCustomer.CurrentRow.Selected = true;
                DataRow rowCustomer = (gridCustomer.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
                this.quotationBinding.CustomerName = rowCustomer["CustomerName"].ToString();
                this.quotationBinding.CustomerAddress = rowCustomer["Address"].ToString();
                this.quotationBinding.CustomerPhone = rowCustomer["Phone"].ToString();

                this.Hide();
            }
            catch (Exception)
            {

            
            }
            
        }

        private void InitData()
        {
            gridCustomer.DataSource = this.TBCustomer;
        }
       
    }
}
