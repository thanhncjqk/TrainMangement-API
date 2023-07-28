using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController<T> : ControllerBase
    {
        private IBaseBL<T> _baseBL;

        public BasesController(IBaseBL<T> baseBL)
        {
            _baseBL = baseBL;
        }
        [HttpGet("{id}")]
        public virtual IActionResult GetRecordById([FromRoute] int id)
        {
            try
            {
                var record = _baseBL.GetRecordById(id);

                if (record != null)
                {
                    return StatusCode(200, record);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetFilterRecords([FromQuery] string? search, [FromQuery] int pageSize = 10, [FromQuery] int pageNumber = 1)
        {
            try
            {
                var records = _baseBL.GetFilterRecords(search, pageSize, pageNumber);

                if (records != null)
                {
                    return StatusCode(200, records);
                }
                else
                {
                    return StatusCode(500, "loi");
                }
            }
            catch (ValidateException ex)
            {
                var res = new
                {
                    devMsg = ex.Message,
                    userMsg = ex.Data
                };
                return StatusCode(400, res);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOneRecord([FromRoute] int id)
        {
            try
            {
                int a = _baseBL.DeleteOneRecord(id);

                if (a > 0)
                {
                    return StatusCode(200, id);
                }
                else
                {
                    return StatusCode(500, "e001");
                }
            }
           
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public virtual IActionResult InsertOneRecord([FromBody] T record)
        {
            try
            {
                int affectedRow = _baseBL.InsertOneRecord(record);

                if (affectedRow != 0)
                {
                    return StatusCode(201, affectedRow);
                }
                else
                {
                    return StatusCode(500, "e001");
                }
            }
            catch (ValidateException ex)
            {
                var res = new
                {
                    devMsg = ex.Message,
                    userMsg = ex.Data
                };
                return StatusCode(400, res);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{ID}")]
        public virtual IActionResult UpdateOneRecord([FromRoute] int ID, [FromBody] T record)
        {
            try
            {
                var recodID = _baseBL.UpdateOneRecord(ID, record);

                if (recodID != 0)
                {
                    return StatusCode(200, recodID);
                }
                else
                {
                    return StatusCode(500, "e001");
                }
            }
            catch (ValidateException ex)
            {
                var res = new
                {
                    devMsg = ex.Message,
                    userMssg = ex.Data
                };
                return StatusCode(400, res);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("multi_delete")]
        public virtual IActionResult DeleteMultiRecord([FromBody] List<int> ids)
        {
            try
            {
                var a = _baseBL.DeleteMutirecord(ids);

                if (a > 0)
                {
                    return StatusCode(200, a);
                }
                else
                {
                    return StatusCode(500, "e001");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
