using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos.Requests
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
