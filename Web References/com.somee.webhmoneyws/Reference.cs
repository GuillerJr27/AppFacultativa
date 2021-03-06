//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace AppFacultativa.com.somee.webhmoneyws {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebHmoneyWSSoap", Namespace="http://tempuri.org/")]
    public partial class WebHmoneyWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AgregarCuentaOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarCuentaOperationCompleted;
        
        private System.Threading.SendOrPostCallback AgregarGastoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarGastoOperationCompleted;
        
        private System.Threading.SendOrPostCallback AgregarMovimientoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarMovimientoOperationCompleted;
        
        private System.Threading.SendOrPostCallback CambiarClaveOperationCompleted;
        
        private System.Threading.SendOrPostCallback CrearUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebHmoneyWS() {
            this.Url = "http://webhmoneyws.somee.com/WebHmoneyWS/WebHmoneyWS.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AgregarCuentaCompletedEventHandler AgregarCuentaCompleted;
        
        /// <remarks/>
        public event ListarCuentaCompletedEventHandler ListarCuentaCompleted;
        
        /// <remarks/>
        public event AgregarGastoCompletedEventHandler AgregarGastoCompleted;
        
        /// <remarks/>
        public event ListarGastoCompletedEventHandler ListarGastoCompleted;
        
        /// <remarks/>
        public event AgregarMovimientoCompletedEventHandler AgregarMovimientoCompleted;
        
        /// <remarks/>
        public event ListarMovimientoCompletedEventHandler ListarMovimientoCompleted;
        
        /// <remarks/>
        public event CambiarClaveCompletedEventHandler CambiarClaveCompleted;
        
        /// <remarks/>
        public event CrearUsuarioCompletedEventHandler CrearUsuarioCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AgregarCuenta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AgregarCuenta(string NombreCuenta, string TipoCuenta, string Moneda, decimal BalanceInicial) {
            object[] results = this.Invoke("AgregarCuenta", new object[] {
                        NombreCuenta,
                        TipoCuenta,
                        Moneda,
                        BalanceInicial});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AgregarCuentaAsync(string NombreCuenta, string TipoCuenta, string Moneda, decimal BalanceInicial) {
            this.AgregarCuentaAsync(NombreCuenta, TipoCuenta, Moneda, BalanceInicial, null);
        }
        
        /// <remarks/>
        public void AgregarCuentaAsync(string NombreCuenta, string TipoCuenta, string Moneda, decimal BalanceInicial, object userState) {
            if ((this.AgregarCuentaOperationCompleted == null)) {
                this.AgregarCuentaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAgregarCuentaOperationCompleted);
            }
            this.InvokeAsync("AgregarCuenta", new object[] {
                        NombreCuenta,
                        TipoCuenta,
                        Moneda,
                        BalanceInicial}, this.AgregarCuentaOperationCompleted, userState);
        }
        
        private void OnAgregarCuentaOperationCompleted(object arg) {
            if ((this.AgregarCuentaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AgregarCuentaCompleted(this, new AgregarCuentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarCuenta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CuentasWS[] ListarCuenta() {
            object[] results = this.Invoke("ListarCuenta", new object[0]);
            return ((CuentasWS[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarCuentaAsync() {
            this.ListarCuentaAsync(null);
        }
        
        /// <remarks/>
        public void ListarCuentaAsync(object userState) {
            if ((this.ListarCuentaOperationCompleted == null)) {
                this.ListarCuentaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarCuentaOperationCompleted);
            }
            this.InvokeAsync("ListarCuenta", new object[0], this.ListarCuentaOperationCompleted, userState);
        }
        
        private void OnListarCuentaOperationCompleted(object arg) {
            if ((this.ListarCuentaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarCuentaCompleted(this, new ListarCuentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AgregarGasto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AgregarGasto(string Nombre, string Descripcion, bool EsActivo) {
            object[] results = this.Invoke("AgregarGasto", new object[] {
                        Nombre,
                        Descripcion,
                        EsActivo});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AgregarGastoAsync(string Nombre, string Descripcion, bool EsActivo) {
            this.AgregarGastoAsync(Nombre, Descripcion, EsActivo, null);
        }
        
        /// <remarks/>
        public void AgregarGastoAsync(string Nombre, string Descripcion, bool EsActivo, object userState) {
            if ((this.AgregarGastoOperationCompleted == null)) {
                this.AgregarGastoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAgregarGastoOperationCompleted);
            }
            this.InvokeAsync("AgregarGasto", new object[] {
                        Nombre,
                        Descripcion,
                        EsActivo}, this.AgregarGastoOperationCompleted, userState);
        }
        
        private void OnAgregarGastoOperationCompleted(object arg) {
            if ((this.AgregarGastoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AgregarGastoCompleted(this, new AgregarGastoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarGasto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoGastoWS[] ListarGasto() {
            object[] results = this.Invoke("ListarGasto", new object[0]);
            return ((TipoGastoWS[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarGastoAsync() {
            this.ListarGastoAsync(null);
        }
        
        /// <remarks/>
        public void ListarGastoAsync(object userState) {
            if ((this.ListarGastoOperationCompleted == null)) {
                this.ListarGastoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarGastoOperationCompleted);
            }
            this.InvokeAsync("ListarGasto", new object[0], this.ListarGastoOperationCompleted, userState);
        }
        
        private void OnListarGastoOperationCompleted(object arg) {
            if ((this.ListarGastoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarGastoCompleted(this, new ListarGastoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AgregarMovimiento", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AgregarMovimiento(System.DateTime Fecha, string Descripcion, decimal Monto) {
            object[] results = this.Invoke("AgregarMovimiento", new object[] {
                        Fecha,
                        Descripcion,
                        Monto});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AgregarMovimientoAsync(System.DateTime Fecha, string Descripcion, decimal Monto) {
            this.AgregarMovimientoAsync(Fecha, Descripcion, Monto, null);
        }
        
        /// <remarks/>
        public void AgregarMovimientoAsync(System.DateTime Fecha, string Descripcion, decimal Monto, object userState) {
            if ((this.AgregarMovimientoOperationCompleted == null)) {
                this.AgregarMovimientoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAgregarMovimientoOperationCompleted);
            }
            this.InvokeAsync("AgregarMovimiento", new object[] {
                        Fecha,
                        Descripcion,
                        Monto}, this.AgregarMovimientoOperationCompleted, userState);
        }
        
        private void OnAgregarMovimientoOperationCompleted(object arg) {
            if ((this.AgregarMovimientoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AgregarMovimientoCompleted(this, new AgregarMovimientoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarMovimiento", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MovimientoWS[] ListarMovimiento() {
            object[] results = this.Invoke("ListarMovimiento", new object[0]);
            return ((MovimientoWS[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarMovimientoAsync() {
            this.ListarMovimientoAsync(null);
        }
        
        /// <remarks/>
        public void ListarMovimientoAsync(object userState) {
            if ((this.ListarMovimientoOperationCompleted == null)) {
                this.ListarMovimientoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarMovimientoOperationCompleted);
            }
            this.InvokeAsync("ListarMovimiento", new object[0], this.ListarMovimientoOperationCompleted, userState);
        }
        
        private void OnListarMovimientoOperationCompleted(object arg) {
            if ((this.ListarMovimientoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarMovimientoCompleted(this, new ListarMovimientoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CambiarClave", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CambiarClave(string correo, string Pass) {
            object[] results = this.Invoke("CambiarClave", new object[] {
                        correo,
                        Pass});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CambiarClaveAsync(string correo, string Pass) {
            this.CambiarClaveAsync(correo, Pass, null);
        }
        
        /// <remarks/>
        public void CambiarClaveAsync(string correo, string Pass, object userState) {
            if ((this.CambiarClaveOperationCompleted == null)) {
                this.CambiarClaveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCambiarClaveOperationCompleted);
            }
            this.InvokeAsync("CambiarClave", new object[] {
                        correo,
                        Pass}, this.CambiarClaveOperationCompleted, userState);
        }
        
        private void OnCambiarClaveOperationCompleted(object arg) {
            if ((this.CambiarClaveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CambiarClaveCompleted(this, new CambiarClaveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CrearUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ResultadoSW CrearUsuario(string Email, string Pass) {
            object[] results = this.Invoke("CrearUsuario", new object[] {
                        Email,
                        Pass});
            return ((ResultadoSW)(results[0]));
        }
        
        /// <remarks/>
        public void CrearUsuarioAsync(string Email, string Pass) {
            this.CrearUsuarioAsync(Email, Pass, null);
        }
        
        /// <remarks/>
        public void CrearUsuarioAsync(string Email, string Pass, object userState) {
            if ((this.CrearUsuarioOperationCompleted == null)) {
                this.CrearUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCrearUsuarioOperationCompleted);
            }
            this.InvokeAsync("CrearUsuario", new object[] {
                        Email,
                        Pass}, this.CrearUsuarioOperationCompleted, userState);
        }
        
        private void OnCrearUsuarioOperationCompleted(object arg) {
            if ((this.CrearUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CrearUsuarioCompleted(this, new CrearUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Login(string cuenta, string Pass) {
            object[] results = this.Invoke("Login", new object[] {
                        cuenta,
                        Pass});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string cuenta, string Pass) {
            this.LoginAsync(cuenta, Pass, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string cuenta, string Pass, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        cuenta,
                        Pass}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CuentasWS {
        
        private int idField;
        
        private string nombreCuentaField;
        
        private string tipoCuentaField;
        
        private string monedaField;
        
        private decimal balanceInicialField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string NombreCuenta {
            get {
                return this.nombreCuentaField;
            }
            set {
                this.nombreCuentaField = value;
            }
        }
        
        /// <remarks/>
        public string TipoCuenta {
            get {
                return this.tipoCuentaField;
            }
            set {
                this.tipoCuentaField = value;
            }
        }
        
        /// <remarks/>
        public string Moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }
        
        /// <remarks/>
        public decimal BalanceInicial {
            get {
                return this.balanceInicialField;
            }
            set {
                this.balanceInicialField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResultadoSW {
        
        private string mensajeField;
        
        private bool respuestaField;
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public bool respuesta {
            get {
                return this.respuestaField;
            }
            set {
                this.respuestaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MovimientoWS {
        
        private int idField;
        
        private System.DateTime fechaField;
        
        private string descripcionField;
        
        private decimal montoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        public decimal Monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TipoGastoWS {
        
        private int idField;
        
        private string nombreField;
        
        private string descripcionField;
        
        private bool esActivoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        public bool EsActivo {
            get {
                return this.esActivoField;
            }
            set {
                this.esActivoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AgregarCuentaCompletedEventHandler(object sender, AgregarCuentaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgregarCuentaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AgregarCuentaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ListarCuentaCompletedEventHandler(object sender, ListarCuentaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarCuentaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarCuentaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CuentasWS[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CuentasWS[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AgregarGastoCompletedEventHandler(object sender, AgregarGastoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgregarGastoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AgregarGastoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ListarGastoCompletedEventHandler(object sender, ListarGastoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarGastoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarGastoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoGastoWS[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoGastoWS[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AgregarMovimientoCompletedEventHandler(object sender, AgregarMovimientoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgregarMovimientoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AgregarMovimientoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ListarMovimientoCompletedEventHandler(object sender, ListarMovimientoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarMovimientoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarMovimientoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MovimientoWS[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MovimientoWS[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CambiarClaveCompletedEventHandler(object sender, CambiarClaveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CambiarClaveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CambiarClaveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CrearUsuarioCompletedEventHandler(object sender, CrearUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrearUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CrearUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultadoSW Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultadoSW)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591