using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CodigoClase20MVVM.ViewModel
{
    public class CalculadoraViewModel: ViewModelBase
    {
        #region Propieades        

        private int _Valor1;
        public int Valor1
        {
            get { return _Valor1; }
            set
            {
                _Valor1 = value;
                OnPropertyChanged(nameof(Valor1));
            }
        }

        private int _Valor2;
        public int Valor2
        {
            get { return _Valor2; }
            set
            {
                _Valor2 = value;
                OnPropertyChanged(nameof(Valor2));
            }
        }

        private int _Resultado;
        public int Resultado
        {
            get { return _Resultado; }
            set
            {
                _Resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        private int _ResultadoResta;
        public int ResultadoResta
        {
            get { return _ResultadoResta; }
            set
            {
                _ResultadoResta = value;
                OnPropertyChanged(nameof(ResultadoResta));
            }
        }

        private int _ResultadoProducto;
        public int ResultadoProducto
        {
            get { return _ResultadoProducto; }
            set
            {
                _ResultadoProducto = value;
                OnPropertyChanged(nameof(ResultadoProducto));
            }
        }

        private double _ResultadoPotencia;
        public double ResultadoPotencia
        {
            get { return _ResultadoPotencia; }
            set
            {
                _ResultadoPotencia = value;
                OnPropertyChanged(nameof(ResultadoPotencia));
            }
        }


        #endregion

        #region Comandos

       
        //public RelayCommand<string> SumarCommand { get; }
        public RelayCommand SumarCommand { get; }
        public RelayCommand RestarCommand { get; }
        public RelayCommand MultiplicarCommand { get; }

        //Comando recibiendo un parámetro
        public RelayCommand<string> ElevarCommand { get; }


        #endregion

        //
        public CalculadoraViewModel()
        {

            MultiplicarCommand = new RelayCommand(Multiplicar);
            //SumarCommand = new RelayCommand(Sumar);
            SumarCommand = new RelayCommand(Sumar);
            //SumarCommand = new RelayCommand<string>((s) => Sumar(s));
            RestarCommand = new RelayCommand(Restar);

            ElevarCommand = new RelayCommand<string>((s) => Elevar(s));

        }

        #region Métodos Privados

        public void Elevar(string potencia)
        {
            ResultadoPotencia = Math.Pow(Valor1, Convert.ToInt32( potencia));
        }



        public void Sumar()
        {           
            Resultado = Valor1 + Valor2;
        }

        public void Restar()
        {
            ResultadoResta =  Convert.ToInt32( Valor1) -  Convert.ToInt32( Valor2);
        }

        public void Multiplicar()
        {
            ResultadoProducto = Convert.ToInt32(Valor1) * Convert.ToInt32(Valor2);
        }
       


        #endregion

    }
}
