﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddTwoNumbers_Client.AddTwoNumbers_ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AddTwoNumbers_ServiceReference.AddNumbersSoap")]
    public interface AddNumbersSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponse HelloWorld(AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponse> HelloWorldAsync(AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTwoNumbers", ReplyAction="*")]
        int AddTwoNumbers(int tal1, int tal2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTwoNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddTwoNumbersAsync(int tal1, int tal2);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AddNumbersSoapChannel : AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddNumbersSoapClient : System.ServiceModel.ClientBase<AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap>, AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap {
        
        public AddNumbersSoapClient() {
        }
        
        public AddNumbersSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddNumbersSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddNumbersSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddNumbersSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponse AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap.HelloWorld(AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest inValue = new AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest();
            inValue.Body = new AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequestBody();
            AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponse retVal = ((AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponse> AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap.HelloWorldAsync(AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest inValue = new AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequest();
            inValue.Body = new AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.HelloWorldRequestBody();
            return ((AddTwoNumbers_Client.AddTwoNumbers_ServiceReference.AddNumbersSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int AddTwoNumbers(int tal1, int tal2) {
            return base.Channel.AddTwoNumbers(tal1, tal2);
        }
        
        public System.Threading.Tasks.Task<int> AddTwoNumbersAsync(int tal1, int tal2) {
            return base.Channel.AddTwoNumbersAsync(tal1, tal2);
        }
    }
}