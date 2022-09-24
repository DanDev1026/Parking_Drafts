using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Drafts.App.Dominio;
using Drafts.App.Persistencia;
namespace Drafts.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioCliente repositorio;
        public IEnumerable <Cliente> Clientes {get; set;}
        public ListModel (IRepositorioCliente repositorio){
            this.repositorio= new RepositorioCliente (new Drafts.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Clientes = repositorio.GetAllCliente();

        }
    }
}
