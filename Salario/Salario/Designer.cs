using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    // Classe pública Designer herdado da abstrata Funcionário
    public class Designer : Funcionario
    {
        // Sobreescrita do método reajustar para adicionar o salário +500
        public override void Reajustar()
        {
            salario += 500;
        }
    }
}
