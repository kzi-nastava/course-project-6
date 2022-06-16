using System;
using System.Collections.Generic;
using Patients.Models;
using ProjectUSI.Polls.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Polls.Controller
{
    public class HospitalPoolsController
    {
        private HospitalPoolsRepository _hospitalPoolsRepository;
        private Dictionary<string, Dictionary<int, int>> _grades;

        public HospitalPoolsController(MainRepository mainRepository)
        {
            _hospitalPoolsRepository = mainRepository.HospitalPoolsRepository;
            InitGrades();
            GetGradesCount();
        }

        public List<HospitalQuery> GetPools()
        {
            return _hospitalPoolsRepository.GetPools();
        }

        public Dictionary<string, Dictionary<int, int>> GetGrades()
        {
            return _grades;
        }

        private void InitGrades()
        {
            _grades = new Dictionary<string, Dictionary<int, int>>();
            _grades["hygiene"] = new Dictionary<int, int>();
            _grades["quality"] = new Dictionary<int, int>();
            _grades["recommendation"] = new Dictionary<int, int>();
            _grades["satisfied"] = new Dictionary<int, int>();
            for (int i = 1; i < 6; i++)
            {
                _grades["hygiene"][i] = 0;
                _grades["quality"][i] = 0;
                _grades["recommendation"][i] = 0;
                _grades["satisfied"][i] = 0;
            }
            
        }

        public void GetGradesCount()
        {
            foreach (HospitalQuery hospitalQuery in _hospitalPoolsRepository.GetPools())
            {
                _grades["hygiene"][hospitalQuery.hygiene] += 1;
                _grades["quality"][hospitalQuery.quality] += 1;
                _grades["recommendation"][hospitalQuery.recommendation] += 1;
                _grades["satisfied"][hospitalQuery.satisfied] += 1;
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
        
    }
}