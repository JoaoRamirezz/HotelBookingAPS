namespace Application.Dtos
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public static Domain.Entities.Booking MapToEntity(BookingDto dto)
        {
            return new Domain.Entities.Booking
            {
                Id = dto.Id,
                GuestId = dto.GuestId,
                RoomId = dto.RoomId,
                Start = dto.Start,
                End = dto.End
            };
        }

        public static BookingDto MapToDto(Domain.Entities.Booking entity)
        {
            return new BookingDto
            {
                Id = entity.Id,
                GuestId = entity.GuestId,
                RoomId = entity.RoomId,
                Start = entity.Start,
                End = entity.End
            };
        }
    }
}
