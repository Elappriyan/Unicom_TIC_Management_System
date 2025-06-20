using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Controllers;
using unicomtlc.Moddel;


namespace unicomtlc.Views.Staff
{
    public partial class RoomForm : Form
    {
        private  RoomController _controller = new RoomController();
        private int selectedRoomId = -1;
        private List<string> roomTypes = new List<string> { "Lecture Hall", "Lab", "Seminar Room", "Auditorium" };
        public RoomForm()
        {
            InitializeComponent();
            LoadRoomTypes();
            LoadRooms();
        }
        private void LoadRoomTypes()
        {
            roomtype.DataSource = roomTypes;
            roomtype.SelectedIndex = -1;
        }
        private void ClearFields()
        {
            selectedRoomId = -1;
            roomname.Clear();
            roomtype.SelectedIndex = -1;
            roomview.ClearSelection();
        }
        private void Room_Load(object sender, EventArgs e)
        {

        }
        private void LoadRooms()
        {
            roomview.DataSource = null; 

            List<Room> rooms = _controller.GetAllRooms(); 

            roomview.DataSource = rooms;

            
            roomview.Columns["RoomID"].HeaderText = "Room ID";
            roomview.Columns["RoomName"].HeaderText = "Room Name";
            roomview.Columns["RoomType"].HeaderText = "Room Type";

            roomview.ClearSelection(); 
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomname.Text) || roomtype.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            var room = new Room
            {
                RoomName = roomname.Text.Trim(),
                RoomType = roomtype.SelectedItem.ToString()
            };

            _controller.AddRoom(room);
            LoadRooms();
            ClearFields();
            MessageBox.Show("Room added successfully.");
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            if (roomtype.SelectedIndex == -1 || string.IsNullOrWhiteSpace(roomname.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var room = new Room
            {
                RoomID = selectedRoomId,
                RoomName = roomname.Text.Trim(),
                RoomType = roomtype.SelectedItem.ToString()
            };

            _controller.UpdateRoom(room);
            LoadRooms();
            ClearFields();
            MessageBox.Show("Room updated successfully.");
        }

        private void roomview_SelectionChanged(object sender, EventArgs e)
        {
            
                if (roomview.SelectedRows.Count > 0)
                {
                    var row = roomview.SelectedRows[0];
                    selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                    roomname.Text = row.Cells["RoomName"].Value.ToString();

                    string roomType = row.Cells["RoomType"].Value.ToString();
                    roomtype.SelectedIndex = roomTypes.IndexOf(roomType);
                }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this room?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _controller.DeleteRoom(selectedRoomId);
                LoadRooms();
                ClearFields();
                MessageBox.Show("Room deleted successfully.");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
