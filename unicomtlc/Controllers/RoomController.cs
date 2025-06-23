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
            try
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
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error inserting room: {ex.Message}");
                // Handle or rethrow as needed
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error inserting room: {ex.Message}");
                // Handle or rethrow as needed
            }

        }

        public void UpdateRoom(Room room)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "UPDATE Rooms SET RoomName = @name, RoomType = @type WHERE RoomID = @id";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", room.RoomName);
                        cmd.Parameters.AddWithValue("@type", room.RoomType);
                        cmd.Parameters.AddWithValue("@id", room.RoomID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No room found with the specified ID.");
                            // Optionally handle this case (e.g., throw or notify user)
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error updating room: {ex.Message}");
                // Optionally handle or rethrow
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error updating room: {ex.Message}");
                // Optionally handle or rethrow
            }

        }

        public void DeleteRoom(int roomId)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "DELETE FROM Rooms WHERE RoomID = @id";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", roomId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No room found with the specified ID.");
                            // Optionally notify user or handle as needed
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error deleting room: {ex.Message}");
                // Optionally handle or rethrow the exception
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error deleting room: {ex.Message}");
                // Optionally handle or rethrow the exception
            }

        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            try
            {
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
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"Database error fetching rooms: {ex.Message}");
                // Optionally handle or rethrow
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error fetching rooms: {ex.Message}");
                // Optionally handle or rethrow
            }

            return rooms;

        }

        public Room GetRoomById(int roomId)
        {
            try
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
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"Database error fetching room: {ex.Message}");
                // Optionally rethrow or handle error as needed
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error fetching room: {ex.Message}");
                // Optionally rethrow or handle error as needed
            }

            return null;

        }
    }
}
