using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// AdhaarXOTP is for adhaar number and OTP(one time password).
    /// AdhaarXOTP checks the adhaarNumber and provides One time password to the Citizen.
    /// AdhaarXOTP Class object consist of the following properties: Id, AdhaarNumber and OTP(One Time Password).
    /// </summary>
    public class AdhaarXOTP
    {
    public int Id { set; get; }
    public string AdhaarNumber { set; get; }
    public string OTP { set; get; }
    }
}
