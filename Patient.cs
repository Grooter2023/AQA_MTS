using System;

namespace Task_two;

public class Patient: TreatmentPlan
{
    public string NamePatient;
    public int treatmentPlan;

    // Конструктор класса принимает на вход один параметр для инициализации переменной класса - NamePatient.
    public Patient(string NamePatient) { this.NamePatient = NamePatient }

    // Конструктор класса принимает на вход один параметр для инициализации переменной, вызывая базовый конструктор у класса TreatmentPlan. 
    public Patient(int treatmentPlan) : base(treatmentPlan)

    //метод назначить врача;
    public void AppointADoctor()
    { 
        Doctor doctor = new Doctor();

        if (TreatmentPlan.Code==1)
        {
            doctor = new Surgeon();
        }
        else if (TreatmentPlan.Code == 2)
        {
            doctor = new Dentist();
        }
        else
        {
            doctor = new Therapist();
        }
            doctor.Treat(); 
    }
}