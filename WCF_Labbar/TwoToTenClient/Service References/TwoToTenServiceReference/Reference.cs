﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwoToTenClient.TwoToTenServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TwoToTenServiceReference.TwoToTenServicesSoap")]
    public interface TwoToTenServicesSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        TwoToTenClient.TwoToTenServiceReference.HelloWorldResponse HelloWorld(TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<TwoToTenClient.TwoToTenServiceReference.HelloWorldResponse> HelloWorldAsync(TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name inputVal from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeathCasesJanuary", ReplyAction="*")]
        TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponse DeathCasesJanuary(TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeathCasesJanuary", ReplyAction="*")]
        System.Threading.Tasks.Task<TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponse> DeathCasesJanuaryAsync(TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public TwoToTenClient.TwoToTenServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(TwoToTenClient.TwoToTenServiceReference.HelloWorldRequestBody Body) {
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
        public TwoToTenClient.TwoToTenServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(TwoToTenClient.TwoToTenServiceReference.HelloWorldResponseBody Body) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeathCasesJanuaryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeathCasesJanuary", Namespace="http://tempuri.org/", Order=0)]
        public TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequestBody Body;
        
        public DeathCasesJanuaryRequest() {
        }
        
        public DeathCasesJanuaryRequest(TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeathCasesJanuaryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string inputVal;
        
        public DeathCasesJanuaryRequestBody() {
        }
        
        public DeathCasesJanuaryRequestBody(string inputVal) {
            this.inputVal = inputVal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeathCasesJanuaryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeathCasesJanuaryResponse", Namespace="http://tempuri.org/", Order=0)]
        public TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponseBody Body;
        
        public DeathCasesJanuaryResponse() {
        }
        
        public DeathCasesJanuaryResponse(TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeathCasesJanuaryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DeathCasesJanuaryResult;
        
        public DeathCasesJanuaryResponseBody() {
        }
        
        public DeathCasesJanuaryResponseBody(string DeathCasesJanuaryResult) {
            this.DeathCasesJanuaryResult = DeathCasesJanuaryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TwoToTenServicesSoapChannel : TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TwoToTenServicesSoapClient : System.ServiceModel.ClientBase<TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap>, TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap {
        
        public TwoToTenServicesSoapClient() {
        }
        
        public TwoToTenServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TwoToTenServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TwoToTenServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TwoToTenServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TwoToTenClient.TwoToTenServiceReference.HelloWorldResponse TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap.HelloWorld(TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest inValue = new TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest();
            inValue.Body = new TwoToTenClient.TwoToTenServiceReference.HelloWorldRequestBody();
            TwoToTenClient.TwoToTenServiceReference.HelloWorldResponse retVal = ((TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TwoToTenClient.TwoToTenServiceReference.HelloWorldResponse> TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap.HelloWorldAsync(TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<TwoToTenClient.TwoToTenServiceReference.HelloWorldResponse> HelloWorldAsync() {
            TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest inValue = new TwoToTenClient.TwoToTenServiceReference.HelloWorldRequest();
            inValue.Body = new TwoToTenClient.TwoToTenServiceReference.HelloWorldRequestBody();
            return ((TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponse TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap.DeathCasesJanuary(TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest request) {
            return base.Channel.DeathCasesJanuary(request);
        }
        
        public string DeathCasesJanuary(string inputVal) {
            TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest inValue = new TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest();
            inValue.Body = new TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequestBody();
            inValue.Body.inputVal = inputVal;
            TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponse retVal = ((TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap)(this)).DeathCasesJanuary(inValue);
            return retVal.Body.DeathCasesJanuaryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponse> TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap.DeathCasesJanuaryAsync(TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest request) {
            return base.Channel.DeathCasesJanuaryAsync(request);
        }
        
        public System.Threading.Tasks.Task<TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryResponse> DeathCasesJanuaryAsync(string inputVal) {
            TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest inValue = new TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequest();
            inValue.Body = new TwoToTenClient.TwoToTenServiceReference.DeathCasesJanuaryRequestBody();
            inValue.Body.inputVal = inputVal;
            return ((TwoToTenClient.TwoToTenServiceReference.TwoToTenServicesSoap)(this)).DeathCasesJanuaryAsync(inValue);
        }
    }
}
