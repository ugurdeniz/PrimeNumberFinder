﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GASB.Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPrimeService")]
    public interface IPrimeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrimeService/Register", ReplyAction="http://tempuri.org/IPrimeService/RegisterResponse")]
        System.Guid Register(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrimeService/Register", ReplyAction="http://tempuri.org/IPrimeService/RegisterResponse")]
        System.Threading.Tasks.Task<System.Guid> RegisterAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrimeService/GetJob", ReplyAction="http://tempuri.org/IPrimeService/GetJobResponse")]
        int GetJob(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrimeService/GetJob", ReplyAction="http://tempuri.org/IPrimeService/GetJobResponse")]
        System.Threading.Tasks.Task<int> GetJobAsync(System.Guid clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrimeService/SaveResult", ReplyAction="http://tempuri.org/IPrimeService/SaveResultResponse")]
        void SaveResult(System.Guid clientId, int N, bool isPrime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrimeService/SaveResult", ReplyAction="http://tempuri.org/IPrimeService/SaveResultResponse")]
        System.Threading.Tasks.Task SaveResultAsync(System.Guid clientId, int N, bool isPrime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrimeServiceChannel : GASB.Client.ServiceReference1.IPrimeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrimeServiceClient : System.ServiceModel.ClientBase<GASB.Client.ServiceReference1.IPrimeService>, GASB.Client.ServiceReference1.IPrimeService {
        
        public PrimeServiceClient() {
        }
        
        public PrimeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrimeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrimeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrimeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid Register(string Email) {
            return base.Channel.Register(Email);
        }
        
        public System.Threading.Tasks.Task<System.Guid> RegisterAsync(string Email) {
            return base.Channel.RegisterAsync(Email);
        }
        
        public int GetJob(System.Guid clientId) {
            return base.Channel.GetJob(clientId);
        }
        
        public System.Threading.Tasks.Task<int> GetJobAsync(System.Guid clientId) {
            return base.Channel.GetJobAsync(clientId);
        }
        
        public void SaveResult(System.Guid clientId, int N, bool isPrime) {
            base.Channel.SaveResult(clientId, N, isPrime);
        }
        
        public System.Threading.Tasks.Task SaveResultAsync(System.Guid clientId, int N, bool isPrime) {
            return base.Channel.SaveResultAsync(clientId, N, isPrime);
        }
    }
}
