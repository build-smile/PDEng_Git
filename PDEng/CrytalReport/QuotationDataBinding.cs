using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEng
{
    public class QuotationDataBinding: INotifyPropertyChanged
    {

        public QuotationDataBinding()
        {
            //this.CustomerName = "";
            //this.CustomerAddress = "";
            //this.CustomerPhone = "";
            //this.ValidityDate = DateTime.Now;
            //this.SalesName = "";
        }


        private string _CustomerName { get; set; }
        public string CustomerName
        {
            get { return _CustomerName; }

            set
            {
                _CustomerName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CustomerName"));
            }
        }

        private string _CustomerAddress { get; set; }
        public string CustomerAddress
        {
            get { return _CustomerAddress; }

            set
            {
                _CustomerAddress = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CustomerAddress"));
            }
        }
       

        private string _CustomerPhone { get; set; }
        public string CustomerPhone
        {
            get { return _CustomerPhone; }

            set
            {
                _CustomerPhone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CustomerPhone"));
            }
        }

        private string _SalesName { get; set; }
        public string SalesName
        {
            get { return _SalesName; }

            set
            {
                _SalesName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SalesName"));
            }
        }

        private DateTime? _QuoDate { get; set; }
        public DateTime? QuoDate
        {
            get
            {
                return _QuoDate ?? DateTime.Now;
            }

            set
            {
                _QuoDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("QuoDate"));
            }
        }


        private DateTime? _ValidityDate { get; set; }
        public DateTime? ValidityDate
        {
            get {
                return _ValidityDate?? DateTime.Now; }

            set
            {
                _ValidityDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ValidityDate"));
            }
        }


      

       

        public void Clear()
        {
            CustomerName = "";
            CustomerAddress = "";
            CustomerPhone = "";
            ValidityDate = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

