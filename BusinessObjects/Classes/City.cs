using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// City consist the details of the City and the State in which it is located.
    /// City class objects consist of the following properties: Id, StateId, State, Name and PinCode.
    /// </summary>
    public class City
    {
    public int Id { set; get; }
    public int StateId { set; get; }
    public State State { set; get; }
    public string Name { set; get; }
    public string PinCode { set; get; }

    }
}
