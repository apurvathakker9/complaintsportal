using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// ComplaintType is used to map the complaint to its corresponding department.
    /// ComplaintType class object consist of the following properties: Id, Name and DepartmentTypeId.
    /// </summary>
    public class ComplaintType
    {
    public int Id { set; get; }
    public string Name { set; get; }
    public int DepartmentTypeId { set; get; }
    public DepartmentType DepartmentType { set; get; }
    
    }
}
