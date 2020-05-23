/***********************************************************************
 * Module:  IMedicalRecordController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IMedicalRecordController
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Controller
{
   public interface IMedicalRecordController : IController<MedicalRecord>
   {
      Model.Treatment.Treatment[] GetAllTreatments();
      Model.Appointment.MedicalRecord AddTreatment(Model.Treatment.Treatment treatment);
      Model.Appointment.MedicalRecord GetMedRecByPatient(Model.SystemUsers.Patient patient);
   }
}