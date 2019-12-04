using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Services;
using Test.Controllers;

namespace MongoDBNetCore.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class bookController:BooksController<Books>
    {
       
        public bookController(BooksRepository books) : base(books)
        {
        }
    }
}