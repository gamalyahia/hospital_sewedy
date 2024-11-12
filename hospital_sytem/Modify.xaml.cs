using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hospital_sytem
{
    public partial class Modify : Page
    {
        hospitalEntities db = new hospitalEntities();
        public Modify()
        {
            InitializeComponent();
            patients_table.ItemsSource = db.Patients.ToList();
            doctors_table.ItemsSource = db.Doctors.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (specialization_field.Text == "" && status_field.Text.Length > 0)
            {
                Patient rec = new Patient();
                rec.doctorID = int.Parse(doctor_id_field.Text);
                rec.patientName = name_field.Text;
                rec.patientStatus = status_field.Text;
                db.Patients.Add(rec);
            }
            else if (status_field.Text == "" && specialization_field.Text.Length > 0)
            {
                Doctor rec =  new Doctor();
                rec.doctorName = name_field.Text;
                rec.doctorSpeclization = specialization_field.Text;
                db.Doctors.Add(rec);
            }
            db.SaveChanges();
            doctors_table.ItemsSource = db.Doctors.ToList();
            patients_table.ItemsSource = db.Patients.ToList();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (specialization_field.Text == "" && status_field.Text.Length > 0)
            {
                Patient rec = new Patient();
                var idValue = int.Parse(id_field.Text);
                rec = db.Patients.Where(x => x.patientID == idValue).ToList().FirstOrDefault();
                rec.doctorID = doctor_id_field.Text.Length > 0 ? int.Parse(doctor_id_field.Text) : rec.doctorID;
                rec.patientName = name_field.Text;
                rec.patientStatus = status_field.Text;
                db.Patients.AddOrUpdate(rec);
            }
            else if (status_field.Text == "" && specialization_field.Text.Length > 0)
            {
                Doctor rec = new Doctor();
                var idValue = int.Parse(id_field.Text);
                rec = db.Doctors.Where(x => x.doctorID == idValue).ToList().FirstOrDefault();
                rec.doctorName = name_field.Text;
                rec.doctorSpeclization = specialization_field.Text;
                db.Doctors.AddOrUpdate(rec);
            }
            db.SaveChanges();
            doctors_table.ItemsSource = db.Doctors.ToList();
            patients_table.ItemsSource = db.Patients.ToList();
            MessageBox.Show("Data updated");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (doctor_id_field.Text == "" && id_field.Text.Length > 0)
            {
                var idValue = int.Parse(id_field.Text);
                db.Patients.Remove(db.Patients.First(x => x.patientID == idValue));

            }
            else if (id_field.Text == "" && doctor_id_field.Text.Length > 0)
            {
                var idValue = int.Parse(doctor_id_field.Text);
                db.Doctors.Remove(db.Doctors.First(x => x.doctorID == idValue));
            }
            db.SaveChanges();
            doctors_table.ItemsSource = db.Doctors.ToList();
            patients_table.ItemsSource = db.Patients.ToList();
            MessageBox.Show("Data deleted");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string patientSearch = search_field.Text;
            patients_table.ItemsSource = db.Patients.Where(x=>x.patientName.Contains( patientSearch)).ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string doctorSearch = search_field.Text;
            doctors_table.ItemsSource = db.Doctors.Where(x => x.doctorName.Contains( doctorSearch)).ToList();
        }
    }
}
