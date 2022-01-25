using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Models;
using ServerAPI.Persistencia;

namespace ServerAPI.Controllers
{
    [ApiController]
    public class LocalizacaoEntregadorController : ControllerBase
    {
        private readonly CCFoodsContext _context;
        private readonly LocalizacaoEntregadorDAL localizacaoDAL;

        public LocalizacaoEntregadorController(CCFoodsContext context)
        {
            _context = context;
            localizacaoDAL = new LocalizacaoEntregadorDAL(context);
        }

        //	GET
        [Route("localizacao/todos")]
        public IEnumerable<LocalizacaoEntregador> Get()
        {
            return localizacaoDAL.GetAll();
        }

        [Route("localizacao/insert")]
        public void PostInsertGarcom(LocalizacaoEntregador localizacao)
        {
            localizacao.OperacaoSincronismo = Models.Enums.OperacaoSincronismo.Sincronizado;
            localizacaoDAL.Insert(localizacao);
        }
    }
}
