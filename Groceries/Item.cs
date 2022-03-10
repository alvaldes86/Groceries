using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groceries
{
    class Item
    {
        #region Fields and Properties
        private string _description;
        private string _units;

        public string Description
        {
            get { return _description; }
            set { _description = value.Trim(); }
        }
        public string Units
        {
            get { return _units; }
            set { _units = value.Trim(); }
        }
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        public Item()
        {   
            _description = string.Empty;
            _units = string.Empty;
            Price = 0;
        }

        public Item( string pDescription, decimal pPrice, string pUnits)
        {
            Description = pDescription;
            Price = pPrice;
            Units = pUnits;
        }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            string message = Description + " at " + Price.ToString("C") + " " + Units;
            return message;
        }
        #endregion
    }
}
