using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Department Escalation Level states the levels to which any complaint can be escalated in the Department.
    /// Department Escalation Level consist of the following properties:Id, DepartmentId, EscalationLevelName, DesignationOfficialId and LevelNumber.
    /// </summary>
    public class DepartmentEscalationLevel
    {
    public int Id { set; get; }
    public int DepartmentId { set; get; }
    public Department Department { set; get; }
    public string EscalationLevelName { set; get; }
    public int DesignatedOfficialId { set; get; }
    public GovernmentOfficial GovernmentOfficial { set; get; }
    public int LevelNumber { set; get; }
    }
}
