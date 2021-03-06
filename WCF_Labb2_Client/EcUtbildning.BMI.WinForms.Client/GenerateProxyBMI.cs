﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://EcUtbildning.CalculateBmi", ConfigurationName="ICalculateBmi")]
public interface ICalculateBmi
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://EcUtbildning.CalculateBmi/ICalculateBmi/CalculateBmi", ReplyAction="http://EcUtbildning.CalculateBmi/ICalculateBmi/CalculateBmiResponse")]
    string CalculateBmi(int weight, double length);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://EcUtbildning.CalculateBmi/ICalculateBmi/CalculateBmi", ReplyAction="http://EcUtbildning.CalculateBmi/ICalculateBmi/CalculateBmiResponse")]
    System.Threading.Tasks.Task<string> CalculateBmiAsync(int weight, double length);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculateBmiChannel : ICalculateBmi, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculateBmiClient : System.ServiceModel.ClientBase<ICalculateBmi>, ICalculateBmi
{
    
    public CalculateBmiClient()
    {
    }
    
    public CalculateBmiClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculateBmiClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculateBmiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculateBmiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string CalculateBmi(int weight, double length)
    {
        return base.Channel.CalculateBmi(weight, length);
    }
    
    public System.Threading.Tasks.Task<string> CalculateBmiAsync(int weight, double length)
    {
        return base.Channel.CalculateBmiAsync(weight, length);
    }
}
