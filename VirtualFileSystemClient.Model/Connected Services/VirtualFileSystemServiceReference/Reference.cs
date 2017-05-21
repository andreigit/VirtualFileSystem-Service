﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualFileSystemClient.Model.VirtualFileSystemServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizeRequest", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class AuthorizeRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizeResponse", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class AuthorizeResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalUsersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public byte[] Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalUsers {
            get {
                return this.TotalUsersField;
            }
            set {
                if ((this.TotalUsersField.Equals(value) != true)) {
                    this.TotalUsersField = value;
                    this.RaisePropertyChanged("TotalUsers");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizeFault", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class AuthorizeFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DeauthorizeRequest", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class DeauthorizeRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public byte[] Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DeauthorizeResponse", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class DeauthorizeResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DeauthorizeFault", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class DeauthorizeFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CommandRequest", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class CommandRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommandLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string CommandLine {
            get {
                return this.CommandLineField;
            }
            set {
                if ((object.ReferenceEquals(this.CommandLineField, value) != true)) {
                    this.CommandLineField = value;
                    this.RaisePropertyChanged("CommandLine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CommandResponse", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class CommandResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommandLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurrentDirectoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string CommandLine {
            get {
                return this.CommandLineField;
            }
            set {
                if ((object.ReferenceEquals(this.CommandLineField, value) != true)) {
                    this.CommandLineField = value;
                    this.RaisePropertyChanged("CommandLine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrentDirectory {
            get {
                return this.CurrentDirectoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentDirectoryField, value) != true)) {
                    this.CurrentDirectoryField = value;
                    this.RaisePropertyChanged("CurrentDirectory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponseMessage {
            get {
                return this.ResponseMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseMessageField, value) != true)) {
                    this.ResponseMessageField = value;
                    this.RaisePropertyChanged("ResponseMessage");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CommandFault", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class CommandFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommandLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string CommandLine {
            get {
                return this.CommandLineField;
            }
            set {
                if ((object.ReferenceEquals(this.CommandLineField, value) != true)) {
                    this.CommandLineField = value;
                    this.RaisePropertyChanged("CommandLine");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CommandPerformedData", Namespace="http://andrey.sergeev.vfsservice")]
    [System.SerializableAttribute()]
    public partial class CommandPerformedData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommandLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string CommandLine {
            get {
                return this.CommandLineField;
            }
            set {
                if ((object.ReferenceEquals(this.CommandLineField, value) != true)) {
                    this.CommandLineField = value;
                    this.RaisePropertyChanged("CommandLine");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VirtualFileSystemServiceReference.IVFSService", CallbackContract=typeof(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.IVFSServiceCallback))]
    public interface IVFSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVFSService/Authorize", ReplyAction="http://tempuri.org/IVFSService/AuthorizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeFault), Action="http://tempuri.org/IVFSService/AuthorizeAuthorizeFaultFault", Name="AuthorizeFault", Namespace="http://andrey.sergeev.vfsservice")]
        VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeResponse Authorize(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVFSService/Authorize", ReplyAction="http://tempuri.org/IVFSService/AuthorizeResponse")]
        System.Threading.Tasks.Task<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeResponse> AuthorizeAsync(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVFSService/Deauthorize", ReplyAction="http://tempuri.org/IVFSService/DeauthorizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeFault), Action="http://tempuri.org/IVFSService/DeauthorizeDeauthorizeFaultFault", Name="DeauthorizeFault", Namespace="http://andrey.sergeev.vfsservice")]
        VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeResponse Deauthorize(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVFSService/Deauthorize", ReplyAction="http://tempuri.org/IVFSService/DeauthorizeResponse")]
        System.Threading.Tasks.Task<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeResponse> DeauthorizeAsync(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVFSService/PerformCommand", ReplyAction="http://tempuri.org/IVFSService/PerformCommandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandFault), Action="http://tempuri.org/IVFSService/PerformCommandCommandFaultFault", Name="CommandFault", Namespace="http://andrey.sergeev.vfsservice")]
        VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandResponse PerformCommand(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVFSService/PerformCommand", ReplyAction="http://tempuri.org/IVFSService/PerformCommandResponse")]
        System.Threading.Tasks.Task<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandResponse> PerformCommandAsync(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVFSServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IVFSService/OnCommandPerformed")]
        void OnCommandPerformed(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandPerformedData data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVFSServiceChannel : VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.IVFSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VFSServiceClient : System.ServiceModel.DuplexClientBase<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.IVFSService>, VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.IVFSService {
        
        public VFSServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public VFSServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public VFSServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VFSServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VFSServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeResponse Authorize(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeRequest request) {
            return base.Channel.Authorize(request);
        }
        
        public System.Threading.Tasks.Task<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeResponse> AuthorizeAsync(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.AuthorizeRequest request) {
            return base.Channel.AuthorizeAsync(request);
        }
        
        public VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeResponse Deauthorize(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeRequest request) {
            return base.Channel.Deauthorize(request);
        }
        
        public System.Threading.Tasks.Task<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeResponse> DeauthorizeAsync(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.DeauthorizeRequest request) {
            return base.Channel.DeauthorizeAsync(request);
        }
        
        public VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandResponse PerformCommand(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandRequest request) {
            return base.Channel.PerformCommand(request);
        }
        
        public System.Threading.Tasks.Task<VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandResponse> PerformCommandAsync(VirtualFileSystemClient.Model.VirtualFileSystemServiceReference.CommandRequest request) {
            return base.Channel.PerformCommandAsync(request);
        }
    }
}
