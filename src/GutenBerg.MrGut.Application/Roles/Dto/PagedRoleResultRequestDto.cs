using Abp.Application.Services.Dto;

namespace GutenBerg.MrGut.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

