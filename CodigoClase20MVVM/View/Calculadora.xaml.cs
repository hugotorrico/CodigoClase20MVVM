﻿using CodigoClase20MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CodigoClase20MVVM.View
{
    /// <summary>
    /// Lógica de interacción para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        ///Sergio Vallle

        //Hugo Torrico
        public Calculadora()
        {
            InitializeComponent();
            this.DataContext = new CalculadoraViewModel();
        }
    }
}
