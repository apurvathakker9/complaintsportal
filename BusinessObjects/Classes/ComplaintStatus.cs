using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// ComplaintStatus defines the status of the complaint i.e. it can be a new complaint, fixed complaint etc
    /// ComplaintStatus class object consist of the following properties: Id and Name.
    /// </summary>
    public class ComplaintStatus
    {
    public int Id { set; get; }
    public string Name { set; get; }

    }
}
