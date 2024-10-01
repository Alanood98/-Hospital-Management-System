using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Appointment
    {
        public Doctor Doctor;
        public Patient Patient;
        public DateTime? AppointmentDate;


        public Appointment(Patient patient, Doctor doctor,  DateTime AppointmentDate)
        {

            Doctor = doctor;
            Patient = patient;
            
            this.AppointmentDate = AppointmentDate;
        }

        //***************************************************************

        public void ScheduleAppointment(DateTime date)
        {


            AppointmentDate = date;
        }





        //***********************************************************************************************


        public void CancelAppointment()
        {
            AppointmentDate = null;
        }
        public void GetAppointmentDetails()
        {
            
                Console.WriteLine("Appointment Details:");
                Console.WriteLine($"Patient Name: {Patient.Name}");

                Console.WriteLine($"Doctor Name: Dr. {Doctor.Name}");

                Console.WriteLine($"Appointment Date: {AppointmentDate}");
            }
            
        }
    }



