using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoChatMaui.Models
{
    public class ChatMessage
    {
        public string MessageText { get; set; }

        public MessageOwner Owner { get; set; } 
    }
}
