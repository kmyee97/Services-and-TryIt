﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItFinal.MoneyConversion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoneyConversion.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/moneyConvert", ReplyAction="http://tempuri.org/IService1/moneyConvertResponse")]
        double moneyConvert(double value, string currency1, string currency2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/moneyConvert", ReplyAction="http://tempuri.org/IService1/moneyConvertResponse")]
        System.Threading.Tasks.Task<double> moneyConvertAsync(double value, string currency1, string currency2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TryItFinal.MoneyConversion.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TryItFinal.MoneyConversion.IService1>, TryItFinal.MoneyConversion.IService1 {
        
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
        
        public double moneyConvert(double value, string currency1, string currency2) {
            return base.Channel.moneyConvert(value, currency1, currency2);
        }
        
        public System.Threading.Tasks.Task<double> moneyConvertAsync(double value, string currency1, string currency2) {
            return base.Channel.moneyConvertAsync(value, currency1, currency2);
        }
    }
}
