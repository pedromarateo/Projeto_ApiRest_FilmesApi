using FilmesApi.Models;
using System.Collections.Generic;

namespace FilmesApi.Data.GerenteDTO
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public object Cinemas { get; set; }
    }
}
