using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bookstore.Models;
using Bookstore.Infrastructure;

namespace Bookstore.Pages
{
    public class PurchaseModel : PageModel
    {
        private iBookStoreRepository repository;
        //constructor
        public PurchaseModel (iBookStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookid, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.BookId == bookid);

            Cart.AddItem(book, 1);
            
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookid, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookId == bookid).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
