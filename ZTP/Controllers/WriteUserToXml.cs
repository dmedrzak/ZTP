using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ZTP.Models;

namespace ZTP.Controllers
{
    public static class WriteUserToXml
    {
        public static void SaveUserInXml(User user)
        {
            using (XmlWriter writer = XmlWriter.Create("rememberedUser.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("User");
                writer.WriteElementString("Id",Convert.ToString(user.Id));
                writer.WriteElementString("Login", Convert.ToString(user.Login));
                writer.WriteElementString("Password", Convert.ToString(user.Password));
                writer.WriteElementString("CreatedDate", Convert.ToString(user.CreateDate));
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static bool IsExistsXml()
        {
            return File.Exists(Directory.GetCurrentDirectory() + @"rememberedUser.xml") ? true : false;
        }
    }
}
