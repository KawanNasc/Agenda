using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    // Classe pública Programador herdado da abstrata Funcionário
    public class Programador : Funcionario
    {
        // Sobreescrita do método reajustar para adicionar o salário +1000
        public override void Reajustar()
        {
            salario += 1000;
        }
    }
}
