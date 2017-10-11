using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// OfficialXComplaintsAssigned states which on duty official was assigned which complaint and at what time and whether complaint has been escalated or not.
    /// OfficialXComplaintsAssigned class object consist of the following properties: Id, OfficialId, ComplaintId, AssignedOn and IsEscalated.
    /// </summary>
    public class OfficialXComplaintsAssigned
    {
    public int Id { set; get; }
    public int OfficialId { set; get; }
    public GovernmentOfficial GovernmentOfficial { set; get; }
    public int ComplaintId { set; get; }
    public Complaint Complaint { set; get; }
    public DateTime AssignedOn { set; get; }
    public bool IsEscalated { set; get; }
    }
}
