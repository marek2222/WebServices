﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyService.Tests.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyCompanyPublicService")]
    public interface IMyCompanyPublicService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCompanyPublicService/GetPublicInformation", ReplyAction="http://tempuri.org/IMyCompanyPublicService/GetPublicInformationResponse")]
        string GetPublicInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCompanyPublicService/GetPublicInformation", ReplyAction="http://tempuri.org/IMyCompanyPublicService/GetPublicInformationResponse")]
        System.Threading.Tasks.Task<string> GetPublicInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyCompanyPublicServiceChannel : CompanyService.Tests.ServiceReference1.IMyCompanyPublicService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyCompanyPublicServiceClient : System.ServiceModel.ClientBase<CompanyService.Tests.ServiceReference1.IMyCompanyPublicService>, CompanyService.Tests.ServiceReference1.IMyCompanyPublicService {
        
        public MyCompanyPublicServiceClient() {
        }
        
        public MyCompanyPublicServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyCompanyPublicServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCompanyPublicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCompanyPublicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPublicInformation() {
            return base.Channel.GetPublicInformation();
        }
        
        public System.Threading.Tasks.Task<string> GetPublicInformationAsync() {
            return base.Channel.GetPublicInformationAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyCompanyConfidentialService")]
    public interface IMyCompanyConfidentialService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCompanyConfidentialService/GetCofidentialInformation", ReplyAction="http://tempuri.org/IMyCompanyConfidentialService/GetCofidentialInformationRespons" +
            "e")]
        string GetCofidentialInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCompanyConfidentialService/GetCofidentialInformation", ReplyAction="http://tempuri.org/IMyCompanyConfidentialService/GetCofidentialInformationRespons" +
            "e")]
        System.Threading.Tasks.Task<string> GetCofidentialInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyCompanyConfidentialServiceChannel : CompanyService.Tests.ServiceReference1.IMyCompanyConfidentialService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyCompanyConfidentialServiceClient : System.ServiceModel.ClientBase<CompanyService.Tests.ServiceReference1.IMyCompanyConfidentialService>, CompanyService.Tests.ServiceReference1.IMyCompanyConfidentialService {
        
        public MyCompanyConfidentialServiceClient() {
        }
        
        public MyCompanyConfidentialServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyCompanyConfidentialServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCompanyConfidentialServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCompanyConfidentialServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCofidentialInformation() {
            return base.Channel.GetCofidentialInformation();
        }
        
        public System.Threading.Tasks.Task<string> GetCofidentialInformationAsync() {
            return base.Channel.GetCofidentialInformationAsync();
        }
    }
}