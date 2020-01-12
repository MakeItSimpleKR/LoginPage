using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using LoginPage.Model;
using Xamarin.Forms;

namespace LoginPage.ViewModel
{
    class CreateAccountViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Member _member { get; set; }

        public Member MemberModel
        {
            get
            {
                return _member;
            }
            set
            {
                if (_member != value)
                {
                    _member = value;
                    OnPropertyChanged("MemberModel");
                }
            }
        }

        public Command CreateCommand
        {
            get
            {
                return new Command(CreateAccount);
            }
        }

        public Command DismissCommand
        {
            get
            {
                return new Command(async () => {
                    await Application.Current.MainPage.Navigation.PopModalAsync(true);
                });
            }
        }

        private async void CreateAccount()
        {
            string alertMessage = string.Format("FirstName:{0}\nLastName:{1}\nEmail:{2}\nPassword:{3}", _member.FirstName, _member.LastName, _member.Email, _member.Password);
            await Application.Current.MainPage.DisplayAlert("계정생성", alertMessage, "확인");
        }

        public CreateAccountViewModel()
        {
            _member = new Member();
        }
    }
}
