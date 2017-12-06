using System;
using System.Collections.Generic;
using System.Linq;
using KupcheAspNetCore.Models;
using KupcheAspNetCore.Helpers;

namespace KupcheAspNetCore.Services
{
    public interface IUserService
    {
        Users Authenticate(string username, string pass);
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        Users Create(Users user, string pass);
        void Update(Users user,string pass);
        void Delete(int id);
    }
    public class UserService : IUserService
    {
        private servicedbContext _context ;
        public UserService(servicedbContext context)
        {
            _context = context;
        }
        public Users Authenticate(string username, string pass)
        {
            if( string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(pass) ) 
                return null;

            var user = _context.Users.SingleOrDefault(x => x.Email == username);

            if(user == null) 
                return null;
            if(!VerifyPasswordHash(pass,user.PassHash,user.PassSalt))
                return null;
            return user;
        }
        public IEnumerable<Users> GetAll()
        {
            return _context.Users;
        }
        public Users GetById(int id)
        {
            return _context.Users.Find(id);
        }
        public Users Create(Users user, string pass)
        {
            if(string.IsNullOrWhiteSpace(pass))
                throw new AppException("Password is required");
            if(_context.Users.Any(x => x.Email == user.Email))
                throw new ApplicationException("Username "+user.Email+" is already taken");
            byte[] passHash,passSalt;
            CreatePasswordHash(pass,out passHash,out passSalt);
            user.PassHash = passHash;
            user.PassSalt = passSalt;

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public void Update(Users userParam,string pass)
        {
            var userUpd = _context.Users.Find(userParam.IdUsers);
            if(userUpd == null) 
                throw new AppException("User not found!");
            if(userParam.Email != userUpd.Email)
            {
                if( _context.Users.Any(x => x.Email == userParam.Email) )
                    throw new AppException("Email " + userParam + " is already");
            }
            userUpd.FirstName = userParam.FirstName;
            userUpd.LastName = userParam.LastName;
            userUpd.SecondName = userParam.SecondName;
            userUpd.Telephone = userParam.Telephone;
            userUpd.PositionId = userParam.PositionId;
            userUpd.RulesId = userParam.RulesId;
            userUpd.CompanyId = userParam.CompanyId;
            if(!string.IsNullOrWhiteSpace(pass))
            {
                byte[] passHash,passSalt;
                CreatePasswordHash(pass, out passHash, out passSalt);

                userUpd.PassHash = passHash;
                userUpd.PassSalt = passSalt;
            }
            _context.Users.Update(userUpd);
            _context.SaveChanges();    


        }
        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if(user !=null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
 
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
 
        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");
 
            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
 
            return true;
        }
        
    }
}