// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServer.Azure
{
	[Table("TemporalTestHistory")]
	public class TemporalTestHistory
	{
		[Column("ID"       , DataType = LinqToDB.DataType.Int32    , DbType = "int"          , SkipOnInsert = true, SkipOnUpdate = true                     )] public SqlInt32    Id        { get; set; } // int
		[Column("Name"     , DataType = LinqToDB.DataType.NVarChar , DbType = "nvarchar(100)", Length       = 100 , SkipOnInsert = true, SkipOnUpdate = true)] public SqlString   Name      { get; set; } // nvarchar(100)
		[Column("StartedOn", DataType = LinqToDB.DataType.DateTime2, DbType = "datetime2(7)" , Precision    = 7   , SkipOnInsert = true, SkipOnUpdate = true)] public SqlDateTime StartedOn { get; set; } // datetime2(7)
		[Column("EndedOn"  , DataType = LinqToDB.DataType.DateTime2, DbType = "datetime2(7)" , Precision    = 7   , SkipOnInsert = true, SkipOnUpdate = true)] public SqlDateTime EndedOn   { get; set; } // datetime2(7)
	}
}
