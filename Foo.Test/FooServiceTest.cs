using Foo.Repository;
using Foo.Service;
using Foo.Test.Factories;
using NSubstitute;
using Xunit;

namespace Foo.Test
{
    public class FooServiceTest
    {
        private readonly FooService _fooService;
        private readonly FooRepository _fooRepository;

        public FooServiceTest()
        {
            _fooRepository = Substitute.For<FooRepository>();
            _fooService = new FooService(_fooRepository);
        }

        [Fact]
        public void When_Call_FooService_Then_Return_List_With_One_Foo()
        {
            _fooRepository.Returns(FooModelFactory.CreateFooModel());
            var listFooModel = _fooService.GetAll();
            Assert.NotNull(listFooModel);
        }
    }
}