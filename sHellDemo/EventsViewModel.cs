using System.Windows.Input;

namespace sHellDemo
{
    public class EventsViewModel
    {

        public EventsViewModel()
        {
            EventDetailsClickedCommand = new Command(OnEventDetailsClicked);
        }

        public ICommand EventDetailsClickedCommand { get; }

        private async void OnEventDetailsClicked()
        {
            await Shell.Current.GoToAsync("//events/details");
        }
    }

}
