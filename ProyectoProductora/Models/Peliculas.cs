using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoProductora.Models
{
   
    [Table("Productora")]
    public class Peliculas
    {
        [Key]
        [Column("Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codigo { get; set; }


        [Column("Nombre")]
        public String Nombre { get; set; }


        [Column("Capitulos")]
        public int Capitulos { get; set; }


        [Column("Tipo")]
        public String Tipo { get; set; }


        [Column("Descripcion")]
        public String Descripcion { get; set; }

        [Column("Protagonista")]
        public String Prota { get; set; }

        [Column("Coste")]
        public int Coste { get; set; }
    }
}




//1º mapeamos los campos de  producción con entity framework,
//2º vamos a hospital context