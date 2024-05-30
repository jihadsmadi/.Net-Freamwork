using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace MyFirstASP_Project.Pages
{
    public class AboutModel : PageModel
    {
		private readonly IConfiguration _configuration;

		public string title { get; set; }

        public AboutModel(IConfiguration configuration)
        {
			this._configuration = configuration;
            
		}
        public void OnGet()
        {
           
        }

        public List<clsEmployee> ReturnEmployees()
        {
            clsEmployee employee = new clsEmployee();
            return employee.Employees();
        }

		public string GetPageTitleFromAppSettings()
		{
			return _configuration["PageTitle"];

		}

		public string GetPageTitleFromResources()
		{
            return Properties.Resources.PageTitle;

		}
	}

    public class clsEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public string Salary { get; set; }
        public string Phone { get; set; }

        public List<clsEmployee> Employees()
        {
           List<clsEmployee> employees= new List<clsEmployee>();
            employees.Add(new clsEmployee { ID = 1, Name = "MHD Jihad Smaid",Salary = "3500.00",Phone = "0937793120" });
            employees.Add(new clsEmployee { ID = 2, Name = "Omar Sarem",Salary = "200.00",Phone =   "0932294823" });
            employees.Add(new clsEmployee { ID = 3, Name = "Bana Qanout",Salary = "4000.00",Phone = "0955264373" });
            employees.Add(new clsEmployee { ID = 4, Name = "Haya Smadi",Salary = "13500.00",Phone = "0994118341" });

            return employees; 
        }

       
    }


}
