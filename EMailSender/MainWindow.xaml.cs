using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EMailSenderLib;


namespace EMailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            var sendMail = new MailSender();
            ResultLbl.Content =  sendMail.Send(UserNameBox.Text, passwordBox.Password, SubjectBox.Text, BodyBox.Text, ReciverBox.Text);
        }
    }
}
