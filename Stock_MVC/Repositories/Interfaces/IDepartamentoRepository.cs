using Stock_MVC.Models;

namespace Stock_MVC.Repositories.Interfaces {
    public interface IDepartamentoRepository {

        IEnumerable<Departamento> Departamentos { get; }
    }
}
