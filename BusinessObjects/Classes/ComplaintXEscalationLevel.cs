using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// ComplaintXStatus is mapping for a complaint and its EscalationLevel.
    /// It also states the time at which EscalationLevel was changed and could contain further description.
    /// ComplaintXStatus class object consist of following properties: Id, ComplaintId, EscalationLevelNumber, EscalationTime and EscalationReason.
    /// </summary>
    public class ComplaintXEscalationLevel
    {
    public int Id { set; get; }
    public int ComplaintId { set; get; }
    public Complaint Complaint { set; get; }
    public int EscalationLevelNumber { set; get; }
    public DateTime EscalationTime { set; get; }
    public string EscalationReason { set; get; }
    }
}
