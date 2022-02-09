using Foo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo.Repository
{
    public class FooRepository
    {
        private readonly AppDbContext _appDbContext;
        public FooRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<FooModel> GetAll()
        {
            return _appDbContext.Foos.ToList();
        }

        public async Task<IEnumerable<FooModel>> GetAllAsync()
        {
            return await _appDbContext.Foos.ToListAsync();
        }

        public void Returns(IEnumerable<FooModel> enumerable)
        {
            throw new NotImplementedException();
        }
    }
}
