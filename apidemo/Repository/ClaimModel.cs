using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apidemo.Repository
{
    public class ClaimModel
    {
        public class Name
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Initials { get; set; }
        }

        public class Address
        {
            public int Id { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string Address3 { get; set; }
            public string Address4 { get; set; }
            public string Country { get; set; }
            public string NameOrNumber { get; set; }
            public string PostCode { get; set; }
        }

        public class PolicyHolder
        {
            public int Id { get; set; }
            public Name Name { get; set; }
            public Address Address { get; set; }
            public string DateOfBirth { get; set; }
            public string DaytimeTelephoneNumber { get; set; }
            public string EveningTelephoneNumber { get; set; }
            public string MobileTelephoneNumber { get; set; }
        }

        public class Policy
        {
            public int Id { get; set; }
            public int PolicyNumber { get; set; }
            public int SessionNumber { get; set; }
            public DateTime InceptionDate { get; set; }
            public DateTime EffectiveDate { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string Status { get; set; }
            public string BrandCode { get; set; }
            public string BrandName { get; set; }
            public string VehicleRegistration { get; set; }
            public string CoverType { get; set; }
            public string BrokerNumber { get; set; }
            public string Broker { get; set; }
            public PolicyHolder PolicyHolder { get; set; }
            public List<object> NamedDriversDetails { get; set; }
        }

        public class Claim
        {
            public List<Policy> Policies { get; set; }
        }

    }
}
