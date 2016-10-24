using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using FriendStorageXF2.Model;

namespace FriendStorageXF2.DataAccess
{
	public class FriendDataService : IDataService
	{
		public FriendDataService()
		{
		}

		public void DeleteFriend(int friendId)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Friend> GetAllFriends()
		{
			throw new NotImplementedException();
		}

		public Friend GetFriendById(int friendId)
		{
			var friends = ReadFromFile();
			return friends.Single(f => f.Id == friendId);
		}

		public void SaveFriend(Friend friend)
		{
			throw new NotImplementedException();
		}

		private List<Friend> ReadFromFile()
		{
			return new List<Friend>
				{
					new Friend{Id=1,FirstName = "Thomas",LastName="Huber",
						Birthday = new DateTime(1980,10,28), IsDeveloper = true},
					new Friend{Id=2,FirstName = "Jon",LastName="Bachman",
						Birthday = new DateTime(1970,11,11)},
					new Friend{Id=3,FirstName="Christine",LastName="Whelp",
						Birthday = new DateTime(1979,02,02)},
					new Friend{Id=4,FirstName="Emma",LastName="Smelt",
						Birthday = new DateTime(2002,10,10)},
					new Friend{Id=5,FirstName = "Bella",LastName="Welsch",
						Birthday = new DateTime(2007,03,03), IsDeveloper = true},
					new Friend{Id=6,FirstName="Urs",LastName="Meier",
						Birthday = new DateTime(1970,03,5), IsDeveloper = true},
					 new Friend{Id=7,FirstName="Chrissi",LastName="Heuberger",
						Birthday = new DateTime(1987,07,16)},
					 new Friend{Id=8,FirstName="Erkan",LastName="Egin",
						Birthday = new DateTime(1983,05,23)},
				};
		}
	}
}
