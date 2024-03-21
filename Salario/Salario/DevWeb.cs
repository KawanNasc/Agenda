using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    // Classe pública DevWeb herdado da abstrata Funcionário
    public class DevWeb : Funcionario 
    {
        // Sobreescrita do método reajustar para adicionar o salário +900
        public override void Reajustar()
        {
            salario += 900;
        }
    }
}
