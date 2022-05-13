using AnnoChatMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoChatMaui.Views.Chat 
{
    public class ChatMessageDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ReceiveMessageTemplate { get; set; }
        public DataTemplate SendMessageTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            ChatMessage chatMessage = item as ChatMessage;

            if (chatMessage.Owner == MessageOwner.CurrentUser)
            {
                return SendMessageTemplate;
            }
            else
            {
                return ReceiveMessageTemplate;
            }


        }
    }
}
