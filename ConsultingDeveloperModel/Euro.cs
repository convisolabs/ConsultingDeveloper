using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsultingDeveloperModel;
public class Euro
{
    public double euro { get; set; }

    public double ConverterEuroEmReal(double euro)
    {
        return euro * 5.43;
    }


}