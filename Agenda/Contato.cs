using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        // Variáveis privadas (Por motivos de segurança) das informações (Colunas) do BD
        private int cod;
        private string nm;
        private string tel;
        private string cel;
        private string email;

        // Cada informação contém um acessor get (Possibilita receber o valor da variável) e set (Atribuição em si da variável)
        public int Cod { get => cod; set => cod = value; }
        public string Nm { get => nm; set => nm = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Email { get => email; set => email = value; }

    }
}
