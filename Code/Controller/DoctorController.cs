﻿using Controller;
using health_clinicClassDiagram.Service;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Controller
{
    public class DoctorController : IDoctorController
    {
        private static DoctorController instance;

        private readonly IService<Doctor> _service = DoctorService.Instance;

        public static DoctorController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoctorController();
                }
                return instance;
            }
        }

        private DoctorController() { }

        public DoctorController(IService<Doctor> service)
        {
            _service = service;
        }

        public Doctor Create(Doctor obj)
        {
            return _service.Create(obj);
        }

        public bool Delete(Doctor obj)
        {
            return _service.Delete(obj);

        }

        public Doctor Edit(Doctor obj)
        {
            return _service.Edit(obj);

        }

        public List<Doctor> GetAll()
        {
            var doctors = (List<Doctor>)_service.GetAll();
            return doctors;
        }

        public Doctor ValidateLogin(string username, string password)
        {
            return DoctorService.Instance.ValidateLogin(username, password);
        }

        public List<Doctor> GetAllAvailableDoctors(DateTime _startDate, DateTime _endDate)
        {
            return DoctorService.Instance.getAllAvailableDoctors(_startDate, _endDate);
        }
    }
}
