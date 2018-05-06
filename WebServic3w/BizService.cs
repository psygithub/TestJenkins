using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServic3w
{
    public class BizService:IBizService
    {
        public string ShowMessage()
        {
            return "Test Jenkins Auto Build And Deploy! Success!Second Time!";
        }
    }
}
