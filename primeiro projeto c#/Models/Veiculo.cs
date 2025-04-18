﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace primeiro_projeto_c_.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int AnoModelo { get; set; }
    }
}
