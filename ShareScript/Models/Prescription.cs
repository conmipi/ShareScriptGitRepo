using System;
namespace ShareScript.Models
{
    public class Prescription
    {
        private int prescriptionId;
        private String drugName;
        private float dosage;
        private String issueDate;
        private String expiryDate;

        private String doctorName;
        private Object doctorSignature;

        private String patientName;
        private String patientDOB;
        private Object insuranceInfo;
        private Boolean controlledSub;


        public Prescription()
        {
            prescriptionId = 000000;
            drugName = "DrugPrescription";
            dosage = 0.0f;
            issueDate = "00/00/0000";
            expiryDate = "00/00/0000";
            doctorName = "John Doe";
            doctorSignature = null;
            patientName = "Done Joe";
            patientDOB = "00/00/0000";
            insuranceInfo = null;
            controlledSub = false;
        }

        public Prescription(int prescriptionId, String drugName, float dosage, String issueDate, String expiryDate, String doctorName, Object doctorSignature, String patientName, String patientDOB, Object insuranceInfo, Boolean controlledSub)
        {
            this.prescriptionId = prescriptionId;
            this.drugName = drugName;
            this.dosage = dosage;
            this.issueDate = issueDate;
            this.expiryDate = expiryDate;
            this.doctorName = doctorName;
            this.doctorSignature = doctorSignature;
            this.patientName = patientName;
            this.patientDOB = patientDOB;
            this.insuranceInfo = insuranceInfo;
            this.controlledSub = controlledSub;
        }

        public int PrescriptionId { get => prescriptionId; set => prescriptionId = value; }
        public string DrugName { get => drugName; set => drugName = value; }
        public float Dosage { get => dosage; set => dosage = value; }
        public string IssueDate { get => issueDate; set => issueDate = value; }
        public string ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public object DoctorSignature { get => doctorSignature; set => doctorSignature = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string PatientDOB { get => patientDOB; set => patientDOB = value; }
        public object InsuranceInfo { get => insuranceInfo; set => insuranceInfo = value; }
        public bool ControlledSub { get => controlledSub; set => controlledSub = value; }

    }
}
