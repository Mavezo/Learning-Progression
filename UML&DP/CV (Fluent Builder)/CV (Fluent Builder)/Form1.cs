using Employees;

namespace CV__Fluent_Builder_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cv = Employee.CreateBuilder().SetFirstname(firstname_Textbox.Text)
                .SetSurname(surname_Textbox.Text)
                .SetPhonenumber(phoneNumber_Textbox.Text)
                .SetEmail(email_Textbox.Text)
                .SetDateOfBirth(DateTime.Parse(dateOfBirth_Textbox.Text))
                .SetSkills(skills_Textbox.Text)
                .SetEducation(education_Textbox.Text)
                .SetExpirience(expirience_Textbox.Text)
                .Build().ToString();
            cvResult_Textbox.Text= cv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cvResult_Textbox.Text);
        }
    }
}