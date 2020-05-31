/***********************************************************************
 * Module:  IMedicalRecordController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IMedicalRecordController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IMedicalRecordController : IController
   {
      List<Treatment> GetAllTreatments();
      Model.Appointment.MedicalRecord AddTreatment(Model.Treatment.Treatment treatment, Model.Appointment.MedicalRecord medRec);
      Model.Appointment.MedicalRecord GetMedRecByPatient(Model.SystemUsers.Patient patient);
   }
}