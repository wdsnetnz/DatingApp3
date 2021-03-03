using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.api.Extensions;
using DatingApp.api.Models;

namespace DatingApp.api.Data
{
    public interface IDatingRepository
    {
         // Creating CRUD methods for user and photos entities.

         //add T type of user and add entity as parameter where T: as class
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         // Pagination changing IEnumerable to PagedList
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int Id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
         Task<Like> GetLike(int userId, int recipientId);
        Task<Message> GetMessage(int id);
        Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId);

    }
}