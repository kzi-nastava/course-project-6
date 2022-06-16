using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;

namespace ProjectUSI.Doctor.Controller
{
    /// <summary>
    /// This class connects all other classes together for Appointments data.
    /// </summary>
    public class AppointmentsController
    {
        private Appointments _model;
        private AppointmentsRepository _appointmentRepository;
        private ScheduleWindow _view;

        public AppointmentsController(Appointments model, ScheduleWindow view, AppointmentsRepository scheduleRepository)
        {
            this._model = model;
            this._appointmentRepository = scheduleRepository;
            this._view = view;
        }
        
    }
}