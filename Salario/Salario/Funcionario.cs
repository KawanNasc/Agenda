using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    // Classe abstrata pública (Modelo das classes derivadas)
    public abstract class Funcionario
    {
        // Declara a informação do nome e salário para as classes derivadas
        public string nm;
        public decimal salario;

        // Referencia para a mudança do método virtual Reajustar para ser adaptada nas classes derivadas de Programador, Designer e DevWeb
        public abstract void Reajustar();
    }
}
