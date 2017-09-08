using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class UserRoleUpdateDTO
	{
		public int userId { get; set; }

		public int? oldRoleId { get; set; }

		public int? newRoleId { get; set; }
	}
}
