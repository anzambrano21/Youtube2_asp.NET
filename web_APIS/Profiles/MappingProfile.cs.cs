
using AutoMapper;
using web_APIS.Dto;
using web_APIS.Models;
namespace web_APIS.Profiles

{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<Usuario, UsuarioVideo>(); // Necesitarás mapear los libros explícitamente
            CreateMap<Videos, VideoDto>()
                .ForMember(dest => dest.UsuarioID, opt => opt.MapFrom(src => src.Usuario.ID)); // Mapear el nombre del autor

    
        }
    }
}
