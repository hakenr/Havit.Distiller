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

namespace Havit.Distiller.DataLayer.DataSources.Fakes
{
	[Fake]
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public class FakeDistillationScopeDataSource : FakeDataSource<Havit.Distiller.Model.DistillationScope>, Havit.Distiller.DataLayer.DataSources.IDistillationScopeDataSource
	{
		public FakeDistillationScopeDataSource(params Havit.Distiller.Model.DistillationScope[] data)
			: this((IEnumerable<Havit.Distiller.Model.DistillationScope>)data)
		{			
		}

		public FakeDistillationScopeDataSource(IEnumerable<Havit.Distiller.Model.DistillationScope> data, ISoftDeleteManager softDeleteManager = null)
			: base(data, softDeleteManager)
		{
		}
	}
}