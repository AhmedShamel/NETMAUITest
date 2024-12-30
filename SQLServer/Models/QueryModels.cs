using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EClinicMaui.SQLServer.Models
{

    public enum TypeOfUser { Secretary, SecretaryForDoctor, Doctor }
    public enum DisplayMode { Add, PreviousInfo, Details, AddWithSecretaryInfo };

    public class CostsModel
    {
        public long Id { get; set; }
        public string CostName { get; set; }
        public double CostValue { get; set; }
        public int Order { get; set; }
        public string WhichTable { get; set; }
    }
    public class DoctorPermssionsInMenue
    {
        public string UserFullName { get; set; }
        public bool SeeHisStatistics { get; set; }
        public bool CanAddEditDeleteExpenses { get; set; }
        public bool CanAddEditDeleteAppointments { get; set; }
        public bool CanAddEditDeleteClinicMaterials { get; set; }
        public bool AssignEditVisitsPaidCost { get; set; }
        public bool CanEditCustomFields { get; set; }
    }

    public class DoctorInfoInExpensePage
    {
        public long Id { get; set; }
        public string UserFullName { get; set; }
        public bool SeeOtherDoctorsStatistics { get; set; }
    }

    public class ExpensesModel
    {
        public long Id { get; set; }
        public string ExpensesInfo { get; set; }
        public double Cost { get; set; }
        public double PaidCost { get; set; }
        public double RemainingCost { get; set; }
        public DateTime ExpensesDate { get; set; }
        public string DoctorName { get; set; }
        public string Notes { get; set; }
        public bool ShowDoctorName { get; set; }
    }

    public class MaterialsStoreModel
    {
        public long Id { get; set; }
        public string Material { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double? SingleItemCost { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string SingleItemCostString { get; set; }
        public string TotalCostString { get; set; }
    }


    public class HistoryOfUsedMaterialsModel
    {
        public long Id { get; set; }
        public string DoctorName { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public DateTime Date { get; set; }

        public string Unit { get; set; }

        public bool ShowDoctorName { get; set; }
    }

    public class OldAppointmentsModel
    {
        public string Name { get; set; }
        public System.DateTime Appointment { get; set; }
        public bool IsEntered { get; set; }
        public string Notes { get; set; }

        public string IsEnteredString { get; set; }
        public string EnteredStyle { get; set; }

    }

    public class PatientAppointments
    {
        public System.DateTime Appointment { get; set; }
        public bool IsEntered { get; set; }
        public string Notes { get; set; }
        public string IsEnteredString { get; set; }
        public string EnteredStyle { get; set; }

    }

    public class PatientsMainGridModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long Id { get; set; }
        private string name;
        private DateTime birthDate;
        private string gender;
        private string maritalstatus;
        private string birthDateString;
        private string job;
        private string address;
        private string phoneNumber;
        private int visitcount;
        private int operationscount;
        private int appointmentscount;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BirthDateString
        {
            get => birthDateString;
            set
            {
                if (birthDateString != value)
                {
                    birthDateString = value;
                    OnPropertyChanged();


                }
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged();
                }
            }
        }
        public string MaritalStatus
        {
            get => maritalstatus;
            set
            {
                if (maritalstatus != value)
                {
                    maritalstatus = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Job
        {
            get => job;
            set
            {
                if (job != value)
                {
                    job = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public int VisitCount
        {
            get => visitcount;
            set
            {
                if (visitcount != value)
                {
                    visitcount = value;
                    OnPropertyChanged();
                }
            }

        }
        public int OperationsCount
        {

            get => operationscount;
            set
            {
                if (operationscount != value)
                {
                    operationscount = value;
                    OnPropertyChanged();
                }
            }
        }
        public int AppointmentsCount
        {
            get => appointmentscount;
            set
            {
                if (appointmentscount != value)
                {
                    appointmentscount = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool NeedOperations { get; set; }
        public bool ContactInfo { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }


    public class GetVisitsModel : PatientsMainGridModel
    {
        public long VisitId { get; set; }
        public long PatientId { get; set; }
        public string ChiefComplaint { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime DateOfVisiting { get; set; }
    }

    public class GetOperationsModel : PatientsMainGridModel
    {
        public long OperationId { get; set; }
        public long PatientId { get; set; }
        public string OperationName { get; set; }
        public string Dignosis { get; set; }

        public short? OperationPlaceIndex { get; set; }
        public string OperationPlaceText { get; set; }
        public string OperationPlace { get; set; }
        public DateTime OperationDate { get; set; }
    }

    public class PatientsDebtsModel
    {
        public long PatientId { get; set; }
        public string Name { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string BirthDateString { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public System.DateTime LastVisitDate { get; set; }
        public double? TotalCost { get; set; }
        public double? TotalDiscount { get; set; }

        public double? TotalFinalCost { get; set; }
        public double? TotalPaid { get; set; }
        public double? PatientDebt { get; set; }
    }

    public class MaterialsUsedByPatient
    {
        public long MaterialId { get; set; }
        public string Material { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
    }


    public class CommonInfoUsedMaterial
    {
        public string FieldName { get; set; }
    }

    public class VisitCostsModel
    {
        public double? Cost { get; set; }
        public double? DiscountCost { get; set; }
        public double? PaidCost { get; set; }
    }

    public class WaitingPatientsMainGridVisitsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long PatientId { get; set; }
        public long Id { get; set; }
        private string name;
        private DateTime birthDate;
        private string gender;
        private string maritalstatus;
        private string birthDateString;
        private string job;
        private string address;
        private string phoneNumber;
        private int visitcount;
        private int operationscount;
        private int appointmentscount;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BirthDateString
        {
            get => birthDateString;
            set
            {
                if (birthDateString != value)
                {
                    birthDateString = value;
                    OnPropertyChanged();


                }
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged();
                }
            }
        }
        public string MaritalStatus
        {
            get => maritalstatus;
            set
            {
                if (maritalstatus != value)
                {
                    maritalstatus = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Job
        {
            get => job;
            set
            {
                if (job != value)
                {
                    job = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public int VisitCount
        {
            get => visitcount;
            set
            {
                if (visitcount != value)
                {
                    visitcount = value;
                    OnPropertyChanged();
                }
            }

        }
        public int OperationsCount
        {

            get => operationscount;
            set
            {
                if (operationscount != value)
                {
                    operationscount = value;
                    OnPropertyChanged();
                }
            }
        }
        public int AppointmentsCount
        {
            get => appointmentscount;
            set
            {
                if (appointmentscount != value)
                {
                    appointmentscount = value;
                    OnPropertyChanged();
                }
            }
        }
        public string ForwardFromName { get; set; }
        public string Notes { get; set; }


        public bool NeedOperations { get; set; }

        public bool ContactInfo { get; set; }

        public System.DateTime? ArrivalDate { get; set; }

        public string ArrivalDateString { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DoctorVisitsMainGridModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long PatientId { get; set; }
        public long Id { get; set; }


        private string name;
        private DateTime birthDate;
        private string gender;
        private string maritalstatus;
        private string birthDateString;
        private string job;
        private string address;
        private string phoneNumber;
        private int visitcount;
        private int operationscount;
        private int appointmentscount;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BirthDateString
        {
            get => birthDateString;
            set
            {
                if (birthDateString != value)
                {
                    birthDateString = value;
                    OnPropertyChanged();


                }
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged();
                }
            }
        }
        public string MaritalStatus
        {
            get => maritalstatus;
            set
            {
                if (maritalstatus != value)
                {
                    maritalstatus = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Job
        {
            get => job;
            set
            {
                if (job != value)
                {
                    job = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public int VisitCount
        {
            get => visitcount;
            set
            {
                if (visitcount != value)
                {
                    visitcount = value;
                    OnPropertyChanged();
                }
            }

        }
        public int OperationsCount
        {

            get => operationscount;
            set
            {
                if (operationscount != value)
                {
                    operationscount = value;
                    OnPropertyChanged();
                }
            }
        }
        public int AppointmentsCount
        {
            get => appointmentscount;
            set
            {
                if (appointmentscount != value)
                {
                    appointmentscount = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Diagnosis { get; set; }

        public bool NeedOperations { get; set; }
        public bool ContactInfo { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class VisitsMainGridForSecretaryModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long Id { get; set; }
        public long PatientId { get; set; }
        public long Sequence { get; set; }


        private string name;
        private DateTime birthDate;
        private string gender;
        private string maritalstatus;
        private string birthDateString;
        private string job;
        private string address;
        private string phoneNumber;
        private int visitcount;
   
        private int appointmentscount;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BirthDateString
        {
            get => birthDateString;
            set
            {
                if (birthDateString != value)
                {
                    birthDateString = value;
                    OnPropertyChanged();


                }
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged();
                }
            }
        }
        public string MaritalStatus
        {
            get => maritalstatus;
            set
            {
                if (maritalstatus != value)
                {
                    maritalstatus = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Job
        {
            get => job;
            set
            {
                if (job != value)
                {
                    job = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public int VisitCount
        {
            get => visitcount;
            set
            {
                if (visitcount != value)
                {
                    visitcount = value;
                    OnPropertyChanged();
                }
            }

        }

        public int AppointmentsCount
        {
            get => appointmentscount;
            set
            {
                if (appointmentscount != value)
                {
                    appointmentscount = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool? IsEntered { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string IsEnteredString { get; set; }
        public bool ContactInfo { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ServiceOrderModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Count { get; set; }
    }

    public class ServicesReadOnlyItems
    {
        public long Id { get; set; }
        public int Count { get; set; }
    }

    public class SuggestionModel
    {
        public long Id { get; set; }
        public string FieldValue { get; set; }
        public double? Cost { get; set; }

        public int Count { get; set; }
        public Microsoft.Maui.Graphics.Color SelectionColor { get; set; }
    }

    public class LinkToStoreModel
    {
        public long Id { get; set; }
        public string Material { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
    }

    public class DoctorInfoOnMainPage
    {
        public bool IsSecretary { get; set; }
        public bool IsSecretaryDoctor { get; set; }
        public long? SecretaryForDoctorId { get; set; }

        public bool NeedSecretaryConnection { get; set; }
        public bool CanAddEditDeletePatients { get; set; }
        public bool CanAddVisit { get; set; }
        public bool CanAddOperation { get; set; }
        public bool CanAddEditDeleteAppointments { get; set; }

    }

    public class DoctorBasicInfo
    {
        public long Id { get; set; }
        public string UserFullName { get; set; }

    }

    public class CountsOfPatient
    {
        public int VisitsCount { get; set; }
        public int OperationsCount { get; set; }
        public int AppointmentsCount { get; set; }

    }

    public class OperationIdAndDate
    {
        public long Id { get; set; }
        public DateTime OperationDate { get; set; }
    }


    public class PatientNameAndBirthDate
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class VisitIdAndDateOfVisiting
    {
        public long Id { get; set; }
        public DateTime DateOfVisiting { get; set; }
    }

    public class VisitIdPatientIdDoctorId
    {
        public long Id { get; set; }
        public long PatientId { get; set; }
        public long DoctorId { get; set; }
    }

    public class SearchInAppointmentsModel
    {
        public long Id { get; set; }
        public long PatientId { get; set; }
        public long? VisitId { get; set; }
        public string Name { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Appointment { get; set; }
        public bool IsEntered { get; set; }
        public string Notes { get; set; }
        public int VisitCount { get; set; }
        public int OperationsCount { get; set; }
        public string DoctorName { get; set; }
        public byte? WhatsAppMessage { get; set; }



        public string BirthDateString { get; set; }
        public string AppointmentString { get; set; }
        public string IsEnteredString { get; set; }
        public bool ShowDoctorName { get; set; }
        public string WhatsAppMessageString { get; set; }
        public bool NeedOperations { get; set; }

        public string WhatsAppMessageStyle { get; set; }
        public string EnteredStyle { get; set; }

    }

    public class ExpenseDetialsModel
    {
        public long Id { get; set; }
        public long RowNumber { get; set; }
        public double PaidCost { get; set; }

        public DateTime ExpensesDate { get; set; }
        public string DoctorName { get; set; }
        public string Notes { get; set; }

    }

}
