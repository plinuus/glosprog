using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class Elev
    {
        private string namn;
        private string klass;

        public Elev(string u, string p)
        {
            this.namn = n;
            this.klass = k;

        }

        public string Namn
        {
            get { return this.namn; }
            set { this.namn = value; }
        }

        public string Password
        {
            get { return this.klass; }
            set { this.klass = value; }
        }

        public override string ToString()
        {
            return (namn + "\t\t" + klass);
        }
    }
}
