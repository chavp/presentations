using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCode.App
{
    public interface IEmailGateway
    {
        void SendGreetingsEmail(string email);
    }
}
