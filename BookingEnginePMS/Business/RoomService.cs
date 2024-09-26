using BookingEnginePMS.Domain;
using BookingEnginePMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingEnginePMS.Business
{
    public class RoomService : IBaseServiceMultiHotel<Room, int>
    {
        public void DeleteById(int hotelId, int key)
        {
            using (var context = new MyContext())
            {
                Room room = context.Rooms
                    .Where(x => x.HotelId == hotelId)
                    .FirstOrDefault(x => x.RoomId == key);
                if (room != null)
                {
                    room.Deleted = true;
                    context.SaveChanges();
                }
            }
        }

        public List<Room> Get(int hotelId, int roomTypeId)
        {
            using (var context = new MyContext())
            {
                return context.Rooms
                    .AsNoTracking()
                    .Where(x => x.HotelId == hotelId)
                    .Where(x => x.Deleted == false)
                    .Where(x => roomTypeId < 0 || x.RoomTypeId == roomTypeId)
                    .OrderBy(x => x.Floor)
                    .ThenBy(x => x.RoomCode)
                    .ToList();
            }
        }

        public List<Room> GetAll(int hotelId)
        {
            using (var context = new MyContext())
            {
                return context.Rooms
                    .AsNoTracking()
                    .Where(x => x.HotelId == hotelId)
                    .Where(x => x.Deleted == false)
                    .OrderBy(x => x.Floor)
                    .ThenBy(x => x.RoomCode)
                    .ToList();
            }
        }

        public Room GetById(int hotelId, int key)
        {
            using (var context = new MyContext())
            {
                return context.Rooms
                    .Where(x => x.HotelId == hotelId)
                    .Where(x => x.Deleted == false)
                    .Where(x => x.RoomId == key)
                    .FirstOrDefault();
            }
        }

        public Room Insert(int hotelId, Room entity)
        {
            using (var context = new MyContext())
            {
                Room room = new Room()
                {
                    RoomTypeId = entity.RoomTypeId,
                    Floor = entity.Floor,
                    HotelId = hotelId,
                    RoomCode = entity.RoomCode,
                    Status = entity.Status,
                    Deleted = false
                };
                context.Rooms.Add(room);
                context.SaveChanges();

                entity.RoomId = room.RoomId;
            }
            return entity;
        }

        public void Update(int hotelId, int key, Room entity)
        {
            using (var context = new MyContext())
            {
                Room room = context.Rooms
                    .Where(x => x.HotelId == hotelId)
                    .Where(x => x.Deleted == false)
                    .Where(x => x.RoomId == key)
                    .FirstOrDefault();

                if (room != null)
                {
                    room.RoomCode = entity.RoomCode;
                    room.Floor = entity.Floor;
                    room.RoomTypeId = entity.RoomTypeId;
                    room.Status = entity.Status;

                    context.SaveChanges();
                }
            }
        }

        public void CleanAllRoom(int hotelId)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    List<Room> rooms = context.Rooms
                        .Where(x => x.HotelId == hotelId)
                        .Where(x => x.Deleted == false)
                        .ToList();

                    foreach (var room in rooms)
                    {
                        room.Status = Constants.RoomStatus.CLEAN;
                    }

                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }

        public void ChangeStatusRoom(int hotelId, int roomId, int status)
        {
            using (var context = new MyContext())
            {
                Room room = context.Rooms
                    .Where(x => x.HotelId == hotelId)
                    .Where(x => x.Deleted == false)
                    .Where(x => x.RoomId == roomId)
                    .FirstOrDefault();

                if (room != null)
                {
                    room.Status = status;
                    context.SaveChanges();
                }
            }
        }

        public List<Room> GetClean(int hotelId, int roomTypeId, int status)
        {
            using (var context = new MyContext())
            {
                return context.Rooms
                    .AsNoTracking()
                    .Where(x => x.HotelId == hotelId)
                    .Where(x => x.Deleted == false)
                    .Where(x => roomTypeId < 0 || x.RoomTypeId == roomTypeId)
                    .Where(x => status < 0 || x.Status == status)
                    .OrderBy(x => x.Floor)
                    .ThenBy(x => x.RoomCode)
                    .ToList();
            }
        }
    }
}