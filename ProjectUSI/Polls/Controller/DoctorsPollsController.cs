using System;
using System.Collections.Generic;
using Patients.Models;
using ProjectUSI.Polls.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Polls.Controller
{
    public class DoctorsPollsController
    {
        private DoctorsPollsRepository _doctorsPollsRepository;
        private Dictionary<string, Dictionary<int, int>> _grades;
        private Dictionary<string, Dictionary<int, int>> _doctorGrades;
        private DoctorQuery _doctor;

        public DoctorsPollsController(MainRepository mainRepository, DoctorQuery doctorQuery)
        {
            _doctor = doctorQuery;
            _doctorsPollsRepository = mainRepository.DoctorsPollsRepository;
            InitGrades();
            GetGradesCount();
            
        }

        public void InitDoctor()
        {
            InitDoctorGrades();
            GetGradesCountSingle();
        }

        public List<DoctorQuery> GetPolls()
        {
            return _doctorsPollsRepository.GetPolls();
        }
        public List<DoctorQuery> GetDoctorsPols()
        {
            List<DoctorQuery> singleDoctorPools = new List<DoctorQuery>();
            foreach (DoctorQuery doctorQuery in GetPolls())
            {
                if (_doctor.doctor.Equals(doctorQuery.doctor))
                {
                    singleDoctorPools.Add(doctorQuery);
                }
            }
            return singleDoctorPools;
        }

        public Dictionary<string, Dictionary<int, int>> GetGrades()
        {
            return _grades;
        }

        public Dictionary<string, Dictionary<int, int>> GetDoctorsGrades()
        {
            return this._doctorGrades;
        }

        private void InitGrades()
        {
            _grades = new Dictionary<string, Dictionary<int, int>>();
            _grades["quality"] = new Dictionary<int, int>();
            _grades["recommendation"] = new Dictionary<int, int>();
            for (int i = 1; i < 6; i++)
            {
                _grades["quality"][i] = 0;
                _grades["recommendation"][i] = 0;
            }
            
        }

        public void GetGradesCount()
        {
            foreach (DoctorQuery doctorQuery in _doctorsPollsRepository.GetPolls())
            {
                _grades["quality"][doctorQuery.quality] += 1;
                _grades["recommendation"][doctorQuery.recommendation] += 1;
            }

        }

        public double GetAverage(string property)
        {
            int gradesSum = 0;
            int gradesCount = 0;
            double average;
            foreach (KeyValuePair<int, int> pair in _grades[property])
            {
                gradesCount += pair.Value;
                gradesSum += pair.Key * pair.Value;
            }
            try
            {
                average = (double)gradesSum/(double)gradesCount;
            }
            catch (DivideByZeroException e)
            {
                average = 0.0;
            }

            return average;
        }
        private void InitDoctorGrades()
        {
            if (!_doctor.Equals(new DoctorQuery()))
            {
                _doctorGrades = new Dictionary<string, Dictionary<int, int>>();
                _doctorGrades["quality"] = new Dictionary<int, int>();
                _doctorGrades["recommendation"] = new Dictionary<int, int>();
                for (int i = 1; i < 6; i++)
                {
                    _doctorGrades["quality"][i] = 0;
                    _doctorGrades["recommendation"][i] = 0;
                }
            }
        }

        public void GetGradesCountSingle()
        {
            foreach (DoctorQuery doctorQuery in _doctorsPollsRepository.GetPolls())
            {
                if (_doctor.doctor.Equals(doctorQuery.doctor))
                {
                    _doctorGrades["quality"][doctorQuery.quality] += 1;
                    _doctorGrades["recommendation"][doctorQuery.recommendation] += 1;
                }
                
            }

        }

        public double DoctorsAverage(string property)
        {
            int gradesSum = 0;
            int gradesCount = 0;
            double average;
            foreach (KeyValuePair<int, int> pair in _doctorGrades[property])
            {
                gradesCount += pair.Value;
                gradesSum += pair.Key * pair.Value;
            }
            try
            {
                average = (double)gradesSum/(double)gradesCount;
            }
            catch (DivideByZeroException e)
            {
                average = 0.0;
            }

            return average;
        }
        
    }
}