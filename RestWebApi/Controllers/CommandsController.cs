using System.Collections.Generic;
using RestWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using RestWebApi.Data;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using RestWebApi.Dtos;

namespace RestWebApi.Controllers
{

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommandRepo repository, IMapper mapper)
        {
           _repository = repository;
           _mapper = mapper;
        } 
       // private readonly MockCommandRepo _repository = new MockCommandRepo();

        /*

         //Get api/Commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var CommandItems = _repository.GetAllCommands();
            return Ok(CommandItems);

        }*/

        /*

        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var CommandItem = _repository.GetCommandById(id);
            if(CommandItem != null)
            {
               return Ok(CommandItem);
            }
            
            return NotFound();
        }*/

         //Get api/commands
         [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var CommandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(CommandItems));
        }
        
        //Get api/commands/{id}
        [HttpGet("{id}", Name="GetCommandById")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var CommandItem = _repository.GetCommandById(id);
            if(CommandItem != null){
                return Ok(_mapper.Map<CommandReadDto>(CommandItem));
            }
            return NotFound();
           
        }

        //post api/commands
        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
           var commandModel = _mapper.Map<Command>(commandCreateDto);
           _repository.CreateCommand(commandModel);
           _repository.saveChanges();

           var CommandReadDto = _mapper.Map<CommandReadDto>(commandModel);

           return CreatedAtRoute(nameof(GetCommandById), new {Id = CommandReadDto.Id}, CommandReadDto);

          // return Ok(CommandReadDto);
        }

        //PUT api/commands/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if(commandModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(commandUpdateDto, commandModelFromRepo);
            _repository.UpdateCommand(commandModelFromRepo);
            _repository.saveChanges();
            return NoContent();
            
        }

        

        //patch api/commands/{api}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDto> patchDoc)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if(commandModelFromRepo == null)
            {
               return NotFound();
            }

            var commandToPatch = _mapper.Map<CommandUpdateDto>(commandModelFromRepo);
            patchDoc.ApplyTo(commandToPatch, ModelState);

            if(!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(commandToPatch, commandModelFromRepo);
            _repository.UpdateCommand(commandModelFromRepo);
            _repository.saveChanges();
            return NoContent();
        }
        
        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if(commandModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteCommand(commandModelFromRepo);
            _repository.saveChanges();
            return NoContent();

        }


    }

}
