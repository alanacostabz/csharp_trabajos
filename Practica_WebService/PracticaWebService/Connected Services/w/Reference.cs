﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaWebService.w {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="w.PracticaWebServiceSoap")]
    public interface PracticaWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LeeXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable LeeXML();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LeeXML", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> LeeXMLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LeeTXT", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] LeeTXT();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LeeTXT", ReplyAction="*")]
        System.Threading.Tasks.Task<object[]> LeeTXTAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PracticaWebServiceSoapChannel : PracticaWebService.w.PracticaWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PracticaWebServiceSoapClient : System.ServiceModel.ClientBase<PracticaWebService.w.PracticaWebServiceSoap>, PracticaWebService.w.PracticaWebServiceSoap {
        
        public PracticaWebServiceSoapClient() {
        }
        
        public PracticaWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PracticaWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PracticaWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PracticaWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable LeeXML() {
            return base.Channel.LeeXML();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> LeeXMLAsync() {
            return base.Channel.LeeXMLAsync();
        }
        
        public object[] LeeTXT() {
            return base.Channel.LeeTXT();
        }
        
        public System.Threading.Tasks.Task<object[]> LeeTXTAsync() {
            return base.Channel.LeeTXTAsync();
        }
    }
}
