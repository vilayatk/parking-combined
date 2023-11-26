using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkingBackend.Controllers
{
    [Route("api/[controller]")] // route for the whole class; local:3000/parkingspaces
    [ApiController]
    public class ParkingSpacesController : ControllerBase
    {
        /*
         * Routing is case insensitive
            1.  Route("/products) => www.localhost:3000/products
            2.  Route("/products/{id} => www.localhost:3000/products/2 => Controller action parameter taken from URL, 
                2 is passed as a parameter for the function
            3.  Route("/products/{id?}) => Means that id is optional action parameter
            4.  Route("[controller]") => url directs to controller name; ClassName - Controller = [controller]
        */


        [HttpGet]
        public void GetParkingSpaces()
        {

        }
    }
}
