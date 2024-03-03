using App3.Models;
using System.Collections.ObjectModel;

namespace App3.ViewModels
{
    public class PeopleViewModel
    {
        public ObservableCollection<Person> People { get; set; }

        public PeopleViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person { Name = "Jan", Age = 20 },
                new Person { Name = "Anna", Age = 25 },
                new Person { Name = "Tomasz", Age = 30 }
            };
        }
    }
}
