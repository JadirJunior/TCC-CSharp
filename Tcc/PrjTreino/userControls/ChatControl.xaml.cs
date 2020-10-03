using PrjTreino.Controles;
using PrjTreino.DAL.models;
using PrjTreino.userControls.Chat;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrjTreino.userControls
{
    /// <summary>
    /// Interação lógica para ChatControl.xam
    /// </summary>
    public partial class ChatControl : UserControl
    {
        public  Dictionary<String, CardChat> users = new Dictionary<string, CardChat>();
        public static ChatControl control;

        public void renderUsers()
        {
            FuncControler func = new FuncControler();
           List<Funcionario> funcs = func.selectAllFuncs();
            if (funcs.Count == 0) return;

            foreach (Funcionario f in funcs)
            {
                users.Add(f.Nome, new CardChat(f.Nome, f.Foto) {
                    Height = 60,
                    Cursor = Cursors.Hand
                });
            }
        }

        public void selectChat(String name, BitmapImage img)
        {
            ActualChat.Children.Clear();
            actualChat.Children.Add(new CardChat(name, img));
            chatInfo.Children.Clear();
            chatInfo.Children.Add(new ChatInfo(name,img));
            bodyChat.Children.Clear();
            bodyChat.Children.Add(new TalkMessage());
        }
       
        public ChatControl()
        {
            InitializeComponent();
            renderUsers();
            control = this;
            foreach (var user in users)
            {
                listContacts.Children.Add(user.Value);
            }
        }
    }
}
