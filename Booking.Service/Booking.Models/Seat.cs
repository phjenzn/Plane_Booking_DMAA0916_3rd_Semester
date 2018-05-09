﻿using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Seat
    {
        // Constructors
        public Seat()
        {
        }


        // Properties
        [DataMember]
        public string Test { get; set; }
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public int Row { get; set; }

        [DataMember]
        public bool Available { get; set; }
    }
}
