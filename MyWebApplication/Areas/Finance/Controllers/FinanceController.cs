using Microsoft.AspNetCore.Mvc;
using SqlKata.Execution;

namespace MyWebApplication.Areas.Finance.Controllers
{
    [Area("Finance")]
    [Route("Finance")]
    public class FinanceController : Controller
    {
        private QueryFactory db;
        
        public FinanceController(QueryFactory db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            db.Connection.Open();

            ViewData["test"] = db.Query("test_table").Select("name").Where("id", 1).First();
            
            db.Connection.Close();
            return View();
        }
    }
}