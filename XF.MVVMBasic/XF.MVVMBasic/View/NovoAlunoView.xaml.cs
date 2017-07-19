using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.MVVMBasic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoAlunoView : ContentPage
    {
        public NovoAlunoView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Limpar();
        }

        private void OnCancelar(object sender, EventArgs e)
        {
            Limpar();
            Navigation.PopAsync();
        }

        private void Limpar()
        {
            txtNome.Text = txtRM.Text = txtEmail.Text = string.Empty;
        }        
    }
}