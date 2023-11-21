using LiteTalk.Data.Entities.Chats;

namespace LiteTalk.Core.Services.Chats
{
    public interface IChatService
    {
        Task SendMessage(Chat chat);
    }
}