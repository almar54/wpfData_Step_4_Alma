﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpfData.ServiceReferenceSnacks {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CityList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="City")]
    [System.SerializableAttribute()]
    public class CityList : System.Collections.Generic.List<wpfData.ServiceReferenceSnacks.City> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class City : wpfData.ServiceReferenceSnacks.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnacks.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnacks.Snack))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnacks.City))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class User : wpfData.ServiceReferenceSnacks.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnacks.City CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnacks.SnackList SnacksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnacks.City City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnacks.SnackList Snacks {
            get {
                return this.SnacksField;
            }
            set {
                if ((object.ReferenceEquals(this.SnacksField, value) != true)) {
                    this.SnacksField = value;
                    this.RaisePropertyChanged("Snacks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Snack", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Snack : wpfData.ServiceReferenceSnacks.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CaloriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GramsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SugarField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Calories {
            get {
                return this.CaloriesField;
            }
            set {
                if ((this.CaloriesField.Equals(value) != true)) {
                    this.CaloriesField = value;
                    this.RaisePropertyChanged("Calories");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Grams {
            get {
                return this.GramsField;
            }
            set {
                if ((this.GramsField.Equals(value) != true)) {
                    this.GramsField = value;
                    this.RaisePropertyChanged("Grams");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sugar {
            get {
                return this.SugarField;
            }
            set {
                if ((this.SugarField.Equals(value) != true)) {
                    this.SugarField = value;
                    this.RaisePropertyChanged("Sugar");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="SnackList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="Snack")]
    [System.SerializableAttribute()]
    public class SnackList : System.Collections.Generic.List<wpfData.ServiceReferenceSnacks.Snack> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="UserList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="User")]
    [System.SerializableAttribute()]
    public class UserList : System.Collections.Generic.List<wpfData.ServiceReferenceSnacks.User> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSnacks.IServiceSnack")]
    public interface IServiceSnack {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllCities", ReplyAction="http://tempuri.org/IServiceSnack/GetAllCitiesResponse")]
        wpfData.ServiceReferenceSnacks.CityList GetAllCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllCities", ReplyAction="http://tempuri.org/IServiceSnack/GetAllCitiesResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.CityList> GetAllCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllUsers", ReplyAction="http://tempuri.org/IServiceSnack/GetAllUsersResponse")]
        wpfData.ServiceReferenceSnacks.UserList GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllUsers", ReplyAction="http://tempuri.org/IServiceSnack/GetAllUsersResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.UserList> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllSnacks", ReplyAction="http://tempuri.org/IServiceSnack/GetAllSnacksResponse")]
        wpfData.ServiceReferenceSnacks.SnackList GetAllSnacks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllSnacks", ReplyAction="http://tempuri.org/IServiceSnack/GetAllSnacksResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.SnackList> GetAllSnacksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetSnacksByUser", ReplyAction="http://tempuri.org/IServiceSnack/GetSnacksByUserResponse")]
        wpfData.ServiceReferenceSnacks.SnackList GetSnacksByUser(wpfData.ServiceReferenceSnacks.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetSnacksByUser", ReplyAction="http://tempuri.org/IServiceSnack/GetSnacksByUserResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.SnackList> GetSnacksByUserAsync(wpfData.ServiceReferenceSnacks.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetUserBySnack", ReplyAction="http://tempuri.org/IServiceSnack/GetUserBySnackResponse")]
        wpfData.ServiceReferenceSnacks.UserList GetUserBySnack(wpfData.ServiceReferenceSnacks.Snack snack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetUserBySnack", ReplyAction="http://tempuri.org/IServiceSnack/GetUserBySnackResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.UserList> GetUserBySnackAsync(wpfData.ServiceReferenceSnacks.Snack snack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/Login", ReplyAction="http://tempuri.org/IServiceSnack/LoginResponse")]
        wpfData.ServiceReferenceSnacks.User Login(wpfData.ServiceReferenceSnacks.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/Login", ReplyAction="http://tempuri.org/IServiceSnack/LoginResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.User> LoginAsync(wpfData.ServiceReferenceSnacks.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSnackChannel : wpfData.ServiceReferenceSnacks.IServiceSnack, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSnackClient : System.ServiceModel.ClientBase<wpfData.ServiceReferenceSnacks.IServiceSnack>, wpfData.ServiceReferenceSnacks.IServiceSnack {
        
        public ServiceSnackClient() {
        }
        
        public ServiceSnackClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSnackClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSnackClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSnackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public wpfData.ServiceReferenceSnacks.CityList GetAllCities() {
            return base.Channel.GetAllCities();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.CityList> GetAllCitiesAsync() {
            return base.Channel.GetAllCitiesAsync();
        }
        
        public wpfData.ServiceReferenceSnacks.UserList GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.UserList> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public wpfData.ServiceReferenceSnacks.SnackList GetAllSnacks() {
            return base.Channel.GetAllSnacks();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.SnackList> GetAllSnacksAsync() {
            return base.Channel.GetAllSnacksAsync();
        }
        
        public wpfData.ServiceReferenceSnacks.SnackList GetSnacksByUser(wpfData.ServiceReferenceSnacks.User user) {
            return base.Channel.GetSnacksByUser(user);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.SnackList> GetSnacksByUserAsync(wpfData.ServiceReferenceSnacks.User user) {
            return base.Channel.GetSnacksByUserAsync(user);
        }
        
        public wpfData.ServiceReferenceSnacks.UserList GetUserBySnack(wpfData.ServiceReferenceSnacks.Snack snack) {
            return base.Channel.GetUserBySnack(snack);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.UserList> GetUserBySnackAsync(wpfData.ServiceReferenceSnacks.Snack snack) {
            return base.Channel.GetUserBySnackAsync(snack);
        }
        
        public wpfData.ServiceReferenceSnacks.User Login(wpfData.ServiceReferenceSnacks.User user) {
            return base.Channel.Login(user);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnacks.User> LoginAsync(wpfData.ServiceReferenceSnacks.User user) {
            return base.Channel.LoginAsync(user);
        }
    }
}