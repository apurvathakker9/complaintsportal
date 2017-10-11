using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// From Village it will assign to which locality it exist.
    /// It also have Pincode to ensure that it exist in particular State or not.
    /// Village class object consist of the following properties: Id, CityId, City, Name and PinCode.
    /// </summary>
    public class Village
    {
    public int Id { set; get; }
    public int CityId { set; get; }
    public City City { set; get; }
    public string Name { set; get; }
    public string PinCode { set; get; }

    }
}
