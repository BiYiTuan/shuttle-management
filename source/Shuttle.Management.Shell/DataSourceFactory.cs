using Shuttle.Core.Data;

namespace Shuttle.Management.Shell
{
	public class DataSourceFactory
	{
		public static DataSource Create(string name)
		{
			return new DataSource(name, new SqlDbDataParameterFactory());
		}
	}
}