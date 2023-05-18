using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.util
{
    public class GetPropertiesYopMail
    {
        private static GetPropertiesYopMail getPropertiesYopMail = null;
        private string host;
        private string user;

        private GetPropertiesYopMail()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        }
    }
}
