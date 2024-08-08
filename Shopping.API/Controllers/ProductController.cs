using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace SHopping.API.Controllers;
  
 [ApiController]
 [Route("[controller]")]
 public class ProductController : Controller
 {
    private readonly ProductContext _context;

    public ProductController(ProductContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> GetProducts()
    {
        var products = await _context.Products.FindAsync(p => true);

        return products.ToList();
    }
 }