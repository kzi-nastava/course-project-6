using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;

namespace ProjectUSI.Doctor.Controller
{
    public class FreeDaysController
    {
        private FreeDays _model;
        private FreeDaysRepository _freeDaysRepository;
        private FreeDaysWindow _view;

        public FreeDaysController(FreeDays model, FreeDaysWindow view, FreeDaysRepository freeDaysRepository)
        {
            _model = model;
            _freeDaysRepository = freeDaysRepository;
            _view = view;
        }
        
    }
}