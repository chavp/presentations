using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCode.App
{
    public class Controller
    {
        public Controller(IEmailGateway emailGateway) { }
        public Controller(IDatabase database) { }

        public void GreetUser(string email) { }

        public Report CreateReport() 
        { 
            throw new NotImplementedException();
        }

        
    }

    public class Report
    {
        public int NumberOfUsers { get; set; }
    }
}
