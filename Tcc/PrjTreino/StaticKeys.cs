using PrjTreino.DAL.models;
using PrjTreino.userControls.Classes;
using PrjTreino.Utils;
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

        public static void resetKeys()
        {
            compromissos = null;
            funcionarios = null;
            _compromissos = null;
            chats = null;
            Chats = null;
            idFuncChat = 0;
            id_func = 0;
            notas = null;
            Notas = null;
            caminhoImagem = null;
        }

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
        private static List<Funcionario> _funcionarios = null;

        public static List<Funcionario> funcionarios
        {

            get
            {
                return _funcionarios;
            }
            set
            {
                _funcionarios = value;
            }

        }

        private static List<Compromisso> _compromissos = null;

        private static List<Message> chats = null;

        public static List<Message> Chats
        {
            get
            {
                return chats;
            } 
            set
            {
                chats = value;
            }
        }
        private static List<Nota> notas = null;

        public static List<Nota> Notas
        {

            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }

        }
        private static List<Postagem> postagens = null;

        public static List<Postagem> Postagens
        {
            get => postagens;

            set => postagens = value;
        }

        public static List<Compromisso> compromissos { get { return _compromissos; } set { _compromissos = value; } }

        public static String Senha { get; set; }

        public static int id_func { get; set; }

        public static bool Manter_conectado { get; set; }

        public static BitmapImage caminhoImagem { get; set; }

        private static int _idFuncChat = 0;
        public static int idFuncChat {
            get
            {
                return _idFuncChat;
            }
            set
            {
                _idFuncChat = value;
            }
        }


        public static DateTime dataMarcada { get {  return _datasMarcadas; } set { _datasMarcadas = value; } }
    }
}
