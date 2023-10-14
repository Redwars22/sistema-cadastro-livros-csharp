using System;
namespace sistemacadastrolivros
{
    public partial class ErrorMessageForm : Gtk.Dialog
    {
        public ErrorMessageForm(string message)
        {
            this.Build();
            ErrorMessageLabel.Text = message;
        }

        protected void OnButtonOkClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
