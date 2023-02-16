using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract class Students
    {

        public int Rollno { get; set; }
        public string? StudName { get; set; }

        public abstract string InstitutionName { get; set; }

        public abstract void FeesCalculation();
        

    }

    class SchoolStudents : Students
    {

        public override string InstitutionName { get; set; }

        public override void FeesCalculation()
        {
            //throw new NotImplementedException();
        }
    }

    class CollStudents:SchoolStudents
    {

        public override void FeesCalculation()
        {
            base.FeesCalculation();
        }
        public override string InstitutionName { get => base.InstitutionName; set => base.InstitutionName = value; }
    }

    class CollegeStudents : Students
    {
        string instname;
        public override string InstitutionName 
        { 
            get { return instname; } 
            set { instname = value; } 
        }

        public override void FeesCalculation()
        {
            throw new NotImplementedException();
        }
    }

    class InstituteStudents : Students
    {
        public override string InstitutionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void FeesCalculation()
        {
            throw new NotImplementedException();
        }
    }
}
