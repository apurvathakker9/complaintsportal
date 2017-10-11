using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// DepartmentXAreaIncharge is for the area(locality) in charge of the department.
    /// DepartmentXAreaIncharge consist of the following properties: Id, DepartmentId, StateId, CityId, VillageId, LocalityId and InchargeId.
    /// </summary>
    public class DepartmentXAreaIncharge
    {
    public int Id { set; get; }
    public int DepartmentId { set; get; }
    public Department Department { set; get; }
    public int StateId { set; get; }
    public State State { set; get; }
    public int CityId { set; get; }
    public City City { set; get; }
    public int VillageId { set; get; }
    public Village Village { set; get; }
    public int LocalityId { set; get; }
    public Locality Locality { set; get; }
    public int InchargeId { set; get; }
    public GovernmentOfficial GovernmentOfficial { set; get; }


    }
}
