using System.Collections.Immutable;
using System.Text;

namespace Employees
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Skills { get; set; }
        public string Education { get; set; }
        public string Expirience { get; set; }

        public static EmployeeBuilder CreateBuilder()
        {
            return new EmployeeBuilder();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Firstname: \t{Firstname}");
            sb.AppendLine($"Surname: \t{Surname}");
            sb.AppendLine($"Phone Number: \t{Phonenumber}");
            sb.AppendLine($"Date of Birth: \t{DateOfBirth.ToShortDateString()}");
            string[] skills = Skills.Split("\r\n");
            sb.Append("Skills:\r\n");
            foreach( string skill in skills )
            {
                sb.AppendLine('\t'+skill);
            }
            string[] educations = Education.Split("\r\n");
            sb.Append("Education:\r\n");
            foreach (string education in educations)
            {
                sb.AppendLine('\t' + education);
            }
            string[] exps = Expirience.Split("\r\n");
            sb.Append("Expirience:\r\n");
            foreach (string exp in exps)
            {
                sb.AppendLine('\t' + exp);
            }

            return sb.ToString();
        }



    }

    public class EmployeeBuilder
    {
        private Employee employee;

        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        public EmployeeBuilder SetFirstname(string firstname)
        {
            employee.Firstname = firstname;
            return this;
        }
        public EmployeeBuilder SetSurname(string surname)
        {
            employee.Surname = surname;
            return this;
        }
        public EmployeeBuilder SetPhonenumber(string phonenumber)
        {
            employee.Phonenumber = phonenumber;
            return this;
        }
        public EmployeeBuilder SetSkills(string skills)
        {
            employee.Skills = skills;
            return this;
        }
        public EmployeeBuilder SetDateOfBirth(DateTime dateOfBirth)
        {
            employee.DateOfBirth = dateOfBirth;
            return this;
        }
        public EmployeeBuilder SetEmail(string email)
        {
            employee.Email = email;
            return this;
        }
        public EmployeeBuilder SetEducation(string education)
        {
            employee.Education = education;
            return this;
        }
        public EmployeeBuilder SetExpirience(string expirience)
        {
            employee.Expirience = expirience;
            return this;
        }
        public Employee Build()
        {
            return employee;
        }

        public static implicit operator Employee(EmployeeBuilder builder)
        {
            return builder.Build();
        }
    }





}