using Foo.Model;
using Foo.Repository;

namespace Foo.Service
{
    public class FooService
    {
        private readonly FooRepository _fooRepository;
        public FooService(FooRepository fooRepository)
        {
            _fooRepository = fooRepository;
        }

        public IEnumerable<FooModel> GetAll()
        {
            // var foos = _fooRepository.GetAll();

            // if (foos is null || !foos.Any()) throw new Exception();

            return _fooRepository.GetAll();
        }

        public async Task<IEnumerable<FooModel>> GetAllAsync()
        {
            return await _fooRepository.GetAllAsync();
        }
    }
}