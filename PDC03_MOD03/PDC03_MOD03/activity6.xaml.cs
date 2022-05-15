﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity6 : ContentPage
    {
        public activity6()
        {
            InitializeComponent();


            this.BindingContext = this;
            this.IsBusy = false;
            this.BtnConnect.Clicked += BtnConnect_Clicked;
        }
        void BtnConnect_Clicked(object sender, EventArgs e)
        {
            this.IsBusy = true;
        }

    }

}