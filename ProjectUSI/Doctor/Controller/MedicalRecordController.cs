using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;

namespace ProjectUSI.Doctor.Controller
{
    /// <summary>
    /// This class connects all other classes together for Medical Record data.
    /// </summary>
    public class MedicalRecordController
    {
        private MedicalRecord _model;
        private MedicalRecordRepository _medicalRecordRepository;
        private AppointmentWindow _view;

        public MedicalRecordController(MedicalRecord model, AppointmentWindow view, MedicalRecordRepository medicalRecordRepository)
        {
            this._model = model;
            this._medicalRecordRepository = medicalRecordRepository;
            this._view = view;
        }
    }
}