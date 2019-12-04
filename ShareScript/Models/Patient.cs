using System;
using System.Collections.Generic;

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
    }
}
