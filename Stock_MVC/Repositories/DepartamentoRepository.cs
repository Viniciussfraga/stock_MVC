using Stock_MVC.Context;
using Stock_MVC.Models;
using Stock_MVC.Repositories.Interfaces;

namespace Stock_MVC.Repositories {
    public class DepartamentoRepository : IDepartamentoRepository {
        private readonly AppDbContext _context;

        public DepartamentoRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Departamento> Departamentos => _context.Departamentos;
    }
}
