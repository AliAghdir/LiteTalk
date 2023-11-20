using LiteTalk.Data.Context;
using LiteTalk.Data.Entities.Chats;

namespace LiteTalk.Core.Services.Chats
{
    public class ChatService : BaseService, IChatService
    {
        public ChatService(LiteTalkContext context) : base(context)
        {
        }

        public async Task SendMessage(Chat chat)
        {
            Insert(chat);
            await Save();
        }
    }
}