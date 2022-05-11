using System;

namespace ProfessorClasses
{
    public class Professor
    {
        private int id;
        private string firstName;
        private string lastName;
        private string teachingSubject;

        public Professor(int profLn, string first, string last, string department)
        {
            id = profLn;
            firstName = first;
            lastName = last;
            teachingSubject = department;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string TeachingSubject
        {
            get
            {
                return teachingSubject;
            }
            set
            {
                teachingSubject = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Id: {0} First Name: {1} Last Name: {2} Department:  {4}", id, firstName, lastName, teachingSubject);
        }
    }
}
    
