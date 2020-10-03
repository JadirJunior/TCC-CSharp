using PrjTreino.DAL;
using PrjTreino.DAL.models;
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

        public String iniciarSessao(Funcionario func)
        {

            resultado = login.iniciarSessao(func);
            if (login.Erro) { Erro = true; return "Ocorreu algum erro, tente novamente";  }
                
            if (resultado) { Erro = false; return "Bem vindo"; }

            return "Usuário ou senha incorretos";
        }

        public bool cadastrarFuncionario(Funcionario func)
        {

            resultado = login.CadastrarFuncionario(func);
            if (login.Erro) { Erro = true; return false; }


            if (resultado) { Erro = false; return true; }

            if (login.Erro ==false && resultado == false) { return false; }

            return false;
        }

        public bool atualizarFuncionario(Funcionario func)
        {
            resultado = login.atualizarUsuario(func);

            if (login.Erro) { Erro = true; return false; }

            if (resultado) { Erro = false; return true; }

            if (login.Erro == false && resultado ==false) { return false; }

            return false;
        }

        public bool atualizarFuncionarioComImagem(Funcionario func, String Caminho)
        {
            resultado = login.atualizarUsuarioComImagem(func, Caminho);

            if (login.Erro) { Erro = true; return false; }

            if (resultado) { Erro = false; return true; }

            if (login.Erro == false && resultado == false) { return false; }

            return false;
        }
    }
}
