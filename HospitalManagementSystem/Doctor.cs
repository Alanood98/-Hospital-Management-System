using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static HospitalManagementSystem.Doctor;
using static HospitalManagementSystem.Patient;

namespace HospitalManagementSystem
{
    public class Doctor : person
    {

        public int DoctorID;
        public string Specialization;
        public static List<Patient> Patients;

        //▪ PatientsList(List of Patients):
        static Doctor()
        {

            Patients = new List<Patient>();

        }


        public Doctor(int doctorID, string name, int age, Gender gender, string specialization)
           : base(name, age, gender)
        {
            this.DoctorID = doctorID;
            this.Specialization = specialization;

        }


        //****************************************************************************************************************
        public void AddPatient(Patient patient)
        {
            try
            {
                bool Found = false;

                for (int i = 0; i < Patients.Count; i++)
                {
                    if (Patients[i].PatientID == patient.PatientID)
                    {
                        Console.WriteLine("pation id already exist");
                        Found = true;
                    }
                }

                if (Found != true)
                {
                    Patients.Add(patient);
                    Console.WriteLine("pation id add successfully");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("pation id failed to create due to :" + e.Message);
            }
        }
        //****************************************************************************************

        public void RemovePatient(Patient patient)
        {
            try
            {
                bool Found = false;

                for (int i = 0; i < Patients.Count; i++)
                {
                    if (Patients[i].PatientID == patient.PatientID)
                    {
                        Console.WriteLine("pation id already exist");
                        Found = true;
                    }
                }

                if (Found != true)
                {
                    Patients.Remove(patient);
                    Console.WriteLine("pation id remove successfully");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("pation id failed to remove due to :" + e.Message);

            }
        }
        //**********************************************************************************************
        public override void DisplayInfo()
        {

            base.DisplayInfo();
            Console.WriteLine($"doctor id id is : {DoctorID} ,  specialization is : {Specialization} ");

        }
        public List<Patient> GetPatients()
        {
            return Patients;
        }

        public int GetID()
        {
            return DoctorID;
        }

        public string GetSpec()
        {
            return Specialization;
        }
    }
}

