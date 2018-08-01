﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EndUser.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICardInfo")]
    public interface ICardInfo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardInfo/Transaction", ReplyAction="http://tempuri.org/ICardInfo/TransactionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/ICardInfo/TransactionArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool Transaction(int cardno, System.DateTime expdt, int cvv, float tramt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardInfo/Transaction", ReplyAction="http://tempuri.org/ICardInfo/TransactionResponse")]
        System.Threading.Tasks.Task<bool> TransactionAsync(int cardno, System.DateTime expdt, int cvv, float tramt);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICardInfoChannel : EndUser.ServiceReference1.ICardInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CardInfoClient : System.ServiceModel.ClientBase<EndUser.ServiceReference1.ICardInfo>, EndUser.ServiceReference1.ICardInfo {
        
        public CardInfoClient() {
        }
        
        public CardInfoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CardInfoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardInfoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardInfoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Transaction(int cardno, System.DateTime expdt, int cvv, float tramt) {
            return base.Channel.Transaction(cardno, expdt, cvv, tramt);
        }
        
        public System.Threading.Tasks.Task<bool> TransactionAsync(int cardno, System.DateTime expdt, int cvv, float tramt) {
            return base.Channel.TransactionAsync(cardno, expdt, cvv, tramt);
        }
    }
}
