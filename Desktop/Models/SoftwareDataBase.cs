﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace UI.Models
{
    public partial class SoftwareDataBase
    {
        public int IdSoftware { get; set; }
        public int IdDataBase { get; set; }

        public virtual DataBase IdDataBaseNavigation { get; set; }
        public virtual Software IdSoftwareNavigation { get; set; }
    }
}