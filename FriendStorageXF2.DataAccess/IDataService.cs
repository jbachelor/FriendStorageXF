using System;
using System.Collections.Generic;
using FriendStorageXF2.Model;

namespace FriendStorageXF2.DataAccess
{
	public interface IDataService : IDisposable
	{
		Friend GetFriendById(int friendId);
		IEnumerable<Friend> GetAllFriends();
		void SaveFriend(Friend friend);
		void DeleteFriend(int friendId);
	}
}
