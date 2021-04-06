using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvWinProjectQuizz.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnvWinProjectQuizz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPageDropdown : ContentPage
    {
        public TestPageDropdown()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int studentId = ((TestDropdown)StudentEntry.SelectedItem).IdStudent;
            Label labelId = this.FindByName<Label>("labelId");

            labelId.Text = studentId.ToString();
        }
    }
}