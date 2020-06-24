/***********************************************************************
 * Module:  TreatmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.TreatmentService
 ***********************************************************************/

using health_clinicClassDiagram.Model.Treatment;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class TreatmentController : ITreatmentController
   {
        public Service.ITreatmentService _service = TreatmentService.Instance;

        private static TreatmentController instance;

        public static TreatmentController Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new TreatmentController();
                }
                return instance;
            }
        }

        private TreatmentController()
        {
        }

        public TreatmentController GetInstance() { return null; }
        public Prescription WritePrescription(List<Drug> drugs, Treatment treatment)
        {
            return _service.WritePrescription(drugs, treatment);
        }

        public SpecialistAppointment WriteReferralToASpecialist(Doctor specialist, String cause, Treatment treatment, ExamOperationRoom room, DateTime startDate, DateTime endDate)
        {
            return _service.WriteReferralToASpecialist(specialist, cause, treatment, room, startDate, endDate);
        }

        public ScheduledSurgery ScheduleSurgery(Model.Treatment.Treatment treatment, DateTime startDate, DateTime endDate, String cause, Surgeon surgeon, ExamOperationRoom room)
        {
            return _service.ScheduleSurgery(treatment, startDate, endDate, cause, surgeon, room);
        }

        public DiagnosisAndReview WriteDiagnosisAndReview(Treatment treatment, String diagnosis, String review)
        {
            return _service.WriteDiagnosisAndReview(treatment, diagnosis, review);
        }

        public ReferralToHospitalTreatment WriteReferralToHospTreat(Model.Treatment.Treatment treatment, DateTime startDate, DateTime endDate, String cause, List<Drug> drugs, RehabilitationRoom room)
        {
            return _service.WriteReferralToHospTreat(treatment, startDate, endDate, cause, drugs, room);
        }

        public Appointment ScheduleControlAppointment(Appointment appointment)
        {
            return _service.ScheduleControlAppointment(appointment);
        }

        public List<Treatment> GetAll()
        {
            return _service.GetAll();
        }

        public bool Delete(Treatment obj)
        {
            return _service.Delete(obj);
        }

        public Treatment Create(Patient patient, Treatment obj)
        {
            return _service.Create(patient, obj);
        }

        public Treatment Edit(Treatment obj)
        {
            return _service.Edit(obj);
        }

        
    }
}