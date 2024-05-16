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
        #endregion

        #region Comandos

        public RelayCommand SumarCommand { get; }

        #endregion

       
        public CalculadoraViewModel()
        {
            SumarCommand = new RelayCommand(Sumar);
        }

        #region Métodos Privados
        public void Sumar()
        {           
            Resultado = Valor1 + Valor2;
        }
        #endregion

    }
}
