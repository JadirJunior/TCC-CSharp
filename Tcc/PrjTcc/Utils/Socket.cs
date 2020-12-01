using Newtonsoft.Json.Linq;
using PrjTreino.DAL.models;
using PrjTreino.userControls.Chat;
using SocketIOSharp.Client;
using System;
using System.Collections.Generic;
using System.Windows;

namespace PrjTreino.Utils
{
    public class Socket
    {
         public Message Mensagem { get; set; }

         public static SocketIOClient client = new SocketIOClient(new SocketIOClientOption(EngineIOSharp.Common.Enum.EngineIOScheme.http, "localhost", 3333));

        
         delegate void messageCallback(Message message);
       
        void receberMensagem(Message msg)
        {
            Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() => {

                if (msg.Content != "")
                {
                    if (msg.Author == StaticKeys.id_func.ToString() || msg.Author != StaticKeys.idFuncChat.ToString()) return;

                    try
                    {
                        TalkMessage.talk.receiveMessage(msg);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tente novamente, ocorreu um erro na comunicação.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                }
            }));
                
            
        }
        public Socket()
        {

            client.Connect();
            client.On("connection", () =>
            {
                Console.WriteLine("Conectado!");
            });

            client.On("messagesList", (JToken[] Data) => {
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() =>
                {
                    var list = Data[0];
                    List<Message> listaMensagens = new List<Message>();
                    foreach (var l in list)
                    {
                        listaMensagens.Add(l.ToObject<Message>());
                    }
                    TalkMessage.talk.renderMessages(listaMensagens);
                }));
               
            });

            client.On("messageReceived", (JToken[] Data) =>
            {
                Message message = Data[0].ToObject<Message>();
                if (message != null)
                {
                    receberMensagem(message);
                }
            });

        }
        public static void send(Message message)
        {
            client.Emit("chat message", message);
        }
    }
}
