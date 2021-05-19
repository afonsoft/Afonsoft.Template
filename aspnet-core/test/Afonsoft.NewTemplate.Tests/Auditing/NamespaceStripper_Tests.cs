using Afonsoft.NewTemplate.Auditing;
using Afonsoft.NewTemplate.Test.Base;
using Shouldly;
using Xunit;

namespace Afonsoft.NewTemplate.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Afonsoft.NewTemplate.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Afonsoft.NewTemplate.Auditing.GenericEntityService`1[[Afonsoft.NewTemplate.Storage.BinaryObject, Afonsoft.NewTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Afonsoft.NewTemplate.Auditing.XEntityService`1[Afonsoft.NewTemplate.Auditing.AService`5[[Afonsoft.NewTemplate.Storage.BinaryObject, Afonsoft.NewTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Afonsoft.NewTemplate.Storage.TestObject, Afonsoft.NewTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
