using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// It stores the State name and helps recognize to which department it has to go to.
    /// It helps user to find cities easily.
    /// State class object consist of the following properties: Id and Name.
    /// </summary>
    public class State
    {
    public int Id { set; get; }
    public string Name{ set; get; }
    }
}
