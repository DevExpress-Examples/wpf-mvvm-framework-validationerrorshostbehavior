using DevExpress.Mvvm;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationErrorHostBehavior.ViewModels
{
    public class MainViewModel : ViewModelBase, IDataErrorInfo
    {
        protected string firstname_;
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
         ErrorMessage = "Characters are not allowed.")]
        public string FirstName
        {
            get { return this.firstname_; }
            set { this.SetProperty(ref this.firstname_, value, "FirstName"); }
        }


        protected string lastname_;
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
         ErrorMessage = "Characters are not allowed.")]
        public string LastName
        {
            get { return this.lastname_; }
            set { this.SetProperty(ref this.lastname_, value, "LastName"); }
        }

        public string Error
        {
            get
            {
                return string.Join(";", this["FirstName"], this["LastName"]);
            }
        }

        public string this[string columnName]
        {
            get
            {
                return IDataErrorInfoHelper.GetErrorText(this, columnName);
            }
        }
    }
}
