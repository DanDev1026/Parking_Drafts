using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Drafts.App.Dominio;
using Drafts.App.Persistencia;

namespace Drafts.App.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioCliente repositorio;
        [BindProperty]
        public Cliente cliente { get; set; }
        public EditModel(IRepositorioCliente repositorio)
        {
            this.repositorio = new RepositorioCliente(new Drafts.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                cliente = repositorio.GetCliente(clienteId.Value);
            }
            else
            {
                cliente = new Cliente();
            }
            if (cliente == null)
            {
                return RedirectToPage("./List");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (cliente.Id > 0)
            {
                repositorio.UpdateCliente(cliente);
            }
            else
            {
                repositorio.AddCliente(cliente);

            }
            return Page();
        }
    }

}
