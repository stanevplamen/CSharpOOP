using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademyGlobal
{
    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }
}
