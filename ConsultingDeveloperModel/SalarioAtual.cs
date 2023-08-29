using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultingDeveloperModel;

public class SalarioAtual
{
    public double Salario { get; set; }
    public double Reajuste { get; set; }

    public double salarioReajustado (double salario, double reajuste)
    {
        this.Salario = salario;
        this.Reajuste = reajuste;

        return salario + (salario * (reajuste / 100));

    }

}
