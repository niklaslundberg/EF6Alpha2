using System;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace EF6Alpha2.Common
{
	internal class DefaultDateTimeColumnTypeConvention
		: IConfigurationConvention<PropertyInfo, DateTimePropertyConfiguration>
	{
		public void Apply(
			PropertyInfo propertyInfo,
			Func<DateTimePropertyConfiguration> configuration)
		{
			if (configuration().ColumnType == null)
			{
				configuration().ColumnType = "datetime2";
			}
		}
	}
}