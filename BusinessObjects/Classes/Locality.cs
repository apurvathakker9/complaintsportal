using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Locality consist of the details of the Locality of the particular city or Village accordingly.
    /// It has longitude and latitude which consist of the location where the user or department or the problems exist.
    /// Locality class object consist of the following properties: Id, CityId, City, VillageId, Village, Name, Pincode, Latitude, Longitude.
    /// </summary>

    public class Locality
    {
    public int Id { set; get; }
    public int CityId { set; get; }
    public City City { set; get; }
    public int VillageId { set; get; }
    public Village Village { set; get; }
    public string Name { set; get; }
    public string Pincode { set; get; }
    public string Latitude { set; get; }
    public string Longitude { set; get; }


    }
}
