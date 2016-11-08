﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1.ProductoWSC {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EProducto", Namespace="http://schemas.datacontract.org/2004/07/CFFLORES.Entidad")]
    [System.SerializableAttribute()]
    public partial class EProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codigobarraField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProducto {
            get {
                return this.NombreProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreProductoField, value) != true)) {
                    this.NombreProductoField = value;
                    this.RaisePropertyChanged("NombreProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codigobarra {
            get {
                return this.codigobarraField;
            }
            set {
                if ((object.ReferenceEquals(this.codigobarraField, value) != true)) {
                    this.codigobarraField = value;
                    this.RaisePropertyChanged("codigobarra");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/CFFLORES.WebService.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string exNombreProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int exStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string excodigobarraField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string exNombreProducto {
            get {
                return this.exNombreProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.exNombreProductoField, value) != true)) {
                    this.exNombreProductoField = value;
                    this.RaisePropertyChanged("exNombreProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int exStock {
            get {
                return this.exStockField;
            }
            set {
                if ((this.exStockField.Equals(value) != true)) {
                    this.exStockField = value;
                    this.RaisePropertyChanged("exStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string excodigobarra {
            get {
                return this.excodigobarraField;
            }
            set {
                if ((object.ReferenceEquals(this.excodigobarraField, value) != true)) {
                    this.excodigobarraField = value;
                    this.RaisePropertyChanged("excodigobarra");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductoWSC.IProducto")]
    public interface IProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ObtenerProducto", ReplyAction="http://tempuri.org/IProducto/ObtenerProductoResponse")]
        string ObtenerProducto(string codigobarra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ObtenerProducto", ReplyAction="http://tempuri.org/IProducto/ObtenerProductoResponse")]
        System.Threading.Tasks.Task<string> ObtenerProductoAsync(string codigobarra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/CrearProducto", ReplyAction="http://tempuri.org/IProducto/CrearProductoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UnitTestProject1.ProductoWSC.RepetidoException), Action="http://tempuri.org/IProducto/CrearProductoRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/CFFLORES.WebService.Errores")]
        UnitTestProject1.ProductoWSC.EProducto CrearProducto(UnitTestProject1.ProductoWSC.EProducto productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/CrearProducto", ReplyAction="http://tempuri.org/IProducto/CrearProductoResponse")]
        System.Threading.Tasks.Task<UnitTestProject1.ProductoWSC.EProducto> CrearProductoAsync(UnitTestProject1.ProductoWSC.EProducto productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ModificarProducto", ReplyAction="http://tempuri.org/IProducto/ModificarProductoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UnitTestProject1.ProductoWSC.RepetidoException), Action="http://tempuri.org/IProducto/ModificarProductoRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/CFFLORES.WebService.Errores")]
        UnitTestProject1.ProductoWSC.EProducto ModificarProducto(UnitTestProject1.ProductoWSC.EProducto productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ModificarProducto", ReplyAction="http://tempuri.org/IProducto/ModificarProductoResponse")]
        System.Threading.Tasks.Task<UnitTestProject1.ProductoWSC.EProducto> ModificarProductoAsync(UnitTestProject1.ProductoWSC.EProducto productos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductoChannel : UnitTestProject1.ProductoWSC.IProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductoClient : System.ServiceModel.ClientBase<UnitTestProject1.ProductoWSC.IProducto>, UnitTestProject1.ProductoWSC.IProducto {
        
        public ProductoClient() {
        }
        
        public ProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtenerProducto(string codigobarra) {
            return base.Channel.ObtenerProducto(codigobarra);
        }
        
        public System.Threading.Tasks.Task<string> ObtenerProductoAsync(string codigobarra) {
            return base.Channel.ObtenerProductoAsync(codigobarra);
        }
        
        public UnitTestProject1.ProductoWSC.EProducto CrearProducto(UnitTestProject1.ProductoWSC.EProducto productos) {
            return base.Channel.CrearProducto(productos);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ProductoWSC.EProducto> CrearProductoAsync(UnitTestProject1.ProductoWSC.EProducto productos) {
            return base.Channel.CrearProductoAsync(productos);
        }
        
        public UnitTestProject1.ProductoWSC.EProducto ModificarProducto(UnitTestProject1.ProductoWSC.EProducto productos) {
            return base.Channel.ModificarProducto(productos);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ProductoWSC.EProducto> ModificarProductoAsync(UnitTestProject1.ProductoWSC.EProducto productos) {
            return base.Channel.ModificarProductoAsync(productos);
        }
    }
}
