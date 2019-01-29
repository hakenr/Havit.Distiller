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
using Havit.Data.EntityFrameworkCore;
using Havit.Data.EntityFrameworkCore.Patterns.Caching;
using Havit.Data.EntityFrameworkCore.Patterns.Repositories;
using Havit.Data.EntityFrameworkCore.Patterns.SoftDeletes;
using Havit.Data.Patterns.DataEntries;
using Havit.Data.Patterns.DataLoaders;
using Havit.Data.Patterns.Infrastructure;

namespace Havit.Distiller.DataLayer.Repositories
{
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public abstract class DistillationResponseSetDbRepositoryBase : DbRepository<Havit.Distiller.Model.DistillationResponseSet>
	{
		protected DistillationResponseSetDbRepositoryBase(IDbContext dbContext, Havit.Distiller.DataLayer.DataSources.IDistillationResponseSetDataSource dataSource, IEntityKeyAccessor<Havit.Distiller.Model.DistillationResponseSet, int> entityKeyAccessor, IDataLoader dataLoader, IDataLoaderAsync dataLoaderAsync, ISoftDeleteManager softDeleteManager, IEntityCacheManager entityCacheManager)
			: base(dbContext, dataSource, entityKeyAccessor, dataLoader, dataLoaderAsync, softDeleteManager, entityCacheManager)
		{
		}

	}
}