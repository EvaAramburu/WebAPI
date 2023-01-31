using Data;
using Entities.Entities;
using Logic.ILogic;
using Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public int InsertUser(UserEntity user)
        {
            _serviceContext.Users.Add(user);
            _serviceContext.SaveChanges();
            return user.Id;
        }

        List<UserEntity> IUserLogic.GetAllUsers()
        {
            return _serviceContext.Set<UserEntity>().ToList();
        }

        List<UserEntity> IUserLogic.GetSelectedUser(int id)
        {
            var selection = _serviceContext.Set<UserEntity>()
                .Where(u => u.Id == id).ToList();
            return selection;


        }

        void IUserLogic.DeactivateUser(int id)
        {
            var userToDeactivate = _serviceContext.Set<UserEntity>()
           .Where(u => u.Id == id).First();

            userToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }
        void IUserLogic.DeleteUser(int id)
        {
            //var userToDelete = _serviceContext.Set<UserEntity>().Where(u => u.Id == id).First();

            _serviceContext.Users.Remove(_serviceContext.Set<UserEntity>().Where(u => u.Id == id).First());
           
            _serviceContext.SaveChanges();

        }

        //void IUserLogic.UpdateUser(UserEntity user)
        //{

        //    var updatedUser = _serviceContext.Users.FirstOrDefault(u => u.Id == id);

        //    if (updatedUser == null)
        //    {
        //        return NotFound();
        //    }

            

        //    return Ok(updatedUser;
        //}




        //_serviceContext.Users.Update(user);
        //    _serviceContext.SaveChanges();
        //}
    }
}
