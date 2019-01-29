﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Patterns.DataSources.Fakes;
using Havit.Data.EntityFrameworkCore.Patterns.SoftDeletes;
using Havit.Data.Patterns.Attributes;

namespace Havit.Distiller.DataLayer.DataSources.Security.Fakes
{
	[Fake]
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public class FakeLoginAccountDataSource : FakeDataSource<Havit.Distiller.Model.Security.LoginAccount>, Havit.Distiller.DataLayer.DataSources.Security.ILoginAccountDataSource
	{
		public FakeLoginAccountDataSource(params Havit.Distiller.Model.Security.LoginAccount[] data)
			: this((IEnumerable<Havit.Distiller.Model.Security.LoginAccount>)data)
		{			
		}

		public FakeLoginAccountDataSource(IEnumerable<Havit.Distiller.Model.Security.LoginAccount> data, ISoftDeleteManager softDeleteManager = null)
			: base(data, softDeleteManager)
		{
		}
	}
}