//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientKost.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CekKos", Namespace="http://schemas.datacontract.org/2004/07/ServiceKos")]
    [System.SerializableAttribute()]
    public partial class CekKos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDKamarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaKamarField;
        
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
        public string Deskripsi {
            get {
                return this.DeskripsiField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiField, value) != true)) {
                    this.DeskripsiField = value;
                    this.RaisePropertyChanged("Deskripsi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDKamar {
            get {
                return this.IDKamarField;
            }
            set {
                if ((object.ReferenceEquals(this.IDKamarField, value) != true)) {
                    this.IDKamarField = value;
                    this.RaisePropertyChanged("IDKamar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaKamar {
            get {
                return this.NamaKamarField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaKamarField, value) != true)) {
                    this.NamaKamarField = value;
                    this.RaisePropertyChanged("NamaKamar");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailKos", Namespace="http://schemas.datacontract.org/2004/07/ServiceKos")]
    [System.SerializableAttribute()]
    public partial class DetailKos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HargaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDKamarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KetersediaanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaKamarField;
        
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
        public string Deskripsi {
            get {
                return this.DeskripsiField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiField, value) != true)) {
                    this.DeskripsiField = value;
                    this.RaisePropertyChanged("Deskripsi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Harga {
            get {
                return this.HargaField;
            }
            set {
                if ((object.ReferenceEquals(this.HargaField, value) != true)) {
                    this.HargaField = value;
                    this.RaisePropertyChanged("Harga");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDKamar {
            get {
                return this.IDKamarField;
            }
            set {
                if ((object.ReferenceEquals(this.IDKamarField, value) != true)) {
                    this.IDKamarField = value;
                    this.RaisePropertyChanged("IDKamar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ketersediaan {
            get {
                return this.KetersediaanField;
            }
            set {
                if ((object.ReferenceEquals(this.KetersediaanField, value) != true)) {
                    this.KetersediaanField = value;
                    this.RaisePropertyChanged("Ketersediaan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaKamar {
            get {
                return this.NamaKamarField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaKamarField, value) != true)) {
                    this.NamaKamarField = value;
                    this.RaisePropertyChanged("NamaKamar");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanan", Namespace="http://schemas.datacontract.org/2004/07/ServiceKos")]
    [System.SerializableAttribute()]
    public partial class Pemesanan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDKamarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaPemesanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoTelponField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WaktuSewaField;
        
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
        public string IDKamar {
            get {
                return this.IDKamarField;
            }
            set {
                if ((object.ReferenceEquals(this.IDKamarField, value) != true)) {
                    this.IDKamarField = value;
                    this.RaisePropertyChanged("IDKamar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDPemesanan {
            get {
                return this.IDPemesananField;
            }
            set {
                if ((object.ReferenceEquals(this.IDPemesananField, value) != true)) {
                    this.IDPemesananField = value;
                    this.RaisePropertyChanged("IDPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaPemesan {
            get {
                return this.NamaPemesanField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaPemesanField, value) != true)) {
                    this.NamaPemesanField = value;
                    this.RaisePropertyChanged("NamaPemesan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoTelpon {
            get {
                return this.NoTelponField;
            }
            set {
                if ((object.ReferenceEquals(this.NoTelponField, value) != true)) {
                    this.NoTelponField = value;
                    this.RaisePropertyChanged("NoTelpon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WaktuSewa {
            get {
                return this.WaktuSewaField;
            }
            set {
                if ((this.WaktuSewaField.Equals(value) != true)) {
                    this.WaktuSewaField = value;
                    this.RaisePropertyChanged("WaktuSewa");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRegister", Namespace="http://schemas.datacontract.org/2004/07/ServiceKos")]
    [System.SerializableAttribute()]
    public partial class DataRegister : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kategoriField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string kategori {
            get {
                return this.kategoriField;
            }
            set {
                if ((object.ReferenceEquals(this.kategoriField, value) != true)) {
                    this.kategoriField = value;
                    this.RaisePropertyChanged("kategori");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string IDPemesanan, string NamaPemesan, string NoTelpon, int WaktuSewa, string IDKamar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaPemesan, string NoTelpon, int WaktuSewa, string IDKamar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string IDPemesanan, string NamaPemesan, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaPemesan, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewKos", ReplyAction="http://tempuri.org/IService1/ReviewKosResponse")]
        ClientKost.ServiceReference1.CekKos[] ReviewKos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewKos", ReplyAction="http://tempuri.org/IService1/ReviewKosResponse")]
        System.Threading.Tasks.Task<ClientKost.ServiceReference1.CekKos[]> ReviewKosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailKos", ReplyAction="http://tempuri.org/IService1/DetailKosResponse")]
        ClientKost.ServiceReference1.DetailKos[] DetailKos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailKos", ReplyAction="http://tempuri.org/IService1/DetailKosResponse")]
        System.Threading.Tasks.Task<ClientKost.ServiceReference1.DetailKos[]> DetailKosAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientKost.ServiceReference1.PemesananResponse Pemesanan1(ClientKost.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientKost.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientKost.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        string Register(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        string UpdateRegister(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        string DeleteRegister(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        ClientKost.ServiceReference1.DataRegister[] DataRegist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        System.Threading.Tasks.Task<ClientKost.ServiceReference1.DataRegister[]> DataRegistAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientKost.ServiceReference1.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ClientKost.ServiceReference1.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientKost.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientKost.ServiceReference1.IService1>, ClientKost.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string pemesanan(string IDPemesanan, string NamaPemesan, string NoTelpon, int WaktuSewa, string IDKamar) {
            return base.Channel.pemesanan(IDPemesanan, NamaPemesan, NoTelpon, WaktuSewa, IDKamar);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaPemesan, string NoTelpon, int WaktuSewa, string IDKamar) {
            return base.Channel.pemesananAsync(IDPemesanan, NamaPemesan, NoTelpon, WaktuSewa, IDKamar);
        }
        
        public string editPemesanan(string IDPemesanan, string NamaPemesan, string No_telpon) {
            return base.Channel.editPemesanan(IDPemesanan, NamaPemesan, No_telpon);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaPemesan, string No_telpon) {
            return base.Channel.editPemesananAsync(IDPemesanan, NamaPemesan, No_telpon);
        }
        
        public string deletePemesanan(string IDPemesanan) {
            return base.Channel.deletePemesanan(IDPemesanan);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan) {
            return base.Channel.deletePemesananAsync(IDPemesanan);
        }
        
        public ClientKost.ServiceReference1.CekKos[] ReviewKos() {
            return base.Channel.ReviewKos();
        }
        
        public System.Threading.Tasks.Task<ClientKost.ServiceReference1.CekKos[]> ReviewKosAsync() {
            return base.Channel.ReviewKosAsync();
        }
        
        public ClientKost.ServiceReference1.DetailKos[] DetailKos() {
            return base.Channel.DetailKos();
        }
        
        public System.Threading.Tasks.Task<ClientKost.ServiceReference1.DetailKos[]> DetailKosAsync() {
            return base.Channel.DetailKosAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientKost.ServiceReference1.PemesananResponse ClientKost.ServiceReference1.IService1.Pemesanan1(ClientKost.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ClientKost.ServiceReference1.Pemesanan[] Pemesanan1() {
            ClientKost.ServiceReference1.PemesananRequest inValue = new ClientKost.ServiceReference1.PemesananRequest();
            ClientKost.ServiceReference1.PemesananResponse retVal = ((ClientKost.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientKost.ServiceReference1.PemesananResponse> ClientKost.ServiceReference1.IService1.Pemesanan1Async(ClientKost.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientKost.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientKost.ServiceReference1.PemesananRequest inValue = new ClientKost.ServiceReference1.PemesananRequest();
            return ((ClientKost.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public string Register(string username, string password, string kategori) {
            return base.Channel.Register(username, password, kategori);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori) {
            return base.Channel.RegisterAsync(username, password, kategori);
        }
        
        public string UpdateRegister(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegister(username, password, kategori, id);
        }
        
        public System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegisterAsync(username, password, kategori, id);
        }
        
        public string DeleteRegister(string username) {
            return base.Channel.DeleteRegister(username);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username) {
            return base.Channel.DeleteRegisterAsync(username);
        }
        
        public ClientKost.ServiceReference1.DataRegister[] DataRegist() {
            return base.Channel.DataRegist();
        }
        
        public System.Threading.Tasks.Task<ClientKost.ServiceReference1.DataRegister[]> DataRegistAsync() {
            return base.Channel.DataRegistAsync();
        }
    }
}
