namespace Stock_MVC.Models {
    public class Produto {

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool IsProdutoPreferido { get; set; }

        public bool EmEstoque { get; set; }

        public int DepartamentoId { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}
