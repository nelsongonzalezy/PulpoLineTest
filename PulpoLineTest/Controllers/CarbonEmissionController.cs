using DataService.Service;
using Microsoft.AspNetCore.Mvc;

namespace PulpoLineTest.Controllers
{
    public class CarbonEmissionController : BaseController
    {
        private readonly ICarbonEmission _Manager;

        public CarbonEmissionController(ICarbonEmission manager)
        {
            _Manager = manager;
 
        }

        [HttpGet(nameof(GetAll))]
        [ProducesResponseType(typeof(IEnumerable<CarbonEmissionModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _Manager.GetAll());
        } 
        [HttpGet(nameof(GetById))]
        [ProducesResponseType(typeof(CarbonEmissionModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await _Manager.GetById(Id));
        }        
        [HttpGet(nameof(GetByCompanyId))]
        [ProducesResponseType(typeof(CarbonEmissionModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByCompanyId(int CompanyId)
        {
            return Ok(await _Manager.GetByCompanyId(CompanyId));
        }       
        [HttpPost(nameof(Create))]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] CarbonEmissionModel model)
        {
            return Ok(await _Manager.CreateCarbonEmission(model));
        }        
        [HttpPut(nameof(Update))]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromBody] CarbonEmissionModel model)
        {
            return Ok(await _Manager.UpdateCarbonEmission(model));
        }        
        [HttpDelete(nameof(SoftDelete))]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SoftDelete(int Id)
        {
            return Ok(await _Manager.SoftDeleteCarbonEmission(Id));
        }       
        [HttpDelete(nameof(Delete))]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await _Manager.HardDeleteCarbonEmission(Id));
        }
    }
}
