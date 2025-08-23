
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
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.Usuario.nombre)); // Mapear el nombre del autor

    
        }
    }
}
