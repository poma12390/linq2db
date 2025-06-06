// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SapHana
{
	[Table("AllTypesGeo")]
	public class AllTypesGeo : IEquatable<AllTypesGeo>
	{
		[Column("ID"                , DataType = LinqToDB.DataType.Int32  , DbType = "INTEGER"    , Length = 10, Precision = 10, Scale = 0, IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int     Id                 { get; set; } // INTEGER
		[Column("dataType"          , DataType = LinqToDB.DataType.VarChar, DbType = "VARCHAR(20)", Length = 20, Precision = 20                                                                                             )] public string? DataType           { get; set; } // VARCHAR(20)
		[Column("stgeometryDataType", DataType = LinqToDB.DataType.Udt    , DbType = "ST_GEOMETRY", Length = 8 , Precision = 8                                                                                              )] public byte[]? StgeometryDataType { get; set; } // ST_GEOMETRY

		#region IEquatable<T> support
		private static readonly IEqualityComparer<AllTypesGeo> _equalityComparer = ComparerBuilder.GetEqualityComparer<AllTypesGeo>(c => c.Id);

		public bool Equals(AllTypesGeo? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as AllTypesGeo);
		}
		#endregion
	}
}
