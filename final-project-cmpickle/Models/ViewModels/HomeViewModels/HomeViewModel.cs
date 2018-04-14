namespace final_project_cmpickle.Models.ViewModels.HomeViewModels
{
    public class HomeViewModel
    {
        public string Vendor { get; set; } = "Cat Inc";

        public HomeViewModel()
        {
            Vendor = "Cat Inc";
        }

        public HomeViewModel(string vendor)
        {
            Vendor = vendor;
        }
    }
}