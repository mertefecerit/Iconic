﻿using System.ComponentModel;
using System.Windows.Media;

namespace Iconic.Models.Common
{
    public class NavbarItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ApplicationPage ApplicationPage { get; set; }
        public Geometry IconData { get; set; }
        public bool IsChecked { get; set; }
    }
}