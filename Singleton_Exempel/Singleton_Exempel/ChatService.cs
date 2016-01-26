using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Singleton_Exempel;

namespace Singleton_Exempel
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

        [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChatService
    {
        readonly List<Chat> _chats = new List<Chat>();
        public void SubmitChat(Chat chat)
        {
            chat.Id = Guid.NewGuid().ToString();
            _chats.Add(chat);
        }

        public List<Chat> GetChats()
        {
            return _chats;
        }

        public void RemoveEval(string id)
        {
            _chats.Remove(_chats.Find(x => x.Id.Equals(id)));
        }
    }
}
