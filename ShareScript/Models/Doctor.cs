using System;
namespace ShareScript.Models
{
    public class Doctor
    {
        private string firstName;
        private string lastName;
        private int cpso;
        private int phoneNumber;
        private string dob;
        private string address;

        public Doctor()
        {
            firstName = "John";
            lastName = "Doe";
            cpso = 1000000;
            phoneNumber = 12312313;
            dob = "00/00/0000";
            address = "bbbbb";
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Cpso { get => cpso; set => cpso = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }

    }
}
