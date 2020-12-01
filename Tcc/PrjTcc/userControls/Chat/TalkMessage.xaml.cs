using PrjTreino.Controles;
using PrjTreino.DAL.models;
using PrjTreino.Utils;
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

namespace PrjTreino.userControls.Chat
{
    /// <summary>
    /// Interação lógica para TalkMessage.xaml
    /// </summary>
    /// 

    public partial class TalkMessage : UserControl 
    {
        public static TalkMessage talk;

        private void messageWhite()
        {
            messages.Items.Add(new ListViewItem()
            {
                Content = "",
                HorizontalAlignment = HorizontalAlignment.Right,
                Background = Brushes.Transparent
            });
        }

        public TalkMessage()
        {
            InitializeComponent();
            talk = this;

           //Socket.client.Emit("render Messages");
           renderMessages(ControllerMessages.getMessages());
        }

        public TalkMessage(double width)
        {
            InitializeComponent();
            talk = this;
            this.Width = width;
            //Socket.client.Emit("render Messages");
            renderMessages(ControllerMessages.getMessages());
        }

        public void renderMessages(List<Message> mensagens)
        {
            if (mensagens.Count == 0) return;

            foreach (var m in mensagens)
            {
                if (m.Author != StaticKeys.id_func.ToString() && m.Author != StaticKeys.idFuncChat.ToString()) continue;

                if (m.Destinatario != StaticKeys.idFuncChat.ToString() && m.Author == StaticKeys.id_func.ToString()) continue;

                if (m.Destinatario != StaticKeys.idFuncChat.ToString() && m.Destinatario != StaticKeys.id_func.ToString()) continue;

                    messages.Items.Add(new ListViewItem()
                    {
                        Content = m.Content,
                        HorizontalAlignment = m.Author == StaticKeys.id_func.ToString() ? HorizontalAlignment.Right : HorizontalAlignment.Left,
                        Background = m.Author == StaticKeys.id_func.ToString() ? Brushes.LightGray : Brushes.LightBlue,
                        Opacity = 0.4
                    });
                messageWhite();
            }
        }

        private void sendMessage()
        {
            Socket.send(new Message()
            {
                Author = StaticKeys.id_func.ToString(),
                Content = txtMessage.Text,
                Destinatario = StaticKeys.idFuncChat.ToString()
            });

            String text = txtMessage.Text;

            if (text.Trim() == "") return;

            int length = txtMessage.Text.Length;
            if (length < 30)
            {
                messages.Items.Add(new ListViewItem()
                {
                    Content = text,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Background = Brushes.LightGray,
                    Opacity = 0.4
                });
                txtMessage.Text = "";

            } 
            else
            {
                char[] letras = text.ToCharArray();
                String content = "";
                for (int j = 0; j < letras.Length; j++)
                {
                    content += letras[j];
                    if (j % 30 == 0 && j >= 30)
                    {
                        if (content != "")
                        {
                            messages.Items.Add(new ListViewItem()
                            {
                                Content = content,
                                HorizontalAlignment = HorizontalAlignment.Right,
                                Background = Brushes.LightGray,
                                Margin = new Thickness() { Right = 5 },
                                Opacity = 0.4
                            });
                            content = "";
                        }

                    }
                }
            }

            

            messageWhite();
            txtMessage.Text = "";
        }

        public void receiveMessage(Message message)
        {
            if (message.Author == StaticKeys.id_func.ToString()) return;

            if (message.Author != StaticKeys.idFuncChat.ToString()) return;

            String text = message.Content;

            if (text.Trim() == "") return;

            int length = text.Length;

            

            if (length < 30)
            {
                messages.Items.Add(new ListViewItem()
                {
                    Content = text,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Background = Brushes.LightBlue,
                    Margin = new Thickness() { Left = 5 },
                    Opacity = 0.4
                });
            } else
            {
                char[] letras = text.ToCharArray();
                String content = "";
                for (int j = 0; j < letras.Length; j++)
                {
                    content += letras[j];
                    if (j % 30 == 0 && j >= 30)
                    {
                        if (content != "")
                        {
                            messages.Items.Add(new ListViewItem()
                            {
                                Content = content,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Background = Brushes.LightBlue,
                                Margin = new Thickness() { Left = 5 },
                                Opacity = 0.4
                            });
                            content = "";
                        }

                    }
                }
            }

            
            messageWhite();
        }

        private void BtnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            sendMessage();
        }

        private void TxtMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txtMessage.IsFocused && txtMessage.Text != "")
            {
                sendMessage();
            }
        }
    }
}
