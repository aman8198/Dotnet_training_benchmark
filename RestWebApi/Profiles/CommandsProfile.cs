using AutoMapper;
using RestWebApi.Dtos;
using RestWebApi.Models;

namespace RestWebApi.Profiles
{
   public class CommandsProfile : Profile{
      public CommandsProfile()
      {
          //source -> Target
          CreateMap<CommandsProfile, CommandReadDto>();
          CreateMap<CommandCreateDto, Command>();
          CreateMap<CommandUpdateDto, Command>();
          CreateMap<Command, CommandUpdateDto>();
      }
       

   }
}