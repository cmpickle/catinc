namespace final_project_cmpickle.Models.ViewModels.HomeViewModels
{
    public class HomeViewModel
    {
        public string Vendor { get; set; } = "Cat Inc";
        public bool isVendor { get; set; } = false;

        public HomeViewModel()
        {
            Vendor = "Cat Inc";
        }

        public HomeViewModel(string vendor)
        {
            Vendor = vendor;
            isVendor = true;
        }
    }
}