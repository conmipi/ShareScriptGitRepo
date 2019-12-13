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
        private String dob;
        private String address;
        private Object medicalHistory;
        private int phoneNumber;
        private List<Prescription> prescriptions;

        public Patient()
        {
            patientID = 0000;
            firstName = "Joe";
            lastName = "Doe";
            dob = "00/00/0000";
            address = "addressstreet";
            medicalHistory = null;
            phoneNumber = 11111111;
            prescriptions = new List<Prescription>();
        }

        public Patient(int patientID, String firstName, String lastName, String dob, String address, Object medicalHistory, int phoneNumber, List<Prescription> prescriptions)
        {
            this.patientID = patientID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.address = address;
            this.medicalHistory = medicalHistory;
            this.phoneNumber = phoneNumber;
            this.prescriptions = new List<Prescription>(prescriptions);
        }

        public int PatientID { get => patientID; set => patientID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public object MedicalHistory { get => medicalHistory; set => medicalHistory = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public List<Prescription> Prescriptions { get => prescriptions; set => prescriptions = value; }


        public void CreatePrescription(Prescription p)
        {
            Prescriptions.Add(p);
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
