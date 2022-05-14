using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;

namespace ProjectUSI.Doctor.Controller
{
    public class ReferralController
    {
        private Referral _model;
        private ReferralRepository _referralRepository;
        private ReferralWindow _view;

        public ReferralController(Referral model, ReferralWindow view, ReferralRepository referralRepository)
        {
            this._model = model;
            this._referralRepository = referralRepository;
            this._view = view;
        }
    }
}