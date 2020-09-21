using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261018_w05
{
    class Section
    {
        private string sectionDate;
        private string sectionTimeSt;
        private string sectionTimeEn;
        private Room sectionRoom;
        private Subject sectionSubject;
        private Lecturer sectionLecturer;

        public string SectionDate
        {
            get { return this.sectionDate; }
            set { this.sectionDate = value; }
        }

        public string SectionTimeSt
        {
            get { return this.sectionTimeSt; }
            set { this.sectionTimeSt = value; }
        }
        public string SectionTimeEn
        {
            get { return this.sectionTimeEn; }
            set { this.sectionTimeEn = value; }
        }
        public Room SectionRoom
        {
            get { return this.sectionRoom; }
            set { this.sectionRoom = value; }
        }
        public Subject SectionSubject
        {
            get { return this.sectionSubject; }
            set { this.sectionSubject = value; }
        }
        public Lecturer SectionLecturer
        {
            get { return this.sectionLecturer; }
            set { this.sectionLecturer = value; }
        }
        public Section() { }
        public Section(string sd, string sts, string ste, Room sr, Subject ss, Lecturer sl)
        {
            this.SectionDate = sd;
            this.SectionTimeSt = sts;
            this.SectionTimeEn = ste;
            this.SectionRoom = sr;
            this.SectionSubject = ss;
            this.SectionLecturer = sl;
        }
        public override string ToString()
        {
            return " Room " + this.SectionRoom.RoomCode + " " + " Subject "
                + this.SectionSubject.SubjectName + " " + " Lecturer " + this.SectionLecturer.LecturerFName + " "
                + this.SectionLecturer.LecturerLName
                + " Date " + this.SectionDate + " Start " + this.SectionTimeSt + " End " + this.SectionTimeEn;
        }
    }
}