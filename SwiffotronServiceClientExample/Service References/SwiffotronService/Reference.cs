﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWFProcessing.SwiffotronServiceClientExample.SwiffotronService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SwiffotronService.ISWFProcessor")]
    public interface ISWFProcessor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWFProcessor/Process", ReplyAction="http://tempuri.org/ISWFProcessor/ProcessResponse")]
        System.Collections.Generic.Dictionary<string, byte[]> Process(System.IO.Stream jobXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWFProcessor/Interrogate", ReplyAction="http://tempuri.org/ISWFProcessor/InterrogateResponse")]
        System.Collections.Generic.Dictionary<string, string> Interrogate();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISWFProcessorChannel : SWFProcessing.SwiffotronServiceClientExample.SwiffotronService.ISWFProcessor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SWFProcessorClient : System.ServiceModel.ClientBase<SWFProcessing.SwiffotronServiceClientExample.SwiffotronService.ISWFProcessor>, SWFProcessing.SwiffotronServiceClientExample.SwiffotronService.ISWFProcessor {
        
        public SWFProcessorClient() {
        }
        
        public SWFProcessorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SWFProcessorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SWFProcessorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SWFProcessorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.Dictionary<string, byte[]> Process(System.IO.Stream jobXml) {
            return base.Channel.Process(jobXml);
        }
        
        public System.Collections.Generic.Dictionary<string, string> Interrogate() {
            return base.Channel.Interrogate();
        }
    }
}
