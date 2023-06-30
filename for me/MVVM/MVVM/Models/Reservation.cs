using System;
using System.Runtime.CompilerServices;
using System.Windows.Automation.Peers;

namespace MVVM.Models
{
    public class Reservation
    {
        public RoomId RoomId { get;}
        public string UserName { get;}
        public DateTime StartTime { get;}
        public DateTime EndTime { get;}
        public TimeSpan Lenght => EndTime.Subtract(StartTime);

        public Reservation(RoomId roomId, string userName, DateTime startTime, DateTime endTime)
        {
            RoomId = roomId;
            StartTime = startTime;
            EndTime = endTime;
            UserName = userName;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomId != RoomId) 
            {
                return false;
            }

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
    