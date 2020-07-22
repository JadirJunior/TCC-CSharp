using PrjTreino.userControls.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PrjTreino
{

    public class trocaProp : INotifyPropertyChanged
    {
        private String _usuario;
        public  String Usuario {
            get
            {
                return _usuario;
            }

            set
            {
                    _usuario = value;
                    NotifyPropertyChanged("Usuario");
            }
        } 

        public void NotifyPropertyChanged(String propName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public static class StaticKeys
    {
        private static String _usuario;
        public static DateTime _datasMarcadas;
        public static String Usuario {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
                trocaProp troca = new trocaProp();
                troca.Usuario = _usuario;
            }
        }
        private static List<Compromisso> _compromissos = null;

        public static List<Compromisso> compromissos { get { return _compromissos; } set { _compromissos = value; } }

        public static String Senha { get; set; }

        public static int id_func { get; set; }

        public static bool Manter_conectado { get; set; }

        public static BitmapImage caminhoImagem { get; set; }

        public static DateTime dataMarcada { get {  return _datasMarcadas; } set { _datasMarcadas = value; } }
    }
}
