// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace Enumeration
{
    // Declaring some enumerations - we put them in this file as we need to declare them after any 
    // top level statements, otherwise we will get an - "Error CS8803  Top-level statements must
    // precede namespace and type declarations."


    //enum Days
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}

    // enum Days default values
    //enum Days
    //{
    //    Monday,         // default value 0
    //    Tuesday,        // default value 1
    //    Wednesday,      // default value 2
    //    Thursday,       // default value 3
    //    Friday,         // default value 4
    //    Saturday,       // default value 5
    //    Sunday          // default value 6
    //}

    // Enum days with bit flags
    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,  // 0
        Monday = 0b_0000_0001,  // 1
        Tuesday = 0b_0000_0010,  // 2
        Wednesday = 0b_0000_0100,  // 4
        Thursday = 0b_0000_1000,  // 8
        Friday = 0b_0001_0000,  // 16
        Saturday = 0b_0010_0000,  // 32
        Sunday = 0b_0100_0000,  // 64
        Weekend = Saturday | Sunday
    }

    enum ErrorCode : ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    }

    // Activity solution - create StatusCode enum with custom error code values
    // These are common HTTP status codes see: https://restfulapi.net/http-status-codes/
     enum StatusCode
    {
        OK = 200,
        Found = 302,
        BadRequest = 400,
        Unauthorised = 4010,
        Forbidden = 403,
        NotFound = 404
    }

}
