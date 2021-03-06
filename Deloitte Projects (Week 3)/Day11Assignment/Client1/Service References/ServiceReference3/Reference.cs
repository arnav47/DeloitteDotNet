﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client1.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.ICard")]
    public interface ICard {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICard/Authenticate", ReplyAction="http://tempuri.org/ICard/AuthenticateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/ICard/AuthenticateArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool Authenticate(int CardNo, string cvv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICard/Authenticate", ReplyAction="http://tempuri.org/ICard/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(int CardNo, string cvv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICard/DateCheck", ReplyAction="http://tempuri.org/ICard/DateCheckResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/ICard/DateCheckArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool DateCheck(int CardNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICard/DateCheck", ReplyAction="http://tempuri.org/ICard/DateCheckResponse")]
        System.Threading.Tasks.Task<bool> DateCheckAsync(int CardNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICard/Trans", ReplyAction="http://tempuri.org/ICard/TransResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/ICard/TransArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        decimal Trans(int CardNo, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICard/Trans", ReplyAction="http://tempuri.org/ICard/TransResponse")]
        System.Threading.Tasks.Task<decimal> TransAsync(int CardNo, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICardChannel : Client1.ServiceReference3.ICard, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CardClient : System.ServiceModel.ClientBase<Client1.ServiceReference3.ICard>, Client1.ServiceReference3.ICard {
        
        public CardClient() {
        }
        
        public CardClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CardClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Authenticate(int CardNo, string cvv) {
            return base.Channel.Authenticate(CardNo, cvv);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(int CardNo, string cvv) {
            return base.Channel.AuthenticateAsync(CardNo, cvv);
        }
        
        public bool DateCheck(int CardNo) {
            return base.Channel.DateCheck(CardNo);
        }
        
        public System.Threading.Tasks.Task<bool> DateCheckAsync(int CardNo) {
            return base.Channel.DateCheckAsync(CardNo);
        }
        
        public decimal Trans(int CardNo, decimal amount) {
            return base.Channel.Trans(CardNo, amount);
        }
        
        public System.Threading.Tasks.Task<decimal> TransAsync(int CardNo, decimal amount) {
            return base.Channel.TransAsync(CardNo, amount);
        }
    }
}
