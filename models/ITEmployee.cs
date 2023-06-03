using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWF_Mañana_30052023.models
{
    public class ITEmployee : Employee
    {
        private string _maritalStatus = "";
        private List<string> languagesProgramming = new List<string>();

        public List<string> LanguagesProgramming { get => languagesProgramming; set => languagesProgramming = value; }
        public override string MaritalStatus { get => _maritalStatus; set => _maritalStatus = value; }
    }
}
