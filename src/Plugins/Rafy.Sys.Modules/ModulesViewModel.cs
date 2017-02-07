﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy.Sys.Modules
{

    /// <summary>
    /// Modules
    /// </summary>

    public class ModulesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private long _Id;
        /// <summary>
        /// Id
        /// </summary>
        public long Id
        {
            get { return _Id; }
            set
            {
                if (Id != value)
                {
                    Id = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                }
            }
        }
        private String _Assembly;
        /// <summary>
        /// Assembly
        /// </summary>
        public String Assembly
        {
            get { return _Assembly; }
            set
            {
                if (Assembly != value)
                {
                    Assembly = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Assembly"));
                }
            }
        }
        private String _Description;
        /// <summary>
        /// Description
        /// </summary>
        public String Description
        {
            get { return _Description; }
            set
            {
                if (Description != value)
                {
                    Description = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }
        private String _ModuleGuid;
        /// <summary>
        /// ModuleGuid
        /// </summary>
        public String ModuleGuid
        {
            get { return _ModuleGuid; }
            set
            {
                if (ModuleGuid != value)
                {
                    ModuleGuid = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ModuleGuid"));
                }
            }
        }
        private String _ModuleName;
        /// <summary>
        /// ModuleName
        /// </summary>
        public String ModuleName
        {
            get { return _ModuleName; }
            set
            {
                if (ModuleName != value)
                {
                    ModuleName = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ModuleName"));
                }
            }
        }
        private String _ModuleType;
        /// <summary>
        /// ModuleType
        /// </summary>
        public String ModuleType
        {
            get { return _ModuleType; }
            set
            {
                if (ModuleType != value)
                {
                    ModuleType = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ModuleType"));
                }
            }
        }
    }
}

