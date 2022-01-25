using ServerAPI.Models;

namespace ServerAPI.Persistencia
{
    public class LocalizacaoEntregadorDAL
    {
		private CCFoodsContext _context;
		public LocalizacaoEntregadorDAL(CCFoodsContext context)
		{
			_context = context;
		}

		public IEnumerable<LocalizacaoEntregador> GetAll()
		{
			return _context.Localizacoes;
		}
		public void Insert(LocalizacaoEntregador localizacao)
		{
			_context.Localizacoes.Add(localizacao);
			_context.SaveChanges();
		}
	}
}
