﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoParking.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://servicio-face-proyecto-parking.cognitiveservices.azure.com/face/v1.0/")]
        public string EndpointIACara {
            get {
                return ((string)(this["EndpointIACara"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("38cac79a9bd04f648466d0b24ad1d9f5")]
        public string LicenseKeyIACara {
            get {
                return ((string)(this["LicenseKeyIACara"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://customvisionproyectoparkingdint-prediction.cognitiveservices.azure.com/cu" +
            "stomvision/")]
        public string EndpointIACustomVision {
            get {
                return ((string)(this["EndpointIACustomVision"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1d14987690a64deda0d17d7790d49cea")]
        public string PredictionKeyIACustomVision {
            get {
                return ((string)(this["PredictionKeyIACustomVision"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("v3.0/Prediction/768c2adc-d877-4c94-908a-847930e8426a/classify/iterations/Iteratio" +
            "n1/url")]
        public string MethodIACustomVision {
            get {
                return ((string)(this["MethodIACustomVision"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=C:/ProyectoParking/database/parking.db")]
        public string RutaConexionDatabase {
            get {
                return ((string)(this["RutaConexionDatabase"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NTY2OTI3QDMxMzkyZTM0MmUzMG85Q0toWFI2U2dGcVIwdjlXRHBDVGlHanpxZFlWVEJLcnZWUWtuSE5Ee" +
            "kU9")]
        public string LicenciaSyncfusion {
            get {
                return ((string)(this["LicenciaSyncfusion"]));
            }
        }
    }
}
