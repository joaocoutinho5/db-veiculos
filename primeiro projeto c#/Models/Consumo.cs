﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace primeiro_projeto_c_.Models
{
    [Tags("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage= "Obrigatório adicionar uma descrição")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem")]
        public int Km { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo de combustível")]
        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel
    }
}
