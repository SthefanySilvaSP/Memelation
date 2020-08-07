using System;
using System.Collections.Generic;


namespace backend.Utils
{
    public class ListaNegraConversor
    {
        public Models.TbListaNegra ParaTabela(Models.Request.ListaNegraRequest request)
        {
            Models.TbListaNegra ln = new Models.TbListaNegra();
            ln.NmPessoa = request.Nome;
            ln.DsMotivo = request.Motivo;
            ln.DtInclusao = DateTime.Now;

            return ln;
        }

        public Models.Response.ListaNegraResposne ParaResponse(Models.TbListaNegra ln)
        {
            Models.Response.ListaNegraResposne resp =new Models.Response.ListaNegraResposne();
            resp.Id = ln.IdListaNegra;
            resp.Nome = ln.NmPessoa;
            resp.Motivo = ln.DsMotivo;
            resp.Inclusao = ln.DtInclusao;
            return resp;
        }

        public List<Models.Response.ListaNegraResposne> ParaResponse(List<Models.TbListaNegra> lns)
        {
            List<Models.Response.ListaNegraResposne> resp = new List<Models.Response.ListaNegraResposne>();
            foreach (Models.TbListaNegra item in lns)
            {
                resp.Add(
                    this.ParaResponse(item));
            }
            return resp;
        }
    }
}