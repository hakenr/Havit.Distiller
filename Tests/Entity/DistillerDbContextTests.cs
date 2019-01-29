using System;
using Havit.Distiller.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Havit.Distiller.Tests.Entity
{
	[TestClass]
	public class DistillerDbContextTests
	{
		[TestMethod]
		public void DistillerDbContext_CheckModelConventions()
		{
			// Arrange
			DbContextOptions<DistillerDbContext> options = new DbContextOptionsBuilder<DistillerDbContext>()
				.UseInMemoryDatabase(nameof(DistillerDbContext))
				.Options;
			DistillerDbContext dbContext = new DistillerDbContext(options);

			// Act
			Havit.Data.EntityFrameworkCore.ModelValidation.ModelValidator modelValidator = new Havit.Data.EntityFrameworkCore.ModelValidation.ModelValidator();
			string errors = modelValidator.Validate(dbContext);

			// Assert
			if (!String.IsNullOrEmpty(errors))
			{
				Assert.Fail(errors);
			}
		}
	}
}
