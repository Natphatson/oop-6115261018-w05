using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261018_w05
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectCredit;
        private string subjectPeriods;
        private string subjectPractice;

        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public string SubjectCredit
        {
            get { return subjectCredit; }
            set { subjectCredit = value; }
        }

        public string SubjectPeriods
        {
            get { return subjectPeriods; }
            set { subjectPeriods = value; }
        }

        public string SubjectPractice
        {
            get { return subjectPractice; }
            set { subjectPractice = value; }
        }
        public Subject() { }
        public Subject(string sc, string sn, string scr, string sp, string spr)
        {
            this.SubjectCode = sc;
            this.SubjectName = sn;
            this.SubjectCredit = scr;
            this.SubjectPeriods = sp;
            this.SubjectPractice = spr;
        }
        public override string ToString()
        {
            return this.SubjectCode + this.SubjectName
                + this.SubjectCredit + this.SubjectPeriods + this.SubjectPractice;
        }
    }
}