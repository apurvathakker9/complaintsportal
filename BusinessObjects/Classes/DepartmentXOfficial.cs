using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Because one department can have multiple official so DepartmentXOfficial is created.
    /// It looks for the department and the type of official to be contacted.
    /// DepartmentXOfficial class object consist of the following properties: Id, DepartmentId, GovernmentOfficialId and DesignationId.
    /// </summary>
    public class DepartmentXOfficial
    {
    public int Id { set; get; }
    public int DepartmentId { set; get; }
    public Department Department { set; get; }
    public int GovernmentOfficialId { set; get; }
    public GovernmentOfficial GovernmentOfficial { set; get; }
    public int DesignationId { set; get; }
    public DepartmentDesignation DepartmentDesignation{ set; get; }
    }
}
