using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        public static List<Patient> PatientsList;
        public static List<Doctor> DoctorsList;
        public static List<Room> RoomsList;

        static Hospital()
        {
            PatientsList = new List<Patient>();
          
        
        
        
            DoctorsList = new List<Doctor>();
           
        

        
        
            RoomsList = new List<Room>();
            
        }
        
    
    //*************************************************************************************
        public void AddDoctor(Doctor doctor)
        {
        DoctorsList.Add(doctor);
        }

        public void AddPation(Patient pation)
                    {
        PatientsList.Add(pation);
                    
                     }

        public void AddRoom(Room room)
    {
        RoomsList.Add(room);
    }

        //**********************************************************************************************
        public void AssignRoomToPatient(Patient patient, Room room)
        {
            patient.AssignRoom(room);
            room.OccupyRoom();
            Console.WriteLine($"{patient.Name} Assigned to room {room.RoomNumber}");
        }

        //*********************************************************************************************
        public void GetDoctorPatients(Doctor doctor)
        {
            var DocPatients = doctor.GetPatients();
            Console.WriteLine($"Patients of {doctor.Name}:");
            for (int i = 0; i < DocPatients.Count; i++)
            {
                Console.WriteLine($"Name: {DocPatients[i].Name}, ID: {DocPatients[i].GetID()}, Ailment: {DocPatients[i].GetAilment()}");
            }
        }

        public List<Doctor> GetDoctors()
        {
            return DoctorsList;
        }

        public List<Patient> GetPatients()
        {
            return PatientsList;
        }

        public List<Room> GetRooms()
        {
            return RoomsList;
        }
    }
}

