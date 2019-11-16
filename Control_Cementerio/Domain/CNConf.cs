using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Configuration;
using Common.Configuracion;
using System.Xml;

namespace Domain
{
    public class CNConf
    {
        XmlDocument xmlDoc = new XmlDocument();

        public void GetConfApp()
        {
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach(XmlElement elemento in xmlDoc.DocumentElement)
            {
                if(elemento.Name.Equals("appSettings"))
                {
                    foreach(XmlNode nodo in elemento.ChildNodes)
                    {
                        if(nodo.Attributes[0].Value == "IVA")
                        {
                            DataConfig.IVA = nodo.Attributes[1].Value.Trim();
                        }
                        else if (nodo.Attributes[0].Value == "AÑOS")
                        {
                            DataConfig.AÑOS = nodo.Attributes[1].Value.Trim();
                        }
                    }
                }
            }            
        }

        public void SetConfApp(string nuevovalor)
        {
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement elemento in xmlDoc.DocumentElement)
            {
                if (elemento.Name.Equals("appSettings"))
                {
                    foreach (XmlNode nodo in elemento.ChildNodes)
                    {
                        if (nodo.Attributes[0].Value == "IVA")
                        {
                            nodo.Attributes[1].Value = nuevovalor.Trim();
                        }
                        else if (nodo.Attributes[0].Value == "AÑOS")
                        {
                            nodo.Attributes[1].Value = nuevovalor.Trim();
                        }
                    }
                }
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
