using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;
using unicomtlc.Moddel;

namespace unicomtlc.Controllers
{
    internal class RoomController
    {
        public void AddRoom(Room room)
        {
            using (var con = DB.GetConnection())
            {
                string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", room.RoomName);
                    cmd.Parameters.AddWithValue("@type", room.RoomType);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRoom(Room room)
        {
            using (var con = DB.GetConnection())
            {
                string query = "UPDATE Rooms SET RoomName = @name, RoomType = @type WHERE RoomID = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", room.RoomName);
                    cmd.Parameters.AddWithValue("@type", room.RoomType);
                    cmd.Parameters.AddWithValue("@id", room.RoomID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRoom(int roomId)
        {
            using (var con = DB.GetConnection())
            {
                string query = "DELETE FROM Rooms WHERE RoomID = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", roomId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (var con = DB.GetConnection())
            {
                string query = "SELECT RoomID, RoomName, RoomType FROM Rooms";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        });
                    }
                }
            }

            return rooms;
        }

        public Room GetRoomById(int roomId)
        {
            using (var con = DB.GetConnection())
            {
                string query = "SELECT RoomID, RoomName, RoomType FROM Rooms WHERE RoomID = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", roomId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Room
                            {
                                RoomID = reader.GetInt32(0),
                                RoomName = reader.GetString(1),
                                RoomType = reader.GetString(2)
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
