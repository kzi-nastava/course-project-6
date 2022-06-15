using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Models
{
    public class DoctorQuery
    {
        public string doctor;
        public int quality;
        public int recommendation;
        public string comment;
        public float average;

        public DoctorQuery(string Doctor, int Quality, int Recommendation, float Average, string Comment)
        {
            doctor = Doctor;
            quality = Quality;
            recommendation = Recommendation;
            average = Average;
            comment = Comment;
        }
    }

    public class HospitalQuery
    {
        public int quality;
        public int hygiene;
        public int satisfied;
        public int recommendation;
        public double average;
        public string comment;

        public HospitalQuery(int Quality, int Hygiene, int Satistied, int Recommendation, double Average, string Comment)
        {
            quality = Quality;
            hygiene = Hygiene;
            satisfied = Satistied;
            recommendation = Recommendation;
            average = Average;
            comment = Comment;
        }
    }
}
