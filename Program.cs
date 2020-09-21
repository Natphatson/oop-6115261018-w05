using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261018_w05
{
    class Programm
    {
        private string programmName;
        private string programmRank;


        public string Programmname
        {
            get { return programmName; }
            set { programmName = value; }
        }

        public string ProgrammRnank
        {
            get { return programmRank; }
            set { programmRank = value; }
        }

        public Programm(string pn, string pr)
        {
            this.programmName = pn;
            this.programmRank = pr;


        }
        public override string ToString()
        {
            return this.programmRank + this.programmName;
        }
    }
}