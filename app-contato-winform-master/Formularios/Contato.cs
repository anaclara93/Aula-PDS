using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContatoForm.Formularios
{
    internal class Contato
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public string sexo { get; set; }
        public string dataNascimento { get; set; }

        public string ToString()
        {
            string ass = Id + ";" + Nome + ";" + telefone + ";" + Email+";"+ sexo+";"+ dataNascimento;
            return ass;
        }
    }
}
