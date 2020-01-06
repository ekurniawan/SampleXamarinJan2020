using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployee : ContentPage
    {
        private DataAccess dataAcces;
        public AddEmployee()
        {
            InitializeComponent();
            dataAcces = new DataAccess();
        }

        private async void btnCreate_Clicked(object sender, EventArgs e)
        {
            
            Employee newEmp = new Employee
            {
                EmpName = "Erick",
                Designation = "IT",
                Department = "IT",
                Qualification = "Mobile Dev"
            };
            try
            {
                dataAcces.SaveEmployee(newEmp);
                await DisplayAlert("Keterangan", $"Data emp {newEmp.EmpName} berhasil ditambah","OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ketarangan", $"Error: {ex.Message}","OK");
            }
        }

        private async void btnSelect_Clicked(object sender, EventArgs e)
        {
            List<Employee> data = dataAcces.GetAllEmployees().ToList();
            await DisplayAlert("Keterangan", $"{data[0].EmpName}","OK");
        }
    }
}