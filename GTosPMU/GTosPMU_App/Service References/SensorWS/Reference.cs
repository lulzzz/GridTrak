﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GTosPMU.SensorWS {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.gridtrak.com/", ConfigurationName="SensorWS.SensorWSSoap")]
    public interface SensorWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.gridtrak.com/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.gridtrak.com/Sensor_New", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Sensor_New(long iAccountID, string sAccountEMail, string sAccountPswd, System.Data.DataSet dsSensor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.gridtrak.com/Get_SensorList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Get_SensorList(long iAccountID, string sAccountEMail, string sAccountPswd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SensorWSSoapChannel : GTosPMU.SensorWS.SensorWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SensorWSSoapClient : System.ServiceModel.ClientBase<GTosPMU.SensorWS.SensorWSSoap>, GTosPMU.SensorWS.SensorWSSoap {
        
        public SensorWSSoapClient() {
        }
        
        public SensorWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SensorWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensorWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensorWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public string Sensor_New(long iAccountID, string sAccountEMail, string sAccountPswd, System.Data.DataSet dsSensor) {
            return base.Channel.Sensor_New(iAccountID, sAccountEMail, sAccountPswd, dsSensor);
        }
        
        public System.Data.DataSet Get_SensorList(long iAccountID, string sAccountEMail, string sAccountPswd) {
            return base.Channel.Get_SensorList(iAccountID, sAccountEMail, sAccountPswd);
        }
    }
}
