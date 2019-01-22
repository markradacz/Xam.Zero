using System.Threading.Tasks;
using System.Windows.Input;
using Xam.Zero.Dev.Features.Second;
using Xamarin.Forms;

namespace Xam.Zero.Dev.Features.Home
{
    public class HomeViewModel : ZeroBaseModel
    {
        private string _text;
        public string Text
        {
            get => this._text;
            set
            {
                this._text = value;
                this.RaisePropertyChanged(()=>this.Text);
            } 
        }

        public ICommand NavigateCommand { get; set; }

        public HomeViewModel()
        {
            this.Text = "Ctor";
            this.NavigateCommand = new Command(async ()=> await this.GoTo<SecondPage>(null));
        }


        protected override Task Init(object data)
        {
            this.Text = "init";
            return base.Init(data);
        }

        protected override Task ReverseInit(object data)
        {
            this.Text = "reverseinit";
            return base.ReverseInit(data);
        }
    }
}