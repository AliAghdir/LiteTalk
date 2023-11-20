using LiteTalk.Data.Entities.Chats;

namespace CoreLayer.Services.Chats
{
    public interface IChatService
    {
        Task SendMessage(Chat chat);
    }
}