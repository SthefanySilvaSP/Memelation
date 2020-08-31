using System.Collections.Generic;


namespace backend.Models.Response
{
    public class MemePorCategoria
    {
        public List<MemeResponse> Meme { get; set; }
    }

    public class MemesPorCategoriaResponse 
    {
        public List<MemePorCategoria> Meme { get; set; }
    }

}