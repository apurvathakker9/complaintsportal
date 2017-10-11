using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// GovernmentOfficial contains the detail of official in the corresponding department and they are contacted when needed.
    /// GovernmentOfficial class object consist of the following properties: Id, Name, ContactNumber, ContactEmail, Picture, DesignationId and officialCode.
    /// </summary>
    public class GovernmentOfficial
    {
    public int Id { set; get; }
    public string Name { set; get; }
    public string ContactNumber { set; get; }
    public string ContactEmail { set; get; }
    public string Picture { set; get; }
    public int DesignationId { set; get; }
    public DepartmentDesignation DepartmentDesignation { set; get; }
    public string OfficialCode { set; get; }

    }
}
