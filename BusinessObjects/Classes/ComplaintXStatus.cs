using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// ComplaintXStatus is mapping for a complaint and its Status.
    /// It also states the time at which status was changed and could contain further description.
    /// ComplaintXStatus class object consist of the following properties: Id, ComplaintId, StatusId, StatusAssignTime and StatusChangeSummary.
    /// </summary>
    public class ComplaintXStatus
    {
    public int Id { set; get; }
    public int ComplaintId { set; get; }
    public Complaint Complaint { set; get; }
    public int StatusId { set; get; }
    public ComplaintStatus ComplaintStatus { set; get; }
    public DateTime StatusAssignTime { set; get; }
    public string StatusChangeSummary { set; get; }

    }
}
