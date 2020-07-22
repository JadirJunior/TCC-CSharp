using PrjTreino.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.Controles
{
    public class loginControler
    {
        public bool resultado;
        public bool Erro = false;
        LoginComands login = new LoginComands();

        public String iniciarSessao(String Usuario, String senha)
        {

            resultado = login.iniciarSessao(Usuario, senha);
            if (login.Erro) { Erro = true; return "Ocorreu algum erro, tente novamente";  }
                
            if (resultado) { Erro = false; return "Bem vindo"; }

            return "Usuário ou senha incorretos";
        }

        public bool cadastrarFuncionario(String Usuario, String senha)
        {

            resultado = login.CadastrarFuncionario(Usuario, senha);
            if (login.Erro) { Erro = true; return false; }


            if (resultado) { Erro = false; return true; }

            if (login.Erro ==false && resultado == false) { return false; }

            return false;
        }

        public bool atualizarFuncionario(String Usuario, String Senha)
        {
            resultado = login.atualizarUsuario(Usuario, Senha);

            if (login.Erro) { Erro = true; return false; }

            if (resultado) { Erro = false; return true; }

            if (login.Erro == false && resultado ==false) { return false; }

            return false;
        }

        public bool atualizarFuncionarioComImagem(String Usuario, String Senha, String Caminho)
        {
            resultado = login.atualizarUsuarioComImagem(Usuario, Senha, Caminho);

            if (login.Erro) { Erro = true; return false; }

            if (resultado) { Erro = false; return true; }

            if (login.Erro == false && resultado == false) { return false; }

            return false;
        }
    }
}
