using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Department holds the Departemnt type and the address depending on the localities.
    /// It also holds the contact information with the timings of the office.
    /// Department class object consist of the following properties: Id, DepartmentTypeId, Name, StateId, CityId, VillageId, LocalityId, office address, website, contactEmails, ContactNumbers and ContactTimings.
    /// </summary>
    public class Department
    {
    public int Id { set; get; }
    public int DepartmentTypeId { set; get; }
    public DepartmentType DepartmentType { set; get; }
    public string Name { set; get; }
    public int StateId { set; get; }
    public State State { set; get; }
    public int CityId { set; get; }
    public City City { set; get; }
    public int VillageId { set; get; }
    public Village Village { set; get; }
    public int LocalityId { set; get; }
    public Locality Locality { set; get; }
    public string OfficeAddress { set; get; }
    public string Website { set; get; }
    public string ContactEmails { set; get; }
    public string ContactNumbers { set; get; }
    public string ContactTimings { set; get; }



    }
}
