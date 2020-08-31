using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Database
{
    public class MemeDatabase
    {
        Models.lndbContext db = new Models.lndbContext();

        public Models.TbMemelation Salvar (Models.TbMemelation tb)
        {
            db.Add(tb);
            db.SaveChanges();

            return tb;
        }

        public List<Models.TbMemelation> Listar ()
        {
            return db.TbMemelation.ToList();
        }

        public Models.TbMemelation Deletar (int id)
        {
            Models.TbMemelation tb = 
                db.TbMemelation.FirstOrDefault(x => x.IdMemelation == id);
        
            if (tb != null)
            {
                db.TbMemelation.Remove(tb);
                db.SaveChanges();
            }

            return tb;
        }

        public Models.TbMemelation Alterar (int id, Models.TbMemelation novaTb)
        {
            Models.TbMemelation tb = 
                db.TbMemelation.FirstOrDefault(x => x.IdMemelation == id);

            if (tb != null)
            {
                tb.NmAutor = novaTb.NmAutor;
                tb.DsCategoria = novaTb.DsCategoria;
                tb.DsHashtags = novaTb.DsHashtags;
                tb.BtMaior = novaTb.BtMaior;
                tb.DtInclusao = novaTb.DtInclusao;
                tb.ImgMeme=novaTb.ImgMeme;
                
                db.SaveChanges();
            }

            return tb;
        }

        Models.Response.MemesPorCategoriaResponse MemesPorCategoria()
        {
            List<Models.TbMemelation> MemesDB = db.TbMemelation.ToList();
            List<Models.Response.MemesPorCategoriaResponse> memesCategoria = new List<Models.Response.MemesPorCategoriaResponse>();

            return null;
        }
        
    }
}