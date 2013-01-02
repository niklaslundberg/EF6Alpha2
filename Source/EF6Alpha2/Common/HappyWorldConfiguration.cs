using System.Data.Entity.Config;
using System.Data.Entity.Infrastructure;

namespace EF6Alpha2.Common
{
	public class HappyWorldConfiguration : DbConfiguration
	{
		public HappyWorldConfiguration()
		{
			SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0",
			                                                         "server=localhost; Integrated Security=True; MultipleActiveResultSets=True"));
		}
	}
}