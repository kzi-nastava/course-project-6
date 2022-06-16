using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Rooms.Controller;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Rooms.View
{
    public partial class RenovationWindow : Form
    {
        private MainRepository _mainRepository;
        private List<Renovation> _renovations;
        internal RenovationController _controller;
        public RenovationWindow(MainRepository mainRepository, RenovationController renovationController)
        {
            _mainRepository = mainRepository;
            _renovations = _mainRepository.RenovationRepository.GetRenovation();
            _controller = renovationController;
            InitializeComponent();
            InitListBox(_renovations);
        }
        private void InitListBox(List<Renovation> renovations)
        {
            for (int i = 0; i < _renovations.Count; i++)
            {
                listBox1.Items.Add(renovations.ElementAt(i).ToString());
            }
        }
        //Doctor/Data/Appointments1.json
    }
}