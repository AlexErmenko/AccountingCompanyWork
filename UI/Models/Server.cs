﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace UI.Models
{
    public partial class Server
    {
        public Server()
        {
            Databases = new ObservableCollection<DataBase>();
        }
        [DisplayName("Код")]
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }

        public override string ToString() => $"{Name}";

        public virtual ObservableCollection<DataBase> Databases { get; set; }
    }
}