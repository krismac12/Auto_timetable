using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    class XML
    {

        public static void Login(string Key)
        {
            var doc = XDocument.Load("./db/Key.xml");

            var node = doc.Descendants("Data").FirstOrDefault();

            node.SetElementValue("Login", 1);
            node.SetElementValue("Key", Key);



            doc.Save("./db/Key.xml");
        }

        public static bool Check()
        {
            bool login = false;
            var doc = XDocument.Load("./db/Key.xml");

            var node = doc.Descendants("Data").FirstOrDefault();

            if(((int)node.Element("Login")) == 1 && KeyDB.Login(((string?)node.Element("Key"))))
            {
                login = true;
            }

            return login;
        }



    }
}
