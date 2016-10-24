using System;

namespace FriendStorageXF2.Model
{
	public class Friend
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string DisplayName
		{
			get { return $"{FirstName} {LastName}"; }
		}
		public DateTime? Birthday { get; set; }
		public string DisplayBirthday
		{
			get
			{
				if (Birthday != null)
					return $"{Birthday?.Year}/{Birthday?.Month}/{Birthday?.Day}";
				else
					return string.Empty;
			}
		}
		public bool IsDeveloper { get; set; }
	}
}
