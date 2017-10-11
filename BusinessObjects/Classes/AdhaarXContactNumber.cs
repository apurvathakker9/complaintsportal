using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Business object layer consist the properties for the application.
/// </summary>
namespace BusinessObjects
{
    /// <summary>
    /// AdhaarXContactNumber will check adhaar number and the contact number of the citizen who is going to submit a complaint.
    /// AdhaarXContactNumber class object consist of the following properties: Id, AdhaarNumber and ContactNumber.
    /// </summary>
    public class AdhaarXContactNumber
    {
    public int Id { set; get; }
    public string AdhaarNumber { set; get; }
    public string ContactNumber { set; get; }

    }
}
