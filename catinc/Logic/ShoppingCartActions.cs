using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using catinc.Models;
using catinc.Models.Database;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Http;

namespace WingtipToys.Logic
{
  public class ShoppingCartActions : IDisposable
  {
    public string ShoppingCartId { get; set; }

    private MySqlDbContext _mySqlDbContext;

    public ShoppingCartActions(MySqlDbContext mySqlDbContext)
    {
        _mySqlDbContext = mySqlDbContext;
    }

    public const string CartSessionKey = "CartId";

    public void AddToCart(HttpContext context, int id)
    {
      // Retrieve the product from the database.           
      ShoppingCartId = GetCartId(context);

      var cartItem = _mySqlDbContext.ShoppingCartItems.SingleOrDefault(
          c => c.CartId == ShoppingCartId
          && c.ProductId == id);
      if (cartItem == null)
      {
        // Create a new cart item if no cart item exists.                 
        cartItem = new CartItem
        {
          ItemId = Guid.NewGuid().ToString(),
          ProductId = id,
          CartId = ShoppingCartId,
          Product = _mySqlDbContext.Products.SingleOrDefault(
           p => p.ProductID == id),
          Quantity = 1,
          DateCreated = DateTime.Now
        };

        _mySqlDbContext.ShoppingCartItems.Add(cartItem);
      }
      else
      {
        // If the item does exist in the cart,                  
        // then add one to the quantity.                 
        cartItem.Quantity++;
      }
      _mySqlDbContext.SaveChanges();
    }

    public string GetCartId(HttpContext httpContext)
    {
      if (httpContext.Session.GetString(CartSessionKey) == null)
      {
        if (!string.IsNullOrWhiteSpace(httpContext.User.Identity.Name))
        {
          httpContext.Session.SetString(httpContext.Session.GetString(CartSessionKey), httpContext.User.Identity.Name);
        }
        else
        {
          // Generate a new random GUID using System.Guid class.     
          Guid tempCartId = Guid.NewGuid();
          httpContext.Session.SetString(httpContext.Session.GetString(CartSessionKey), tempCartId.ToString());
        }
      }
      return httpContext.Session.GetString(CartSessionKey);
    }

    public List<CartItem> GetCartItems(HttpContext context)
    {
      ShoppingCartId = GetCartId(context);

      return _mySqlDbContext.ShoppingCartItems.Where(
          c => c.CartId == ShoppingCartId).ToList();
    }

        public void Dispose()
        {
        }
    }
}