namespace ProvaProd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contato")]
    public partial class Contato
    {
        [Key]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Telefone { get; set; }
    }
}
