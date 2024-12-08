using System;
using System.Collections.Generic;

namespace Mini_Cs
{
    // Main Customer Data Class
    public class CustomerData
    {
        public int CustomerID { get; set; }
        public string ServiceType { get; set; }
        public string WithLifePlan { get; set; }
        public string LifePlanOtherDetails { get; set; }
        public DateTime? ServiceDate { get; set; }

        public DeceasedInfoData DeceasedInfo { get; set; }
        public ServiceDetailsData ServiceDetails { get; set; }
        public DeathCertificationData DeathCertification { get; set; }
        public DispositionDetailsData DispositionDetails { get; set; }
        public VehiclesAssignedData VehiclesAssigned { get; set; } // Changed from List to single object

        public PlanDetailsData PlanDetails { get; set; }
        public PaymentDetailsData PaymentDetails { get; set; }
        public SeniorPaymentDetailsData SeniorPaymentDetails { get; set; }
        public RepresentativeInfoData RepresentativeInfo { get; set; }

        public CustomerData()
        {
            DeceasedInfo = new DeceasedInfoData();
            ServiceDetails = new ServiceDetailsData();
            DeathCertification = new DeathCertificationData();
            DispositionDetails = new DispositionDetailsData();
            VehiclesAssigned = new VehiclesAssignedData();
            PlanDetails = new PlanDetailsData();
            PaymentDetails = new PaymentDetailsData();
            SeniorPaymentDetails = new SeniorPaymentDetailsData();
            RepresentativeInfo = new RepresentativeInfoData();
        }
    }

    // Deceased Info Data Class
    public class DeceasedInfoData
    {
        public int DeceasedID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public DateTime? Birthdate { get; set; }
        public string OSCAPWDID { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public int? Age { get; set; }
    }

    // Service Details Data Class
    public class ServiceDetailsData
    {
        public int ServiceDetailsID { get; set; }
        public int CustomerID { get; set; }
        public string CasketCode { get; set; }
        public bool Autopsy { get; set; }
        public string UrnCode { get; set; }
        public string ViewingPlace { get; set; }
        public int EmbalmingDays { get; set; }
    }

    // Death Certification Data Class
    public class DeathCertificationData
    {
        public int CertID { get; set; }
        public int CustomerID { get; set; }
        public string IssuedBy { get; set; }
        public string OthersDetails { get; set; }
    }

    // Disposition Details Data Class
    public class DispositionDetailsData
    {
        public int DispositionID { get; set; }
        public int CustomerID { get; set; }
        public string DispositionManner { get; set; }
        public string DispositionOtherDetails { get; set; }
        public string DispositionPlace { get; set; }
        public DateTime? DispositionDateTime { get; set; }
    }

    // Vehicles Assigned Data Class
    public class VehiclesAssignedData
    {
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string VehicleType { get; set; }
        public string VehicleOtherDetails { get; set; }
        public DateTime? DateReceivedByRepresentative { get; set; }
    }

    // Plan Details Data Class
    public class PlanDetailsData
    {
        public int PlanID { get; set; }
        public int CustomerID { get; set; }
        public string PlanHolderName { get; set; }
        public string PlanNo { get; set; }
        public string Company { get; set; }
        public string PlanType { get; set; }
    }

    // Regular Payment Details Data Class
    public class PaymentDetailsData
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal PlanValue { get; set; }
        public decimal ExtraCharges { get; set; }
        public decimal Discount { get; set; }
        public decimal ContractPrice { get; set; }
        public decimal VAT { get; set; }
        public decimal VATableSales { get; set; }
    }

    // Senior Payment Details Data Class
    public class SeniorPaymentDetailsData
    {
        public int SeniorPaymentID { get; set; }
        public int CustomerID { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal PlanValue { get; set; }
        public decimal ExtraCharges { get; set; }
        public decimal TotalVATExempt { get; set; }
        public decimal SCDiscount { get; set; }
        public decimal AdditionalDiscount { get; set; }
        public decimal ContractPrice { get; set; }
    }

    // Representative Info Data Class
    public class RepresentativeInfoData
    {
        public int RepID { get; set; }
        public int CustomerID { get; set; }
        public string PrimaryName { get; set; }
        public string PrimaryRelationship { get; set; }
        public string PrimaryAddress { get; set; }
        public string PrimaryTelMobile { get; set; }
        public string PrimaryEmail { get; set; }
        public DateTime? PrimaryDate { get; set; }
        public string SecondaryName { get; set; }
        public string SecondaryRelationship { get; set; }
        public string SecondaryAddress { get; set; }
        public string SecondaryTelMobile { get; set; }
        public string SecondaryEmail { get; set; }
        public DateTime? SecondaryDate { get; set; }
    }
}
