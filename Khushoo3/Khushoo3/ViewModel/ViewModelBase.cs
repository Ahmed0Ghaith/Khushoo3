﻿using Khushoo3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Khushoo3.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {

      

        private DateTimeOffset _Timestamp ;
        public DateTimeOffset Timestamp
        {
            get => _Timestamp;
            set => SetProperty(ref _Timestamp, value);
        }
    
        public  double _Latitude = 30.0456926;
        public double Latitude 
        {
            get => _Latitude;
            set => SetProperty(ref _Latitude, value);
        }
        public  double _Longitude = 31.2648738;
        public double Longitude
        {
            get => _Longitude;
            set => SetProperty(ref _Longitude, value);
        }

      

        public string day
        {
            get => DateTime.Now.ToString("dddd", new CultureInfo("ar-AE"));

        }


  

        private bool _isErrorState = false;
        public bool IsErrorState
        {
            get => _isErrorState;
            set => SetProperty(ref _isErrorState, value);
        }

        private string _errorMessage = string.Empty;
        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        private string _errorImage = string.Empty;
        public string ErrorImage
        {
            get => _errorImage;
            set => SetProperty(ref _errorImage, value);
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;

            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
