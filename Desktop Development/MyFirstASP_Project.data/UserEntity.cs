using MyFirstASP_Project.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstASP_Project.data
{
	public class UserEntity : IDataHelper <User>
	{
		private List<User> ListOfUser;
		private User user;
		public UserEntity()
		{
			ListOfUser = new List<User>()
			{
				new User(){Id = 1,Name= "MHD Jihad",Email = "Jihad@gmail.com",Password = "12341234",Phone = "0937793120",Bio = ".Net Dev"},
			new User() { Id = 2, Name = "Khaled ali", Email = "Jihad@gmail.com", Password = "12341234", Phone = "0937793120", Bio = ".Net Dev" },
				new User(){Id = 3,Name= "Abood",Email = "Jihad@gmail.com",Password = "12341234",Phone = "0937793120",Bio = ".Net Dev"},
			new User() { Id = 4, Name = "Abu Hadhod", Email = "Jihad@gmail.com", Password = "12341234", Phone = "0937793120", Bio = ".Net Dev" },
			};
			
		}
		public void Add(User table)
		{
			ListOfUser.Add(table);
		}

		public void Delete(int ID)
		{
			 user = GetById(ID);
			ListOfUser.Remove(user);
		}

		public void Edit(int ID, User table)
		{
			user= GetById(ID);
			user = new User
			{
				Bio = table.Bio,
				Email = table.Email,
				Phone = table.Phone,
				Name = table.Name,
				Password = table.Password,
			};
		}

		public User GetById(int id)
		{
			return ListOfUser.Where(x => x.Id == id).First();
		}

		public List<User> GetData()
		{
			return ListOfUser;
		}

		public List<User> Search(string SearchItem)
		{
			return ListOfUser.Where(x => x.Id.ToString() == SearchItem
			|| x.Name.Contains(SearchItem)
			|| x.Password.Contains(SearchItem)
			|| x.Phone== SearchItem
			|| x.Email== SearchItem
			|| x.Bio.Contains(SearchItem)).ToList();

		}
	}
}
