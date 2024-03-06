using StudentGuide.Models;
using System.Collections.ObjectModel;

namespace StudentGuide.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private ObservableCollection<DataItemModel> dataItems;
        private int currentIndex = -1;

        public MainViewModel()
        {
            // Initialize data
            dataItems = new ObservableCollection<DataItemModel>
            {
                    new DataItemModel { Title = "CAFETERIA", Description = "CAFETERIA BUILDING", ImagePath = "cafe1.jpg" },
                    new DataItemModel { Title = "LIBRARY", Description = "CAMPUS LIBRARY BUILDING", ImagePath = "library2.jpg" },
                    new DataItemModel { Title = "OLD ACAD", Description = "CAS/COED BUILDING", ImagePath = "oldacad2.jpg" },
                    new DataItemModel { Title = "CAS Building", Description = "CAS BUILDING", ImagePath = "casbldg1.jpg" },
                    new DataItemModel { Title = "ADMIN", Description = "ADMINISTRATIVE BUILDING", ImagePath = "adminbldng2.jpg" },
                    new DataItemModel { Title = "DORM", Description = "TAUSI HALL", ImagePath = "dormm2.jpg" },
                    new DataItemModel { Title = "OLD AD", Description = "COLLEGE OF FISHERIES BUILDING", ImagePath = "fisherishbldg2.jpg" },
                    new DataItemModel { Title = "OD ACHFAD", Description = "HENRY V KONG GYMNASIUM", ImagePath = "gym2.jpg" },
                    new DataItemModel { Title = "OCAD", Description = "IOES BUILDING", ImagePath = "ioesnldng1.jpg" },
                    new DataItemModel { Title = "OLD ACERAD", Description = "JOSE I. SULIT BUILDING", ImagePath = "josebldg.jpg" },
                    new DataItemModel { Title = "OLD D", Description = "MARINE FISHERIES DEP. BLDG", ImagePath = "marinefsheris1.jpg" },

                      new DataItemModel { Title = "OLD EE", Description = "RESEARCH & EXTENSION OFFICE", ImagePath = "marinesci4.jpg" },
                      new DataItemModel { Title = "OLD SAHFD", Description = "MASJID", ImagePath = "masjid1.jpg" },
                      new DataItemModel { Title = "OLD ADFCAD", Description = "ACADEMIC BUILDING", ImagePath = "newacad2.jpg" },
                      new DataItemModel { Title = "OLD FD", Description = "SECONDARY BUILDING", ImagePath = "second3.jpg" },
                      new DataItemModel { Title = "OLD FGD", Description = "SUPPLY BUILDING", ImagePath = "procure1.jpg" },
                      new DataItemModel { Title = "OLD ACAGSD", Description = "REGISTRAR BUILDING", ImagePath = "registrar1.jpg" },
                      new DataItemModel { Title = "OLD RT", Description = "STUDENT CENTER", ImagePath = "studentcntr2.jpg" },
                      new DataItemModel { Title = "OLD ACDFGAD", Description = "PROCUREMENT BUILDING", ImagePath = "supply1.jpg" },
                      new DataItemModel { Title = "OLD", Description = "AUDITORIUM", ImagePath = "auditori2.jpg" },


                       new DataItemModel { Title = "OLD", Description = "CAS BUILDING-2 ", ImagePath = "cas2bldg3.jpg" },
                        new DataItemModel { Title = "OLD", Description = "TENNIS COURT ", ImagePath = "tenniscrt1.jpg" },
                         new DataItemModel { Title = "OLD", Description = "ISL BUILDING", ImagePath = "islbldg3.jpg" },
                          new DataItemModel { Title = "OLD", Description = " STUDENT FOOD INNOVATION CENTER", ImagePath = "food1.jpg" },
                          new DataItemModel { Title = "OLD", Description = "MARINE SCIENCE MUSEUM", ImagePath = "fish.jpg" },
                          new DataItemModel { Title = "OLD", Description = "COLLEGE INFIRMARY BUILDING", ImagePath = "infir2.jpg" },
                           new DataItemModel { Title = "OLD", Description = "COED BUILDING", ImagePath = "coedbldng1.jpg" },
                            new DataItemModel { Title = "OLD", Description = "DANDUNAY HALL", ImagePath = "dorml2.jpg" },
                     
                // Add more data items as needed
            };

            // Set initial data
            UpdateUI();
        }

        public Command ExitCommand => new Command(Exit);

        private void Exit()
        {
            currentIndex = -1; // Reset the index
            UpdateUI(); // Reset the UI
        }

        public ObservableCollection<DataItemModel> DataItems
        {
            get => dataItems;
            set
            {
                dataItems = value;
                OnPropertyChanged();
            }
        }

        private void UpdateUI()
        {
            OnPropertyChanged(nameof(CurrentDataItem));
            OnPropertyChanged(nameof(CurrentButtonId));
            OnPropertyChanged(nameof(IsDataVisible)); // New property
        }

        public bool IsDataVisible => currentIndex > -1;

        public Command ChangeDataCommand => new Command<string>(ChangeData);

        private void ChangeData(string buttonId)
        {
            // Find the index based on the buttonId
            int index = int.Parse(buttonId) - 1; // Assuming buttonIds are 1, 2, 3, ...

            // Update index only if it's within the range of dataItems
            if (index >= 0 && index < dataItems.Count)
            {
                currentIndex = index;

                // Update UI with the new data
                UpdateUI();
            }
        }

        public DataItemModel CurrentDataItem => IsDataVisible ? dataItems[currentIndex] : null;
        public string CurrentButtonId => (currentIndex + 1).ToString(); // Assuming buttonIds are 1, 2, 3, ...
    }


}

