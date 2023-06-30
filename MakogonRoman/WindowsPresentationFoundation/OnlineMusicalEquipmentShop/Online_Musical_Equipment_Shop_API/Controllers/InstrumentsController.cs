using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Online_Musical_Equipment_Shop_BLL.DTOs.RequestsDTOs;
using Online_Musical_Equipment_Shop_BLL.DTOs.ResponseDTOs;
using Online_Musical_Equipment_Shop_BLL.Services.Interfaces;
using Online_Musical_Equipment_Shop_DAL.Entities;
using System.Runtime.CompilerServices;

namespace Online_Musical_Equipment_Shop_API.Controllers
{
    [ApiController]
    [Route("api/instruments")]
    public class InstrumentsController : Controller
    {
        private readonly IInstrumentsService _instrumentsService;

        public InstrumentsController(IInstrumentsService instrumentsService)
        {
            _instrumentsService = instrumentsService;
        }

        /// <summary>
        /// Return_all_Instruments_with_pagination from the database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet, Route("Return_all_Instruments_with_pagination")]
        public async Task<ActionResult<IEnumerable<GetInstrumentsDTO>>> GetInstrumentsWithPaginationAsync([FromQuery] InstrumentParameters parameters)
        {
            try
            {
                var result = await _instrumentsService.GetInstrumentsWithPaginationAsync(parameters);
                return Ok(result);
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong... {exception.Message}");
            }
        }

        /// <summary>
        /// Return_all_Instruments_Sort_By_Name from the database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet, Route("Return_all_Instruments_Sort_By_Name")]
        public async Task<ActionResult<IEnumerable<GetInstrumentsDTO>>> GetInstrumentsSortByDescroptionAsync()
        {
            try
            {
                var result = await _instrumentsService.GetInstrumentsSortByDescroptionAsync();
                return Ok(result);
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong... {exception.Message}");
            }
        }

        /// <summary>
        /// Return_all_Instruments from the database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet, Route("Return_all_Instruments")]
        public async Task<ActionResult<IEnumerable<GetInstrumentsDTO>>> GetAllInstrumentsAsync(  )   
        {
            try
            {
                var result = await _instrumentsService.GetAllEntitiesAsync();
                return Ok(result);
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong... {exception.Message}");
            }
        }

        /// <summary>
        /// Return_Instrument_by_Id from the database
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet, Route("Return_Instrument_by_Id")]
        public async Task<ActionResult<GetInstrumentsDTO>> GetInstrumentsByIdAsync([FromQuery] Guid Id)
        {
            try
            {
                var result = await _instrumentsService.GetEntityByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong... {exception.Message}");
            }
        }

        /// <summary>
        /// Insert_Instrument_to_Database
        /// </summary>
        /// <param name="insertInstrumentsDTO"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost, Route("Insert_Instrument_to_Database")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetInstrumentsDTO>> InsertInstrumentAsync([FromBody] InsertInstrumentsDTO insertInstrumentsDTO)
        {
            try
            {
                var result = await _instrumentsService.InsertEntityAsync(insertInstrumentsDTO);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong... {exception.Message}");
            }
        }

        /// <summary>
        /// Update_Instrument_by_Id
        /// </summary>
        /// <param name="updateInstrumentsDTO"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPut, Route("Update_Instrument_by_Id")]
        public async Task<ActionResult<GetInstrumentsDTO>> UpdateInstrumentAsync([FromBody] UpdateInstrumentsDTO updateInstrumentsDTO)
        {
            try
            {
                var result = await _instrumentsService.UpdateEntityAsync(updateInstrumentsDTO);
                return Ok(result);
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong... {exception.Message}");
            }
        }

        /// <summary>
        /// Delete_Instrument
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpDelete, Route("Delete_Instrument/{id}")]
        public async Task<ActionResult<IEnumerable<GetInstrumentsDTO>>> DeleteInstrumentAsync(Guid Id)
        {
            try
            {
                var result = await _instrumentsService.DeleteEntityByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong... {exception.Message}");
            }
        }
    }
}
