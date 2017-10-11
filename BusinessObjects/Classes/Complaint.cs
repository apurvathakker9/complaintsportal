using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// A Citizen can register a complaint through this BuisnessObjects.
    /// A Citizen must define the locality, Department Type, Complaint Type and his/her own details verified via OTP to register a complaint.
    /// Complaint class object consist of the following properties: Id, StateId, CityId, VillageId, LocalityId, DepartmentTypeId, ComplaintTypeId, ReportingPersonFirstName, ReportingPersonLastName, ReportingPersonAdhaarId, ReportingPersonContactNumber, ReportingTime, CurrentStatusId, CurrentEscalationNumber, OTP, ComplaintVerifiedViaOTP , IsEscalated, Description, DepartmentId,  ClosingTime.
    /// </summary>
    public class Complaint
    {
        public int Id { set; get; }
        public int StateId { set; get; }
        public State State { set; get; }
        public int CityId { set; get; }
        public City City { set; get; }
        public int VillageId { set; get; }
        public Village Village { set; get; }
        public int LocalityId { set; get; }
        public Locality Locality { set; get; }
        public int DepartmentTypeId { set; get; }
        public DepartmentType DepartmentType { set; get; }
        public int ComplaintTypeId { set; get; }
        public ComplaintType ComplaintType { set; get; }
        public string ReportingPersonFirstName { set; get; }
        public string ReportingPersonLastName { set; get; }
        public string ReportingPersonAdhaarId { set; get; }
        public string ReportingPersonContactNumber { set; get; }
        public DateTime ReportingTime { set; get; }
        public int CurrentStatusId { set; get; }
        public ComplaintStatus ComplaintStatus { set; get; }
        public int CurrentEscalationNumber { set; get; }
        public string OTP { set; get; }
        public bool ComplaintVerifiedViaOTP { set; get; }
        public bool IsEscalated { set; get; }
        public string Description { set; get; }
        public int DepartmentId { set; get; }
        public Department Department { set; get; }
        public DateTime ClosingTime { set; get; }
        public string Image { get; set; }

    }
}
