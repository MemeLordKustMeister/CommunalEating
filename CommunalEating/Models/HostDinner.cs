﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalEating.Models
{
    class HostDinner
    {
        // # Needed variables / backing-fields
        #region Variables
        private string _headline;
        private string _description;
        private string _additionalNote;
        private string _host;
        private double _price;
        private DateTime _date;
        #endregion

        // ## Properties
        #region Properties
        // # Headline
        public String Headline
        {
            get { return _headline; }
            set { _headline = value; }
        }
        // # Description
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        // # Additional Note
        public String AdditionalNote
        {
            get { return _additionalNote; }
            set { _additionalNote = value; }
        }
        // # Hosting Household
        public string Host
        {
            get { return _host; }
            set { _host = value; }
        }
        // # Price
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        // # Date
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region Constructors (3 of a kind)
        // # Default Constructor
        public HostDinner()
        {
            _headline = "";
            _description = "";
            _additionalNote = "";
            _host = "";
            _price = 0.0;
        }

        // # Constructor that takes values (+price)
        public HostDinner(String _headline,
                          String _description,
                          String _additionalNote,
                          string _host,
                          double _price,
                          DateTime _date)
        {
            this._headline = _headline;
            this._description = _description;
            this._additionalNote = _additionalNote;
            this._host = _host;
            this._price = _price;
            this._date = _date;
        }

        // # Constructor that takes values (-price)
        public HostDinner(String _headline,
                          String _description,
                          String _additionalNote,
                          string _host,
                          DateTime _date)
        {
            this._headline = _headline;
            this._description = _description;
            this._additionalNote = _additionalNote;
            this._host = _host;
            this._price = 0;
            this._date = _date;
        } 
        #endregion
    }
}
