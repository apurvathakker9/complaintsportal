using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// DepartmentType states what type of department we are refering to in a particular state.
    /// Example:- Electrical board department, Water Supply department etc.
    /// Department class object consist of the following properties: Id and Name(name of department).
    /// </summary>
    public class DepartmentType
    {
    public int Id { set; get; }
    public string Name { set; get; }
    
    }
}
