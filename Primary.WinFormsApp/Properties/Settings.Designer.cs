﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Primary.WinFormsApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserName {
            get {
                return ((string)(this["UserName"]));
            }
            set {
                this["UserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Enabled24Hours {
            get {
                return ((bool)(this["Enabled24Hours"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("850")]
        public decimal USDARS {
            get {
                return ((decimal)(this["USDARS"]));
            }
            set {
                this["USDARS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal Comision {
            get {
                return ((decimal)(this["Comision"]));
            }
            set {
                this["Comision"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.01")]
        public decimal DerechoMercado {
            get {
                return ((decimal)(this["DerechoMercado"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.08")]
        public decimal DerechoMercadoAccionCEDEAR {
            get {
                return ((decimal)(this["DerechoMercadoAccionCEDEAR"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>AL30</string>\r\n  <string>AL29</string>\r\n  <string>AE38</string>\r\n</ArrayOf" +
            "String>")]
        public global::System.Collections.Specialized.StringCollection OwnedTickers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OwnedTickers"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://api.cocos.xoms.com.ar")]
        public string ApiBaseUrl {
            get {
                return ((string)(this["ApiBaseUrl"]));
            }
            set {
                this["ApiBaseUrl"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>AAPL</string>\r\n  <string>AAPLC</string>\r\n  <string>AAPLD</string>\r\n  <stri" +
            "ng>ABBV</string>\r\n  <string>ABEV</string>\r\n  <string>ABT</string>\r\n  <string>ACH" +
            "D</string>\r\n  <string>ADBE</string>\r\n  <string>ADGO</string>\r\n  <string>ADI</str" +
            "ing>\r\n  <string>AEM</string>\r\n  <string>AIG</string>\r\n  <string>AMD</string>\r\n  " +
            "<string>AMDD</string>\r\n  <string>AMGN</string>\r\n  <string>AMX</string>\r\n  <strin" +
            "g>AMXD</string>\r\n  <string>AMZN</string>\r\n  <string>AMZNC</string>\r\n  <string>AM" +
            "ZND</string>\r\n  <string>ARCO</string>\r\n  <string>AUY</string>\r\n  <string>AUYD</s" +
            "tring>\r\n  <string>AVGO</string>\r\n  <string>AVY</string>\r\n  <string>AXP</string>\r" +
            "\n  <string>AXPD</string>\r\n  <string>AZN</string>\r\n  <string>AZND</string>\r\n  <st" +
            "ring>BA</string>\r\n  <string>BA.C</string>\r\n  <string>BA.CD</string>\r\n  <string>B" +
            "ABA</string>\r\n  <string>BABA</string>\r\n  <string>BABAC</string>\r\n  <string>BABAD" +
            "</string>\r\n  <string>BAD</string>\r\n  <string>BB</string>\r\n  <string>BBD</string>" +
            "\r\n  <string>BBDC</string>\r\n  <string>BBDD</string>\r\n  <string>BBV</string>\r\n  <s" +
            "tring>BCS</string>\r\n  <string>BHP</string>\r\n  <string>BIDU</string>\r\n  <string>B" +
            "IDUD</string>\r\n  <string>BIIB</string>\r\n  <string>BIOX</string>\r\n  <string>BK</s" +
            "tring>\r\n  <string>BMA</string>\r\n  <string>BMY</string>\r\n  <string>BNG</string>\r\n" +
            "  <string>BP</string>\r\n  <string>BPD</string>\r\n  <string>BRFS</string>\r\n  <strin" +
            "g>BRKB</string>\r\n  <string>BSBR</string>\r\n  <string>BYMA</string>\r\n  <string>C</" +
            "string>\r\n  <string>C.D</string>\r\n  <string>CAAP</string>\r\n  <string>CAH</string>" +
            "\r\n  <string>CAHD</string>\r\n  <string>CAT</string>\r\n  <string>CATD</string>\r\n  <s" +
            "tring>CDE</string>\r\n  <string>CHL</string>\r\n  <string>CL</string>\r\n  <string>COS" +
            "T</string>\r\n  <string>CRM</string>\r\n  <string>CS</string>\r\n  <string>CSCO</strin" +
            "g>\r\n  <string>CSCOD</string>\r\n  <string>CVX</string>\r\n  <string>CVXD</string>\r\n " +
            " <string>CX</string>\r\n  <string>DD</string>\r\n  <string>DE</string>\r\n  <string>DE" +
            "SP</string>\r\n  <string>DESPD</string>\r\n  <string>DIA</string>\r\n  <string>DIAC</s" +
            "tring>\r\n  <string>DIAD</string>\r\n  <string>DISN</string>\r\n  <string>DISND</strin" +
            "g>\r\n  <string>DOCU</string>\r\n  <string>EBAY</string>\r\n  <string>EBAYD</string>\r\n" +
            "  <string>EEM</string>\r\n  <string>EEMC</string>\r\n  <string>EEMD</string>\r\n  <str" +
            "ing>EFX</string>\r\n  <string>ERIC</string>\r\n  <string>ERJ</string>\r\n  <string>ERJ" +
            "D</string>\r\n  <string>ETSY</string>\r\n  <string>EWZ</string>\r\n  <string>FB</strin" +
            "g>\r\n  <string>FBD</string>\r\n  <string>FCX</string>\r\n  <string>FDX</string>\r\n  <s" +
            "tring>FDXD</string>\r\n  <string>FMX</string>\r\n  <string>FSLR</string>\r\n  <string>" +
            "GE</string>\r\n  <string>GEC</string>\r\n  <string>GFI</string>\r\n  <string>GGAL</str" +
            "ing>\r\n  <string>GGB</string>\r\n  <string>GILD</string>\r\n  <string>GILDC</string>\r" +
            "\n  <string>GILDD</string>\r\n  <string>GLNT</string>\r\n  <string>GLNTD</string>\r\n  " +
            "<string>GLW</string>\r\n  <string>GOGLD</string>\r\n  <string>GOLD</string>\r\n  <stri" +
            "ng>GOLDC</string>\r\n  <string>GOLDD</string>\r\n  <string>GOOGL</string>\r\n  <string" +
            ">GPRK</string>\r\n  <string>GS</string>\r\n  <string>GSD</string>\r\n  <string>GSK</st" +
            "ring>\r\n  <string>GSKD</string>\r\n  <string>HAL</string>\r\n  <string>HD</string>\r\n " +
            " <string>HL</string>\r\n  <string>HMC</string>\r\n  <string>HMY</string>\r\n  <string>" +
            "HMYD</string>\r\n  <string>HON</string>\r\n  <string>HPQ</string>\r\n  <string>HSBC</s" +
            "tring>\r\n  <string>HSY</string>\r\n  <string>HWM</string>\r\n  <string>IBM</string>\r\n" +
            "  <string>IBMD</string>\r\n  <string>INTC</string>\r\n  <string>INTCD</string>\r\n  <s" +
            "tring>ITUB</string>\r\n  <string>ITUBD</string>\r\n  <string>IWM</string>\r\n  <string" +
            ">JD</string>\r\n  <string>JNJ</string>\r\n  <string>JNJC</string>\r\n  <string>JNJD</s" +
            "tring>\r\n  <string>JPM</string>\r\n  <string>JPMD</string>\r\n  <string>KMB</string>\r" +
            "\n  <string>KO</string>\r\n  <string>KOC</string>\r\n  <string>KOD</string>\r\n  <strin" +
            "g>LLY</string>\r\n  <string>LMT</string>\r\n  <string>LMTD</string>\r\n  <string>LVS</" +
            "string>\r\n  <string>LYG</string>\r\n  <string>MA</string>\r\n  <string>MCD</string>\r\n" +
            "  <string>MCDD</string>\r\n  <string>MDT</string>\r\n  <string>MELI</string>\r\n  <str" +
            "ing>MELIC</string>\r\n  <string>MELID</string>\r\n  <string>MMC</string>\r\n  <string>" +
            "MMM</string>\r\n  <string>MMMD</string>\r\n  <string>MO</string>\r\n  <string>MOD</str" +
            "ing>\r\n  <string>MRK</string>\r\n  <string>MRKD</string>\r\n  <string>MSFT</string>\r\n" +
            "  <string>MSFTC</string>\r\n  <string>MSFTD</string>\r\n  <string>NEM</string>\r\n  <s" +
            "tring>NEMD</string>\r\n  <string>NFLX</string>\r\n  <string>NFLXD</string>\r\n  <strin" +
            "g>NGG</string>\r\n  <string>NKE</string>\r\n  <string>NKED</string>\r\n  <string>NOKA<" +
            "/string>\r\n  <string>NTES</string>\r\n  <string>NVDA</string>\r\n  <string>NVDAD</str" +
            "ing>\r\n  <string>NVS</string>\r\n  <string>NVSD</string>\r\n  <string>OGZD</string>\r\n" +
            "  <string>OGZDD</string>\r\n  <string>ORAN</string>\r\n  <string>ORCL</string>\r\n  <s" +
            "tring>OXY</string>\r\n  <string>PAAS</string>\r\n  <string>PAMP</string>\r\n  <string>" +
            "PBR</string>\r\n  <string>PBRD</string>\r\n  <string>PEP</string>\r\n  <string>PFE</st" +
            "ring>\r\n  <string>PFED</string>\r\n  <string>PG</string>\r\n  <string>PGD</string>\r\n " +
            " <string>PHG</string>\r\n  <string>PKS</string>\r\n  <string>PSX</string>\r\n  <string" +
            ">PTR</string>\r\n  <string>PYPL</string>\r\n  <string>PYPLD</string>\r\n  <string>QCOM" +
            "</string>\r\n  <string>QCOMC</string>\r\n  <string>QCOMD</string>\r\n  <string>QQQ</st" +
            "ring>\r\n  <string>QQQC</string>\r\n  <string>QQQD</string>\r\n  <string>RDS</string>\r" +
            "\n  <string>RIO</string>\r\n  <string>RTX</string>\r\n  <string>SAN</string>\r\n  <stri" +
            "ng>SAP</string>\r\n  <string>SBS</string>\r\n  <string>SBUX</string>\r\n  <string>SCCO" +
            "</string>\r\n  <string>SHOP</string>\r\n  <string>SID</string>\r\n  <string>SLB</strin" +
            "g>\r\n  <string>SLBD</string>\r\n  <string>SNAP</string>\r\n  <string>SNOW</string>\r\n " +
            " <string>SONY</string>\r\n  <string>SPOT</string>\r\n  <string>SPY</string>\r\n  <stri" +
            "ng>SPYC</string>\r\n  <string>SPYD</string>\r\n  <string>SQ</string>\r\n  <string>SUZ<" +
            "/string>\r\n  <string>T</string>\r\n  <string>TD</string>\r\n  <string>TEN</string>\r\n " +
            " <string>TEND</string>\r\n  <string>TGNO4</string>\r\n  <string>TGT</string>\r\n  <str" +
            "ing>TMD</string>\r\n  <string>TMO</string>\r\n  <string>TOT</string>\r\n  <string>TRAN" +
            "</string>\r\n  <string>TRIP</string>\r\n  <string>TSLA</string>\r\n  <string>TSLAC</st" +
            "ring>\r\n  <string>TSLAD</string>\r\n  <string>TSM</string>\r\n  <string>TWTR</string>" +
            "\r\n  <string>TWTRD</string>\r\n  <string>TXN</string>\r\n  <string>TXR</string>\r\n  <s" +
            "tring>UGP</string>\r\n  <string>UL</string>\r\n  <string>UNH</string>\r\n  <string>UNP" +
            "</string>\r\n  <string>V</string>\r\n  <string>VALE</string>\r\n  <string>VALED</strin" +
            "g>\r\n  <string>VD</string>\r\n  <string>VIST</string>\r\n  <string>VISTD</string>\r\n  " +
            "<string>VIV</string>\r\n  <string>VOD</string>\r\n  <string>VRSN</string>\r\n  <string" +
            ">VZ</string>\r\n  <string>VZD</string>\r\n  <string>WBA</string>\r\n  <string>WFC</str" +
            "ing>\r\n  <string>WFCC</string>\r\n  <string>WFCD</string>\r\n  <string>WMT</string>\r\n" +
            "  <string>WMTD</string>\r\n  <string>X</string>\r\n  <string>XD</string>\r\n  <string>" +
            "XLEC</string>\r\n  <string>XLED</string>\r\n  <string>XOM</string>\r\n  <string>XOMC</" +
            "string>\r\n  <string>XOMD</string>\r\n  <string>XOMD</string>\r\n  <string>XROX</strin" +
            "g>\r\n  <string>YELP</string>\r\n  <string>ZM</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AccionesCEDEARs {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AccionesCEDEARs"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>AAL</string>\r\n  <string>AAPL</string>\r\n  <string>ABBV</string>\r\n  <string>" +
            "ABT</string>\r\n  <string>ADBE</string>\r\n  <string>ADGO</string>\r\n  <string>AE38</" +
            "string>\r\n  <string>AL29</string>\r\n  <string>AL30</string>\r\n  <string>AL35</strin" +
            "g>\r\n  <string>AL41</string>\r\n  <string>AMD</string>\r\n  <string>AMZN</string>\r\n  " +
            "<string>ARCO</string>\r\n  <string>ARKK</string>\r\n  <string>AVGO</string>\r\n  <stri" +
            "ng>AXP</string>\r\n  <string>BA</string>\r\n  <string>BA.C</string>\r\n  <string>BABA<" +
            "/string>\r\n  <string>BBD</string>\r\n  <string>BBV</string>\r\n  <string>BIDU</string" +
            ">\r\n  <string>BIDU</string>\r\n  <string>BIOX</string>\r\n  <string>BITF</string>\r\n  " +
            "<string>BNG</string>\r\n  <string>BRFS</string>\r\n  <string>BRKB</string>\r\n  <strin" +
            "g>C</string>\r\n  <string>CAT</string>\r\n  <string>COIN</string>\r\n  <string>CRM</st" +
            "ring>\r\n  <string>CSCO</string>\r\n  <string>CVX</string>\r\n  <string>CX</string>\r\n " +
            " <string>DE</string>\r\n  <string>DEO</string>\r\n  <string>DESP</string>\r\n  <string" +
            ">DIA</string>\r\n  <string>DISN</string>\r\n  <string>DOW</string>\r\n  <string>EEM</s" +
            "tring>\r\n  <string>ETSY</string>\r\n  <string>EWZ</string>\r\n  <string>F</string>\r\n " +
            " <string>FCX</string>\r\n  <string>GD29</string>\r\n  <string>GD30</string>\r\n  <stri" +
            "ng>GD35</string>\r\n  <string>GD38</string>\r\n  <string>GD41</string>\r\n  <string>GD" +
            "46</string>\r\n  <string>GE</string>\r\n  <string>GLOB</string>\r\n  <string>GM</strin" +
            "g>\r\n  <string>GOLD</string>\r\n  <string>GOOGL</string>\r\n  <string>HMY</string>\r\n " +
            " <string>HSY</string>\r\n  <string>HUT</string>\r\n  <string>IBM</string>\r\n  <string" +
            ">INTC</string>\r\n  <string>IWM</string>\r\n  <string>JD</string>\r\n  <string>JMIA</s" +
            "tring>\r\n  <string>JNJ</string>\r\n  <string>JPM</string>\r\n  <string>KO</string>\r\n " +
            " <string>MCD</string>\r\n  <string>MELI</string>\r\n  <string>META</string>\r\n  <stri" +
            "ng>MMM</string>\r\n  <string>MO</string>\r\n  <string>MRK</string>\r\n  <string>MSFT</" +
            "string>\r\n  <string>MTR</string>\r\n  <string>NFLX</string>\r\n  <string>NIO</string>" +
            "\r\n  <string>NKE</string>\r\n  <string>NVDA</string>\r\n  <string>OXY</string>\r\n  <st" +
            "ring>PAAS</string>\r\n  <string>PBR</string>\r\n  <string>PEP</string>\r\n  <string>PF" +
            "E</string>\r\n  <string>PG</string>\r\n  <string>PYPL</string>\r\n  <string>QCOM</stri" +
            "ng>\r\n  <string>QCOM</string>\r\n  <string>QQQ</string>\r\n  <string>RIO</string>\r\n  " +
            "<string>SATL</string>\r\n  <string>SHOP</string>\r\n  <string>SID</string>\r\n  <strin" +
            "g>SPY</string>\r\n  <string>SQ</string>\r\n  <string>T</string>\r\n  <string>TEN</stri" +
            "ng>\r\n  <string>TGT</string>\r\n  <string>TSLA</string>\r\n  <string>TSM</string>\r\n  " +
            "<string>UPST</string>\r\n  <string>V</string>\r\n  <string>VALE</string>\r\n  <string>" +
            "VIST</string>\r\n  <string>VZ</string>\r\n  <string>WBA</string>\r\n  <string>WFC</str" +
            "ing>\r\n  <string>WMT</string>\r\n  <string>X18E4</string>\r\n  <string>X20F4</string>" +
            "\r\n  <string>XLE</string>\r\n  <string>XLF</string>\r\n  <string>XOM</string>\r\n  <str" +
            "ing>ZM</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ArbitrationTickers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ArbitrationTickers"]));
            }
            set {
                this["ArbitrationTickers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("70")]
        public decimal TasaCaucion {
            get {
                return ((decimal)(this["TasaCaucion"]));
            }
            set {
                this["TasaCaucion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.5")]
        public decimal ArancelCaucionColocadora {
            get {
                return ((decimal)(this["ArancelCaucionColocadora"]));
            }
            set {
                this["ArancelCaucionColocadora"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal ArancelCaucionTomadora {
            get {
                return ((decimal)(this["ArancelCaucionTomadora"]));
            }
            set {
                this["ArancelCaucionTomadora"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.001")]
        public decimal DerechoMercadoLetra {
            get {
                return ((decimal)(this["DerechoMercadoLetra"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        public string AppInsightsConnectionString {
            get {
                return ((string)(this["AppInsightsConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>X18E4;XE4D;XE4C</string>\r\n  <string>X20F4;XF4D;XF4C</string>\r\n</ArrayOfStr" +
            "ing>")]
        public global::System.Collections.Specialized.StringCollection TickersDC {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TickersDC"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>X18E4</string>\r\n  <string>X20F4</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Letras {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Letras"]));
            }
        }
    }
}
