using System.ComponentModel.DataAnnotations;

namespace Exercise_2_Crud_Employees.Models
{
    public class Employees
    {
        public Employees(string firstName,string lastName,decimal salary)
        {
            this.EmployeeId = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
                
        }

        public Guid EmployeeId  { get; set; }
        
        [Required (ErrorMessage ="El FirstName es requerido")]
        [MaxLength(50,ErrorMessage ="Solo admite como maximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Solo admite como minimo 2 caracteres")]
        private string FirstName  {get;}


        [Required(ErrorMessage = "El LastName es requerido")]
        [MaxLength(50, ErrorMessage = "Solo admite como maximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Solo admite como minimo 2 caracteres")]
        public string LastName  {get;}

        [Required(ErrorMessage = "El Salary es requerido")]
        [Range(0, double.MaxValue, ErrorMessage = "El campo Salary debe ser un valor positivo.")]
        public decimal Salary  { get; }
    }
}
