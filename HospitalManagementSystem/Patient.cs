using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HospitalManagementSystem.Patient;
using static HospitalManagementSystem.person;

namespace HospitalManagementSystem
{
    public class Patient: person
    {


            public int PatientID;
            public string Ailment;
            public Doctor AssignedDoctor;
        public Room Room;

            public Patient(int patientID, string Name, int Age, Gender gender, string ailment, Doctor doctor) : base(Name, Age, gender)
            {
                this.PatientID = patientID;
                this.Ailment = ailment;
            AssignedDoctor = doctor;
            doctor.AddPatient(this);
            //this.Room = room;
        }

            public void Discharge()
            {
                Room.VacateRoom();
                Room = null;

            }

            //****************************************************************************************************************

            public void AssignRoom(Room room)
            {
                if (room != null && room.RoomNumber > 0)
                {
                    this.Room = room;
                    Console.WriteLine($"Room {room.RoomNumber} has been assigned to patient {this.PatientID}.");
                }
                else
                {
                    Console.WriteLine("The room assignment is invalid. Room number must be greater than zero.");
                }
            }
        //**************************************************************************************************************

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"pation id id is : {PatientID} , the ailment is : {Ailment} ");
        }
            public int GetID()
            {
                return PatientID;
            }
            public string GetAilment()
            {
                return Ailment;
            }
        }
    }



