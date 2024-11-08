using AutoMapper;
using Guest_Memorandum_API.Context.Models;
using Guest_Memorandum_Shared.Dtos;

namespace Guest_Memorandum_API.Extensions
{
    public class AutoMapperProFile
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<User, UserDto>().ReverseMap();
            configuration.CreateMap<ToDo, ToDoDto>().ReverseMap();
            configuration.CreateMap<Memo, MemoDto>().ReverseMap();
        }
    }
}