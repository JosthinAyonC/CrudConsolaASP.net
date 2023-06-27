using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app1_Migrations.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        
        public string Dirección { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        
        public string fechaDeNacimiento { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public Boolean Status { get; set; }

    }
}
