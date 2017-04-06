﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWorldR2Callback.EchoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EchoService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Echo", ReplyAction="http://tempuri.org/IService1/EchoResponse")]
        HelloWorldR2Callback.EchoService.EchoResponse Echo(HelloWorldR2Callback.EchoService.EchoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EchoOnExit", ReplyAction="http://tempuri.org/IService1/EchoOnExitResponse")]
        HelloWorldR2Callback.EchoService.EchoOnExitResponse EchoOnExit(HelloWorldR2Callback.EchoService.EchoOnExitRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Echo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string input;
        
        public EchoRequest() {
        }
        
        public EchoRequest(string input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string EchoResult;
        
        public EchoResponse() {
        }
        
        public EchoResponse(string EchoResult) {
            this.EchoResult = EchoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoOnExit", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoOnExitRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.TimeSpan delay;
        
        public EchoOnExitRequest() {
        }
        
        public EchoOnExitRequest(System.TimeSpan delay) {
            this.delay = delay;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoOnExitResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoOnExitResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string EchoOnExitResult;
        
        public EchoOnExitResponse() {
        }
        
        public EchoOnExitResponse(string EchoOnExitResult) {
            this.EchoOnExitResult = EchoOnExitResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : HelloWorldR2Callback.EchoService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<HelloWorldR2Callback.EchoService.IService1>, HelloWorldR2Callback.EchoService.IService1 {
        
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
        
        public HelloWorldR2Callback.EchoService.EchoResponse Echo(HelloWorldR2Callback.EchoService.EchoRequest request) {
            return base.Channel.Echo(request);
        }
        
        public HelloWorldR2Callback.EchoService.EchoOnExitResponse EchoOnExit(HelloWorldR2Callback.EchoService.EchoOnExitRequest request) {
            return base.Channel.EchoOnExit(request);
        }
    }
}
