using Exercise_2_Crud_Employees.Models;
using Exercise_2_Crud_Employees.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_2_Crud_Employees.Controllers
{
    [Route("api/[controller]")] 
    [ApiController] 
    public class EmployeesController : ControllerBase
    {
        protected IRepositoryEmployees _employees;

        //Se Inyecta el repositorio para hacer uso de la implementacion en el controller
        public EmployeesController(IRepositoryEmployees employees)
        {
            _employees = employees;
            
        }
       
        [HttpGet]
        public IActionResult Listar()
        {

            return Ok(_employees.Listar());
            

        }
        [HttpPost]
        public IActionResult Create(Employees employees)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }
            

            try
            {
                return Ok(new
                {
                    Message = "Registro creado",
                    Data= _employees.Insertar(employees)
                });
            }
            catch (Exception ex )
            {

                return BadRequest($"Ocurrio un error: {ex.Message}");
            }
        }
        [HttpPut]
        public IActionResult Editar(Employees employees)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }
            try
            {
                return Ok(new
                {
                    Message = "Registro modificado",
                    Data = _employees.Actualizar(employees)
                });
                
            }
            catch (Exception ex )
            {

                return BadRequest($"Ha ocurrido un error :{ex.Message}");
            }
        }
        [HttpDelete("{employeeId}")]
        public IActionResult Eliminar(Guid employeeId)
        {
          
            try
            {
                _employees.Eliminar(employeeId);

                return Ok($" Registro Eliminado  {employeeId}");

            }
            catch (Exception ex)
            {

                return BadRequest($"Ha ocurrido un error: {ex.Message}");
            }
        }
        [HttpGet("{employeeId}")]
        public IActionResult BuscarById(Guid employeeId)
        {
            try
            {
                return Ok(new
                {
                    Message = "Elemento encontrado",
                    Data = _employees.GetById(employeeId)
                });
            }
            catch (Exception ex )
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}"); throw;
            }
        }
    }
}
