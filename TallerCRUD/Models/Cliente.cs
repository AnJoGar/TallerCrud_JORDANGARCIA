using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TallerCRUD.Models
{
  public class Cliente
  {
    public int Id { get; set; }
    public string Nombre { get; set; }

    public string Apellido { get; set; }


    public string Direccion { get; set; }


    public int Telefono { get; set; }


    public DateTime FechaNacimiento { get; set; }


    public String Estado { get; set; }



  }
}
