using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Room
    {
        public int RoomNumber;
        public enum RoomType
        {
            General,
            ICU,
            OperationTheatre
        }
        public RoomType roomType;

        public bool IsOccupied = false;

        public Room(int RoomNumber, RoomType roomType)
        {
            this.RoomNumber = RoomNumber;
            this.roomType = roomType;
        }


        public void OccupyRoom()
        {
            if (!IsOccupied)
            {
                IsOccupied = true;
                Console.WriteLine($"Room {RoomNumber} is now occupied.");
            }
            else
            {
                Console.WriteLine($"Room {RoomNumber} is already occupied.");
            }


        }

        public void VacateRoom()
        {

            if (IsOccupied)
            {
                IsOccupied = false;
                Console.WriteLine($"Room {RoomNumber} is now available.");
            }
            else
            {
                Console.WriteLine($"Room {RoomNumber} is already vacant.");
            }

        }

    }
}
