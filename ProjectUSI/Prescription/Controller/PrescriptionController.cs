using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;

namespace ProjectUSI.Doctor.Controller
{
    /// <summary>
    /// This class connects all other classes together for Prescription data.
    /// </summary>
    public class PrescriptionController
    {
        private Prescription _model;
        private PrescriptionRepository _prescriptionRepository;
        private PrescriptionWindow _view;

        public PrescriptionController(Prescription model, PrescriptionWindow view, PrescriptionRepository prescriptionRepository)
        {
            this._model = model;
            this._prescriptionRepository = prescriptionRepository;
            this._view = view;
        }
    }
}