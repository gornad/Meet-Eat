using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Linq;
using Nutshell.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Nutshell
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class EventsPage : ContentPage
    {
        public ObservableCollection<EventModel> events { get; set; }
        public EventsPage()
        {
            InitializeComponent();

            events = new ObservableCollection<EventModel>();
            events.Add(new EventModel { Picture = "Texture1.jpg" , Name = "Google Tech talk", Time = "4/10/17 6:00PM", Location = "Hammond 332", Freebies = "Free Swag and Pizza!", Points = "130 Points"});
            events.Add(new EventModel { Picture = "Texture2.jpg", Name = "HackPSU 2017", Time = "4/8/17 11:00AM", Location = "Business building", Freebies = "Free food and company swag" , Points = "300 Points" });
            events.Add(new EventModel { Picture = "Texture3.jpg", Name = "Code PSU", Time = "4/10/17 4PM", Location = "Hammond 208", Freebies = "None", Points = "20 Points" });
            events.Add(new EventModel { Picture = "Texture4.jpg", Name = "Microsoft Meet and Greet", Time = "4/8/17 11:00AM", Location = "Business building", Freebies = "Free food and company swag", Points = "300 Points" });
            events.Add(new EventModel { Picture = "Texture5.jpg", Name = "ACM Puzzle Day", Time = "4/11/17 6:00PM", Location = "Hammond 332", Freebies = "Free Swag and Pizza!", Points = "130 Points" });
            events.Add(new EventModel { Picture = "Texture6.jpg", Name = "Reverse Engineering Lab", Time = "4/19/17 4PM", Location = "Hammond 208", Freebies = "None", Points = "20 Points" });
            listView.ItemsSource = events;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new EventDetailPage());
        }
    }
}
