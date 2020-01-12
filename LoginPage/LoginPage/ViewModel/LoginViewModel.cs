using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using LoginPage.Model;
using LoginPage.View;
using Xamarin.Forms;

namespace LoginPage.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
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
                _member = value;
                OnPropertyChanged("MemberModel");
            }
        }

        public LoginViewModel()
        {
            _member = new Member();
        }

        public Command MoveToCreateAccountCommand
        {
            get
            {
                return new Command(async () => {
                    await Application.Current.MainPage.Navigation.PushModalAsync(new CreateAccount());
                });
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(MemberLogin);
            }
        }

        private async void MemberLogin()
        {
            Member tempMember = new Member()
            {
                Email = "insert@kakao.com",
                Password = "123456",
                FirstName = "Make It",
                LastName = "Simple"                
            };

            if (tempMember.Email != _member.Email || tempMember.Password != _member.Password)
            {
                string alertMessage = $"로그인에 실패하였습니다. \n로그인 가능한 이메일 : {tempMember.Email}\n비밀번호 : {tempMember.Password}";
                await Application.Current.MainPage.DisplayAlert("로그인실패", alertMessage, "확인");
                return;
            }

            await Application.Current.MainPage.DisplayAlert("로그인 성공!", "로그인에 성공하였습니다", "확인");

        }
    }
}
