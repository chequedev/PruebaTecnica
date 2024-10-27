using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Exercise_2_Crud_Employees.Models
{
    public class Employees
    {
       
        public Employees()
        {
            EmployeeId = Guid.NewGuid(); // Generar un nuevo ID si es necesario
        }

        [Key]
        public Guid EmployeeId  { get; set; }
        
        [Required (ErrorMessage ="El FirstName es requerido")]
        [MaxLength(50,ErrorMessage = "El FisrtName debe tener como maximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "El FirstName debe tener como minimo 3 caracteres")]
        public string FirstName  { get; set; }


        [Required(ErrorMessage = "El LastName es requerido")]
        [MaxLength(50, ErrorMessage = "El LastName debe tener como maximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "El LastName debe tener como minimo 3 caracteres")]
        public string LastName  { get; set; }

        

        [Required(ErrorMessage = "El Salary es requerido")]
        [Range(0, double.MaxValue, ErrorMessage = "El campo Salary debe ser un valor positivo.")]
        public decimal Salary  { get; set; }
    }
}
