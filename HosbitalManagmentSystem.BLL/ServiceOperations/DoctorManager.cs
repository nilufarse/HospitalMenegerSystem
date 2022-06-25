﻿using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Enums;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class DoctorManager
    {
        public static void AddDoctor()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Doctor adini giriniz");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Doctor soyadini giriniz");
            doctor.Surname = Console.ReadLine();
            Console.WriteLine("Doctorun cinsini giriniz (Kisi:1,Qadin:2)");
            doctor.GetGenderType = (GenderType)int.Parse(Console.ReadLine());

            if (QualificationManager.ShowQualification() > 0)
            {
                
                Console.WriteLine("Nomresini daxil edir");
                int number = int.Parse(Console.ReadLine());

               
                foreach (var item in DataOperation.Qualifications)
                {
                    if (item.Number== number)
                    {
                        doctor.Qualifications.Add(item);
                        break;
                    }
                }
              

            }


            DataOperation.Doctors.Add(doctor);

        }
        public static void ShowDoctor()
        {
            foreach (var item in DataOperation.Doctors)
            {
                Console.WriteLine($"Doctor ad: {item.Name} soyad :{item.Surname}");
                foreach (var qualification in item.Qualifications)
                {
                    Console.WriteLine($"Doctor ixtisasi: {qualification.Name}");
                }
            }


        }
    }
}
