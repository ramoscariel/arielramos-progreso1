using System.ComponentModel.DataAnnotations;

namespace arielramos_progreso1.Models
{
    public class ArielRamos_Tabla
    {
        public int Id { get; set; }
        [ValidarPeso] public decimal ArPesoKilogramos { get; set; }
        [Range(0.4,2.20)]public decimal ArAlturaM { get; set; }
        [StringLength(25)] public string? ArNombre { get; set; }
        [Required] public bool ArEmpleado { get; set; }
        [ValidarFecha] public DateTime ArFechaIngreso { get; set; }

    }
    public class ValidarFecha : ValidationAttribute 
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;

            DateTime d = (DateTime)value;
            if (d.Day != DateTime.Now.Day)
            {
                return false;
            }
            else 
            {
                return true;
            }

        }
    }
    public class ValidarPeso : ValidationAttribute 
    {
        public override bool IsValid(object? value)
        {
            if(value == null) return false;
            decimal d = (decimal)value;
            if (d < (decimal)80.7)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
