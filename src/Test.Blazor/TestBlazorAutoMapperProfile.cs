using AutoMapper;
using Test.Books;

namespace Test.Blazor;

public class TestBlazorAutoMapperProfile : Profile
{
    public TestBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}
