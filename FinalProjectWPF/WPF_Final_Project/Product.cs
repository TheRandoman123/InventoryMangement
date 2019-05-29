using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Final_Project
{
    public class Product
    {
        private int _SKUorUPC;
        private int _QuantityOnHand;
        private int _QuantityInHastings;
        private int _QuantityInKalamazoo;
        private double _Price;
        private string _Location;
        private string _Photo;

        public int SKUorUPC
        {
            get
            {
                return _SKUorUPC;
            }

            set
            {
                _SKUorUPC = value;
            }
        }
        public int QuantityOnHand
        {
            get
            {
                return _QuantityOnHand;
            }

            set
            {
                _QuantityOnHand = value;
            }
        }
        public int QuantityInHastings
        {
            get
            {
                return _QuantityInHastings;
            }

            set
            {
                _QuantityInHastings = value;
            }
        }
        public int QuantityInKalamazoo
        {
            get
            {
                return _QuantityInKalamazoo;
            }

            set
            {
                _QuantityInKalamazoo = value;

            }
        }
        public double Price
        {
            get
            {
                return _Price;
            }

            set
            {
                _Price = value;
            }

        }
        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }

        public string Photo
        {
            get
            {
                return _Photo;
            }

            set
            {
                _Photo = value;
            }
        }

    }
}
