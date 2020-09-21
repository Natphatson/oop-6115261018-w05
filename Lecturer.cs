using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261018_w05
{
    class Lecturer
    {
        private string lecturerFName;
        private string lecturerLName;
        private string lecturerPosition;

        public string LecturerFName
        {
            get { return lecturerFName; }
            set { lecturerFName = value; }
        }

        public string LecturerLName
        {
            get { return lecturerLName; }
            set { lecturerLName = value; }
        }

        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }
        public Lecturer(string sc, string ln, string lp)
        {
            this.LecturerFName = sc;
            this.LecturerLName = ln;
            this.LecturerPosition = lp;

        }
        public override string ToString()
        {
            return this.LecturerFName + this.LecturerLName + this.LecturerPosition;
        }
    }
}