namespace Stock_MVC.Models {
    public class Departamento {
        public int DepartamentoId { get; set; }

        public string DepartamentoNome { get; set; }

        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
