﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationNew.EditFieldsWcf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EditFieldsWcf.IEditFieldsWcf")]
    public interface IEditFieldsWcf {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditFieldsWcf/Edit", ReplyAction="http://tempuri.org/IEditFieldsWcf/EditResponse")]
        bool Edit(string userid, string firstname, string lastname, string email, string addr1, string addr2, string street, string city, string state, string zip, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditFieldsWcf/Edit", ReplyAction="http://tempuri.org/IEditFieldsWcf/EditResponse")]
        System.Threading.Tasks.Task<bool> EditAsync(string userid, string firstname, string lastname, string email, string addr1, string addr2, string street, string city, string state, string zip, string mobile);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEditFieldsWcfChannel : WebApplicationNew.EditFieldsWcf.IEditFieldsWcf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EditFieldsWcfClient : System.ServiceModel.ClientBase<WebApplicationNew.EditFieldsWcf.IEditFieldsWcf>, WebApplicationNew.EditFieldsWcf.IEditFieldsWcf {
        
        public EditFieldsWcfClient() {
        }
        
        public EditFieldsWcfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EditFieldsWcfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EditFieldsWcfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EditFieldsWcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Edit(string userid, string firstname, string lastname, string email, string addr1, string addr2, string street, string city, string state, string zip, string mobile) {
            return base.Channel.Edit(userid, firstname, lastname, email, addr1, addr2, street, city, state, zip, mobile);
        }
        
        public System.Threading.Tasks.Task<bool> EditAsync(string userid, string firstname, string lastname, string email, string addr1, string addr2, string street, string city, string state, string zip, string mobile) {
            return base.Channel.EditAsync(userid, firstname, lastname, email, addr1, addr2, street, city, state, zip, mobile);
        }
    }
}