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
using unicomtlc.Views.admin;

namespace unicomtlc.Views
{
    public partial class TimetableForm : Form
    {
        private Form _previousForm;
        private readonly TimetableController _controller = new TimetableController();
        private int selectedTimeTableId = -1;

        private LecturerController _lecturerController = new LecturerController();
        private subjectController _subjectController = new subjectController();
        private RoomController _roomController = new RoomController();

        public TimetableForm(Lecturerview lecturerview)
        {
            InitializeComponent();
            LoadLecturers();
            LoadSubjects();
            LoadRooms();
            LoadDays();
            LoadTimes();
            LoadTimeTables();
            this._previousForm = lecturerview;
            
            /*this.BackColor = Color.Red;  // Form background black

            Button blackBtn = new Button();
            blackBtn.Text = "Black Button";
            blackBtn.BackColor = Color.Red;
            blackBtn.ForeColor = Color.White;
            blackBtn.Size = new Size(120, 40);
            blackBtn.Location = new Point(50, 50);

            this.Controls.Add(blackBtn);*/
        }
        public TimetableForm(Adminview adminview)
        {
            InitializeComponent();
            this._previousForm = adminview;
            LoadLecturers();
            LoadSubjects();
            LoadRooms();
            LoadDays();
            LoadTimes();
            LoadTimeTables();
        }
       


        public TimetableForm(Staffview staffview)
        {
            InitializeComponent();
            this._previousForm = staffview;
        }

        public TimetableForm()
        {
        }

        private void LoadLecturers()
        {
            var lecturers = _lecturerController.GetAllLecturers(); 
            Lecturerbox.DataSource = lecturers;
            Lecturerbox.DisplayMember = "Name";    
            Lecturerbox.ValueMember = "Id";        
            Lecturerbox.SelectedIndex = -1;
        }
        private void LoadSubjects()
        {
            var subjects = _subjectController.GetAllSubjectsWithCourseName();
            subjectbox.DataSource = subjects;
            subjectbox.DisplayMember = "Name";
            subjectbox.ValueMember = "Id";
            subjectbox.SelectedIndex = -1;
        }
        private void LoadRooms()
        {
            var rooms = _roomController.GetAllRooms();
            roombox.DataSource = rooms;
            roombox.DisplayMember = "RoomName";
            roombox.ValueMember = "RoomID";
            roombox.SelectedIndex = -1;
        }
        private void LoadDays()
        {
            var days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            daybox.DataSource = days;
            daybox.SelectedIndex = -1;
        }
        private void LoadTimes()
        {
            var times = new List<string>
        {
            "08:00 AM - 09:00 AM",
            "09:00 AM - 10:00 AM",
            "10:00 AM - 11:00 AM",
            "11:00 AM - 12:00 PM",
            "12:00 PM - 01:00 PM",
            "01:00 PM - 02:00 PM",
            "02:00 PM - 03:00 PM",
            "03:00 PM - 04:00 PM",
        };
            timebox.DataSource = times;
            timebox.SelectedIndex = -1;
        }
        private void TimetableForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Lecturerbox.SelectedIndex == -1 || subjectbox.SelectedIndex == -1 ||
            daybox.SelectedIndex == -1 || timebox.SelectedIndex == -1 || roombox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var tt = new TimeTable
            {
                Lecturer = Lecturerbox.Text,
                Subject = subjectbox.Text,
                Day = daybox.Text,
                Time = timebox.Text,
                Room = roombox.Text
            };

            _controller.AddTimeTable(tt);
            LoadTimeTables();
            ClearFields();
            MessageBox.Show("TimeTable added successfully!");
            
        }

        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timetableview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = timetableview.SelectedRows[0];

                // Example: update your form fields
                int selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                string lecturer = row.Cells["Lecturer"].Value.ToString();
                string subject = row.Cells["Subject"].Value.ToString();
                string day = row.Cells["Day"].Value.ToString();
                string time = row.Cells["Time"].Value.ToString();
                string room = row.Cells["Room"].Value.ToString();

                // Set values to form controls (ComboBoxes/TextBoxes)
                Lecturerbox.Text = lecturer;
                subjectbox.Text = subject;
                daybox.Text = day;
                timebox.Text = time;
                roombox.Text = room;

                // Store selected ID globally if needed for update/delete
                selectedTimeTableId = selectedId;
            }

        }
        private void ClearFields()
        {
            selectedTimeTableId = -1;
            Lecturerbox.SelectedIndex = -1;
            subjectbox.SelectedIndex = -1;
            daybox.SelectedIndex = -1;
            timebox.SelectedIndex = -1;
            roombox.SelectedIndex = -1;
            timetableview.ClearSelection();
        }
        private void LoadTimeTables()
        {
            timetableview.DataSource = null;
            timetableview.DataSource = _controller.GetAllTimeTables();

            
            timetableview.Columns["Id"].Visible = true;
        }

        private void dele_Click(object sender, EventArgs e)
        {
            if (selectedTimeTableId == -1)
            {
                MessageBox.Show("Select a timetable entry to update.");
                return;
            }

            if (Lecturerbox.SelectedIndex == -1 || subjectbox.SelectedIndex == -1 ||
                daybox.SelectedIndex == -1 || timebox.SelectedIndex == -1 || roombox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var tt = new TimeTable
            {
                Id = selectedTimeTableId,
                Lecturer = Lecturerbox.Text,
                Subject = subjectbox.Text,
                Day = daybox.Text,
                Time = timebox.Text,
                Room = roombox.Text
            };

            _controller.UpdateTimeTable(tt);
            LoadTimeTables();
            ClearFields();
            MessageBox.Show("TimeTable updated successfully!");
        }

        private void timetableview_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void black_Click(object sender, EventArgs e)
        {
            /*Staffview form1 = new Staffview();
            this.Hide();
            form1.ShowDialog();

            
            this.Show();*/
            /*  this.Close();
              _previousForm.Show();*/
            this.Close();

            this.Close();  // Close current form

            if (_previousForm != null)
                _previousForm.Show();  // Show Adminview again
            else
                MessageBox.Show("Previous form reference is missing.", "Warning");
        }

        private void timetableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
