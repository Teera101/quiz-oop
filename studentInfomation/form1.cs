namespace studentInfomation
{
    public partial class form1 : Form
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        public form1()
        {
            InitializeComponent();
            LoadTeachers();

            dataGridView.Visible = false;
        }
        private void LoadTeachers()
        {
            // เพิ่มรายชื่ออาจารย์ลงใน List
            teachers.Add(new Teacher("ดร.สมชาย", "วิศวกรรมคอมพิวเตอร์"));
            teachers.Add(new Teacher("ดร.วรรณพร", "วิศวกรรมซอฟต์แวร์"));
            teachers.Add(new Teacher("ดร.กิตติศักดิ์", "วิศวกรรมไฟฟ้า"));

            // ใส่ข้อมูลอาจารย์ลงใน ComboBox
            comboBox.DataSource = teachers;
            comboBox.DisplayMember = "Name"; // ให้แสดงเฉพาะชื่ออาจารย์

            //dataGridView.DataSource = null;
            //dataGridView.DataSource = teachers;
            //dataGridView.Refresh(); //รีเฟรช DataGridView

            //UpdateDataGridView();
                                                
           
        }

        private void UpdateDataGridView()
        {
            var sortedStudents = students.OrderByDescending(s => s.Grade).ToList();

            dataGridView.DataSource = null;
            dataGridView.DataSource = sortedStudents;
            dataGridView.Refresh();

            if (dataGridView.Columns["Advisor"] != null)
            {
                dataGridView.Columns["Advisor"].Visible = false;
            }
        }
        
       

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem is Teacher selectedTeacher)
            {
                labelDepartment.Text = $"ภาควิชา: {selectedTeacher.Department}";

                //โหลดรายชื่อนักศึกษาที่อยู่ภายใต้ที่ปรึกษาคนนี้
                LoadStudentsForAdvisor(selectedTeacher);

            }
        }

        private void labelDepartment_Click(object sender, EventArgs e)
        {

        }

        private void addstudentButton_Click(object sender, EventArgs e)
        {
            string studentName = sdntextBox.Text.Trim();
            string studentID = sdIDtextBox.Text.Trim();
            string major = sdmTextBox.Text.Trim();
            double grade;

            //ตรวจสอบค่าที่กรอก
            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(major)|| !double.TryParse(gradetextBox.Text, out grade))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ตรวจสอบว่าอาจารย์ที่ปรึกษาได้รับการเลือกแล้ว
            if (comboBox.SelectedItem is not Teacher selectedTeacher)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ตรวจสอบว่านักศึกษามีที่ปรึกษาอยู่แล้วหรือไม่
            if (students.Any(s => s.StudentID == studentID)) // ✅ ใช้ students ที่เป็น List
            {
                MessageBox.Show("รหัสนักศึกษานี้ถูกใช้งานแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Adding Student: {studentName}, Grade: {grade}", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //สร้างนักศึกษาใหม่
            Student newStudent = new Student(studentID, studentName, major, grade);
            newStudent.AssignAdvisor(selectedTeacher);
            students.Add(newStudent);

            //LoadStudentsForAdvisor(selectedTeacher);

            //ล้างข้อมูลใน TextBox
            //UpdateDataGridView();
            sdntextBox.Clear();
            sdIDtextBox.Clear();
            sdmTextBox.Clear();
            gradetextBox.Clear();
        }

        private void LoadStudentsForAdvisor(Teacher advisor)
        {
            //ดึงรายชื่อนักศึกษาของอาจารย์ที่เลือก
            List<Student> studentsOfTeacher = advisor.GetStudents();


            if (studentsOfTeacher.Count == 0)
            {
                dataGridView.Visible = false;
                return;
            }

            var sortedStudents = studentsOfTeacher.OrderByDescending(s => s.Grade).ToList();


            //แสดงรายชื่อนักศึกษาใน DataGridView
            dataGridView.Visible = true;
            dataGridView.DataSource = null; // เคลียร์ข้อมูลเก่า
            dataGridView.DataSource = sortedStudents;

            if (dataGridView.Columns["Advisor"] != null)
            {
                dataGridView.Columns["Advisor"].Visible = false;
            }
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem is Teacher selectedTeacher)
            {
                labelDepartment.Text = $"ภาควิชา: {selectedTeacher.Department}";
            }
        }

        private void showstudentButton_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่ามีอาจารย์ถูกเลือกใน ComboBox หรือไม่
            if (comboBox.SelectedItem is not Teacher selectedTeacher)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษาก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ดึงรายชื่อนักศึกษาของอาจารย์ที่เลือก
            List<Student> studentsOfTeacher = selectedTeacher.GetStudents();

            //ตรวจสอบว่ามีนักศึกษาหรือไม่
            if (studentsOfTeacher.Count == 0)
            {
                dataGridView.Visible = false;
                MessageBox.Show($"อาจารย์ {selectedTeacher.Name} ยังไม่มีนักศึกษาในที่ปรึกษา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var sortedStudents = studentsOfTeacher.OrderByDescending(s => s.Grade).ToList();

            //แสดงรายชื่อนักศึกษาใน DataGridView
            dataGridView.Visible = true;
            dataGridView.DataSource = null; // เคลียร์ข้อมูลเก่า
            dataGridView.DataSource = sortedStudents;

            UpdateDataGridView();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
