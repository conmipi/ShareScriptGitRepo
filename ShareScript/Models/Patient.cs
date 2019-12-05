using System;
using System.Collections.Generic;
using System.Linq;

namespace ShareScript.Models
{
    public class Patient
    {
        private int patientID;
        private String firstName;
        private String lastName;
        private String DOB;
        private String address;
        private Object medicalHistory;
        private int phoneNumber;
        private List<Prescription> prescriptions;

        public Patient()
        {
            patientID = 0000;
            firstName = "Joe";
            lastName = "Doe";
            DOB = "00/00/0000";
            address = "addressstreet";
            medicalHistory = null;
            phoneNumber = 11111111;
            prescriptions = null;
        }

        public Patient(int patientID, String firstName, String lastName, String DOB, String address, Object medicalHistory, int phoneNumber, List<Prescription> prescriptions)
        {
            this.patientID = patientID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            this.address = address;
            this.medicalHistory = medicalHistory;
            this.phoneNumber = phoneNumber;
            this.prescriptions = prescriptions;
        }

        public int PatientID { get => patientID; set => patientID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Address { get => address; set => address = value; }
        public object MedicalHistory { get => medicalHistory; set => medicalHistory = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public List<Prescription> Prescriptions { get => prescriptions; set => prescriptions = value; }


        public void CreatePrescription(int prescriptionId, String drugName, float dosage, String issueDate, String expiryDate, String doctorName, Object doctorSignature, String patientName, String patientDOB, Object insuranceInfo, Boolean controlledSub)
        {
            Prescription p = new Prescription(prescriptionId, drugName, dosage, issueDate, expiryDate, doctorName, doctorSignature, patientName, patientDOB, insuranceInfo, controlledSub);
            prescriptions.Add(p);
        }

        public List<Prescription> ViewPrescriptions()
        {
            // Check to see if the list of prescriptions is null. If so, insert some dummy data
            if (prescriptions == null)
            {
                // Declare & initialize a new prescription list
                List<Prescription> prescriptions = new List<Prescription>();

                // Add prescription objects to the list
                prescriptions.Add(new Prescription(0, "Xanax", 10, "4 December 2019", "5 December 2022", "Dr. Smith", null, firstName + " " + lastName, DOB, null, true));
                prescriptions.Add(new Prescription(0, "Acetamemophin", 5, "4 December 2019", "5 December 2020", "Dr. Smith", null, firstName + "" + lastName, DOB, null, true));

                // Set the prescription list via mutators
                Prescriptions = prescriptions;
            }

            // Return the list of prescriptions
            return Prescriptions;
        }

        public string ToString()
        {
            string s = "";
            for(int i = 0; i < prescriptions.Count(); i++)
            {
                s += prescriptions[i].PrescriptionId + " \n" + prescriptions[i].DrugName;
            }
            return s;
        }
    }
}
