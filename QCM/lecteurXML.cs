using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace QCM
{
    class lecteurXML
    {
        /// <summary>
        /// lis le fichier xml "fichier" et renvoie l'énoncé de la question de l'indice demandé
        /// </summary>
        /// <param name="num"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        public string retournerQuestion(int num, string fichier)
        {
            string x = num.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(x))
                {
                    return reader.GetAttribute("nom");
                }
            }
            return "oupsy doopsy";
        }

        /// <summary>
        /// lis le fichier xml "fichier" et renvoie l'énoncé de la réponse d'indice numR de la question d'indice numQ 
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="numR"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        public string retournerReponse(int numQ, int numR, string fichier)
        {
            string question = numQ.ToString();
            string reponse = numR.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(question))
                {
                    switch (numR)
                    {
                        case 1:
                            return reader.GetAttribute("rep1");
                        case 2:
                            return reader.GetAttribute("rep2");
                        case 3:
                            return reader.GetAttribute("rep3");
                        case 4:
                            return reader.GetAttribute("rep4");
                    }
                }
            }
            return "oupsy doopsy";
        }

        /// <summary>
        /// lis le fichier xml "fichier" et renvoie l'énoncé de la réponse juste de la question d'indice numQ
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        public string retournerReponseJusteString(int numQ, string fichier)
        {
            return retournerReponse(numQ, retournerReponseJusteInt(numQ, fichier), fichier);
        }

        /// <summary>
        /// lis le fichier xml "fichier" et renvoie l'indice de la réponse juste de la question d'indice numQ
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        public int retournerReponseJusteInt(int numQ, string fichier)
        {
            string question = numQ.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            int rep = 5;
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(question))
                {
                    rep = int.Parse(reader.GetAttribute("bonneR"));
                    return rep;
                }
            }
            return rep;
        }

        /// <summary>
        /// lis le fichier xml "fichier" et compare la reponse entrée et la réponse juste de la question d'indice numQ
        /// </summary>
        /// <param name="rep"></param>
        /// <param name="numQ"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        public bool verificationReponse(int rep, int numQ, string fichier)
        {
            if (rep == retournerReponseJusteInt(numQ, fichier)) { return true; }
            else { return false; }
        }

        /// <summary>
        /// lis le fichier xml "fichier" et renvoie l'explication de la bonne réponse associée à la question de l'indice demandé
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="fichier"></param>
        /// <returns></returns>
        public string retournerExplication(int numQ, string fichier)
        {
            string x = numQ.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(x))
                {
                    return reader.GetAttribute("explication");
                }
            }
            return "oupsy doopsy";
        }
    }
}
