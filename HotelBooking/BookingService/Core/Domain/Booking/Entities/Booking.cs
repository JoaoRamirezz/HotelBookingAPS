﻿using Domain.Enums;
using Action = Domain.Enums.Action;

namespace Domain.Entities
{
    public class Booking
    {
        public Booking()
        {
            Status = Status.Created;
            PlacedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public DateTime PlacedAt { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int RoomId { get; set; }
        public int GuestId { get; set; }

        public Room Room { get; set; }
        public Guest Guest { get; set; }

        public Status Status { get; set; }
        public Status CurrentStatus
        {
            get { return this.Status; }
        }

        //Máquina de estado - POO
        public void ChangeState(Action action)
        {

            Status = (Status, action) switch
            {
                (Status.Created, Action.Pay) => Status.Paid,
                (Status.Created, Action.Cancel) => Status.Canceled,
                (Status.Paid, Action.Finish) => Status.Finished,
                (Status.Paid, Action.Refound) => Status.Refounded,
                (Status.Canceled, Action.Reopen) => Status.Created,

                _ => Status

            };
        }
    }
}
