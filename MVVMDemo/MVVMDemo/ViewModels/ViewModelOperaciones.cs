using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    public class ViewModelOperaciones :ViewModelBase
    {

        #region  Atributos
        string message;
        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged();
                }
            }
        }


        double valorA;
        public double ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        double valorB;
        public double ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        double resultadoSuma, resultadoResta, resultadoMultiplicacion, resultadoDivision;
        public double ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        public double ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }


        public double ResultadoMultiplicacion
        {
            get { return resultadoMultiplicacion; }
            set
            {
                if (resultadoMultiplicacion != value)
                {
                    resultadoMultiplicacion = value;
                    OnPropertyChanged();
                }
            }
        }

        public double ResultadoDivision
        {
            get { return resultadoDivision; }
            set
            {
                if (resultadoDivision != value)
                {
                    resultadoDivision = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }



        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = Math.Round(ValorA + ValorB, 2);
            });

            Restar = new Command(()=>
            {
                ResultadoResta = Math.Round(ValorA - ValorB, 2);
            });

            Multiplicar = new Command(() =>
            {
                ResultadoMultiplicacion = Math.Round(ValorA * ValorB, 2);
            });

            Dividir = new Command(() =>
            {
                if (ValorB==0)
                {
                    Message = "Error: No puedes dividir entre 0";
                    ResultadoDivision = 0;
                }
                else
                {
                    ResultadoDivision = Math.Round(ValorA / ValorB,2);
                }

            });

        }       
    }
}
