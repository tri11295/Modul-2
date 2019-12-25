using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class InputViewModel : BaseViewModel
    {
        private ObservableCollection<Model.InputInfo> _List;
        public ObservableCollection<Model.InputInfo> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<Model.Object> _Object;
        public ObservableCollection<Model.Object> Object { get => _Object; set { _Object = value; OnPropertyChanged(); } }

        private ObservableCollection<Model.Input> _Input;
        public ObservableCollection<Model.Input> Input { get => _Input; set { _Input = value; OnPropertyChanged(); } }

        private Model.InputInfo _SelectedItem;
        public Model.InputInfo SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Count = SelectedItem.Count;
                    InputPrice = SelectedItem.InputPrice;
                    OutputPrice = SelectedItem.OutputPrice;
                    Status = SelectedItem.Status;
                    SelectedObject = SelectedItem.Object;
                    SelectedInput = SelectedItem.Input;
                    //ObjectDisplayName = SelectedItem.Object.DisplayName;
                    //DateInput = SelectedItem.Input.DateInput;
                }
            }
        }

        //private Nullable<System.DateTime> _DateInput;
        //public Nullable<System.DateTime> DateInput { get => _DateInput; set { _DateInput = value; OnPropertyChanged(); } }


        //private string _ObjectDisplayName;
        //public string ObjectDisplayName { get => _ObjectDisplayName; set { _ObjectDisplayName = value; OnPropertyChanged(); } }


        private Nullable<int> _Count;
        public Nullable<int> Count { get => _Count; set { _Count = value; OnPropertyChanged(); } }


        private Nullable<double> _InputPrice;
        public Nullable<double> InputPrice { get => _InputPrice; set { _InputPrice = value; OnPropertyChanged(); } }


        private Nullable<double> _OutputPrice;
        public Nullable<double> OutputPrice { get => _OutputPrice; set { _OutputPrice = value; OnPropertyChanged(); } }


        private string _Status;
        public string Status { get => _Status; set { _Status = value; OnPropertyChanged(); } }


        private Model.Object _SelectedObject;
        public Model.Object SelectedObject
        {
            get => _SelectedObject;
            set
            {
                _SelectedObject = value;
                OnPropertyChanged();
            }
        }

        private Model.Input _SelectedInput;
        public Model.Input SelectedInput
        {
            get => _SelectedInput;
            set
            {
                _SelectedInput = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public InputViewModel()
        {
            List = new ObservableCollection<Model.InputInfo>(Dataprovider.Ins.DB.InputInfoes);
            Object = new ObservableCollection<Model.Object>(Dataprovider.Ins.DB.Objects);
            Input = new ObservableCollection<Model.Input>(Dataprovider.Ins.DB.Inputs);

            AddCommand = new RelayCommand<InputInfo>((p) =>
            {
                if (SelectedObject == null || SelectedInput == null)
                    return false;
                return true;

            }, (p) =>
            {
                var Object = new Model.InputInfo() { Count = Count,InputPrice = InputPrice,OutputPrice = OutputPrice,Status = Status,IdObject = SelectedObject.Id,IdInput = SelectedInput.Id, Id = Guid.NewGuid().ToString() };

                Dataprovider.Ins.DB.InputInfoes.Add(Object);
                Dataprovider.Ins.DB.SaveChanges();

                List.Add(Object);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedObject == null || SelectedInput == null)
                    return false;

                var displayList = Dataprovider.Ins.DB.InputInfoes.Where(x => x.Id == SelectedItem.Id);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var Object = Dataprovider.Ins.DB.InputInfoes.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                Object.InputPrice = InputPrice;
                Object.OutputPrice = OutputPrice;
                Object.Status = Status;
                Object.IdObject = SelectedObject.Id;
                Object.IdInput = SelectedInput.Id;
                Object.Count = Count;
               
                Dataprovider.Ins.DB.SaveChanges();

                
                //SelectedItem.Object.DisplayName = ObjectDisplayName;
                //SelectedItem.Input.DateInput = DateInput;
            });
        }
    }
}
