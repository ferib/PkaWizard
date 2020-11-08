
namespace PkaWizardCli.Pka
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PACKETTRACER5_ACTIVITY
    {

        private string vERSIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5[] pACKETTRACER5Field;

        private PACKETTRACER5_ACTIVITYCOMPARISONS cOMPARISONSField;

        private PACKETTRACER5_ACTIVITYINITIALSETUP iNITIALSETUPField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREE lOCKINGTREEField;

        private PACKETTRACER5_ACTIVITYOPTIONS oPTIONSField;

        private PACKETTRACER5_ACTIVITYACTIVITY aCTIVITYField;

        private PACKETTRACER5_ACTIVITYVARIABLE_MANAGER vARIABLE_MANAGERField;

        private PACKETTRACER5_ACTIVITYOVERALL_INCOMPLETE_FEEDBACK oVERALL_INCOMPLETE_FEEDBACKField;

        private PACKETTRACER5_ACTIVITYOVERALL_COMPLETE_FEEDBACK oVERALL_COMPLETE_FEEDBACKField;

        private byte uNLOCK_ASSESSMENT_ITEM_PERCENTField;

        private PACKETTRACER5_ACTIVITYDYNAMIC_PERCENTAGE_FEEDBACK dYNAMIC_PERCENTAGE_FEEDBACKField;

        private bool uSER_PROFILE_LOCKEDField;

        private bool uSER_PROFILE_NOGUESTField;

        private string cOMPONENT_LISTField;

        private bool cLEAN_ACTIVITYField;

        private PACKETTRACER5_ACTIVITYSCRIPT_MODULE sCRIPT_MODULEField;

        private PACKETTRACER5_ACTIVITYAUTHOR aUTHORField;

        private PACKETTRACER5_ACTIVITYOBJECT_LOCATIONS oBJECT_LOCATIONSField;

        private object cEPSField;

        /// <remarks/>
        public string VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACKETTRACER5")]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5[] PACKETTRACER5
        {
            get
            {
                return this.pACKETTRACER5Field;
            }
            set
            {
                this.pACKETTRACER5Field = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONS COMPARISONS
        {
            get
            {
                return this.cOMPARISONSField;
            }
            set
            {
                this.cOMPARISONSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUP INITIALSETUP
        {
            get
            {
                return this.iNITIALSETUPField;
            }
            set
            {
                this.iNITIALSETUPField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYLOCKINGTREE LOCKINGTREE
        {
            get
            {
                return this.lOCKINGTREEField;
            }
            set
            {
                this.lOCKINGTREEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONS OPTIONS
        {
            get
            {
                return this.oPTIONSField;
            }
            set
            {
                this.oPTIONSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYACTIVITY ACTIVITY
        {
            get
            {
                return this.aCTIVITYField;
            }
            set
            {
                this.aCTIVITYField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYVARIABLE_MANAGER VARIABLE_MANAGER
        {
            get
            {
                return this.vARIABLE_MANAGERField;
            }
            set
            {
                this.vARIABLE_MANAGERField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOVERALL_INCOMPLETE_FEEDBACK OVERALL_INCOMPLETE_FEEDBACK
        {
            get
            {
                return this.oVERALL_INCOMPLETE_FEEDBACKField;
            }
            set
            {
                this.oVERALL_INCOMPLETE_FEEDBACKField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOVERALL_COMPLETE_FEEDBACK OVERALL_COMPLETE_FEEDBACK
        {
            get
            {
                return this.oVERALL_COMPLETE_FEEDBACKField;
            }
            set
            {
                this.oVERALL_COMPLETE_FEEDBACKField = value;
            }
        }

        /// <remarks/>
        public byte UNLOCK_ASSESSMENT_ITEM_PERCENT
        {
            get
            {
                return this.uNLOCK_ASSESSMENT_ITEM_PERCENTField;
            }
            set
            {
                this.uNLOCK_ASSESSMENT_ITEM_PERCENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYDYNAMIC_PERCENTAGE_FEEDBACK DYNAMIC_PERCENTAGE_FEEDBACK
        {
            get
            {
                return this.dYNAMIC_PERCENTAGE_FEEDBACKField;
            }
            set
            {
                this.dYNAMIC_PERCENTAGE_FEEDBACKField = value;
            }
        }

        /// <remarks/>
        public bool USER_PROFILE_LOCKED
        {
            get
            {
                return this.uSER_PROFILE_LOCKEDField;
            }
            set
            {
                this.uSER_PROFILE_LOCKEDField = value;
            }
        }

        /// <remarks/>
        public bool USER_PROFILE_NOGUEST
        {
            get
            {
                return this.uSER_PROFILE_NOGUESTField;
            }
            set
            {
                this.uSER_PROFILE_NOGUESTField = value;
            }
        }

        /// <remarks/>
        public string COMPONENT_LIST
        {
            get
            {
                return this.cOMPONENT_LISTField;
            }
            set
            {
                this.cOMPONENT_LISTField = value;
            }
        }

        /// <remarks/>
        public bool CLEAN_ACTIVITY
        {
            get
            {
                return this.cLEAN_ACTIVITYField;
            }
            set
            {
                this.cLEAN_ACTIVITYField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYSCRIPT_MODULE SCRIPT_MODULE
        {
            get
            {
                return this.sCRIPT_MODULEField;
            }
            set
            {
                this.sCRIPT_MODULEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYAUTHOR AUTHOR
        {
            get
            {
                return this.aUTHORField;
            }
            set
            {
                this.aUTHORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOBJECT_LOCATIONS OBJECT_LOCATIONS
        {
            get
            {
                return this.oBJECT_LOCATIONSField;
            }
            set
            {
                this.oBJECT_LOCATIONSField = value;
            }
        }

        /// <remarks/>
        public object CEPS
        {
            get
            {
                return this.cEPSField;
            }
            set
            {
                this.cEPSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5
    {

        private string vERSIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5IMAGE[] pIXMAPBANKField;

        private object mOVIEBANKField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORK nETWORKField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSET sCENARIOSETField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONS oPTIONSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACE pHYSICALWORKSPACEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERS fILTERSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERS cLUSTERSField;

        private object lINESField;

        private object rECTANGLESField;

        private object eLLIPSESField;

        private object pOLYGONSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5USER_PROFILE uSER_PROFILEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5MULTIUSER mULTIUSERField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5GEOVIEW_GRAPHICSITEMS gEOVIEW_GRAPHICSITEMSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULE sCRIPT_MODULEField;

        private object cODE_TESTINGField;

        /// <remarks/>
        public string VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("IMAGE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5IMAGE[] PIXMAPBANK
        {
            get
            {
                return this.pIXMAPBANKField;
            }
            set
            {
                this.pIXMAPBANKField = value;
            }
        }

        /// <remarks/>
        public object MOVIEBANK
        {
            get
            {
                return this.mOVIEBANKField;
            }
            set
            {
                this.mOVIEBANKField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORK NETWORK
        {
            get
            {
                return this.nETWORKField;
            }
            set
            {
                this.nETWORKField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSET SCENARIOSET
        {
            get
            {
                return this.sCENARIOSETField;
            }
            set
            {
                this.sCENARIOSETField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONS OPTIONS
        {
            get
            {
                return this.oPTIONSField;
            }
            set
            {
                this.oPTIONSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACE PHYSICALWORKSPACE
        {
            get
            {
                return this.pHYSICALWORKSPACEField;
            }
            set
            {
                this.pHYSICALWORKSPACEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERS FILTERS
        {
            get
            {
                return this.fILTERSField;
            }
            set
            {
                this.fILTERSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERS CLUSTERS
        {
            get
            {
                return this.cLUSTERSField;
            }
            set
            {
                this.cLUSTERSField = value;
            }
        }

        /// <remarks/>
        public object LINES
        {
            get
            {
                return this.lINESField;
            }
            set
            {
                this.lINESField = value;
            }
        }

        /// <remarks/>
        public object RECTANGLES
        {
            get
            {
                return this.rECTANGLESField;
            }
            set
            {
                this.rECTANGLESField = value;
            }
        }

        /// <remarks/>
        public object ELLIPSES
        {
            get
            {
                return this.eLLIPSESField;
            }
            set
            {
                this.eLLIPSESField = value;
            }
        }

        /// <remarks/>
        public object POLYGONS
        {
            get
            {
                return this.pOLYGONSField;
            }
            set
            {
                this.pOLYGONSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5USER_PROFILE USER_PROFILE
        {
            get
            {
                return this.uSER_PROFILEField;
            }
            set
            {
                this.uSER_PROFILEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5MULTIUSER MULTIUSER
        {
            get
            {
                return this.mULTIUSERField;
            }
            set
            {
                this.mULTIUSERField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5GEOVIEW_GRAPHICSITEMS GEOVIEW_GRAPHICSITEMS
        {
            get
            {
                return this.gEOVIEW_GRAPHICSITEMSField;
            }
            set
            {
                this.gEOVIEW_GRAPHICSITEMSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULE SCRIPT_MODULE
        {
            get
            {
                return this.sCRIPT_MODULEField;
            }
            set
            {
                this.sCRIPT_MODULEField = value;
            }
        }

        /// <remarks/>
        public object CODE_TESTING
        {
            get
            {
                return this.cODE_TESTINGField;
            }
            set
            {
                this.cODE_TESTINGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5IMAGE
    {

        private string iMAGE_PATHField;
        private string iMAGE_CONTENTField;

        /// <remarks/>
        public string IMAGE_PATH
        {
            get
            {
                return this.iMAGE_PATHField;
            }
            set
            {
                this.iMAGE_PATHField = value;
            }
        }

        /// <remarks/>
        public string IMAGE_CONTENT
        {
            get
            {
                return this.iMAGE_CONTENTField;
            }
            set
            {
                this.iMAGE_CONTENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORK
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICE[] dEVICESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKLINK[] lINKSField;

        private object sHAPETESTSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDESCRIPTION dESCRIPTIONField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DEVICE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICE[] DEVICES
        {
            get
            {
                return this.dEVICESField;
            }
            set
            {
                this.dEVICESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LINK", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKLINK[] LINKS
        {
            get
            {
                return this.lINKSField;
            }
            set
            {
                this.lINKSField = value;
            }
        }

        /// <remarks/>
        public object SHAPETESTS
        {
            get
            {
                return this.sHAPETESTSField;
            }
            set
            {
                this.sHAPETESTSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDESCRIPTION DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINE eNGINEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACE wORKSPACEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINE ENGINE
        {
            get
            {
                return this.eNGINEField;
            }
            set
            {
                this.eNGINEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACE WORKSPACE
        {
            get
            {
                return this.wORKSPACEField;
            }
            set
            {
                this.wORKSPACEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINETYPE tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENAME nAMEField;

        private bool pOWERField;

        private object dESCRIPTIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULE mODULEField;

        private string cUSTOM_VARSField;

        private object cUSTOM_INTERFACEField;

        private object sYS_CONTACTField;

        private object sYS_LOCATIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECOORD_SETTINGS cOORD_SETTINGSField;

        private string sERIALNUMBERField;

        private string eXT_ATTRIBUTESField;

        private byte uSB_PORT_COUNTField;

        private byte tEMPLATE_CREATION_TIMEField;

        private ulong sTARTTIMEField;

        private byte sTARTSIMTIMEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEUSER_APPS uSER_APPSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_PORT bLUETOOTH_PORTField;

        private string sAVE_REF_IDField;

        private string sYS_NAMEField;

        private string gATEWAYField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDNS_CLIENT dNS_CLIENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEEMAIL_CLIENT eMAIL_CLIENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENT wIRELESS_CLIENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENT cELLULAR_CLIENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENT dHCP_CLIENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEACL_PROCESS aCL_PROCESSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEACL_V6_PROCESS aCL_V6_PROCESSField;

        private object gATEWAYV6Field;

        private bool iSATAP_ENABLEDField;

        private bool iSATAP_ENABLEDFieldSpecified;

        private object iSATAP_ROUTERField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCPV6_MAIN dHCPV6_MAINField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENDV6 nDV6Field;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENF_COLLECTOR nF_COLLECTORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVOIP_TFTP_IP vOIP_TFTP_IPField;

        private string[] rUNNINGCONFIGField;

        private object sTARTUPCONFIGField;

        private string cURRENT_COMMAND_SETField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGER fILE_MANAGERField;

        private ushort cONFIG_REGISTERField;

        private bool cONFIG_REGISTERFieldSpecified;

        private ushort nEXT_CONFIG_REGISTERField;

        private bool nEXT_CONFIG_REGISTERFieldSpecified;

        private string cURRENT_BOOT_FILEField;

        private object cONFIG_BOOT_FILESField;

        private string bUILD_IN_ADDRField;

        private object bIOS_VERSIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESECURITY sECURITYField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEALGORITHM_SETTINGS aLGORITHM_SETTINGSField;

        private object tRAFFICGEN_USER_TRAFFICField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINETERMINAL_SETTINGS tERMINAL_SETTINGSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEPPPOE_SETTINGS pPPOE_SETTINGSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINELOCK_SETTINGS lOCK_SETTINGSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEHTML_TAB hTML_TABField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEGUI_TAB gUI_TABField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEIMAGE_SETTINGS iMAGE_SETTINGSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_MANAGER bLUETOOTH_MANAGERField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDOT1X_SETTINGS dOT1X_SETTINGSField;

        private bool sCP_SERVER_ENABLEDField;

        private bool sCP_SERVER_ENABLEDFieldSpecified;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVLAN[] vLANSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVTP vTPField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_SNOOPING_BINDING_DB_AGENT dHCP_SNOOPING_BINDING_DB_AGENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESDM sDMField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESIG_IPSPROCESS sIG_IPSPROCESSField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINETYPE TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public bool POWER
        {
            get
            {
                return this.pOWERField;
            }
            set
            {
                this.pOWERField = value;
            }
        }

        /// <remarks/>
        public object DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULE MODULE
        {
            get
            {
                return this.mODULEField;
            }
            set
            {
                this.mODULEField = value;
            }
        }

        /// <remarks/>
        public string CUSTOM_VARS
        {
            get
            {
                return this.cUSTOM_VARSField;
            }
            set
            {
                this.cUSTOM_VARSField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_INTERFACE
        {
            get
            {
                return this.cUSTOM_INTERFACEField;
            }
            set
            {
                this.cUSTOM_INTERFACEField = value;
            }
        }

        /// <remarks/>
        public object SYS_CONTACT
        {
            get
            {
                return this.sYS_CONTACTField;
            }
            set
            {
                this.sYS_CONTACTField = value;
            }
        }

        /// <remarks/>
        public object SYS_LOCATION
        {
            get
            {
                return this.sYS_LOCATIONField;
            }
            set
            {
                this.sYS_LOCATIONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECOORD_SETTINGS COORD_SETTINGS
        {
            get
            {
                return this.cOORD_SETTINGSField;
            }
            set
            {
                this.cOORD_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public string SERIALNUMBER
        {
            get
            {
                return this.sERIALNUMBERField;
            }
            set
            {
                this.sERIALNUMBERField = value;
            }
        }

        /// <remarks/>
        public string EXT_ATTRIBUTES
        {
            get
            {
                return this.eXT_ATTRIBUTESField;
            }
            set
            {
                this.eXT_ATTRIBUTESField = value;
            }
        }

        /// <remarks/>
        public byte USB_PORT_COUNT
        {
            get
            {
                return this.uSB_PORT_COUNTField;
            }
            set
            {
                this.uSB_PORT_COUNTField = value;
            }
        }

        /// <remarks/>
        public byte TEMPLATE_CREATION_TIME
        {
            get
            {
                return this.tEMPLATE_CREATION_TIMEField;
            }
            set
            {
                this.tEMPLATE_CREATION_TIMEField = value;
            }
        }

        /// <remarks/>
        public ulong STARTTIME
        {
            get
            {
                return this.sTARTTIMEField;
            }
            set
            {
                this.sTARTTIMEField = value;
            }
        }

        /// <remarks/>
        public byte STARTSIMTIME
        {
            get
            {
                return this.sTARTSIMTIMEField;
            }
            set
            {
                this.sTARTSIMTIMEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEUSER_APPS USER_APPS
        {
            get
            {
                return this.uSER_APPSField;
            }
            set
            {
                this.uSER_APPSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_PORT BLUETOOTH_PORT
        {
            get
            {
                return this.bLUETOOTH_PORTField;
            }
            set
            {
                this.bLUETOOTH_PORTField = value;
            }
        }

        /// <remarks/>
        public string SAVE_REF_ID
        {
            get
            {
                return this.sAVE_REF_IDField;
            }
            set
            {
                this.sAVE_REF_IDField = value;
            }
        }

        /// <remarks/>
        public string SYS_NAME
        {
            get
            {
                return this.sYS_NAMEField;
            }
            set
            {
                this.sYS_NAMEField = value;
            }
        }

        /// <remarks/>
        public string GATEWAY
        {
            get
            {
                return this.gATEWAYField;
            }
            set
            {
                this.gATEWAYField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDNS_CLIENT DNS_CLIENT
        {
            get
            {
                return this.dNS_CLIENTField;
            }
            set
            {
                this.dNS_CLIENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEEMAIL_CLIENT EMAIL_CLIENT
        {
            get
            {
                return this.eMAIL_CLIENTField;
            }
            set
            {
                this.eMAIL_CLIENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENT WIRELESS_CLIENT
        {
            get
            {
                return this.wIRELESS_CLIENTField;
            }
            set
            {
                this.wIRELESS_CLIENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENT CELLULAR_CLIENT
        {
            get
            {
                return this.cELLULAR_CLIENTField;
            }
            set
            {
                this.cELLULAR_CLIENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENT DHCP_CLIENT
        {
            get
            {
                return this.dHCP_CLIENTField;
            }
            set
            {
                this.dHCP_CLIENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEACL_PROCESS ACL_PROCESS
        {
            get
            {
                return this.aCL_PROCESSField;
            }
            set
            {
                this.aCL_PROCESSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEACL_V6_PROCESS ACL_V6_PROCESS
        {
            get
            {
                return this.aCL_V6_PROCESSField;
            }
            set
            {
                this.aCL_V6_PROCESSField = value;
            }
        }

        /// <remarks/>
        public object GATEWAYV6
        {
            get
            {
                return this.gATEWAYV6Field;
            }
            set
            {
                this.gATEWAYV6Field = value;
            }
        }

        /// <remarks/>
        public bool ISATAP_ENABLED
        {
            get
            {
                return this.iSATAP_ENABLEDField;
            }
            set
            {
                this.iSATAP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ISATAP_ENABLEDSpecified
        {
            get
            {
                return this.iSATAP_ENABLEDFieldSpecified;
            }
            set
            {
                this.iSATAP_ENABLEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public object ISATAP_ROUTER
        {
            get
            {
                return this.iSATAP_ROUTERField;
            }
            set
            {
                this.iSATAP_ROUTERField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCPV6_MAIN DHCPV6_MAIN
        {
            get
            {
                return this.dHCPV6_MAINField;
            }
            set
            {
                this.dHCPV6_MAINField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENDV6 NDV6
        {
            get
            {
                return this.nDV6Field;
            }
            set
            {
                this.nDV6Field = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENF_COLLECTOR NF_COLLECTOR
        {
            get
            {
                return this.nF_COLLECTORField;
            }
            set
            {
                this.nF_COLLECTORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVOIP_TFTP_IP VOIP_TFTP_IP
        {
            get
            {
                return this.vOIP_TFTP_IPField;
            }
            set
            {
                this.vOIP_TFTP_IPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LINE", IsNullable = false)]
        public string[] RUNNINGCONFIG
        {
            get
            {
                return this.rUNNINGCONFIGField;
            }
            set
            {
                this.rUNNINGCONFIGField = value;
            }
        }

        /// <remarks/>
        public object STARTUPCONFIG
        {
            get
            {
                return this.sTARTUPCONFIGField;
            }
            set
            {
                this.sTARTUPCONFIGField = value;
            }
        }

        /// <remarks/>
        public string CURRENT_COMMAND_SET
        {
            get
            {
                return this.cURRENT_COMMAND_SETField;
            }
            set
            {
                this.cURRENT_COMMAND_SETField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGER FILE_MANAGER
        {
            get
            {
                return this.fILE_MANAGERField;
            }
            set
            {
                this.fILE_MANAGERField = value;
            }
        }

        /// <remarks/>
        public ushort CONFIG_REGISTER
        {
            get
            {
                return this.cONFIG_REGISTERField;
            }
            set
            {
                this.cONFIG_REGISTERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CONFIG_REGISTERSpecified
        {
            get
            {
                return this.cONFIG_REGISTERFieldSpecified;
            }
            set
            {
                this.cONFIG_REGISTERFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort NEXT_CONFIG_REGISTER
        {
            get
            {
                return this.nEXT_CONFIG_REGISTERField;
            }
            set
            {
                this.nEXT_CONFIG_REGISTERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NEXT_CONFIG_REGISTERSpecified
        {
            get
            {
                return this.nEXT_CONFIG_REGISTERFieldSpecified;
            }
            set
            {
                this.nEXT_CONFIG_REGISTERFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CURRENT_BOOT_FILE
        {
            get
            {
                return this.cURRENT_BOOT_FILEField;
            }
            set
            {
                this.cURRENT_BOOT_FILEField = value;
            }
        }

        /// <remarks/>
        public object CONFIG_BOOT_FILES
        {
            get
            {
                return this.cONFIG_BOOT_FILESField;
            }
            set
            {
                this.cONFIG_BOOT_FILESField = value;
            }
        }

        /// <remarks/>
        public string BUILD_IN_ADDR
        {
            get
            {
                return this.bUILD_IN_ADDRField;
            }
            set
            {
                this.bUILD_IN_ADDRField = value;
            }
        }

        /// <remarks/>
        public object BIOS_VERSION
        {
            get
            {
                return this.bIOS_VERSIONField;
            }
            set
            {
                this.bIOS_VERSIONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESECURITY SECURITY
        {
            get
            {
                return this.sECURITYField;
            }
            set
            {
                this.sECURITYField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEALGORITHM_SETTINGS ALGORITHM_SETTINGS
        {
            get
            {
                return this.aLGORITHM_SETTINGSField;
            }
            set
            {
                this.aLGORITHM_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public object TRAFFICGEN_USER_TRAFFIC
        {
            get
            {
                return this.tRAFFICGEN_USER_TRAFFICField;
            }
            set
            {
                this.tRAFFICGEN_USER_TRAFFICField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINETERMINAL_SETTINGS TERMINAL_SETTINGS
        {
            get
            {
                return this.tERMINAL_SETTINGSField;
            }
            set
            {
                this.tERMINAL_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEPPPOE_SETTINGS PPPOE_SETTINGS
        {
            get
            {
                return this.pPPOE_SETTINGSField;
            }
            set
            {
                this.pPPOE_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINELOCK_SETTINGS LOCK_SETTINGS
        {
            get
            {
                return this.lOCK_SETTINGSField;
            }
            set
            {
                this.lOCK_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEHTML_TAB HTML_TAB
        {
            get
            {
                return this.hTML_TABField;
            }
            set
            {
                this.hTML_TABField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEGUI_TAB GUI_TAB
        {
            get
            {
                return this.gUI_TABField;
            }
            set
            {
                this.gUI_TABField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEIMAGE_SETTINGS IMAGE_SETTINGS
        {
            get
            {
                return this.iMAGE_SETTINGSField;
            }
            set
            {
                this.iMAGE_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_MANAGER BLUETOOTH_MANAGER
        {
            get
            {
                return this.bLUETOOTH_MANAGERField;
            }
            set
            {
                this.bLUETOOTH_MANAGERField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDOT1X_SETTINGS DOT1X_SETTINGS
        {
            get
            {
                return this.dOT1X_SETTINGSField;
            }
            set
            {
                this.dOT1X_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public bool SCP_SERVER_ENABLED
        {
            get
            {
                return this.sCP_SERVER_ENABLEDField;
            }
            set
            {
                this.sCP_SERVER_ENABLEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SCP_SERVER_ENABLEDSpecified
        {
            get
            {
                return this.sCP_SERVER_ENABLEDFieldSpecified;
            }
            set
            {
                this.sCP_SERVER_ENABLEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("VLAN", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVLAN[] VLANS
        {
            get
            {
                return this.vLANSField;
            }
            set
            {
                this.vLANSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVTP VTP
        {
            get
            {
                return this.vTPField;
            }
            set
            {
                this.vTPField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_SNOOPING_BINDING_DB_AGENT DHCP_SNOOPING_BINDING_DB_AGENT
        {
            get
            {
                return this.dHCP_SNOOPING_BINDING_DB_AGENTField;
            }
            set
            {
                this.dHCP_SNOOPING_BINDING_DB_AGENTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESDM SDM
        {
            get
            {
                return this.sDMField;
            }
            set
            {
                this.sDMField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESIG_IPSPROCESS SIG_IPSPROCESS
        {
            get
            {
                return this.sIG_IPSPROCESSField;
            }
            set
            {
                this.sIG_IPSPROCESSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINETYPE
    {

        private string modelField;

        private string customModelField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string customModel
        {
            get
            {
                return this.customModelField;
            }
            set
            {
                this.customModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULE
    {

        private string tYPEField;

        private object mODELField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOT[] sLOTField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public object MODEL
        {
            get
            {
                return this.mODELField;
            }
            set
            {
                this.mODELField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SLOT")]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOT[] SLOT
        {
            get
            {
                return this.sLOTField;
            }
            set
            {
                this.sLOTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOT
    {

        private string tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULE mODULEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULE MODULE
        {
            get
            {
                return this.mODULEField;
            }
            set
            {
                this.mODULEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULE
    {

        private string tYPEField;

        private string mODELField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULESLOT[] sLOTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULEPORT[] pORTField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string MODEL
        {
            get
            {
                return this.mODELField;
            }
            set
            {
                this.mODELField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SLOT")]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULESLOT[] SLOT
        {
            get
            {
                return this.sLOTField;
            }
            set
            {
                this.sLOTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PORT")]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULEPORT[] PORT
        {
            get
            {
                return this.pORTField;
            }
            set
            {
                this.pORTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULESLOT
    {

        private string tYPEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEMODULESLOTMODULEPORT
    {

        private string tYPEField;

        private bool pOWERField;

        private byte mEDIATYPEField;

        private bool pINSField;

        private uint bANDWIDTHField;

        private bool fULLDUPLEXField;

        private bool aUTONEGOTIATEBANDWIDTHField;

        private bool aUTONEGOTIATEDUPLEXField;

        private string mACADDRESSField;

        private string bIAField;

        private byte cLOCKRATEField;

        private bool cLOCKRATEFLAGField;

        private object dESCRIPTIONField;

        private byte cHANNELField;

        private byte cHANNEL5GHZField;

        private byte cOVERAGERANGEField;

        private bool sAVED_FULLDUPLEXField;

        private byte uP_METHODField;

        private string ipField;

        private string sUBNETField;

        private string pORT_GATEWAYField;

        private object pORT_DNSField;

        private bool pORT_DHCP_ENABLEField;

        private bool pORT_DHCP_ENABLEFieldSpecified;

        private bool nD_SUPPRESSEDField;

        private bool nD_SUPPRESSEDFieldSpecified;

        private uint tIMEOUTField;

        private bool tIMEOUTFieldSpecified;

        private bool pC_FIREWALLField;

        private bool pC_FIREWALLFieldSpecified;

        private bool pC_IPV6_FIREWALLField;

        private bool pC_IPV6_FIREWALLFieldSpecified;

        private bool iPV6_ENABLEDField;

        private bool iPV6_ENABLEDFieldSpecified;

        private bool iPV6_ADDRESS_AUTOCONFIGField;

        private bool iPV6_ADDRESS_AUTOCONFIGFieldSpecified;

        private object iPV6_PORT_GATEWAYField;

        private object iPV6_PORT_DNSField;

        private object iPV6_LINK_LOCALField;

        private string iPV6_DEFAULT_LINK_LOCALField;

        private bool iPV6_PORT_DHCP_ENABLEDField;

        private bool iPV6_PORT_DHCP_ENABLEDFieldSpecified;

        private object iPV6_ADDRESSESField;

        private object iP_UNNUMBEREDField;

        private bool mANAGEMENT_INTERFACEField;

        private bool mANAGEMENT_INTERFACEFieldSpecified;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public bool POWER
        {
            get
            {
                return this.pOWERField;
            }
            set
            {
                this.pOWERField = value;
            }
        }

        /// <remarks/>
        public byte MEDIATYPE
        {
            get
            {
                return this.mEDIATYPEField;
            }
            set
            {
                this.mEDIATYPEField = value;
            }
        }

        /// <remarks/>
        public bool PINS
        {
            get
            {
                return this.pINSField;
            }
            set
            {
                this.pINSField = value;
            }
        }

        /// <remarks/>
        public uint BANDWIDTH
        {
            get
            {
                return this.bANDWIDTHField;
            }
            set
            {
                this.bANDWIDTHField = value;
            }
        }

        /// <remarks/>
        public bool FULLDUPLEX
        {
            get
            {
                return this.fULLDUPLEXField;
            }
            set
            {
                this.fULLDUPLEXField = value;
            }
        }

        /// <remarks/>
        public bool AUTONEGOTIATEBANDWIDTH
        {
            get
            {
                return this.aUTONEGOTIATEBANDWIDTHField;
            }
            set
            {
                this.aUTONEGOTIATEBANDWIDTHField = value;
            }
        }

        /// <remarks/>
        public bool AUTONEGOTIATEDUPLEX
        {
            get
            {
                return this.aUTONEGOTIATEDUPLEXField;
            }
            set
            {
                this.aUTONEGOTIATEDUPLEXField = value;
            }
        }

        /// <remarks/>
        public string MACADDRESS
        {
            get
            {
                return this.mACADDRESSField;
            }
            set
            {
                this.mACADDRESSField = value;
            }
        }

        /// <remarks/>
        public string BIA
        {
            get
            {
                return this.bIAField;
            }
            set
            {
                this.bIAField = value;
            }
        }

        /// <remarks/>
        public byte CLOCKRATE
        {
            get
            {
                return this.cLOCKRATEField;
            }
            set
            {
                this.cLOCKRATEField = value;
            }
        }

        /// <remarks/>
        public bool CLOCKRATEFLAG
        {
            get
            {
                return this.cLOCKRATEFLAGField;
            }
            set
            {
                this.cLOCKRATEFLAGField = value;
            }
        }

        /// <remarks/>
        public object DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL
        {
            get
            {
                return this.cHANNELField;
            }
            set
            {
                this.cHANNELField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL5GHZ
        {
            get
            {
                return this.cHANNEL5GHZField;
            }
            set
            {
                this.cHANNEL5GHZField = value;
            }
        }

        /// <remarks/>
        public byte COVERAGERANGE
        {
            get
            {
                return this.cOVERAGERANGEField;
            }
            set
            {
                this.cOVERAGERANGEField = value;
            }
        }

        /// <remarks/>
        public bool SAVED_FULLDUPLEX
        {
            get
            {
                return this.sAVED_FULLDUPLEXField;
            }
            set
            {
                this.sAVED_FULLDUPLEXField = value;
            }
        }

        /// <remarks/>
        public byte UP_METHOD
        {
            get
            {
                return this.uP_METHODField;
            }
            set
            {
                this.uP_METHODField = value;
            }
        }

        /// <remarks/>
        public string IP
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }

        /// <remarks/>
        public string SUBNET
        {
            get
            {
                return this.sUBNETField;
            }
            set
            {
                this.sUBNETField = value;
            }
        }

        /// <remarks/>
        public string PORT_GATEWAY
        {
            get
            {
                return this.pORT_GATEWAYField;
            }
            set
            {
                this.pORT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object PORT_DNS
        {
            get
            {
                return this.pORT_DNSField;
            }
            set
            {
                this.pORT_DNSField = value;
            }
        }

        /// <remarks/>
        public bool PORT_DHCP_ENABLE
        {
            get
            {
                return this.pORT_DHCP_ENABLEField;
            }
            set
            {
                this.pORT_DHCP_ENABLEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PORT_DHCP_ENABLESpecified
        {
            get
            {
                return this.pORT_DHCP_ENABLEFieldSpecified;
            }
            set
            {
                this.pORT_DHCP_ENABLEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ND_SUPPRESSED
        {
            get
            {
                return this.nD_SUPPRESSEDField;
            }
            set
            {
                this.nD_SUPPRESSEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ND_SUPPRESSEDSpecified
        {
            get
            {
                return this.nD_SUPPRESSEDFieldSpecified;
            }
            set
            {
                this.nD_SUPPRESSEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint TIMEOUT
        {
            get
            {
                return this.tIMEOUTField;
            }
            set
            {
                this.tIMEOUTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TIMEOUTSpecified
        {
            get
            {
                return this.tIMEOUTFieldSpecified;
            }
            set
            {
                this.tIMEOUTFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool PC_FIREWALL
        {
            get
            {
                return this.pC_FIREWALLField;
            }
            set
            {
                this.pC_FIREWALLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PC_FIREWALLSpecified
        {
            get
            {
                return this.pC_FIREWALLFieldSpecified;
            }
            set
            {
                this.pC_FIREWALLFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool PC_IPV6_FIREWALL
        {
            get
            {
                return this.pC_IPV6_FIREWALLField;
            }
            set
            {
                this.pC_IPV6_FIREWALLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PC_IPV6_FIREWALLSpecified
        {
            get
            {
                return this.pC_IPV6_FIREWALLFieldSpecified;
            }
            set
            {
                this.pC_IPV6_FIREWALLFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IPV6_ENABLED
        {
            get
            {
                return this.iPV6_ENABLEDField;
            }
            set
            {
                this.iPV6_ENABLEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPV6_ENABLEDSpecified
        {
            get
            {
                return this.iPV6_ENABLEDFieldSpecified;
            }
            set
            {
                this.iPV6_ENABLEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IPV6_ADDRESS_AUTOCONFIG
        {
            get
            {
                return this.iPV6_ADDRESS_AUTOCONFIGField;
            }
            set
            {
                this.iPV6_ADDRESS_AUTOCONFIGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPV6_ADDRESS_AUTOCONFIGSpecified
        {
            get
            {
                return this.iPV6_ADDRESS_AUTOCONFIGFieldSpecified;
            }
            set
            {
                this.iPV6_ADDRESS_AUTOCONFIGFieldSpecified = value;
            }
        }

        /// <remarks/>
        public object IPV6_PORT_GATEWAY
        {
            get
            {
                return this.iPV6_PORT_GATEWAYField;
            }
            set
            {
                this.iPV6_PORT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object IPV6_PORT_DNS
        {
            get
            {
                return this.iPV6_PORT_DNSField;
            }
            set
            {
                this.iPV6_PORT_DNSField = value;
            }
        }

        /// <remarks/>
        public object IPV6_LINK_LOCAL
        {
            get
            {
                return this.iPV6_LINK_LOCALField;
            }
            set
            {
                this.iPV6_LINK_LOCALField = value;
            }
        }

        /// <remarks/>
        public string IPV6_DEFAULT_LINK_LOCAL
        {
            get
            {
                return this.iPV6_DEFAULT_LINK_LOCALField;
            }
            set
            {
                this.iPV6_DEFAULT_LINK_LOCALField = value;
            }
        }

        /// <remarks/>
        public bool IPV6_PORT_DHCP_ENABLED
        {
            get
            {
                return this.iPV6_PORT_DHCP_ENABLEDField;
            }
            set
            {
                this.iPV6_PORT_DHCP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPV6_PORT_DHCP_ENABLEDSpecified
        {
            get
            {
                return this.iPV6_PORT_DHCP_ENABLEDFieldSpecified;
            }
            set
            {
                this.iPV6_PORT_DHCP_ENABLEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public object IPV6_ADDRESSES
        {
            get
            {
                return this.iPV6_ADDRESSESField;
            }
            set
            {
                this.iPV6_ADDRESSESField = value;
            }
        }

        /// <remarks/>
        public object IP_UNNUMBERED
        {
            get
            {
                return this.iP_UNNUMBEREDField;
            }
            set
            {
                this.iP_UNNUMBEREDField = value;
            }
        }

        /// <remarks/>
        public bool MANAGEMENT_INTERFACE
        {
            get
            {
                return this.mANAGEMENT_INTERFACEField;
            }
            set
            {
                this.mANAGEMENT_INTERFACEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MANAGEMENT_INTERFACESpecified
        {
            get
            {
                return this.mANAGEMENT_INTERFACEFieldSpecified;
            }
            set
            {
                this.mANAGEMENT_INTERFACEFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECOORD_SETTINGS
    {

        private decimal x_COORDField;

        private decimal y_COORDField;

        private byte z_COORDField;

        /// <remarks/>
        public decimal X_COORD
        {
            get
            {
                return this.x_COORDField;
            }
            set
            {
                this.x_COORDField = value;
            }
        }

        /// <remarks/>
        public decimal Y_COORD
        {
            get
            {
                return this.y_COORDField;
            }
            set
            {
                this.y_COORDField = value;
            }
        }

        /// <remarks/>
        public byte Z_COORD
        {
            get
            {
                return this.z_COORDField;
            }
            set
            {
                this.z_COORDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEUSER_APPS
    {

        private object rUNNING_APPSField;

        private object dESKTOP_APPSField;

        /// <remarks/>
        public object RUNNING_APPS
        {
            get
            {
                return this.rUNNING_APPSField;
            }
            set
            {
                this.rUNNING_APPSField = value;
            }
        }

        /// <remarks/>
        public object DESKTOP_APPS
        {
            get
            {
                return this.dESKTOP_APPSField;
            }
            set
            {
                this.dESKTOP_APPSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_PORT
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_PORTPORT pORTField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_PORTPORT PORT
        {
            get
            {
                return this.pORTField;
            }
            set
            {
                this.pORTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_PORTPORT
    {

        private string tYPEField;

        private bool pOWERField;

        private byte mEDIATYPEField;

        private bool pINSField;

        private ushort bANDWIDTHField;

        private bool fULLDUPLEXField;

        private bool aUTONEGOTIATEBANDWIDTHField;

        private bool aUTONEGOTIATEDUPLEXField;

        private string mACADDRESSField;

        private string bIAField;

        private uint cLOCKRATEField;

        private bool cLOCKRATEFLAGField;

        private object dESCRIPTIONField;

        private byte cHANNELField;

        private byte cHANNEL5GHZField;

        private byte cOVERAGERANGEField;

        private bool sAVED_FULLDUPLEXField;

        private byte uP_METHODField;

        private object ipField;

        private object sUBNETField;

        private object pORT_GATEWAYField;

        private object pORT_DNSField;

        private bool pORT_DHCP_ENABLEField;

        private bool nD_SUPPRESSEDField;

        private uint tIMEOUTField;

        private bool pC_FIREWALLField;

        private bool pC_IPV6_FIREWALLField;

        private bool iPV6_ENABLEDField;

        private bool iPV6_ADDRESS_AUTOCONFIGField;

        private object iPV6_PORT_GATEWAYField;

        private object iPV6_PORT_DNSField;

        private object iPV6_LINK_LOCALField;

        private string iPV6_DEFAULT_LINK_LOCALField;

        private bool iPV6_PORT_DHCP_ENABLEDField;

        private object iPV6_ADDRESSESField;

        private object iP_UNNUMBEREDField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public bool POWER
        {
            get
            {
                return this.pOWERField;
            }
            set
            {
                this.pOWERField = value;
            }
        }

        /// <remarks/>
        public byte MEDIATYPE
        {
            get
            {
                return this.mEDIATYPEField;
            }
            set
            {
                this.mEDIATYPEField = value;
            }
        }

        /// <remarks/>
        public bool PINS
        {
            get
            {
                return this.pINSField;
            }
            set
            {
                this.pINSField = value;
            }
        }

        /// <remarks/>
        public ushort BANDWIDTH
        {
            get
            {
                return this.bANDWIDTHField;
            }
            set
            {
                this.bANDWIDTHField = value;
            }
        }

        /// <remarks/>
        public bool FULLDUPLEX
        {
            get
            {
                return this.fULLDUPLEXField;
            }
            set
            {
                this.fULLDUPLEXField = value;
            }
        }

        /// <remarks/>
        public bool AUTONEGOTIATEBANDWIDTH
        {
            get
            {
                return this.aUTONEGOTIATEBANDWIDTHField;
            }
            set
            {
                this.aUTONEGOTIATEBANDWIDTHField = value;
            }
        }

        /// <remarks/>
        public bool AUTONEGOTIATEDUPLEX
        {
            get
            {
                return this.aUTONEGOTIATEDUPLEXField;
            }
            set
            {
                this.aUTONEGOTIATEDUPLEXField = value;
            }
        }

        /// <remarks/>
        public string MACADDRESS
        {
            get
            {
                return this.mACADDRESSField;
            }
            set
            {
                this.mACADDRESSField = value;
            }
        }

        /// <remarks/>
        public string BIA
        {
            get
            {
                return this.bIAField;
            }
            set
            {
                this.bIAField = value;
            }
        }

        /// <remarks/>
        public uint CLOCKRATE
        {
            get
            {
                return this.cLOCKRATEField;
            }
            set
            {
                this.cLOCKRATEField = value;
            }
        }

        /// <remarks/>
        public bool CLOCKRATEFLAG
        {
            get
            {
                return this.cLOCKRATEFLAGField;
            }
            set
            {
                this.cLOCKRATEFLAGField = value;
            }
        }

        /// <remarks/>
        public object DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL
        {
            get
            {
                return this.cHANNELField;
            }
            set
            {
                this.cHANNELField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL5GHZ
        {
            get
            {
                return this.cHANNEL5GHZField;
            }
            set
            {
                this.cHANNEL5GHZField = value;
            }
        }

        /// <remarks/>
        public byte COVERAGERANGE
        {
            get
            {
                return this.cOVERAGERANGEField;
            }
            set
            {
                this.cOVERAGERANGEField = value;
            }
        }

        /// <remarks/>
        public bool SAVED_FULLDUPLEX
        {
            get
            {
                return this.sAVED_FULLDUPLEXField;
            }
            set
            {
                this.sAVED_FULLDUPLEXField = value;
            }
        }

        /// <remarks/>
        public byte UP_METHOD
        {
            get
            {
                return this.uP_METHODField;
            }
            set
            {
                this.uP_METHODField = value;
            }
        }

        /// <remarks/>
        public object IP
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }

        /// <remarks/>
        public object SUBNET
        {
            get
            {
                return this.sUBNETField;
            }
            set
            {
                this.sUBNETField = value;
            }
        }

        /// <remarks/>
        public object PORT_GATEWAY
        {
            get
            {
                return this.pORT_GATEWAYField;
            }
            set
            {
                this.pORT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object PORT_DNS
        {
            get
            {
                return this.pORT_DNSField;
            }
            set
            {
                this.pORT_DNSField = value;
            }
        }

        /// <remarks/>
        public bool PORT_DHCP_ENABLE
        {
            get
            {
                return this.pORT_DHCP_ENABLEField;
            }
            set
            {
                this.pORT_DHCP_ENABLEField = value;
            }
        }

        /// <remarks/>
        public bool ND_SUPPRESSED
        {
            get
            {
                return this.nD_SUPPRESSEDField;
            }
            set
            {
                this.nD_SUPPRESSEDField = value;
            }
        }

        /// <remarks/>
        public uint TIMEOUT
        {
            get
            {
                return this.tIMEOUTField;
            }
            set
            {
                this.tIMEOUTField = value;
            }
        }

        /// <remarks/>
        public bool PC_FIREWALL
        {
            get
            {
                return this.pC_FIREWALLField;
            }
            set
            {
                this.pC_FIREWALLField = value;
            }
        }

        /// <remarks/>
        public bool PC_IPV6_FIREWALL
        {
            get
            {
                return this.pC_IPV6_FIREWALLField;
            }
            set
            {
                this.pC_IPV6_FIREWALLField = value;
            }
        }

        /// <remarks/>
        public bool IPV6_ENABLED
        {
            get
            {
                return this.iPV6_ENABLEDField;
            }
            set
            {
                this.iPV6_ENABLEDField = value;
            }
        }

        /// <remarks/>
        public bool IPV6_ADDRESS_AUTOCONFIG
        {
            get
            {
                return this.iPV6_ADDRESS_AUTOCONFIGField;
            }
            set
            {
                this.iPV6_ADDRESS_AUTOCONFIGField = value;
            }
        }

        /// <remarks/>
        public object IPV6_PORT_GATEWAY
        {
            get
            {
                return this.iPV6_PORT_GATEWAYField;
            }
            set
            {
                this.iPV6_PORT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object IPV6_PORT_DNS
        {
            get
            {
                return this.iPV6_PORT_DNSField;
            }
            set
            {
                this.iPV6_PORT_DNSField = value;
            }
        }

        /// <remarks/>
        public object IPV6_LINK_LOCAL
        {
            get
            {
                return this.iPV6_LINK_LOCALField;
            }
            set
            {
                this.iPV6_LINK_LOCALField = value;
            }
        }

        /// <remarks/>
        public string IPV6_DEFAULT_LINK_LOCAL
        {
            get
            {
                return this.iPV6_DEFAULT_LINK_LOCALField;
            }
            set
            {
                this.iPV6_DEFAULT_LINK_LOCALField = value;
            }
        }

        /// <remarks/>
        public bool IPV6_PORT_DHCP_ENABLED
        {
            get
            {
                return this.iPV6_PORT_DHCP_ENABLEDField;
            }
            set
            {
                this.iPV6_PORT_DHCP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        public object IPV6_ADDRESSES
        {
            get
            {
                return this.iPV6_ADDRESSESField;
            }
            set
            {
                this.iPV6_ADDRESSESField = value;
            }
        }

        /// <remarks/>
        public object IP_UNNUMBERED
        {
            get
            {
                return this.iP_UNNUMBEREDField;
            }
            set
            {
                this.iP_UNNUMBEREDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDNS_CLIENT
    {

        private object sERVER_IPField;

        private object sERVER_IPV6Field;

        /// <remarks/>
        public object SERVER_IP
        {
            get
            {
                return this.sERVER_IPField;
            }
            set
            {
                this.sERVER_IPField = value;
            }
        }

        /// <remarks/>
        public object SERVER_IPV6
        {
            get
            {
                return this.sERVER_IPV6Field;
            }
            set
            {
                this.sERVER_IPV6Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEEMAIL_CLIENT
    {

        private byte eNABLEDField;

        private object nAMEField;

        private object mAIL_IDField;

        private object pOP3_SERVERField;

        private object sMTP_SERVERField;

        private object uSERField;

        private object pASSWORDField;

        private byte nO_OF_MAILSField;

        /// <remarks/>
        public byte ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }

        /// <remarks/>
        public object NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public object MAIL_ID
        {
            get
            {
                return this.mAIL_IDField;
            }
            set
            {
                this.mAIL_IDField = value;
            }
        }

        /// <remarks/>
        public object POP3_SERVER
        {
            get
            {
                return this.pOP3_SERVERField;
            }
            set
            {
                this.pOP3_SERVERField = value;
            }
        }

        /// <remarks/>
        public object SMTP_SERVER
        {
            get
            {
                return this.sMTP_SERVERField;
            }
            set
            {
                this.sMTP_SERVERField = value;
            }
        }

        /// <remarks/>
        public object USER
        {
            get
            {
                return this.uSERField;
            }
            set
            {
                this.uSERField = value;
            }
        }

        /// <remarks/>
        public object PASSWORD
        {
            get
            {
                return this.pASSWORDField;
            }
            set
            {
                this.pASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte NO_OF_MAILS
        {
            get
            {
                return this.nO_OF_MAILSField;
            }
            set
            {
                this.nO_OF_MAILSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENT
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTWIRELESS_COMMON wIRELESS_COMMONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTPROFILES pROFILESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTCURRENT_PROFILE cURRENT_PROFILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTWIRELESS_COMMON WIRELESS_COMMON
        {
            get
            {
                return this.wIRELESS_COMMONField;
            }
            set
            {
                this.wIRELESS_COMMONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTPROFILES PROFILES
        {
            get
            {
                return this.pROFILESField;
            }
            set
            {
                this.pROFILESField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTCURRENT_PROFILE CURRENT_PROFILE
        {
            get
            {
                return this.cURRENT_PROFILEField;
            }
            set
            {
                this.cURRENT_PROFILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTWIRELESS_COMMON
    {

        private byte nETWORK_MODEField;

        private string sSIDField;

        private byte eNCRYPT_TYPEField;

        private byte aUTHEN_TYPEField;

        private byte rADIO_BANDField;

        private byte wIDE_CHANNELField;

        private byte sTANDARD_CHANNELField;

        private byte sTANDARD_CHANNEL5GField;

        /// <remarks/>
        public byte NETWORK_MODE
        {
            get
            {
                return this.nETWORK_MODEField;
            }
            set
            {
                this.nETWORK_MODEField = value;
            }
        }

        /// <remarks/>
        public string SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }

        /// <remarks/>
        public byte ENCRYPT_TYPE
        {
            get
            {
                return this.eNCRYPT_TYPEField;
            }
            set
            {
                this.eNCRYPT_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte RADIO_BAND
        {
            get
            {
                return this.rADIO_BANDField;
            }
            set
            {
                this.rADIO_BANDField = value;
            }
        }

        /// <remarks/>
        public byte WIDE_CHANNEL
        {
            get
            {
                return this.wIDE_CHANNELField;
            }
            set
            {
                this.wIDE_CHANNELField = value;
            }
        }

        /// <remarks/>
        public byte STANDARD_CHANNEL
        {
            get
            {
                return this.sTANDARD_CHANNELField;
            }
            set
            {
                this.sTANDARD_CHANNELField = value;
            }
        }

        /// <remarks/>
        public byte STANDARD_CHANNEL5G
        {
            get
            {
                return this.sTANDARD_CHANNEL5GField;
            }
            set
            {
                this.sTANDARD_CHANNEL5GField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTPROFILES
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTPROFILESWIRELESS_PROFILE wIRELESS_PROFILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTPROFILESWIRELESS_PROFILE WIRELESS_PROFILE
        {
            get
            {
                return this.wIRELESS_PROFILEField;
            }
            set
            {
                this.wIRELESS_PROFILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTPROFILESWIRELESS_PROFILE
    {

        private string nAMEField;

        private string sSIDField;

        private byte nETWORK_TYPEField;

        private byte rADIO_BANDField;

        private byte aUTHEN_TYPEField;

        private byte eNCRYPT_TYPEField;

        private object wEP_KEYField;

        private object wPA_EAP_USERIDField;

        private object wPA_EAP_PASSWORDField;

        private byte dHCP_ENABLEDField;

        private object iP_ADDRESSField;

        private object sUBNET_MASKField;

        private object dEFAULT_GATEWAYField;

        private object dNSField;

        private byte cHANNELField;

        private byte vLANField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }

        /// <remarks/>
        public byte NETWORK_TYPE
        {
            get
            {
                return this.nETWORK_TYPEField;
            }
            set
            {
                this.nETWORK_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte RADIO_BAND
        {
            get
            {
                return this.rADIO_BANDField;
            }
            set
            {
                this.rADIO_BANDField = value;
            }
        }

        /// <remarks/>
        public byte AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte ENCRYPT_TYPE
        {
            get
            {
                return this.eNCRYPT_TYPEField;
            }
            set
            {
                this.eNCRYPT_TYPEField = value;
            }
        }

        /// <remarks/>
        public object WEP_KEY
        {
            get
            {
                return this.wEP_KEYField;
            }
            set
            {
                this.wEP_KEYField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_USERID
        {
            get
            {
                return this.wPA_EAP_USERIDField;
            }
            set
            {
                this.wPA_EAP_USERIDField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_PASSWORD
        {
            get
            {
                return this.wPA_EAP_PASSWORDField;
            }
            set
            {
                this.wPA_EAP_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte DHCP_ENABLED
        {
            get
            {
                return this.dHCP_ENABLEDField;
            }
            set
            {
                this.dHCP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        public object IP_ADDRESS
        {
            get
            {
                return this.iP_ADDRESSField;
            }
            set
            {
                this.iP_ADDRESSField = value;
            }
        }

        /// <remarks/>
        public object SUBNET_MASK
        {
            get
            {
                return this.sUBNET_MASKField;
            }
            set
            {
                this.sUBNET_MASKField = value;
            }
        }

        /// <remarks/>
        public object DEFAULT_GATEWAY
        {
            get
            {
                return this.dEFAULT_GATEWAYField;
            }
            set
            {
                this.dEFAULT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object DNS
        {
            get
            {
                return this.dNSField;
            }
            set
            {
                this.dNSField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL
        {
            get
            {
                return this.cHANNELField;
            }
            set
            {
                this.cHANNELField = value;
            }
        }

        /// <remarks/>
        public byte VLAN
        {
            get
            {
                return this.vLANField;
            }
            set
            {
                this.vLANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTCURRENT_PROFILE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTCURRENT_PROFILEWIRELESS_PROFILE wIRELESS_PROFILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTCURRENT_PROFILEWIRELESS_PROFILE WIRELESS_PROFILE
        {
            get
            {
                return this.wIRELESS_PROFILEField;
            }
            set
            {
                this.wIRELESS_PROFILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEWIRELESS_CLIENTCURRENT_PROFILEWIRELESS_PROFILE
    {

        private string nAMEField;

        private string sSIDField;

        private byte nETWORK_TYPEField;

        private byte rADIO_BANDField;

        private byte aUTHEN_TYPEField;

        private byte eNCRYPT_TYPEField;

        private object wEP_KEYField;

        private object wPA_EAP_USERIDField;

        private object wPA_EAP_PASSWORDField;

        private byte dHCP_ENABLEDField;

        private object iP_ADDRESSField;

        private object sUBNET_MASKField;

        private object dEFAULT_GATEWAYField;

        private object dNSField;

        private byte cHANNELField;

        private byte vLANField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }

        /// <remarks/>
        public byte NETWORK_TYPE
        {
            get
            {
                return this.nETWORK_TYPEField;
            }
            set
            {
                this.nETWORK_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte RADIO_BAND
        {
            get
            {
                return this.rADIO_BANDField;
            }
            set
            {
                this.rADIO_BANDField = value;
            }
        }

        /// <remarks/>
        public byte AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte ENCRYPT_TYPE
        {
            get
            {
                return this.eNCRYPT_TYPEField;
            }
            set
            {
                this.eNCRYPT_TYPEField = value;
            }
        }

        /// <remarks/>
        public object WEP_KEY
        {
            get
            {
                return this.wEP_KEYField;
            }
            set
            {
                this.wEP_KEYField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_USERID
        {
            get
            {
                return this.wPA_EAP_USERIDField;
            }
            set
            {
                this.wPA_EAP_USERIDField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_PASSWORD
        {
            get
            {
                return this.wPA_EAP_PASSWORDField;
            }
            set
            {
                this.wPA_EAP_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte DHCP_ENABLED
        {
            get
            {
                return this.dHCP_ENABLEDField;
            }
            set
            {
                this.dHCP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        public object IP_ADDRESS
        {
            get
            {
                return this.iP_ADDRESSField;
            }
            set
            {
                this.iP_ADDRESSField = value;
            }
        }

        /// <remarks/>
        public object SUBNET_MASK
        {
            get
            {
                return this.sUBNET_MASKField;
            }
            set
            {
                this.sUBNET_MASKField = value;
            }
        }

        /// <remarks/>
        public object DEFAULT_GATEWAY
        {
            get
            {
                return this.dEFAULT_GATEWAYField;
            }
            set
            {
                this.dEFAULT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object DNS
        {
            get
            {
                return this.dNSField;
            }
            set
            {
                this.dNSField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL
        {
            get
            {
                return this.cHANNELField;
            }
            set
            {
                this.cHANNELField = value;
            }
        }

        /// <remarks/>
        public byte VLAN
        {
            get
            {
                return this.vLANField;
            }
            set
            {
                this.vLANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENT
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENT wIRELESS_CLIENTField;

        private object pROFILESField;

        private byte cURRENT_PROFILE_NUMField;

        private string cO_USERNAMEField;

        private string cO_PASSWORDField;

        private byte aCTIVATEDField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENT WIRELESS_CLIENT
        {
            get
            {
                return this.wIRELESS_CLIENTField;
            }
            set
            {
                this.wIRELESS_CLIENTField = value;
            }
        }

        /// <remarks/>
        public object PROFILES
        {
            get
            {
                return this.pROFILESField;
            }
            set
            {
                this.pROFILESField = value;
            }
        }

        /// <remarks/>
        public byte CURRENT_PROFILE_NUM
        {
            get
            {
                return this.cURRENT_PROFILE_NUMField;
            }
            set
            {
                this.cURRENT_PROFILE_NUMField = value;
            }
        }

        /// <remarks/>
        public string CO_USERNAME
        {
            get
            {
                return this.cO_USERNAMEField;
            }
            set
            {
                this.cO_USERNAMEField = value;
            }
        }

        /// <remarks/>
        public string CO_PASSWORD
        {
            get
            {
                return this.cO_PASSWORDField;
            }
            set
            {
                this.cO_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte ACTIVATED
        {
            get
            {
                return this.aCTIVATEDField;
            }
            set
            {
                this.aCTIVATEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENT
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTWIRELESS_COMMON wIRELESS_COMMONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTPROFILES pROFILESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTCURRENT_PROFILE cURRENT_PROFILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTWIRELESS_COMMON WIRELESS_COMMON
        {
            get
            {
                return this.wIRELESS_COMMONField;
            }
            set
            {
                this.wIRELESS_COMMONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTPROFILES PROFILES
        {
            get
            {
                return this.pROFILESField;
            }
            set
            {
                this.pROFILESField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTCURRENT_PROFILE CURRENT_PROFILE
        {
            get
            {
                return this.cURRENT_PROFILEField;
            }
            set
            {
                this.cURRENT_PROFILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTWIRELESS_COMMON
    {

        private byte nETWORK_MODEField;

        private string sSIDField;

        private byte eNCRYPT_TYPEField;

        private byte aUTHEN_TYPEField;

        private byte rADIO_BANDField;

        private byte wIDE_CHANNELField;

        private byte sTANDARD_CHANNELField;

        private byte sTANDARD_CHANNEL5GField;

        /// <remarks/>
        public byte NETWORK_MODE
        {
            get
            {
                return this.nETWORK_MODEField;
            }
            set
            {
                this.nETWORK_MODEField = value;
            }
        }

        /// <remarks/>
        public string SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }

        /// <remarks/>
        public byte ENCRYPT_TYPE
        {
            get
            {
                return this.eNCRYPT_TYPEField;
            }
            set
            {
                this.eNCRYPT_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte RADIO_BAND
        {
            get
            {
                return this.rADIO_BANDField;
            }
            set
            {
                this.rADIO_BANDField = value;
            }
        }

        /// <remarks/>
        public byte WIDE_CHANNEL
        {
            get
            {
                return this.wIDE_CHANNELField;
            }
            set
            {
                this.wIDE_CHANNELField = value;
            }
        }

        /// <remarks/>
        public byte STANDARD_CHANNEL
        {
            get
            {
                return this.sTANDARD_CHANNELField;
            }
            set
            {
                this.sTANDARD_CHANNELField = value;
            }
        }

        /// <remarks/>
        public byte STANDARD_CHANNEL5G
        {
            get
            {
                return this.sTANDARD_CHANNEL5GField;
            }
            set
            {
                this.sTANDARD_CHANNEL5GField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTPROFILES
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTPROFILESWIRELESS_PROFILE wIRELESS_PROFILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTPROFILESWIRELESS_PROFILE WIRELESS_PROFILE
        {
            get
            {
                return this.wIRELESS_PROFILEField;
            }
            set
            {
                this.wIRELESS_PROFILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTPROFILESWIRELESS_PROFILE
    {

        private string nAMEField;

        private string sSIDField;

        private byte nETWORK_TYPEField;

        private byte rADIO_BANDField;

        private byte aUTHEN_TYPEField;

        private byte eNCRYPT_TYPEField;

        private object wEP_KEYField;

        private object wPA_EAP_USERIDField;

        private object wPA_EAP_PASSWORDField;

        private byte dHCP_ENABLEDField;

        private object iP_ADDRESSField;

        private object sUBNET_MASKField;

        private object dEFAULT_GATEWAYField;

        private object dNSField;

        private byte cHANNELField;

        private byte vLANField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }

        /// <remarks/>
        public byte NETWORK_TYPE
        {
            get
            {
                return this.nETWORK_TYPEField;
            }
            set
            {
                this.nETWORK_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte RADIO_BAND
        {
            get
            {
                return this.rADIO_BANDField;
            }
            set
            {
                this.rADIO_BANDField = value;
            }
        }

        /// <remarks/>
        public byte AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte ENCRYPT_TYPE
        {
            get
            {
                return this.eNCRYPT_TYPEField;
            }
            set
            {
                this.eNCRYPT_TYPEField = value;
            }
        }

        /// <remarks/>
        public object WEP_KEY
        {
            get
            {
                return this.wEP_KEYField;
            }
            set
            {
                this.wEP_KEYField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_USERID
        {
            get
            {
                return this.wPA_EAP_USERIDField;
            }
            set
            {
                this.wPA_EAP_USERIDField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_PASSWORD
        {
            get
            {
                return this.wPA_EAP_PASSWORDField;
            }
            set
            {
                this.wPA_EAP_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte DHCP_ENABLED
        {
            get
            {
                return this.dHCP_ENABLEDField;
            }
            set
            {
                this.dHCP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        public object IP_ADDRESS
        {
            get
            {
                return this.iP_ADDRESSField;
            }
            set
            {
                this.iP_ADDRESSField = value;
            }
        }

        /// <remarks/>
        public object SUBNET_MASK
        {
            get
            {
                return this.sUBNET_MASKField;
            }
            set
            {
                this.sUBNET_MASKField = value;
            }
        }

        /// <remarks/>
        public object DEFAULT_GATEWAY
        {
            get
            {
                return this.dEFAULT_GATEWAYField;
            }
            set
            {
                this.dEFAULT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object DNS
        {
            get
            {
                return this.dNSField;
            }
            set
            {
                this.dNSField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL
        {
            get
            {
                return this.cHANNELField;
            }
            set
            {
                this.cHANNELField = value;
            }
        }

        /// <remarks/>
        public byte VLAN
        {
            get
            {
                return this.vLANField;
            }
            set
            {
                this.vLANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTCURRENT_PROFILE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTCURRENT_PROFILEWIRELESS_PROFILE wIRELESS_PROFILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTCURRENT_PROFILEWIRELESS_PROFILE WIRELESS_PROFILE
        {
            get
            {
                return this.wIRELESS_PROFILEField;
            }
            set
            {
                this.wIRELESS_PROFILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINECELLULAR_CLIENTWIRELESS_CLIENTCURRENT_PROFILEWIRELESS_PROFILE
    {

        private string nAMEField;

        private string sSIDField;

        private byte nETWORK_TYPEField;

        private byte rADIO_BANDField;

        private byte aUTHEN_TYPEField;

        private byte eNCRYPT_TYPEField;

        private object wEP_KEYField;

        private object wPA_EAP_USERIDField;

        private object wPA_EAP_PASSWORDField;

        private byte dHCP_ENABLEDField;

        private object iP_ADDRESSField;

        private object sUBNET_MASKField;

        private object dEFAULT_GATEWAYField;

        private object dNSField;

        private byte cHANNELField;

        private byte vLANField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }

        /// <remarks/>
        public byte NETWORK_TYPE
        {
            get
            {
                return this.nETWORK_TYPEField;
            }
            set
            {
                this.nETWORK_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte RADIO_BAND
        {
            get
            {
                return this.rADIO_BANDField;
            }
            set
            {
                this.rADIO_BANDField = value;
            }
        }

        /// <remarks/>
        public byte AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }

        /// <remarks/>
        public byte ENCRYPT_TYPE
        {
            get
            {
                return this.eNCRYPT_TYPEField;
            }
            set
            {
                this.eNCRYPT_TYPEField = value;
            }
        }

        /// <remarks/>
        public object WEP_KEY
        {
            get
            {
                return this.wEP_KEYField;
            }
            set
            {
                this.wEP_KEYField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_USERID
        {
            get
            {
                return this.wPA_EAP_USERIDField;
            }
            set
            {
                this.wPA_EAP_USERIDField = value;
            }
        }

        /// <remarks/>
        public object WPA_EAP_PASSWORD
        {
            get
            {
                return this.wPA_EAP_PASSWORDField;
            }
            set
            {
                this.wPA_EAP_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte DHCP_ENABLED
        {
            get
            {
                return this.dHCP_ENABLEDField;
            }
            set
            {
                this.dHCP_ENABLEDField = value;
            }
        }

        /// <remarks/>
        public object IP_ADDRESS
        {
            get
            {
                return this.iP_ADDRESSField;
            }
            set
            {
                this.iP_ADDRESSField = value;
            }
        }

        /// <remarks/>
        public object SUBNET_MASK
        {
            get
            {
                return this.sUBNET_MASKField;
            }
            set
            {
                this.sUBNET_MASKField = value;
            }
        }

        /// <remarks/>
        public object DEFAULT_GATEWAY
        {
            get
            {
                return this.dEFAULT_GATEWAYField;
            }
            set
            {
                this.dEFAULT_GATEWAYField = value;
            }
        }

        /// <remarks/>
        public object DNS
        {
            get
            {
                return this.dNSField;
            }
            set
            {
                this.dNSField = value;
            }
        }

        /// <remarks/>
        public byte CHANNEL
        {
            get
            {
                return this.cHANNELField;
            }
            set
            {
                this.cHANNELField = value;
            }
        }

        /// <remarks/>
        public byte VLAN
        {
            get
            {
                return this.vLANField;
            }
            set
            {
                this.vLANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENT
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENTPORT_DATA_MAP pORT_DATA_MAPField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENTPORT_DATA_MAP PORT_DATA_MAP
        {
            get
            {
                return this.pORT_DATA_MAPField;
            }
            set
            {
                this.pORT_DATA_MAPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENTPORT_DATA_MAP
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENTPORT_DATA_MAPPORT_DATA_ENTRY pORT_DATA_ENTRYField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENTPORT_DATA_MAPPORT_DATA_ENTRY PORT_DATA_ENTRY
        {
            get
            {
                return this.pORT_DATA_ENTRYField;
            }
            set
            {
                this.pORT_DATA_ENTRYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_CLIENTPORT_DATA_MAPPORT_DATA_ENTRY
    {

        private string pORTField;

        /// <remarks/>
        public string PORT
        {
            get
            {
                return this.pORTField;
            }
            set
            {
                this.pORTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEACL_PROCESS
    {

        private object aCLSField;

        /// <remarks/>
        public object ACLS
        {
            get
            {
                return this.aCLSField;
            }
            set
            {
                this.aCLSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEACL_V6_PROCESS
    {

        private object aCLSField;

        /// <remarks/>
        public object ACLS
        {
            get
            {
                return this.aCLSField;
            }
            set
            {
                this.aCLSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCPV6_MAIN
    {

        private string pARTIAL_DUIDField;

        private object eNABLED_PORTSField;

        /// <remarks/>
        public string PARTIAL_DUID
        {
            get
            {
                return this.pARTIAL_DUIDField;
            }
            set
            {
                this.pARTIAL_DUIDField = value;
            }
        }

        /// <remarks/>
        public object ENABLED_PORTS
        {
            get
            {
                return this.eNABLED_PORTSField;
            }
            set
            {
                this.eNABLED_PORTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENDV6
    {

        private object eNABLED_HOSTField;

        private byte eNABLED_ROUTERField;

        private object sERVER_ROUTER_PORT_DATA_HEADField;

        /// <remarks/>
        public object ENABLED_HOST
        {
            get
            {
                return this.eNABLED_HOSTField;
            }
            set
            {
                this.eNABLED_HOSTField = value;
            }
        }

        /// <remarks/>
        public byte ENABLED_ROUTER
        {
            get
            {
                return this.eNABLED_ROUTERField;
            }
            set
            {
                this.eNABLED_ROUTERField = value;
            }
        }

        /// <remarks/>
        public object SERVER_ROUTER_PORT_DATA_HEAD
        {
            get
            {
                return this.sERVER_ROUTER_PORT_DATA_HEADField;
            }
            set
            {
                this.sERVER_ROUTER_PORT_DATA_HEADField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINENF_COLLECTOR
    {

        private byte eNABLEDField;

        /// <remarks/>
        public byte ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVOIP_TFTP_IP
    {

        private string tFTP_IPField;

        private byte iS_DEFAULT_TFTPField;

        /// <remarks/>
        public string TFTP_IP
        {
            get
            {
                return this.tFTP_IPField;
            }
            set
            {
                this.tFTP_IPField = value;
            }
        }

        /// <remarks/>
        public byte IS_DEFAULT_TFTP
        {
            get
            {
                return this.iS_DEFAULT_TFTPField;
            }
            set
            {
                this.iS_DEFAULT_TFTPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGER
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILE fILEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILE FILE
        {
            get
            {
                return this.fILEField;
            }
            set
            {
                this.fILEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILE
    {

        private byte fILE_NUMBERField;

        private object nAMEField;

        private byte dATE_TIMEField;

        private byte pERMISSIONField;

        private object fILE_CONTENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILE[] fILESField;

        private string classField;

        /// <remarks/>
        public byte FILE_NUMBER
        {
            get
            {
                return this.fILE_NUMBERField;
            }
            set
            {
                this.fILE_NUMBERField = value;
            }
        }

        /// <remarks/>
        public object NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public byte DATE_TIME
        {
            get
            {
                return this.dATE_TIMEField;
            }
            set
            {
                this.dATE_TIMEField = value;
            }
        }

        /// <remarks/>
        public byte PERMISSION
        {
            get
            {
                return this.pERMISSIONField;
            }
            set
            {
                this.pERMISSIONField = value;
            }
        }

        /// <remarks/>
        public object FILE_CONTENT
        {
            get
            {
                return this.fILE_CONTENTField;
            }
            set
            {
                this.fILE_CONTENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FILE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILE[] FILES
        {
            get
            {
                return this.fILESField;
            }
            set
            {
                this.fILESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILE
    {

        private byte fILE_NUMBERField;

        private string nAMEField;

        private byte dATE_TIMEField;

        private byte pERMISSIONField;

        private object fILE_CONTENTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILE[] fILESField;

        private byte fILE_COUNTERField;

        private uint cAPACITYField;

        private string classField;

        /// <remarks/>
        public byte FILE_NUMBER
        {
            get
            {
                return this.fILE_NUMBERField;
            }
            set
            {
                this.fILE_NUMBERField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public byte DATE_TIME
        {
            get
            {
                return this.dATE_TIMEField;
            }
            set
            {
                this.dATE_TIMEField = value;
            }
        }

        /// <remarks/>
        public byte PERMISSION
        {
            get
            {
                return this.pERMISSIONField;
            }
            set
            {
                this.pERMISSIONField = value;
            }
        }

        /// <remarks/>
        public object FILE_CONTENT
        {
            get
            {
                return this.fILE_CONTENTField;
            }
            set
            {
                this.fILE_CONTENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FILE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILE[] FILES
        {
            get
            {
                return this.fILESField;
            }
            set
            {
                this.fILESField = value;
            }
        }

        /// <remarks/>
        public byte FILE_COUNTER
        {
            get
            {
                return this.fILE_COUNTERField;
            }
            set
            {
                this.fILE_COUNTERField = value;
            }
        }

        /// <remarks/>
        public uint CAPACITY
        {
            get
            {
                return this.cAPACITYField;
            }
            set
            {
                this.cAPACITYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILE
    {

        private byte fILE_NUMBERField;

        private string nAMEField;

        private uint dATE_TIMEField;

        private byte pERMISSIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENT fILE_CONTENTField;

        private string classField;

        /// <remarks/>
        public byte FILE_NUMBER
        {
            get
            {
                return this.fILE_NUMBERField;
            }
            set
            {
                this.fILE_NUMBERField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public uint DATE_TIME
        {
            get
            {
                return this.dATE_TIMEField;
            }
            set
            {
                this.dATE_TIMEField = value;
            }
        }

        /// <remarks/>
        public byte PERMISSION
        {
            get
            {
                return this.pERMISSIONField;
            }
            set
            {
                this.pERMISSIONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENT FILE_CONTENT
        {
            get
            {
                return this.fILE_CONTENTField;
            }
            set
            {
                this.fILE_CONTENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENT
    {

        private string tEXTField;

        private string firmware_VersionField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENTICMP_SIGNATURE iCMP_SIGNATUREField;

        private object sIG_CATField;

        private string dEVICE_TYPEField;

        private string sET_NAMEField;

        private string classField;

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        public string Firmware_Version
        {
            get
            {
                return this.firmware_VersionField;
            }
            set
            {
                this.firmware_VersionField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENTICMP_SIGNATURE ICMP_SIGNATURE
        {
            get
            {
                return this.iCMP_SIGNATUREField;
            }
            set
            {
                this.iCMP_SIGNATUREField = value;
            }
        }

        /// <remarks/>
        public object SIG_CAT
        {
            get
            {
                return this.sIG_CATField;
            }
            set
            {
                this.sIG_CATField = value;
            }
        }

        /// <remarks/>
        public string DEVICE_TYPE
        {
            get
            {
                return this.dEVICE_TYPEField;
            }
            set
            {
                this.dEVICE_TYPEField = value;
            }
        }

        /// <remarks/>
        public string SET_NAME
        {
            get
            {
                return this.sET_NAMEField;
            }
            set
            {
                this.sET_NAMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENTICMP_SIGNATURE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENTICMP_SIGNATURESIGNATURE sIGNATUREField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENTICMP_SIGNATURESIGNATURE SIGNATURE
        {
            get
            {
                return this.sIGNATUREField;
            }
            set
            {
                this.sIGNATUREField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEFILE_MANAGERFILEFILEFILEFILE_CONTENTICMP_SIGNATURESIGNATURE
    {

        private ushort sIG_IDField;

        private byte sUB_IDField;

        private byte rETIREDField;

        private byte eNABLEDField;

        private byte eVENT_ACTIONField;

        /// <remarks/>
        public ushort SIG_ID
        {
            get
            {
                return this.sIG_IDField;
            }
            set
            {
                this.sIG_IDField = value;
            }
        }

        /// <remarks/>
        public byte SUB_ID
        {
            get
            {
                return this.sUB_IDField;
            }
            set
            {
                this.sUB_IDField = value;
            }
        }

        /// <remarks/>
        public byte RETIRED
        {
            get
            {
                return this.rETIREDField;
            }
            set
            {
                this.rETIREDField = value;
            }
        }

        /// <remarks/>
        public byte ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }

        /// <remarks/>
        public byte EVENT_ACTION
        {
            get
            {
                return this.eVENT_ACTIONField;
            }
            set
            {
                this.eVENT_ACTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESECURITY
    {

        private object kEY_NAMEField;

        private object tEMP_KEY_NAMEField;

        private object rSA_KEYField;

        private object tEMP_RSA_KEYField;

        private object tIME_DATEField;

        private byte eNABLEDField;

        private byte mODULUS_BITSField;

        /// <remarks/>
        public object KEY_NAME
        {
            get
            {
                return this.kEY_NAMEField;
            }
            set
            {
                this.kEY_NAMEField = value;
            }
        }

        /// <remarks/>
        public object TEMP_KEY_NAME
        {
            get
            {
                return this.tEMP_KEY_NAMEField;
            }
            set
            {
                this.tEMP_KEY_NAMEField = value;
            }
        }

        /// <remarks/>
        public object RSA_KEY
        {
            get
            {
                return this.rSA_KEYField;
            }
            set
            {
                this.rSA_KEYField = value;
            }
        }

        /// <remarks/>
        public object TEMP_RSA_KEY
        {
            get
            {
                return this.tEMP_RSA_KEYField;
            }
            set
            {
                this.tEMP_RSA_KEYField = value;
            }
        }

        /// <remarks/>
        public object TIME_DATE
        {
            get
            {
                return this.tIME_DATEField;
            }
            set
            {
                this.tIME_DATEField = value;
            }
        }

        /// <remarks/>
        public byte ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }

        /// <remarks/>
        public byte MODULUS_BITS
        {
            get
            {
                return this.mODULUS_BITSField;
            }
            set
            {
                this.mODULUS_BITSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEALGORITHM_SETTINGS
    {

        private bool uSE_GLOBALField;

        private byte cBAC_HALF_OPEN_SESSION_MULTIPLIERField;

        private byte tCP_MAX_CONNECTING_SESSIONSField;

        private ushort tCP_MAX_OPENED_SESSIONSField;

        private byte iNTERFACE_QUEUE_SIZEField;

        private byte sTORM_CONTROL_MULTIPLIERField;

        private ushort tCP_MAX_RETRANSMISSION_TIMEOUTField;

        /// <remarks/>
        public bool USE_GLOBAL
        {
            get
            {
                return this.uSE_GLOBALField;
            }
            set
            {
                this.uSE_GLOBALField = value;
            }
        }

        /// <remarks/>
        public byte CBAC_HALF_OPEN_SESSION_MULTIPLIER
        {
            get
            {
                return this.cBAC_HALF_OPEN_SESSION_MULTIPLIERField;
            }
            set
            {
                this.cBAC_HALF_OPEN_SESSION_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte TCP_MAX_CONNECTING_SESSIONS
        {
            get
            {
                return this.tCP_MAX_CONNECTING_SESSIONSField;
            }
            set
            {
                this.tCP_MAX_CONNECTING_SESSIONSField = value;
            }
        }

        /// <remarks/>
        public ushort TCP_MAX_OPENED_SESSIONS
        {
            get
            {
                return this.tCP_MAX_OPENED_SESSIONSField;
            }
            set
            {
                this.tCP_MAX_OPENED_SESSIONSField = value;
            }
        }

        /// <remarks/>
        public byte INTERFACE_QUEUE_SIZE
        {
            get
            {
                return this.iNTERFACE_QUEUE_SIZEField;
            }
            set
            {
                this.iNTERFACE_QUEUE_SIZEField = value;
            }
        }

        /// <remarks/>
        public byte STORM_CONTROL_MULTIPLIER
        {
            get
            {
                return this.sTORM_CONTROL_MULTIPLIERField;
            }
            set
            {
                this.sTORM_CONTROL_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public ushort TCP_MAX_RETRANSMISSION_TIMEOUT
        {
            get
            {
                return this.tCP_MAX_RETRANSMISSION_TIMEOUTField;
            }
            set
            {
                this.tCP_MAX_RETRANSMISSION_TIMEOUTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINETERMINAL_SETTINGS
    {

        private ushort bITSField;

        private byte dATA_BITSField;

        private byte pARITYField;

        private byte sTOP_BITSField;

        private byte fLOW_CONTROLField;

        /// <remarks/>
        public ushort BITS
        {
            get
            {
                return this.bITSField;
            }
            set
            {
                this.bITSField = value;
            }
        }

        /// <remarks/>
        public byte DATA_BITS
        {
            get
            {
                return this.dATA_BITSField;
            }
            set
            {
                this.dATA_BITSField = value;
            }
        }

        /// <remarks/>
        public byte PARITY
        {
            get
            {
                return this.pARITYField;
            }
            set
            {
                this.pARITYField = value;
            }
        }

        /// <remarks/>
        public byte STOP_BITS
        {
            get
            {
                return this.sTOP_BITSField;
            }
            set
            {
                this.sTOP_BITSField = value;
            }
        }

        /// <remarks/>
        public byte FLOW_CONTROL
        {
            get
            {
                return this.fLOW_CONTROLField;
            }
            set
            {
                this.fLOW_CONTROLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEPPPOE_SETTINGS
    {

        private string aUTHEN_TYPEField;

        /// <remarks/>
        public string AUTHEN_TYPE
        {
            get
            {
                return this.aUTHEN_TYPEField;
            }
            set
            {
                this.aUTHEN_TYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINELOCK_SETTINGS
    {

        private byte dLOCKField;

        private byte lOCKField;

        private object pASSWDField;

        /// <remarks/>
        public byte DLOCK
        {
            get
            {
                return this.dLOCKField;
            }
            set
            {
                this.dLOCKField = value;
            }
        }

        /// <remarks/>
        public byte LOCK
        {
            get
            {
                return this.lOCKField;
            }
            set
            {
                this.lOCKField = value;
            }
        }

        /// <remarks/>
        public object PASSWD
        {
            get
            {
                return this.pASSWDField;
            }
            set
            {
                this.pASSWDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEHTML_TAB
    {

        private object hTML_CODEField;

        /// <remarks/>
        public object HTML_CODE
        {
            get
            {
                return this.hTML_CODEField;
            }
            set
            {
                this.hTML_CODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEGUI_TAB
    {

        private object gUI_CODEField;

        /// <remarks/>
        public object GUI_CODE
        {
            get
            {
                return this.gUI_CODEField;
            }
            set
            {
                this.gUI_CODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEIMAGE_SETTINGS
    {

        private object cUSTOM_PHYSICALField;

        /// <remarks/>
        public object CUSTOM_PHYSICAL
        {
            get
            {
                return this.cUSTOM_PHYSICALField;
            }
            set
            {
                this.cUSTOM_PHYSICALField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEBLUETOOTH_MANAGER
    {

        private bool dISCOVERABLEField;

        private object pAIRED_DEVICESField;

        private bool bEACON_BROADCASTINGField;

        private byte bEACON_FREQUENCYField;

        private string bEACON_UUIDField;

        private object bEACON_DATAField;

        private bool tETHERField;

        private bool tETHERED_MACField;

        /// <remarks/>
        public bool DISCOVERABLE
        {
            get
            {
                return this.dISCOVERABLEField;
            }
            set
            {
                this.dISCOVERABLEField = value;
            }
        }

        /// <remarks/>
        public object PAIRED_DEVICES
        {
            get
            {
                return this.pAIRED_DEVICESField;
            }
            set
            {
                this.pAIRED_DEVICESField = value;
            }
        }

        /// <remarks/>
        public bool BEACON_BROADCASTING
        {
            get
            {
                return this.bEACON_BROADCASTINGField;
            }
            set
            {
                this.bEACON_BROADCASTINGField = value;
            }
        }

        /// <remarks/>
        public byte BEACON_FREQUENCY
        {
            get
            {
                return this.bEACON_FREQUENCYField;
            }
            set
            {
                this.bEACON_FREQUENCYField = value;
            }
        }

        /// <remarks/>
        public string BEACON_UUID
        {
            get
            {
                return this.bEACON_UUIDField;
            }
            set
            {
                this.bEACON_UUIDField = value;
            }
        }

        /// <remarks/>
        public object BEACON_DATA
        {
            get
            {
                return this.bEACON_DATAField;
            }
            set
            {
                this.bEACON_DATAField = value;
            }
        }

        /// <remarks/>
        public bool TETHER
        {
            get
            {
                return this.tETHERField;
            }
            set
            {
                this.tETHERField = value;
            }
        }

        /// <remarks/>
        public bool TETHERED_MAC
        {
            get
            {
                return this.tETHERED_MACField;
            }
            set
            {
                this.tETHERED_MACField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDOT1X_SETTINGS
    {

        private object pORTSField;

        /// <remarks/>
        public object PORTS
        {
            get
            {
                return this.pORTSField;
            }
            set
            {
                this.pORTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVLAN
    {

        private ushort numberField;

        private byte rspanField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rspan
        {
            get
            {
                return this.rspanField;
            }
            set
            {
                this.rspanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEVTP
    {

        private object dOMAIN_NAMEField;

        private byte mODEField;

        private byte vERSIONField;

        private object pASSWORDField;

        private byte cONFIG_REVISIONField;

        private string uPDATER_IPField;

        private string uPDATE_TIMESTAMPField;

        /// <remarks/>
        public object DOMAIN_NAME
        {
            get
            {
                return this.dOMAIN_NAMEField;
            }
            set
            {
                this.dOMAIN_NAMEField = value;
            }
        }

        /// <remarks/>
        public byte MODE
        {
            get
            {
                return this.mODEField;
            }
            set
            {
                this.mODEField = value;
            }
        }

        /// <remarks/>
        public byte VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        public object PASSWORD
        {
            get
            {
                return this.pASSWORDField;
            }
            set
            {
                this.pASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte CONFIG_REVISION
        {
            get
            {
                return this.cONFIG_REVISIONField;
            }
            set
            {
                this.cONFIG_REVISIONField = value;
            }
        }

        /// <remarks/>
        public string UPDATER_IP
        {
            get
            {
                return this.uPDATER_IPField;
            }
            set
            {
                this.uPDATER_IPField = value;
            }
        }

        /// <remarks/>
        public string UPDATE_TIMESTAMP
        {
            get
            {
                return this.uPDATE_TIMESTAMPField;
            }
            set
            {
                this.uPDATE_TIMESTAMPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINEDHCP_SNOOPING_BINDING_DB_AGENT
    {

        private object cONFIGURED_FILENAMEField;

        private object tMP_FILENAMEField;

        /// <remarks/>
        public object CONFIGURED_FILENAME
        {
            get
            {
                return this.cONFIGURED_FILENAMEField;
            }
            set
            {
                this.cONFIGURED_FILENAMEField = value;
            }
        }

        /// <remarks/>
        public object TMP_FILENAME
        {
            get
            {
                return this.tMP_FILENAMEField;
            }
            set
            {
                this.tMP_FILENAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESDM
    {

        private byte aCTIVE_TEMPLATEField;

        private byte nEXT_TEMPLATEField;

        /// <remarks/>
        public byte ACTIVE_TEMPLATE
        {
            get
            {
                return this.aCTIVE_TEMPLATEField;
            }
            set
            {
                this.aCTIVE_TEMPLATEField = value;
            }
        }

        /// <remarks/>
        public byte NEXT_TEMPLATE
        {
            get
            {
                return this.nEXT_TEMPLATEField;
            }
            set
            {
                this.nEXT_TEMPLATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESIG_IPSPROCESS
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESIG_IPSPROCESSSIGNATURE sIGNATUREField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESIG_IPSPROCESSSIGNATURE SIGNATURE
        {
            get
            {
                return this.sIGNATUREField;
            }
            set
            {
                this.sIGNATUREField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEENGINESIG_IPSPROCESSSIGNATURE
    {

        private ushort sIG_IDField;

        private byte sUB_IDField;

        private byte rETIREDField;

        private byte eNABLEDField;

        private byte eVENT_ACTIONField;

        /// <remarks/>
        public ushort SIG_ID
        {
            get
            {
                return this.sIG_IDField;
            }
            set
            {
                this.sIG_IDField = value;
            }
        }

        /// <remarks/>
        public byte SUB_ID
        {
            get
            {
                return this.sUB_IDField;
            }
            set
            {
                this.sUB_IDField = value;
            }
        }

        /// <remarks/>
        public byte RETIRED
        {
            get
            {
                return this.rETIREDField;
            }
            set
            {
                this.rETIREDField = value;
            }
        }

        /// <remarks/>
        public byte ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }

        /// <remarks/>
        public byte EVENT_ACTION
        {
            get
            {
                return this.eVENT_ACTIONField;
            }
            set
            {
                this.eVENT_ACTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACELOGICAL lOGICALField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACEPHYSICAL pHYSICALField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACEPHYSICAL_CPUR pHYSICAL_CPURField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACELOGICAL LOGICAL
        {
            get
            {
                return this.lOGICALField;
            }
            set
            {
                this.lOGICALField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACEPHYSICAL PHYSICAL
        {
            get
            {
                return this.pHYSICALField;
            }
            set
            {
                this.pHYSICALField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACEPHYSICAL_CPUR PHYSICAL_CPUR
        {
            get
            {
                return this.pHYSICAL_CPURField;
            }
            set
            {
                this.pHYSICAL_CPURField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACELOGICAL
    {

        private decimal xField;

        private bool xFieldSpecified;

        private ushort yField;

        private bool yFieldSpecified;

        private string dEVCLUSTERIDField;

        private object cUSTOM_IMAGE_LOGICALField;

        private object cUSTOM_IMAGE_PHYSICALField;

        private uint mEM_ADDRField;

        private uint dEV_ADDRField;

        /// <remarks/>
        public decimal X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DEVCLUSTERID
        {
            get
            {
                return this.dEVCLUSTERIDField;
            }
            set
            {
                this.dEVCLUSTERIDField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_IMAGE_LOGICAL
        {
            get
            {
                return this.cUSTOM_IMAGE_LOGICALField;
            }
            set
            {
                this.cUSTOM_IMAGE_LOGICALField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_IMAGE_PHYSICAL
        {
            get
            {
                return this.cUSTOM_IMAGE_PHYSICALField;
            }
            set
            {
                this.cUSTOM_IMAGE_PHYSICALField = value;
            }
        }

        /// <remarks/>
        public uint MEM_ADDR
        {
            get
            {
                return this.mEM_ADDRField;
            }
            set
            {
                this.mEM_ADDRField = value;
            }
        }

        /// <remarks/>
        public uint DEV_ADDR
        {
            get
            {
                return this.dEV_ADDRField;
            }
            set
            {
                this.dEV_ADDRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACEPHYSICAL
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDEVICEWORKSPACEPHYSICAL_CPUR
    {

        private double x_PNField;

        private decimal y_PNField;

        private int xField;

        private byte yField;

        private string pARENT_PATHField;

        /// <remarks/>
        public double X_PN
        {
            get
            {
                return this.x_PNField;
            }
            set
            {
                this.x_PNField = value;
            }
        }

        /// <remarks/>
        public decimal Y_PN
        {
            get
            {
                return this.y_PNField;
            }
            set
            {
                this.y_PNField = value;
            }
        }

        /// <remarks/>
        public int X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public string PARENT_PATH
        {
            get
            {
                return this.pARENT_PATHField;
            }
            set
            {
                this.pARENT_PATHField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKLINK
    {

        private string tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKLINKCABLE cABLEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKLINKCABLE CABLE
        {
            get
            {
                return this.cABLEField;
            }
            set
            {
                this.cABLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKLINKCABLE
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FROM", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FROM_DEVICE_MEM_ADDR", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("FROM_PORT_MEM_ADDR", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("FUNCTIONAL", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("GEO_VIEW_COLOR", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LENGTH", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("PORT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TO", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TO_DEVICE_MEM_ADDR", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("TO_PORT_MEM_ADDR", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("TYPE", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        FROM,

        /// <remarks/>
        FROM_DEVICE_MEM_ADDR,

        /// <remarks/>
        FROM_PORT_MEM_ADDR,

        /// <remarks/>
        FUNCTIONAL,

        /// <remarks/>
        GEO_VIEW_COLOR,

        /// <remarks/>
        LENGTH,

        /// <remarks/>
        PORT,

        /// <remarks/>
        TO,

        /// <remarks/>
        TO_DEVICE_MEM_ADDR,

        /// <remarks/>
        TO_PORT_MEM_ADDR,

        /// <remarks/>
        TYPE,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5NETWORKDESCRIPTION
    {

        private bool translateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSET
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIO sCENARIOField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIO SCENARIO
        {
            get
            {
                return this.sCENARIOField;
            }
            set
            {
                this.sCENARIOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIO
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIONAME nAMEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIODESCRIPTION dESCRIPTIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDU[] pDUField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIONAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIODESCRIPTION DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PDU")]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDU[] PDU
        {
            get
            {
                return this.pDUField;
            }
            set
            {
                this.pDUField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIONAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIODESCRIPTION
    {

        private bool translateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDU
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUTYPE tYPEField;

        private object cUSTOM_TYPEField;

        private string sOURCEField;

        private object pORTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUDESTINATION dESTINATIONField;

        private int cOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUPDU pDUField;

        private byte tEST_CONDITIONField;

        private byte pOINTSField;

        private byte pDU_SIZEField;

        private ushort sTARTField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUTYPE TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_TYPE
        {
            get
            {
                return this.cUSTOM_TYPEField;
            }
            set
            {
                this.cUSTOM_TYPEField = value;
            }
        }

        /// <remarks/>
        public string SOURCE
        {
            get
            {
                return this.sOURCEField;
            }
            set
            {
                this.sOURCEField = value;
            }
        }

        /// <remarks/>
        public object PORT
        {
            get
            {
                return this.pORTField;
            }
            set
            {
                this.pORTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUDESTINATION DESTINATION
        {
            get
            {
                return this.dESTINATIONField;
            }
            set
            {
                this.dESTINATIONField = value;
            }
        }

        /// <remarks/>
        public int COLOR
        {
            get
            {
                return this.cOLORField;
            }
            set
            {
                this.cOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUPDU PDU
        {
            get
            {
                return this.pDUField;
            }
            set
            {
                this.pDUField = value;
            }
        }

        /// <remarks/>
        public byte TEST_CONDITION
        {
            get
            {
                return this.tEST_CONDITIONField;
            }
            set
            {
                this.tEST_CONDITIONField = value;
            }
        }

        /// <remarks/>
        public byte POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        public byte PDU_SIZE
        {
            get
            {
                return this.pDU_SIZEField;
            }
            set
            {
                this.pDU_SIZEField = value;
            }
        }

        /// <remarks/>
        public ushort START
        {
            get
            {
                return this.sTARTField;
            }
            set
            {
                this.sTARTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUTYPE
    {

        private string patternedField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string patterned
        {
            get
            {
                return this.patternedField;
            }
            set
            {
                this.patternedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUDESTINATION
    {

        private string deviceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string device
        {
            get
            {
                return this.deviceField;
            }
            set
            {
                this.deviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUPDU
    {

        private string tYPEField;

        private string sRCADDRField;

        private string dSTADDRField;

        private object pROTOCOLField;

        private byte tTLField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUPDUPDU pDUField;

        private byte tOSField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string SRCADDR
        {
            get
            {
                return this.sRCADDRField;
            }
            set
            {
                this.sRCADDRField = value;
            }
        }

        /// <remarks/>
        public string DSTADDR
        {
            get
            {
                return this.dSTADDRField;
            }
            set
            {
                this.dSTADDRField = value;
            }
        }

        /// <remarks/>
        public object PROTOCOL
        {
            get
            {
                return this.pROTOCOLField;
            }
            set
            {
                this.pROTOCOLField = value;
            }
        }

        /// <remarks/>
        public byte TTL
        {
            get
            {
                return this.tTLField;
            }
            set
            {
                this.tTLField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUPDUPDU PDU
        {
            get
            {
                return this.pDUField;
            }
            set
            {
                this.pDUField = value;
            }
        }

        /// <remarks/>
        public byte TOS
        {
            get
            {
                return this.tOSField;
            }
            set
            {
                this.tOSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCENARIOSETSCENARIOPDUPDUPDU
    {

        private string tYPEField;

        private ushort sRCField;

        private bool sRCFieldSpecified;

        private byte dSTField;

        private bool dSTFieldSpecified;

        private byte iCMPTYPEField;

        private bool iCMPTYPEFieldSpecified;

        private byte cODEField;

        private bool cODEFieldSpecified;

        private byte idField;

        private bool idFieldSpecified;

        private ushort sEQField;

        private bool sEQFieldSpecified;

        private byte cHKField;

        private byte lENGTHField;

        private bool lENGTHFieldSpecified;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public ushort SRC
        {
            get
            {
                return this.sRCField;
            }
            set
            {
                this.sRCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SRCSpecified
        {
            get
            {
                return this.sRCFieldSpecified;
            }
            set
            {
                this.sRCFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte DST
        {
            get
            {
                return this.dSTField;
            }
            set
            {
                this.dSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSTSpecified
        {
            get
            {
                return this.dSTFieldSpecified;
            }
            set
            {
                this.dSTFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte ICMPTYPE
        {
            get
            {
                return this.iCMPTYPEField;
            }
            set
            {
                this.iCMPTYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ICMPTYPESpecified
        {
            get
            {
                return this.iCMPTYPEFieldSpecified;
            }
            set
            {
                this.iCMPTYPEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte CODE
        {
            get
            {
                return this.cODEField;
            }
            set
            {
                this.cODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CODESpecified
        {
            get
            {
                return this.cODEFieldSpecified;
            }
            set
            {
                this.cODEFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort SEQ
        {
            get
            {
                return this.sEQField;
            }
            set
            {
                this.sEQField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SEQSpecified
        {
            get
            {
                return this.sEQFieldSpecified;
            }
            set
            {
                this.sEQFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte CHK
        {
            get
            {
                return this.cHKField;
            }
            set
            {
                this.cHKField = value;
            }
        }

        /// <remarks/>
        public byte LENGTH
        {
            get
            {
                return this.lENGTHField;
            }
            set
            {
                this.lENGTHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LENGTHSpecified
        {
            get
            {
                return this.lENGTHFieldSpecified;
            }
            set
            {
                this.lENGTHFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONS
    {

        private string lANGUAGEField;

        private bool aNIMATIONField;

        private bool lOGICALALIGNField;

        private bool pHYSICALALIGNField;

        private bool sOUNDField;

        private bool tELEPHONESOUNDField;

        private bool dOCKField;

        private bool lOGGINGField;

        private object pASSField;

        private string cONFIGPATHField;

        private bool mODELSHOWNField;

        private bool lINKLIGHTSSHOWNField;

        private bool pORTSHOWNField;

        private object bACKGROUNDSField;

        private bool hIDEPHYSICALField;

        private bool hIDEATTRIBUTESField;

        private bool hIDECONFIGField;

        private bool hIDECONFIGOFROUTERANDSWITCHField;

        private bool hIDECLIOFROUTERANDSWITCHField;

        private bool hIDESERVICESField;

        private bool hIDECLIField;

        private bool hIDEDESKTOPField;

        private bool hIDEGUIField;

        private bool hIDEDEVICELABELField;

        private bool bUFFER_FILTERED_EVENTS_ONLYField;

        private bool aCCESSIBLEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLOR cOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONT fONTField;

        private byte bUFFER_FULL_ACTIONField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSMULTIUSER mULTIUSERField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSIPC_MANAGER iPC_MANAGERField;

        private bool iPC_ALLOWREMOTEAPPSField;

        private string[] rECENT_FILESField;

        private bool pORTNOTSHOWNONMOUSEOVERField;

        private string iNTERFACE_LOCKField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSALGORITHM_SETTINGS aLGORITHM_SETTINGSField;

        private bool hIDEQOSSTAMPField;

        private bool iPCLISTENSTARTUPField;

        private bool eNABLE_CABLE_LENGTH_EFFECTSField;

        private bool dISABLE_AUTO_CABLEField;

        private bool uSE_METRICField;

        private bool sHOW_DEV_TASKBARField;

        private bool eNABLE_EXTERNAL_NETWORK_ACCESSField;

        private bool sHOW_WIRELESS_GRIDField;

        private bool fILL_WIRELESS_GRIDField;

        private bool hIDE_WIRELESS_COVERAGE_RANGEField;

        private bool sHOW_BOTTOM_TOOLBARField;

        private bool sHOW_RIGHT_TOOLBARField;

        private bool sHOW_MAIN_TOOLBARField;

        private bool sHOW_DEV_MODEL_LABELField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGER sCRIPT_MODULE_MANAGERField;

        private bool uSE_CLI_DEFAULT_TABField;

        private object nEW_DEVICE_CUSTOM_INTERFACESField;

        private object cUSTOM_HIDE_OPTIONSField;

        private bool hIDE_WIRELESS_CONNECTIONField;

        private bool hIDE_LEGACY_EQUIPMENTField;

        private bool tHING_ADVANCED_MODE_DEFAULTField;

        private bool cABLE_POPUP_IN_PHYSICALField;

        private byte gUEST_SAVES_COUNTField;

        private byte aUTOSAVE_INTERVALField;

        private byte aNSWER_TREE_SELECTEDField;

        private uint lAST_LOGON_TIMEField;

        private object aNSWER_TREE_CHECK_BOXField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGER uSER_APP_MANAGERField;

        private string cOLORSCHEMEField;

        /// <remarks/>
        public string LANGUAGE
        {
            get
            {
                return this.lANGUAGEField;
            }
            set
            {
                this.lANGUAGEField = value;
            }
        }

        /// <remarks/>
        public bool ANIMATION
        {
            get
            {
                return this.aNIMATIONField;
            }
            set
            {
                this.aNIMATIONField = value;
            }
        }

        /// <remarks/>
        public bool LOGICALALIGN
        {
            get
            {
                return this.lOGICALALIGNField;
            }
            set
            {
                this.lOGICALALIGNField = value;
            }
        }

        /// <remarks/>
        public bool PHYSICALALIGN
        {
            get
            {
                return this.pHYSICALALIGNField;
            }
            set
            {
                this.pHYSICALALIGNField = value;
            }
        }

        /// <remarks/>
        public bool SOUND
        {
            get
            {
                return this.sOUNDField;
            }
            set
            {
                this.sOUNDField = value;
            }
        }

        /// <remarks/>
        public bool TELEPHONESOUND
        {
            get
            {
                return this.tELEPHONESOUNDField;
            }
            set
            {
                this.tELEPHONESOUNDField = value;
            }
        }

        /// <remarks/>
        public bool DOCK
        {
            get
            {
                return this.dOCKField;
            }
            set
            {
                this.dOCKField = value;
            }
        }

        /// <remarks/>
        public bool LOGGING
        {
            get
            {
                return this.lOGGINGField;
            }
            set
            {
                this.lOGGINGField = value;
            }
        }

        /// <remarks/>
        public object PASS
        {
            get
            {
                return this.pASSField;
            }
            set
            {
                this.pASSField = value;
            }
        }

        /// <remarks/>
        public string CONFIGPATH
        {
            get
            {
                return this.cONFIGPATHField;
            }
            set
            {
                this.cONFIGPATHField = value;
            }
        }

        /// <remarks/>
        public bool MODELSHOWN
        {
            get
            {
                return this.mODELSHOWNField;
            }
            set
            {
                this.mODELSHOWNField = value;
            }
        }

        /// <remarks/>
        public bool LINKLIGHTSSHOWN
        {
            get
            {
                return this.lINKLIGHTSSHOWNField;
            }
            set
            {
                this.lINKLIGHTSSHOWNField = value;
            }
        }

        /// <remarks/>
        public bool PORTSHOWN
        {
            get
            {
                return this.pORTSHOWNField;
            }
            set
            {
                this.pORTSHOWNField = value;
            }
        }

        /// <remarks/>
        public object BACKGROUNDS
        {
            get
            {
                return this.bACKGROUNDSField;
            }
            set
            {
                this.bACKGROUNDSField = value;
            }
        }

        /// <remarks/>
        public bool HIDEPHYSICAL
        {
            get
            {
                return this.hIDEPHYSICALField;
            }
            set
            {
                this.hIDEPHYSICALField = value;
            }
        }

        /// <remarks/>
        public bool HIDEATTRIBUTES
        {
            get
            {
                return this.hIDEATTRIBUTESField;
            }
            set
            {
                this.hIDEATTRIBUTESField = value;
            }
        }

        /// <remarks/>
        public bool HIDECONFIG
        {
            get
            {
                return this.hIDECONFIGField;
            }
            set
            {
                this.hIDECONFIGField = value;
            }
        }

        /// <remarks/>
        public bool HIDECONFIGOFROUTERANDSWITCH
        {
            get
            {
                return this.hIDECONFIGOFROUTERANDSWITCHField;
            }
            set
            {
                this.hIDECONFIGOFROUTERANDSWITCHField = value;
            }
        }

        /// <remarks/>
        public bool HIDECLIOFROUTERANDSWITCH
        {
            get
            {
                return this.hIDECLIOFROUTERANDSWITCHField;
            }
            set
            {
                this.hIDECLIOFROUTERANDSWITCHField = value;
            }
        }

        /// <remarks/>
        public bool HIDESERVICES
        {
            get
            {
                return this.hIDESERVICESField;
            }
            set
            {
                this.hIDESERVICESField = value;
            }
        }

        /// <remarks/>
        public bool HIDECLI
        {
            get
            {
                return this.hIDECLIField;
            }
            set
            {
                this.hIDECLIField = value;
            }
        }

        /// <remarks/>
        public bool HIDEDESKTOP
        {
            get
            {
                return this.hIDEDESKTOPField;
            }
            set
            {
                this.hIDEDESKTOPField = value;
            }
        }

        /// <remarks/>
        public bool HIDEGUI
        {
            get
            {
                return this.hIDEGUIField;
            }
            set
            {
                this.hIDEGUIField = value;
            }
        }

        /// <remarks/>
        public bool HIDEDEVICELABEL
        {
            get
            {
                return this.hIDEDEVICELABELField;
            }
            set
            {
                this.hIDEDEVICELABELField = value;
            }
        }

        /// <remarks/>
        public bool BUFFER_FILTERED_EVENTS_ONLY
        {
            get
            {
                return this.bUFFER_FILTERED_EVENTS_ONLYField;
            }
            set
            {
                this.bUFFER_FILTERED_EVENTS_ONLYField = value;
            }
        }

        /// <remarks/>
        public bool ACCESSIBLE
        {
            get
            {
                return this.aCCESSIBLEField;
            }
            set
            {
                this.aCCESSIBLEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLOR COLOR
        {
            get
            {
                return this.cOLORField;
            }
            set
            {
                this.cOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONT FONT
        {
            get
            {
                return this.fONTField;
            }
            set
            {
                this.fONTField = value;
            }
        }

        /// <remarks/>
        public byte BUFFER_FULL_ACTION
        {
            get
            {
                return this.bUFFER_FULL_ACTIONField;
            }
            set
            {
                this.bUFFER_FULL_ACTIONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSMULTIUSER MULTIUSER
        {
            get
            {
                return this.mULTIUSERField;
            }
            set
            {
                this.mULTIUSERField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSIPC_MANAGER IPC_MANAGER
        {
            get
            {
                return this.iPC_MANAGERField;
            }
            set
            {
                this.iPC_MANAGERField = value;
            }
        }

        /// <remarks/>
        public bool IPC_ALLOWREMOTEAPPS
        {
            get
            {
                return this.iPC_ALLOWREMOTEAPPSField;
            }
            set
            {
                this.iPC_ALLOWREMOTEAPPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FILE", IsNullable = false)]
        public string[] RECENT_FILES
        {
            get
            {
                return this.rECENT_FILESField;
            }
            set
            {
                this.rECENT_FILESField = value;
            }
        }

        /// <remarks/>
        public bool PORTNOTSHOWNONMOUSEOVER
        {
            get
            {
                return this.pORTNOTSHOWNONMOUSEOVERField;
            }
            set
            {
                this.pORTNOTSHOWNONMOUSEOVERField = value;
            }
        }

        /// <remarks/>
        public string INTERFACE_LOCK
        {
            get
            {
                return this.iNTERFACE_LOCKField;
            }
            set
            {
                this.iNTERFACE_LOCKField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSALGORITHM_SETTINGS ALGORITHM_SETTINGS
        {
            get
            {
                return this.aLGORITHM_SETTINGSField;
            }
            set
            {
                this.aLGORITHM_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public bool HIDEQOSSTAMP
        {
            get
            {
                return this.hIDEQOSSTAMPField;
            }
            set
            {
                this.hIDEQOSSTAMPField = value;
            }
        }

        /// <remarks/>
        public bool IPCLISTENSTARTUP
        {
            get
            {
                return this.iPCLISTENSTARTUPField;
            }
            set
            {
                this.iPCLISTENSTARTUPField = value;
            }
        }

        /// <remarks/>
        public bool ENABLE_CABLE_LENGTH_EFFECTS
        {
            get
            {
                return this.eNABLE_CABLE_LENGTH_EFFECTSField;
            }
            set
            {
                this.eNABLE_CABLE_LENGTH_EFFECTSField = value;
            }
        }

        /// <remarks/>
        public bool DISABLE_AUTO_CABLE
        {
            get
            {
                return this.dISABLE_AUTO_CABLEField;
            }
            set
            {
                this.dISABLE_AUTO_CABLEField = value;
            }
        }

        /// <remarks/>
        public bool USE_METRIC
        {
            get
            {
                return this.uSE_METRICField;
            }
            set
            {
                this.uSE_METRICField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_DEV_TASKBAR
        {
            get
            {
                return this.sHOW_DEV_TASKBARField;
            }
            set
            {
                this.sHOW_DEV_TASKBARField = value;
            }
        }

        /// <remarks/>
        public bool ENABLE_EXTERNAL_NETWORK_ACCESS
        {
            get
            {
                return this.eNABLE_EXTERNAL_NETWORK_ACCESSField;
            }
            set
            {
                this.eNABLE_EXTERNAL_NETWORK_ACCESSField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_WIRELESS_GRID
        {
            get
            {
                return this.sHOW_WIRELESS_GRIDField;
            }
            set
            {
                this.sHOW_WIRELESS_GRIDField = value;
            }
        }

        /// <remarks/>
        public bool FILL_WIRELESS_GRID
        {
            get
            {
                return this.fILL_WIRELESS_GRIDField;
            }
            set
            {
                this.fILL_WIRELESS_GRIDField = value;
            }
        }

        /// <remarks/>
        public bool HIDE_WIRELESS_COVERAGE_RANGE
        {
            get
            {
                return this.hIDE_WIRELESS_COVERAGE_RANGEField;
            }
            set
            {
                this.hIDE_WIRELESS_COVERAGE_RANGEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_BOTTOM_TOOLBAR
        {
            get
            {
                return this.sHOW_BOTTOM_TOOLBARField;
            }
            set
            {
                this.sHOW_BOTTOM_TOOLBARField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_RIGHT_TOOLBAR
        {
            get
            {
                return this.sHOW_RIGHT_TOOLBARField;
            }
            set
            {
                this.sHOW_RIGHT_TOOLBARField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_MAIN_TOOLBAR
        {
            get
            {
                return this.sHOW_MAIN_TOOLBARField;
            }
            set
            {
                this.sHOW_MAIN_TOOLBARField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_DEV_MODEL_LABEL
        {
            get
            {
                return this.sHOW_DEV_MODEL_LABELField;
            }
            set
            {
                this.sHOW_DEV_MODEL_LABELField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGER SCRIPT_MODULE_MANAGER
        {
            get
            {
                return this.sCRIPT_MODULE_MANAGERField;
            }
            set
            {
                this.sCRIPT_MODULE_MANAGERField = value;
            }
        }

        /// <remarks/>
        public bool USE_CLI_DEFAULT_TAB
        {
            get
            {
                return this.uSE_CLI_DEFAULT_TABField;
            }
            set
            {
                this.uSE_CLI_DEFAULT_TABField = value;
            }
        }

        /// <remarks/>
        public object NEW_DEVICE_CUSTOM_INTERFACES
        {
            get
            {
                return this.nEW_DEVICE_CUSTOM_INTERFACESField;
            }
            set
            {
                this.nEW_DEVICE_CUSTOM_INTERFACESField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_HIDE_OPTIONS
        {
            get
            {
                return this.cUSTOM_HIDE_OPTIONSField;
            }
            set
            {
                this.cUSTOM_HIDE_OPTIONSField = value;
            }
        }

        /// <remarks/>
        public bool HIDE_WIRELESS_CONNECTION
        {
            get
            {
                return this.hIDE_WIRELESS_CONNECTIONField;
            }
            set
            {
                this.hIDE_WIRELESS_CONNECTIONField = value;
            }
        }

        /// <remarks/>
        public bool HIDE_LEGACY_EQUIPMENT
        {
            get
            {
                return this.hIDE_LEGACY_EQUIPMENTField;
            }
            set
            {
                this.hIDE_LEGACY_EQUIPMENTField = value;
            }
        }

        /// <remarks/>
        public bool THING_ADVANCED_MODE_DEFAULT
        {
            get
            {
                return this.tHING_ADVANCED_MODE_DEFAULTField;
            }
            set
            {
                this.tHING_ADVANCED_MODE_DEFAULTField = value;
            }
        }

        /// <remarks/>
        public bool CABLE_POPUP_IN_PHYSICAL
        {
            get
            {
                return this.cABLE_POPUP_IN_PHYSICALField;
            }
            set
            {
                this.cABLE_POPUP_IN_PHYSICALField = value;
            }
        }

        /// <remarks/>
        public byte GUEST_SAVES_COUNT
        {
            get
            {
                return this.gUEST_SAVES_COUNTField;
            }
            set
            {
                this.gUEST_SAVES_COUNTField = value;
            }
        }

        /// <remarks/>
        public byte AUTOSAVE_INTERVAL
        {
            get
            {
                return this.aUTOSAVE_INTERVALField;
            }
            set
            {
                this.aUTOSAVE_INTERVALField = value;
            }
        }

        /// <remarks/>
        public byte ANSWER_TREE_SELECTED
        {
            get
            {
                return this.aNSWER_TREE_SELECTEDField;
            }
            set
            {
                this.aNSWER_TREE_SELECTEDField = value;
            }
        }

        /// <remarks/>
        public uint LAST_LOGON_TIME
        {
            get
            {
                return this.lAST_LOGON_TIMEField;
            }
            set
            {
                this.lAST_LOGON_TIMEField = value;
            }
        }

        /// <remarks/>
        public object ANSWER_TREE_CHECK_BOX
        {
            get
            {
                return this.aNSWER_TREE_CHECK_BOXField;
            }
            set
            {
                this.aNSWER_TREE_CHECK_BOXField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGER USER_APP_MANAGER
        {
            get
            {
                return this.uSER_APP_MANAGERField;
            }
            set
            {
                this.uSER_APP_MANAGERField = value;
            }
        }

        /// <remarks/>
        public string COLORSCHEME
        {
            get
            {
                return this.cOLORSCHEMEField;
            }
            set
            {
                this.cOLORSCHEMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLOR
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORIOSTEXTCOLOR iOSTEXTCOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORIOSBACKGROUNDCOLOR iOSBACKGROUNDCOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORCONSOLETEXTCOLOR cONSOLETEXTCOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORCONSOLEBACKGROUNDCOLOR cONSOLEBACKGROUNDCOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORTOOLTIPBACKGROUNDCOLOR tOOLTIPBACKGROUNDCOLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORTOOLTIPTEXTCOLOR tOOLTIPTEXTCOLORField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORIOSTEXTCOLOR IOSTEXTCOLOR
        {
            get
            {
                return this.iOSTEXTCOLORField;
            }
            set
            {
                this.iOSTEXTCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORIOSBACKGROUNDCOLOR IOSBACKGROUNDCOLOR
        {
            get
            {
                return this.iOSBACKGROUNDCOLORField;
            }
            set
            {
                this.iOSBACKGROUNDCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORCONSOLETEXTCOLOR CONSOLETEXTCOLOR
        {
            get
            {
                return this.cONSOLETEXTCOLORField;
            }
            set
            {
                this.cONSOLETEXTCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORCONSOLEBACKGROUNDCOLOR CONSOLEBACKGROUNDCOLOR
        {
            get
            {
                return this.cONSOLEBACKGROUNDCOLORField;
            }
            set
            {
                this.cONSOLEBACKGROUNDCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORTOOLTIPBACKGROUNDCOLOR TOOLTIPBACKGROUNDCOLOR
        {
            get
            {
                return this.tOOLTIPBACKGROUNDCOLORField;
            }
            set
            {
                this.tOOLTIPBACKGROUNDCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORTOOLTIPTEXTCOLOR TOOLTIPTEXTCOLOR
        {
            get
            {
                return this.tOOLTIPTEXTCOLORField;
            }
            set
            {
                this.tOOLTIPTEXTCOLORField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORIOSTEXTCOLOR
    {

        private string iosTextColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string iosTextColor
        {
            get
            {
                return this.iosTextColorField;
            }
            set
            {
                this.iosTextColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORIOSBACKGROUNDCOLOR
    {

        private string iosBackgroundColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string iosBackgroundColor
        {
            get
            {
                return this.iosBackgroundColorField;
            }
            set
            {
                this.iosBackgroundColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORCONSOLETEXTCOLOR
    {

        private string consoleTextColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string consoleTextColor
        {
            get
            {
                return this.consoleTextColorField;
            }
            set
            {
                this.consoleTextColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORCONSOLEBACKGROUNDCOLOR
    {

        private string consoleBackgroundColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string consoleBackgroundColor
        {
            get
            {
                return this.consoleBackgroundColorField;
            }
            set
            {
                this.consoleBackgroundColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORTOOLTIPBACKGROUNDCOLOR
    {

        private string tooltipBackgroundColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tooltipBackgroundColor
        {
            get
            {
                return this.tooltipBackgroundColorField;
            }
            set
            {
                this.tooltipBackgroundColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSCOLORTOOLTIPTEXTCOLOR
    {

        private string tooltipTextColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tooltipTextColor
        {
            get
            {
                return this.tooltipTextColorField;
            }
            set
            {
                this.tooltipTextColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONT
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTCLIFONT cLIFONTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTHEADERFONT hEADERFONTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTWORKSPACEFONT wORKSPACEFONTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTACTIVITYFONT aCTIVITYFONTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTFILEMENUFONT fILEMENUFONTField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTTABSWITCH tABSWITCHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTTOOLTIP tOOLTIPField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTBUTTONLABELS bUTTONLABELSField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTAPPLICATION aPPLICATIONField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTCLIFONT CLIFONT
        {
            get
            {
                return this.cLIFONTField;
            }
            set
            {
                this.cLIFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTHEADERFONT HEADERFONT
        {
            get
            {
                return this.hEADERFONTField;
            }
            set
            {
                this.hEADERFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTWORKSPACEFONT WORKSPACEFONT
        {
            get
            {
                return this.wORKSPACEFONTField;
            }
            set
            {
                this.wORKSPACEFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTACTIVITYFONT ACTIVITYFONT
        {
            get
            {
                return this.aCTIVITYFONTField;
            }
            set
            {
                this.aCTIVITYFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTFILEMENUFONT FILEMENUFONT
        {
            get
            {
                return this.fILEMENUFONTField;
            }
            set
            {
                this.fILEMENUFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTTABSWITCH TABSWITCH
        {
            get
            {
                return this.tABSWITCHField;
            }
            set
            {
                this.tABSWITCHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTTOOLTIP TOOLTIP
        {
            get
            {
                return this.tOOLTIPField;
            }
            set
            {
                this.tOOLTIPField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTBUTTONLABELS BUTTONLABELS
        {
            get
            {
                return this.bUTTONLABELSField;
            }
            set
            {
                this.bUTTONLABELSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTAPPLICATION APPLICATION
        {
            get
            {
                return this.aPPLICATIONField;
            }
            set
            {
                this.aPPLICATIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTCLIFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTHEADERFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTWORKSPACEFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTACTIVITYFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTFILEMENUFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTTABSWITCH
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTTOOLTIP
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTBUTTONLABELS
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSFONTAPPLICATION
    {

        private byte scaleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSMULTIUSER
    {

        private object nAMEField;

        private bool aLLOWREMOTESAVINGField;

        private bool aLWAYSLISTENATSTARTUPField;

        private bool sHOW_CONNECTED_PORT_NAMESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSMULTIUSERMU_PEERS mU_PEERSField;

        private byte rEMOTE_SAVING_DEPTHField;

        private string mU_PASSWORDField;

        private byte mU_ACCEPT_MODEField;

        private byte mU_NEW_RNET_ACCEPT_MODEField;

        private bool mU_ALLOW_PTMP_BROADCASTField;

        /// <remarks/>
        public object NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public bool ALLOWREMOTESAVING
        {
            get
            {
                return this.aLLOWREMOTESAVINGField;
            }
            set
            {
                this.aLLOWREMOTESAVINGField = value;
            }
        }

        /// <remarks/>
        public bool ALWAYSLISTENATSTARTUP
        {
            get
            {
                return this.aLWAYSLISTENATSTARTUPField;
            }
            set
            {
                this.aLWAYSLISTENATSTARTUPField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_CONNECTED_PORT_NAMES
        {
            get
            {
                return this.sHOW_CONNECTED_PORT_NAMESField;
            }
            set
            {
                this.sHOW_CONNECTED_PORT_NAMESField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSMULTIUSERMU_PEERS MU_PEERS
        {
            get
            {
                return this.mU_PEERSField;
            }
            set
            {
                this.mU_PEERSField = value;
            }
        }

        /// <remarks/>
        public byte REMOTE_SAVING_DEPTH
        {
            get
            {
                return this.rEMOTE_SAVING_DEPTHField;
            }
            set
            {
                this.rEMOTE_SAVING_DEPTHField = value;
            }
        }

        /// <remarks/>
        public string MU_PASSWORD
        {
            get
            {
                return this.mU_PASSWORDField;
            }
            set
            {
                this.mU_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte MU_ACCEPT_MODE
        {
            get
            {
                return this.mU_ACCEPT_MODEField;
            }
            set
            {
                this.mU_ACCEPT_MODEField = value;
            }
        }

        /// <remarks/>
        public byte MU_NEW_RNET_ACCEPT_MODE
        {
            get
            {
                return this.mU_NEW_RNET_ACCEPT_MODEField;
            }
            set
            {
                this.mU_NEW_RNET_ACCEPT_MODEField = value;
            }
        }

        /// <remarks/>
        public bool MU_ALLOW_PTMP_BROADCAST
        {
            get
            {
                return this.mU_ALLOW_PTMP_BROADCASTField;
            }
            set
            {
                this.mU_ALLOW_PTMP_BROADCASTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSMULTIUSERMU_PEERS
    {

        private string pEERField;

        /// <remarks/>
        public string PEER
        {
            get
            {
                return this.pEERField;
            }
            set
            {
                this.pEERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSIPC_MANAGER
    {

        private string[] mETAFILE_PATHField;

        private object dISABLED_CEPSField;

        private string[] tRUSTED_PUBLISHERSField;

        private object uNTRUSTED_PUBLISHERSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("METAFILE_PATH")]
        public string[] METAFILE_PATH
        {
            get
            {
                return this.mETAFILE_PATHField;
            }
            set
            {
                this.mETAFILE_PATHField = value;
            }
        }

        /// <remarks/>
        public object DISABLED_CEPS
        {
            get
            {
                return this.dISABLED_CEPSField;
            }
            set
            {
                this.dISABLED_CEPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CERTIFICATE", IsNullable = false)]
        public string[] TRUSTED_PUBLISHERS
        {
            get
            {
                return this.tRUSTED_PUBLISHERSField;
            }
            set
            {
                this.tRUSTED_PUBLISHERSField = value;
            }
        }

        /// <remarks/>
        public object UNTRUSTED_PUBLISHERS
        {
            get
            {
                return this.uNTRUSTED_PUBLISHERSField;
            }
            set
            {
                this.uNTRUSTED_PUBLISHERSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSALGORITHM_SETTINGS
    {

        private bool uSE_GLOBALField;

        private byte cBAC_HALF_OPEN_SESSION_MULTIPLIERField;

        private byte tCP_MAX_CONNECTING_SESSIONSField;

        private ushort tCP_MAX_OPENED_SESSIONSField;

        private byte iNTERFACE_QUEUE_SIZEField;

        private byte sTORM_CONTROL_MULTIPLIERField;

        private ushort tCP_MAX_RETRANSMISSION_TIMEOUTField;

        /// <remarks/>
        public bool USE_GLOBAL
        {
            get
            {
                return this.uSE_GLOBALField;
            }
            set
            {
                this.uSE_GLOBALField = value;
            }
        }

        /// <remarks/>
        public byte CBAC_HALF_OPEN_SESSION_MULTIPLIER
        {
            get
            {
                return this.cBAC_HALF_OPEN_SESSION_MULTIPLIERField;
            }
            set
            {
                this.cBAC_HALF_OPEN_SESSION_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte TCP_MAX_CONNECTING_SESSIONS
        {
            get
            {
                return this.tCP_MAX_CONNECTING_SESSIONSField;
            }
            set
            {
                this.tCP_MAX_CONNECTING_SESSIONSField = value;
            }
        }

        /// <remarks/>
        public ushort TCP_MAX_OPENED_SESSIONS
        {
            get
            {
                return this.tCP_MAX_OPENED_SESSIONSField;
            }
            set
            {
                this.tCP_MAX_OPENED_SESSIONSField = value;
            }
        }

        /// <remarks/>
        public byte INTERFACE_QUEUE_SIZE
        {
            get
            {
                return this.iNTERFACE_QUEUE_SIZEField;
            }
            set
            {
                this.iNTERFACE_QUEUE_SIZEField = value;
            }
        }

        /// <remarks/>
        public byte STORM_CONTROL_MULTIPLIER
        {
            get
            {
                return this.sTORM_CONTROL_MULTIPLIERField;
            }
            set
            {
                this.sTORM_CONTROL_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public ushort TCP_MAX_RETRANSMISSION_TIMEOUT
        {
            get
            {
                return this.tCP_MAX_RETRANSMISSION_TIMEOUTField;
            }
            set
            {
                this.tCP_MAX_RETRANSMISSION_TIMEOUTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGER
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULE[] sCRIPT_MODULESField;

        private object dISABLED_SCRIPT_MODULESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SCRIPT_MODULE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULE[] SCRIPT_MODULES
        {
            get
            {
                return this.sCRIPT_MODULESField;
            }
            set
            {
                this.sCRIPT_MODULESField = value;
            }
        }

        /// <remarks/>
        public object DISABLED_SCRIPT_MODULES
        {
            get
            {
                return this.dISABLED_SCRIPT_MODULESField;
            }
            set
            {
                this.dISABLED_SCRIPT_MODULESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULE
    {

        private string fILE_PATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATA sCRIPT_MODULE_DATAField;

        /// <remarks/>
        public string FILE_PATH
        {
            get
            {
                return this.fILE_PATHField;
            }
            set
            {
                this.fILE_PATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATA SCRIPT_MODULE_DATA
        {
            get
            {
                return this.sCRIPT_MODULE_DATAField;
            }
            set
            {
                this.sCRIPT_MODULE_DATAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATA
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATADATA_STORE[] sCRIPT_DATA_STORESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DATA_STORE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATADATA_STORE[] SCRIPT_DATA_STORES
        {
            get
            {
                return this.sCRIPT_DATA_STORESField;
            }
            set
            {
                this.sCRIPT_DATA_STORESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATADATA_STORE
    {

        private string idField;

        private string cONTENTField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string CONTENT
        {
            get
            {
                return this.cONTENTField;
            }
            set
            {
                this.cONTENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGER
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APP[] gLOBAL_APPSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("USER_APP", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APP[] GLOBAL_APPS
        {
            get
            {
                return this.gLOBAL_APPSField;
            }
            set
            {
                this.gLOBAL_APPSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APP
    {

        private string fILE_PATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APPSETTINGS sETTINGSField;

        /// <remarks/>
        public string FILE_PATH
        {
            get
            {
                return this.fILE_PATHField;
            }
            set
            {
                this.fILE_PATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APPSETTINGS SETTINGS
        {
            get
            {
                return this.sETTINGSField;
            }
            set
            {
                this.sETTINGSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APPSETTINGS
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APPSETTINGSSettings settingsField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APPSETTINGSSettings settings
        {
            get
            {
                return this.settingsField;
            }
            set
            {
                this.settingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5OPTIONSUSER_APP_MANAGERUSER_APPSETTINGSSettings
    {

        private object autoinstallField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("auto-install")]
        public object autoinstall
        {
            get
            {
                return this.autoinstallField;
            }
            set
            {
                this.autoinstallField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEHOMERACK hOMERACKField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODE nODEField;

        private bool bGPATH_TILEDField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEINTERCITY_GRID iNTERCITY_GRIDField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACECITY_GRID cITY_GRIDField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEBUILDING_GRID bUILDING_GRIDField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEGENERIC_CONTAINER_GRID gENERIC_CONTAINER_GRIDField;

        private string gRID_COLORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENOTE[] nOTESField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEHOMERACK HOMERACK
        {
            get
            {
                return this.hOMERACKField;
            }
            set
            {
                this.hOMERACKField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        public bool BGPATH_TILED
        {
            get
            {
                return this.bGPATH_TILEDField;
            }
            set
            {
                this.bGPATH_TILEDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEINTERCITY_GRID INTERCITY_GRID
        {
            get
            {
                return this.iNTERCITY_GRIDField;
            }
            set
            {
                this.iNTERCITY_GRIDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACECITY_GRID CITY_GRID
        {
            get
            {
                return this.cITY_GRIDField;
            }
            set
            {
                this.cITY_GRIDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEBUILDING_GRID BUILDING_GRID
        {
            get
            {
                return this.bUILDING_GRIDField;
            }
            set
            {
                this.bUILDING_GRIDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEGENERIC_CONTAINER_GRID GENERIC_CONTAINER_GRID
        {
            get
            {
                return this.gENERIC_CONTAINER_GRIDField;
            }
            set
            {
                this.gENERIC_CONTAINER_GRIDField = value;
            }
        }

        /// <remarks/>
        public string GRID_COLOR
        {
            get
            {
                return this.gRID_COLORField;
            }
            set
            {
                this.gRID_COLORField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("NOTE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENOTE[] NOTES
        {
            get
            {
                return this.nOTESField;
            }
            set
            {
                this.nOTESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEHOMERACK
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODE
    {

        private byte xField;

        private byte yField;

        private byte tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODENAME nAMEField;

        private decimal sxField;

        private decimal syField;

        private decimal wField;

        private decimal hField;

        private decimal dField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEPATH pATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDREN cHILDRENField;

        private bool mANUAL_SCALINGField;

        private uint sCALED_PIXMAP_WIDTHField;

        private uint sCALED_PIXMAP_HEIGHTField;

        private decimal iNIT_WIDTHField;

        private decimal iNIT_HEIGHTField;

        private byte iNIT_DEPTHField;

        private decimal iNIT_SXField;

        private decimal iNIT_SYField;

        private decimal iNIT_SZField;

        private bool bG_TILEDField;

        private sbyte cUSTOM_IMAGE_WIDTHField;

        private sbyte cUSTOM_IMAGE_HEIGHTField;

        private byte sCALE_FACTORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENT eNVIRONMENTField;

        private string uUID_STRField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public decimal SX
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <remarks/>
        public decimal SY
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <remarks/>
        public decimal W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        public decimal H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        public decimal D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEPATH PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDREN CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public bool MANUAL_SCALING
        {
            get
            {
                return this.mANUAL_SCALINGField;
            }
            set
            {
                this.mANUAL_SCALINGField = value;
            }
        }

        /// <remarks/>
        public uint SCALED_PIXMAP_WIDTH
        {
            get
            {
                return this.sCALED_PIXMAP_WIDTHField;
            }
            set
            {
                this.sCALED_PIXMAP_WIDTHField = value;
            }
        }

        /// <remarks/>
        public uint SCALED_PIXMAP_HEIGHT
        {
            get
            {
                return this.sCALED_PIXMAP_HEIGHTField;
            }
            set
            {
                this.sCALED_PIXMAP_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_WIDTH
        {
            get
            {
                return this.iNIT_WIDTHField;
            }
            set
            {
                this.iNIT_WIDTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_HEIGHT
        {
            get
            {
                return this.iNIT_HEIGHTField;
            }
            set
            {
                this.iNIT_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_DEPTH
        {
            get
            {
                return this.iNIT_DEPTHField;
            }
            set
            {
                this.iNIT_DEPTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SX
        {
            get
            {
                return this.iNIT_SXField;
            }
            set
            {
                this.iNIT_SXField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SY
        {
            get
            {
                return this.iNIT_SYField;
            }
            set
            {
                this.iNIT_SYField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SZ
        {
            get
            {
                return this.iNIT_SZField;
            }
            set
            {
                this.iNIT_SZField = value;
            }
        }

        /// <remarks/>
        public bool BG_TILED
        {
            get
            {
                return this.bG_TILEDField;
            }
            set
            {
                this.bG_TILEDField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_WIDTH
        {
            get
            {
                return this.cUSTOM_IMAGE_WIDTHField;
            }
            set
            {
                this.cUSTOM_IMAGE_WIDTHField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_HEIGHT
        {
            get
            {
                return this.cUSTOM_IMAGE_HEIGHTField;
            }
            set
            {
                this.cUSTOM_IMAGE_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte SCALE_FACTOR
        {
            get
            {
                return this.sCALE_FACTORField;
            }
            set
            {
                this.sCALE_FACTORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENT ENVIRONMENT
        {
            get
            {
                return this.eNVIRONMENTField;
            }
            set
            {
                this.eNVIRONMENTField = value;
            }
        }

        /// <remarks/>
        public string UUID_STR
        {
            get
            {
                return this.uUID_STRField;
            }
            set
            {
                this.uUID_STRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEPATH
    {

        private bool isanimField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDREN
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODE nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODE
    {

        private byte xField;

        private byte yField;

        private byte tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODENAME nAMEField;

        private decimal sxField;

        private decimal syField;

        private decimal wField;

        private decimal hField;

        private decimal dField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEPATH pATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDREN cHILDRENField;

        private bool mANUAL_SCALINGField;

        private byte sCALED_PIXMAP_WIDTHField;

        private byte sCALED_PIXMAP_HEIGHTField;

        private decimal iNIT_WIDTHField;

        private decimal iNIT_HEIGHTField;

        private byte iNIT_DEPTHField;

        private decimal iNIT_SXField;

        private decimal iNIT_SYField;

        private decimal iNIT_SZField;

        private bool bG_TILEDField;

        private sbyte cUSTOM_IMAGE_WIDTHField;

        private sbyte cUSTOM_IMAGE_HEIGHTField;

        private byte sCALE_FACTORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENT eNVIRONMENTField;

        private string uUID_STRField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public decimal SX
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <remarks/>
        public decimal SY
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <remarks/>
        public decimal W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        public decimal H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        public decimal D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEPATH PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDREN CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public bool MANUAL_SCALING
        {
            get
            {
                return this.mANUAL_SCALINGField;
            }
            set
            {
                this.mANUAL_SCALINGField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_WIDTH
        {
            get
            {
                return this.sCALED_PIXMAP_WIDTHField;
            }
            set
            {
                this.sCALED_PIXMAP_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_HEIGHT
        {
            get
            {
                return this.sCALED_PIXMAP_HEIGHTField;
            }
            set
            {
                this.sCALED_PIXMAP_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_WIDTH
        {
            get
            {
                return this.iNIT_WIDTHField;
            }
            set
            {
                this.iNIT_WIDTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_HEIGHT
        {
            get
            {
                return this.iNIT_HEIGHTField;
            }
            set
            {
                this.iNIT_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_DEPTH
        {
            get
            {
                return this.iNIT_DEPTHField;
            }
            set
            {
                this.iNIT_DEPTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SX
        {
            get
            {
                return this.iNIT_SXField;
            }
            set
            {
                this.iNIT_SXField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SY
        {
            get
            {
                return this.iNIT_SYField;
            }
            set
            {
                this.iNIT_SYField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SZ
        {
            get
            {
                return this.iNIT_SZField;
            }
            set
            {
                this.iNIT_SZField = value;
            }
        }

        /// <remarks/>
        public bool BG_TILED
        {
            get
            {
                return this.bG_TILEDField;
            }
            set
            {
                this.bG_TILEDField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_WIDTH
        {
            get
            {
                return this.cUSTOM_IMAGE_WIDTHField;
            }
            set
            {
                this.cUSTOM_IMAGE_WIDTHField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_HEIGHT
        {
            get
            {
                return this.cUSTOM_IMAGE_HEIGHTField;
            }
            set
            {
                this.cUSTOM_IMAGE_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte SCALE_FACTOR
        {
            get
            {
                return this.sCALE_FACTORField;
            }
            set
            {
                this.sCALE_FACTORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENT ENVIRONMENT
        {
            get
            {
                return this.eNVIRONMENTField;
            }
            set
            {
                this.eNVIRONMENTField = value;
            }
        }

        /// <remarks/>
        public string UUID_STR
        {
            get
            {
                return this.uUID_STRField;
            }
            set
            {
                this.uUID_STRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEPATH
    {

        private bool isanimField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDREN
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODE nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODE
    {

        private byte xField;

        private byte yField;

        private byte tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODENAME nAMEField;

        private decimal sxField;

        private decimal syField;

        private decimal wField;

        private decimal hField;

        private decimal dField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEPATH pATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDREN cHILDRENField;

        private bool mANUAL_SCALINGField;

        private byte sCALED_PIXMAP_WIDTHField;

        private byte sCALED_PIXMAP_HEIGHTField;

        private decimal iNIT_WIDTHField;

        private decimal iNIT_HEIGHTField;

        private byte iNIT_DEPTHField;

        private decimal iNIT_SXField;

        private decimal iNIT_SYField;

        private decimal iNIT_SZField;

        private bool bG_TILEDField;

        private sbyte cUSTOM_IMAGE_WIDTHField;

        private sbyte cUSTOM_IMAGE_HEIGHTField;

        private byte sCALE_FACTORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENT eNVIRONMENTField;

        private string uUID_STRField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public decimal SX
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <remarks/>
        public decimal SY
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <remarks/>
        public decimal W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        public decimal H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        public decimal D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEPATH PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDREN CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public bool MANUAL_SCALING
        {
            get
            {
                return this.mANUAL_SCALINGField;
            }
            set
            {
                this.mANUAL_SCALINGField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_WIDTH
        {
            get
            {
                return this.sCALED_PIXMAP_WIDTHField;
            }
            set
            {
                this.sCALED_PIXMAP_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_HEIGHT
        {
            get
            {
                return this.sCALED_PIXMAP_HEIGHTField;
            }
            set
            {
                this.sCALED_PIXMAP_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_WIDTH
        {
            get
            {
                return this.iNIT_WIDTHField;
            }
            set
            {
                this.iNIT_WIDTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_HEIGHT
        {
            get
            {
                return this.iNIT_HEIGHTField;
            }
            set
            {
                this.iNIT_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_DEPTH
        {
            get
            {
                return this.iNIT_DEPTHField;
            }
            set
            {
                this.iNIT_DEPTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SX
        {
            get
            {
                return this.iNIT_SXField;
            }
            set
            {
                this.iNIT_SXField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SY
        {
            get
            {
                return this.iNIT_SYField;
            }
            set
            {
                this.iNIT_SYField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SZ
        {
            get
            {
                return this.iNIT_SZField;
            }
            set
            {
                this.iNIT_SZField = value;
            }
        }

        /// <remarks/>
        public bool BG_TILED
        {
            get
            {
                return this.bG_TILEDField;
            }
            set
            {
                this.bG_TILEDField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_WIDTH
        {
            get
            {
                return this.cUSTOM_IMAGE_WIDTHField;
            }
            set
            {
                this.cUSTOM_IMAGE_WIDTHField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_HEIGHT
        {
            get
            {
                return this.cUSTOM_IMAGE_HEIGHTField;
            }
            set
            {
                this.cUSTOM_IMAGE_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte SCALE_FACTOR
        {
            get
            {
                return this.sCALE_FACTORField;
            }
            set
            {
                this.sCALE_FACTORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENT ENVIRONMENT
        {
            get
            {
                return this.eNVIRONMENTField;
            }
            set
            {
                this.eNVIRONMENTField = value;
            }
        }

        /// <remarks/>
        public string UUID_STR
        {
            get
            {
                return this.uUID_STRField;
            }
            set
            {
                this.uUID_STRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEPATH
    {

        private bool isanimField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDREN
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODE nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODE
    {

        private byte xField;

        private byte yField;

        private byte tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENAME nAMEField;

        private decimal sxField;

        private decimal syField;

        private byte wField;

        private byte hField;

        private decimal dField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEPATH pATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODE[] cHILDRENField;

        private bool mANUAL_SCALINGField;

        private byte sCALED_PIXMAP_WIDTHField;

        private byte sCALED_PIXMAP_HEIGHTField;

        private byte iNIT_WIDTHField;

        private byte iNIT_HEIGHTField;

        private byte iNIT_DEPTHField;

        private decimal iNIT_SXField;

        private decimal iNIT_SYField;

        private decimal iNIT_SZField;

        private bool bG_TILEDField;

        private sbyte cUSTOM_IMAGE_WIDTHField;

        private sbyte cUSTOM_IMAGE_HEIGHTField;

        private byte sCALE_FACTORField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENT eNVIRONMENTField;

        private string uUID_STRField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public decimal SX
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <remarks/>
        public decimal SY
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <remarks/>
        public byte W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        public byte H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        public decimal D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEPATH PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("NODE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODE[] CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public bool MANUAL_SCALING
        {
            get
            {
                return this.mANUAL_SCALINGField;
            }
            set
            {
                this.mANUAL_SCALINGField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_WIDTH
        {
            get
            {
                return this.sCALED_PIXMAP_WIDTHField;
            }
            set
            {
                this.sCALED_PIXMAP_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_HEIGHT
        {
            get
            {
                return this.sCALED_PIXMAP_HEIGHTField;
            }
            set
            {
                this.sCALED_PIXMAP_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_WIDTH
        {
            get
            {
                return this.iNIT_WIDTHField;
            }
            set
            {
                this.iNIT_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte INIT_HEIGHT
        {
            get
            {
                return this.iNIT_HEIGHTField;
            }
            set
            {
                this.iNIT_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_DEPTH
        {
            get
            {
                return this.iNIT_DEPTHField;
            }
            set
            {
                this.iNIT_DEPTHField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SX
        {
            get
            {
                return this.iNIT_SXField;
            }
            set
            {
                this.iNIT_SXField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SY
        {
            get
            {
                return this.iNIT_SYField;
            }
            set
            {
                this.iNIT_SYField = value;
            }
        }

        /// <remarks/>
        public decimal INIT_SZ
        {
            get
            {
                return this.iNIT_SZField;
            }
            set
            {
                this.iNIT_SZField = value;
            }
        }

        /// <remarks/>
        public bool BG_TILED
        {
            get
            {
                return this.bG_TILEDField;
            }
            set
            {
                this.bG_TILEDField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_WIDTH
        {
            get
            {
                return this.cUSTOM_IMAGE_WIDTHField;
            }
            set
            {
                this.cUSTOM_IMAGE_WIDTHField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_HEIGHT
        {
            get
            {
                return this.cUSTOM_IMAGE_HEIGHTField;
            }
            set
            {
                this.cUSTOM_IMAGE_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte SCALE_FACTOR
        {
            get
            {
                return this.sCALE_FACTORField;
            }
            set
            {
                this.sCALE_FACTORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENT ENVIRONMENT
        {
            get
            {
                return this.eNVIRONMENTField;
            }
            set
            {
                this.eNVIRONMENTField = value;
            }
        }

        /// <remarks/>
        public string UUID_STR
        {
            get
            {
                return this.uUID_STRField;
            }
            set
            {
                this.uUID_STRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEPATH
    {

        private bool isanimField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODE
    {

        private byte xField;

        private byte yField;

        private byte tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENAME nAMEField;

        private byte sxField;

        private byte syField;

        private byte wField;

        private byte hField;

        private byte dField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODEPATH pATHField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODE[] cHILDRENField;

        private bool mANUAL_SCALINGField;

        private ushort sCALED_PIXMAP_WIDTHField;

        private byte sCALED_PIXMAP_HEIGHTField;

        private byte iNIT_WIDTHField;

        private byte iNIT_HEIGHTField;

        private byte iNIT_DEPTHField;

        private byte iNIT_SXField;

        private byte iNIT_SYField;

        private byte iNIT_SZField;

        private bool bG_TILEDField;

        private sbyte cUSTOM_IMAGE_WIDTHField;

        private sbyte cUSTOM_IMAGE_HEIGHTField;

        private byte sCALE_FACTORField;

        private string uUID_STRField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public byte SX
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <remarks/>
        public byte SY
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <remarks/>
        public byte W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        public byte H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        public byte D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODEPATH PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("NODE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODE[] CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public bool MANUAL_SCALING
        {
            get
            {
                return this.mANUAL_SCALINGField;
            }
            set
            {
                this.mANUAL_SCALINGField = value;
            }
        }

        /// <remarks/>
        public ushort SCALED_PIXMAP_WIDTH
        {
            get
            {
                return this.sCALED_PIXMAP_WIDTHField;
            }
            set
            {
                this.sCALED_PIXMAP_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_HEIGHT
        {
            get
            {
                return this.sCALED_PIXMAP_HEIGHTField;
            }
            set
            {
                this.sCALED_PIXMAP_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_WIDTH
        {
            get
            {
                return this.iNIT_WIDTHField;
            }
            set
            {
                this.iNIT_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte INIT_HEIGHT
        {
            get
            {
                return this.iNIT_HEIGHTField;
            }
            set
            {
                this.iNIT_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_DEPTH
        {
            get
            {
                return this.iNIT_DEPTHField;
            }
            set
            {
                this.iNIT_DEPTHField = value;
            }
        }

        /// <remarks/>
        public byte INIT_SX
        {
            get
            {
                return this.iNIT_SXField;
            }
            set
            {
                this.iNIT_SXField = value;
            }
        }

        /// <remarks/>
        public byte INIT_SY
        {
            get
            {
                return this.iNIT_SYField;
            }
            set
            {
                this.iNIT_SYField = value;
            }
        }

        /// <remarks/>
        public byte INIT_SZ
        {
            get
            {
                return this.iNIT_SZField;
            }
            set
            {
                this.iNIT_SZField = value;
            }
        }

        /// <remarks/>
        public bool BG_TILED
        {
            get
            {
                return this.bG_TILEDField;
            }
            set
            {
                this.bG_TILEDField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_WIDTH
        {
            get
            {
                return this.cUSTOM_IMAGE_WIDTHField;
            }
            set
            {
                this.cUSTOM_IMAGE_WIDTHField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_HEIGHT
        {
            get
            {
                return this.cUSTOM_IMAGE_HEIGHTField;
            }
            set
            {
                this.cUSTOM_IMAGE_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte SCALE_FACTOR
        {
            get
            {
                return this.sCALE_FACTORField;
            }
            set
            {
                this.sCALE_FACTORField = value;
            }
        }

        /// <remarks/>
        public string UUID_STR
        {
            get
            {
                return this.uUID_STRField;
            }
            set
            {
                this.uUID_STRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODEPATH
    {

        private bool isanimField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODE
    {

        private int xField;

        private byte yField;

        private byte tYPEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODENAME nAMEField;

        private byte sxField;

        private byte syField;

        private byte wField;

        private byte hField;

        private byte dField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODEPATH pATHField;

        private object cHILDRENField;

        private bool mANUAL_SCALINGField;

        private byte sCALED_PIXMAP_WIDTHField;

        private byte sCALED_PIXMAP_HEIGHTField;

        private byte iNIT_WIDTHField;

        private byte iNIT_HEIGHTField;

        private byte iNIT_DEPTHField;

        private byte iNIT_SXField;

        private byte iNIT_SYField;

        private byte iNIT_SZField;

        private bool bG_TILEDField;

        private sbyte cUSTOM_IMAGE_WIDTHField;

        private sbyte cUSTOM_IMAGE_HEIGHTField;

        private byte sCALE_FACTORField;

        private string uUID_STRField;

        /// <remarks/>
        public int X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public byte SX
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
            }
        }

        /// <remarks/>
        public byte SY
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
            }
        }

        /// <remarks/>
        public byte W
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        /// <remarks/>
        public byte H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        public byte D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODEPATH PATH
        {
            get
            {
                return this.pATHField;
            }
            set
            {
                this.pATHField = value;
            }
        }

        /// <remarks/>
        public object CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public bool MANUAL_SCALING
        {
            get
            {
                return this.mANUAL_SCALINGField;
            }
            set
            {
                this.mANUAL_SCALINGField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_WIDTH
        {
            get
            {
                return this.sCALED_PIXMAP_WIDTHField;
            }
            set
            {
                this.sCALED_PIXMAP_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte SCALED_PIXMAP_HEIGHT
        {
            get
            {
                return this.sCALED_PIXMAP_HEIGHTField;
            }
            set
            {
                this.sCALED_PIXMAP_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_WIDTH
        {
            get
            {
                return this.iNIT_WIDTHField;
            }
            set
            {
                this.iNIT_WIDTHField = value;
            }
        }

        /// <remarks/>
        public byte INIT_HEIGHT
        {
            get
            {
                return this.iNIT_HEIGHTField;
            }
            set
            {
                this.iNIT_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte INIT_DEPTH
        {
            get
            {
                return this.iNIT_DEPTHField;
            }
            set
            {
                this.iNIT_DEPTHField = value;
            }
        }

        /// <remarks/>
        public byte INIT_SX
        {
            get
            {
                return this.iNIT_SXField;
            }
            set
            {
                this.iNIT_SXField = value;
            }
        }

        /// <remarks/>
        public byte INIT_SY
        {
            get
            {
                return this.iNIT_SYField;
            }
            set
            {
                this.iNIT_SYField = value;
            }
        }

        /// <remarks/>
        public byte INIT_SZ
        {
            get
            {
                return this.iNIT_SZField;
            }
            set
            {
                this.iNIT_SZField = value;
            }
        }

        /// <remarks/>
        public bool BG_TILED
        {
            get
            {
                return this.bG_TILEDField;
            }
            set
            {
                this.bG_TILEDField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_WIDTH
        {
            get
            {
                return this.cUSTOM_IMAGE_WIDTHField;
            }
            set
            {
                this.cUSTOM_IMAGE_WIDTHField = value;
            }
        }

        /// <remarks/>
        public sbyte CUSTOM_IMAGE_HEIGHT
        {
            get
            {
                return this.cUSTOM_IMAGE_HEIGHTField;
            }
            set
            {
                this.cUSTOM_IMAGE_HEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte SCALE_FACTOR
        {
            get
            {
                return this.sCALE_FACTORField;
            }
            set
            {
                this.sCALE_FACTORField = value;
            }
        }

        /// <remarks/>
        public string UUID_STR
        {
            get
            {
                return this.uUID_STRField;
            }
            set
            {
                this.uUID_STRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODENAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODENODENODEPATH
    {

        private bool isanimField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENT
    {

        private byte tIME_IN_SECONDSField;

        private byte tIME_MULTIPLIERField;

        private byte sIM_TIME_SETTINGField;

        private byte rEAL_TIME_SETTINGField;

        private byte sIM_TIME_COMBOField;

        private byte rEAL_TIME_COMBOField;

        private object nOTESField;

        private bool sHOW_NOTESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAME[] kEYFRAMESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public byte TIME_IN_SECONDS
        {
            get
            {
                return this.tIME_IN_SECONDSField;
            }
            set
            {
                this.tIME_IN_SECONDSField = value;
            }
        }

        /// <remarks/>
        public byte TIME_MULTIPLIER
        {
            get
            {
                return this.tIME_MULTIPLIERField;
            }
            set
            {
                this.tIME_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_SETTING
        {
            get
            {
                return this.sIM_TIME_SETTINGField;
            }
            set
            {
                this.sIM_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_SETTING
        {
            get
            {
                return this.rEAL_TIME_SETTINGField;
            }
            set
            {
                this.rEAL_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_COMBO
        {
            get
            {
                return this.sIM_TIME_COMBOField;
            }
            set
            {
                this.sIM_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_COMBO
        {
            get
            {
                return this.rEAL_TIME_COMBOField;
            }
            set
            {
                this.rEAL_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public object NOTES
        {
            get
            {
                return this.nOTESField;
            }
            set
            {
                this.nOTESField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_NOTES
        {
            get
            {
                return this.sHOW_NOTESField;
            }
            set
            {
                this.sHOW_NOTESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KEYFRAME", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAME[] KEYFRAMES
        {
            get
            {
                return this.kEYFRAMESField;
            }
            set
            {
                this.kEYFRAMESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAME
    {

        private uint tIMEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public uint TIME
        {
            get
            {
                return this.tIMEField;
            }
            set
            {
                this.tIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private byte vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private decimal vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public decimal VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENT
    {

        private byte tIME_IN_SECONDSField;

        private byte tIME_MULTIPLIERField;

        private byte sIM_TIME_SETTINGField;

        private byte rEAL_TIME_SETTINGField;

        private byte sIM_TIME_COMBOField;

        private byte rEAL_TIME_COMBOField;

        private object nOTESField;

        private bool sHOW_NOTESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAME[] kEYFRAMESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public byte TIME_IN_SECONDS
        {
            get
            {
                return this.tIME_IN_SECONDSField;
            }
            set
            {
                this.tIME_IN_SECONDSField = value;
            }
        }

        /// <remarks/>
        public byte TIME_MULTIPLIER
        {
            get
            {
                return this.tIME_MULTIPLIERField;
            }
            set
            {
                this.tIME_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_SETTING
        {
            get
            {
                return this.sIM_TIME_SETTINGField;
            }
            set
            {
                this.sIM_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_SETTING
        {
            get
            {
                return this.rEAL_TIME_SETTINGField;
            }
            set
            {
                this.rEAL_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_COMBO
        {
            get
            {
                return this.sIM_TIME_COMBOField;
            }
            set
            {
                this.sIM_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_COMBO
        {
            get
            {
                return this.rEAL_TIME_COMBOField;
            }
            set
            {
                this.rEAL_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public object NOTES
        {
            get
            {
                return this.nOTESField;
            }
            set
            {
                this.nOTESField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_NOTES
        {
            get
            {
                return this.sHOW_NOTESField;
            }
            set
            {
                this.sHOW_NOTESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KEYFRAME", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAME[] KEYFRAMES
        {
            get
            {
                return this.kEYFRAMESField;
            }
            set
            {
                this.kEYFRAMESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAME
    {

        private uint tIMEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public uint TIME
        {
            get
            {
                return this.tIMEField;
            }
            set
            {
                this.tIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private byte vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private decimal vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public decimal VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENT
    {

        private byte tIME_IN_SECONDSField;

        private byte tIME_MULTIPLIERField;

        private byte sIM_TIME_SETTINGField;

        private byte rEAL_TIME_SETTINGField;

        private byte sIM_TIME_COMBOField;

        private byte rEAL_TIME_COMBOField;

        private object nOTESField;

        private bool sHOW_NOTESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTKEYFRAME[] kEYFRAMESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public byte TIME_IN_SECONDS
        {
            get
            {
                return this.tIME_IN_SECONDSField;
            }
            set
            {
                this.tIME_IN_SECONDSField = value;
            }
        }

        /// <remarks/>
        public byte TIME_MULTIPLIER
        {
            get
            {
                return this.tIME_MULTIPLIERField;
            }
            set
            {
                this.tIME_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_SETTING
        {
            get
            {
                return this.sIM_TIME_SETTINGField;
            }
            set
            {
                this.sIM_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_SETTING
        {
            get
            {
                return this.rEAL_TIME_SETTINGField;
            }
            set
            {
                this.rEAL_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_COMBO
        {
            get
            {
                return this.sIM_TIME_COMBOField;
            }
            set
            {
                this.sIM_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_COMBO
        {
            get
            {
                return this.rEAL_TIME_COMBOField;
            }
            set
            {
                this.rEAL_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public object NOTES
        {
            get
            {
                return this.nOTESField;
            }
            set
            {
                this.nOTESField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_NOTES
        {
            get
            {
                return this.sHOW_NOTESField;
            }
            set
            {
                this.sHOW_NOTESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KEYFRAME", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTKEYFRAME[] KEYFRAMES
        {
            get
            {
                return this.kEYFRAMESField;
            }
            set
            {
                this.kEYFRAMESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTKEYFRAME
    {

        private uint tIMEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public uint TIME
        {
            get
            {
                return this.tIMEField;
            }
            set
            {
                this.tIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private byte vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODECHILDRENNODEENVIRONMENTENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private decimal vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public decimal VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENT
    {

        private byte tIME_IN_SECONDSField;

        private byte tIME_MULTIPLIERField;

        private byte sIM_TIME_SETTINGField;

        private byte rEAL_TIME_SETTINGField;

        private byte sIM_TIME_COMBOField;

        private byte rEAL_TIME_COMBOField;

        private object nOTESField;

        private bool sHOW_NOTESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTKEYFRAME[] kEYFRAMESField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public byte TIME_IN_SECONDS
        {
            get
            {
                return this.tIME_IN_SECONDSField;
            }
            set
            {
                this.tIME_IN_SECONDSField = value;
            }
        }

        /// <remarks/>
        public byte TIME_MULTIPLIER
        {
            get
            {
                return this.tIME_MULTIPLIERField;
            }
            set
            {
                this.tIME_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_SETTING
        {
            get
            {
                return this.sIM_TIME_SETTINGField;
            }
            set
            {
                this.sIM_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_SETTING
        {
            get
            {
                return this.rEAL_TIME_SETTINGField;
            }
            set
            {
                this.rEAL_TIME_SETTINGField = value;
            }
        }

        /// <remarks/>
        public byte SIM_TIME_COMBO
        {
            get
            {
                return this.sIM_TIME_COMBOField;
            }
            set
            {
                this.sIM_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public byte REAL_TIME_COMBO
        {
            get
            {
                return this.rEAL_TIME_COMBOField;
            }
            set
            {
                this.rEAL_TIME_COMBOField = value;
            }
        }

        /// <remarks/>
        public object NOTES
        {
            get
            {
                return this.nOTESField;
            }
            set
            {
                this.nOTESField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_NOTES
        {
            get
            {
                return this.sHOW_NOTESField;
            }
            set
            {
                this.sHOW_NOTESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KEYFRAME", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTKEYFRAME[] KEYFRAMES
        {
            get
            {
                return this.kEYFRAMESField;
            }
            set
            {
                this.kEYFRAMESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTKEYFRAME
    {

        private uint tIMEField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] eNVIRONMENT_OPTIONSField;

        /// <remarks/>
        public uint TIME
        {
            get
            {
                return this.tIMEField;
            }
            set
            {
                this.tIMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ENVIRONMENT_OPTION", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION[] ENVIRONMENT_OPTIONS
        {
            get
            {
                return this.eNVIRONMENT_OPTIONSField;
            }
            set
            {
                this.eNVIRONMENT_OPTIONSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTKEYFRAMEENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private decimal vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public decimal VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENODEENVIRONMENTENVIRONMENT_OPTION
    {

        private string cATEGORY_IDField;

        private string idField;

        private string nAMEField;

        private string cATEGORYField;

        private byte tRANSFERENCEField;

        private bool sHOWField;

        private bool iNTERPOLATEField;

        private bool aCTIVEField;

        private decimal vALUEField;

        private sbyte mINField;

        private uint mAXField;

        private decimal mIN_RATEField;

        private decimal mAX_RATEField;

        private string mETRIC_UNITField;

        private string iMPERIAL_UNITField;

        private string iMPERIAL_CONVERSION_FORMULAField;

        private string mETRIC_CONVERSION_FORMULAField;

        /// <remarks/>
        public string CATEGORY_ID
        {
            get
            {
                return this.cATEGORY_IDField;
            }
            set
            {
                this.cATEGORY_IDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get
            {
                return this.cATEGORYField;
            }
            set
            {
                this.cATEGORYField = value;
            }
        }

        /// <remarks/>
        public byte TRANSFERENCE
        {
            get
            {
                return this.tRANSFERENCEField;
            }
            set
            {
                this.tRANSFERENCEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW
        {
            get
            {
                return this.sHOWField;
            }
            set
            {
                this.sHOWField = value;
            }
        }

        /// <remarks/>
        public bool INTERPOLATE
        {
            get
            {
                return this.iNTERPOLATEField;
            }
            set
            {
                this.iNTERPOLATEField = value;
            }
        }

        /// <remarks/>
        public bool ACTIVE
        {
            get
            {
                return this.aCTIVEField;
            }
            set
            {
                this.aCTIVEField = value;
            }
        }

        /// <remarks/>
        public decimal VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        public sbyte MIN
        {
            get
            {
                return this.mINField;
            }
            set
            {
                this.mINField = value;
            }
        }

        /// <remarks/>
        public uint MAX
        {
            get
            {
                return this.mAXField;
            }
            set
            {
                this.mAXField = value;
            }
        }

        /// <remarks/>
        public decimal MIN_RATE
        {
            get
            {
                return this.mIN_RATEField;
            }
            set
            {
                this.mIN_RATEField = value;
            }
        }

        /// <remarks/>
        public decimal MAX_RATE
        {
            get
            {
                return this.mAX_RATEField;
            }
            set
            {
                this.mAX_RATEField = value;
            }
        }

        /// <remarks/>
        public string METRIC_UNIT
        {
            get
            {
                return this.mETRIC_UNITField;
            }
            set
            {
                this.mETRIC_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_UNIT
        {
            get
            {
                return this.iMPERIAL_UNITField;
            }
            set
            {
                this.iMPERIAL_UNITField = value;
            }
        }

        /// <remarks/>
        public string IMPERIAL_CONVERSION_FORMULA
        {
            get
            {
                return this.iMPERIAL_CONVERSION_FORMULAField;
            }
            set
            {
                this.iMPERIAL_CONVERSION_FORMULAField = value;
            }
        }

        /// <remarks/>
        public string METRIC_CONVERSION_FORMULA
        {
            get
            {
                return this.mETRIC_CONVERSION_FORMULAField;
            }
            set
            {
                this.mETRIC_CONVERSION_FORMULAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEINTERCITY_GRID
    {

        private ushort xField;

        private ushort yField;

        private bool eNABLEDField;

        /// <remarks/>
        public ushort X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public ushort Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public bool ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACECITY_GRID
    {

        private byte xField;

        private byte yField;

        private bool eNABLEDField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public bool ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEBUILDING_GRID
    {

        private byte xField;

        private byte yField;

        private bool eNABLEDField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public bool ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACEGENERIC_CONTAINER_GRID
    {

        private byte xField;

        private byte yField;

        private bool eNABLEDField;

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public bool ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5PHYSICALWORKSPACENOTE
    {

        private ushort xField;

        private byte yField;

        private ushort zField;

        private string tEXTField;

        private string nOTECLUSTERIDField;

        private uint mEM_ADDRField;

        private string uuidField;

        /// <remarks/>
        public ushort X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public ushort Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        public string NOTECLUSTERID
        {
            get
            {
                return this.nOTECLUSTERIDField;
            }
            set
            {
                this.nOTECLUSTERIDField = value;
            }
        }

        /// <remarks/>
        public uint MEM_ADDR
        {
            get
            {
                return this.mEM_ADDRField;
            }
            set
            {
                this.mEM_ADDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERS
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERSACL_FILTERS aCL_FILTERSField;

        private object cUSTOM_TYPE_FILTERSField;

        private string sCCPField;

        private string sTPField;

        private string rADIUSField;

        private string telnetField;

        private string pPPoEDField;

        private string dNSField;

        private string iPSecField;

        private string eIGRPField;

        private string ioTTCPField;

        private string lACPField;

        private string iCMPv6Field;

        private string hSRPv6Field;

        private string aRPField;

        private string sNMPField;

        private string uSBField;

        private string eAPOLField;

        private string ioTField;

        private string dHCPv6Field;

        private string oSPFField;

        private string tCPField;

        private string sYSLOGField;

        private string fTPField;

        private string sMTPField;

        private string tACACSField;

        private string tFTPField;

        private string pOP3Field;

        private string vTPField;

        private string rTPField;

        private string eIGRPv6Field;

        private string dTPField;

        private string dHCPField;

        private string rEPField;

        private string pAgPField;

        private string sSHField;

        private string iSAKMPField;

        private string nDPField;

        private string iCMPField;

        private string hTTPField;

        private string rIPngField;

        private string cDPField;

        private string nTPField;

        private string bluetoothField;

        private string h323Field;

        private string bGPField;

        private string rIPField;

        private string pTPField;

        private string hSRPField;

        private string nETFLOWField;

        private string hTTPSField;

        private string cAPWAPField;

        private string pPPField;

        private string oSPFv6Field;

        private string uDPField;

        private string lLDPField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERSACL_FILTERS ACL_FILTERS
        {
            get
            {
                return this.aCL_FILTERSField;
            }
            set
            {
                this.aCL_FILTERSField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_TYPE_FILTERS
        {
            get
            {
                return this.cUSTOM_TYPE_FILTERSField;
            }
            set
            {
                this.cUSTOM_TYPE_FILTERSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SCCP
        {
            get
            {
                return this.sCCPField;
            }
            set
            {
                this.sCCPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STP
        {
            get
            {
                return this.sTPField;
            }
            set
            {
                this.sTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RADIUS
        {
            get
            {
                return this.rADIUSField;
            }
            set
            {
                this.rADIUSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Telnet
        {
            get
            {
                return this.telnetField;
            }
            set
            {
                this.telnetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PPPoED
        {
            get
            {
                return this.pPPoEDField;
            }
            set
            {
                this.pPPoEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DNS
        {
            get
            {
                return this.dNSField;
            }
            set
            {
                this.dNSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IPSec
        {
            get
            {
                return this.iPSecField;
            }
            set
            {
                this.iPSecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EIGRP
        {
            get
            {
                return this.eIGRPField;
            }
            set
            {
                this.eIGRPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("IoT-TCP")]
        public string IoTTCP
        {
            get
            {
                return this.ioTTCPField;
            }
            set
            {
                this.ioTTCPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LACP
        {
            get
            {
                return this.lACPField;
            }
            set
            {
                this.lACPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ICMPv6
        {
            get
            {
                return this.iCMPv6Field;
            }
            set
            {
                this.iCMPv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HSRPv6
        {
            get
            {
                return this.hSRPv6Field;
            }
            set
            {
                this.hSRPv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ARP
        {
            get
            {
                return this.aRPField;
            }
            set
            {
                this.aRPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SNMP
        {
            get
            {
                return this.sNMPField;
            }
            set
            {
                this.sNMPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string USB
        {
            get
            {
                return this.uSBField;
            }
            set
            {
                this.uSBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EAPOL
        {
            get
            {
                return this.eAPOLField;
            }
            set
            {
                this.eAPOLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IoT
        {
            get
            {
                return this.ioTField;
            }
            set
            {
                this.ioTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DHCPv6
        {
            get
            {
                return this.dHCPv6Field;
            }
            set
            {
                this.dHCPv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OSPF
        {
            get
            {
                return this.oSPFField;
            }
            set
            {
                this.oSPFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TCP
        {
            get
            {
                return this.tCPField;
            }
            set
            {
                this.tCPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SYSLOG
        {
            get
            {
                return this.sYSLOGField;
            }
            set
            {
                this.sYSLOGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FTP
        {
            get
            {
                return this.fTPField;
            }
            set
            {
                this.fTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SMTP
        {
            get
            {
                return this.sMTPField;
            }
            set
            {
                this.sMTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TACACS
        {
            get
            {
                return this.tACACSField;
            }
            set
            {
                this.tACACSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TFTP
        {
            get
            {
                return this.tFTPField;
            }
            set
            {
                this.tFTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string POP3
        {
            get
            {
                return this.pOP3Field;
            }
            set
            {
                this.pOP3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VTP
        {
            get
            {
                return this.vTPField;
            }
            set
            {
                this.vTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RTP
        {
            get
            {
                return this.rTPField;
            }
            set
            {
                this.rTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EIGRPv6
        {
            get
            {
                return this.eIGRPv6Field;
            }
            set
            {
                this.eIGRPv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DTP
        {
            get
            {
                return this.dTPField;
            }
            set
            {
                this.dTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string REP
        {
            get
            {
                return this.rEPField;
            }
            set
            {
                this.rEPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PAgP
        {
            get
            {
                return this.pAgPField;
            }
            set
            {
                this.pAgPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SSH
        {
            get
            {
                return this.sSHField;
            }
            set
            {
                this.sSHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ISAKMP
        {
            get
            {
                return this.iSAKMPField;
            }
            set
            {
                this.iSAKMPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NDP
        {
            get
            {
                return this.nDPField;
            }
            set
            {
                this.nDPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ICMP
        {
            get
            {
                return this.iCMPField;
            }
            set
            {
                this.iCMPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTTP
        {
            get
            {
                return this.hTTPField;
            }
            set
            {
                this.hTTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RIPng
        {
            get
            {
                return this.rIPngField;
            }
            set
            {
                this.rIPngField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CDP
        {
            get
            {
                return this.cDPField;
            }
            set
            {
                this.cDPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NTP
        {
            get
            {
                return this.nTPField;
            }
            set
            {
                this.nTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Bluetooth
        {
            get
            {
                return this.bluetoothField;
            }
            set
            {
                this.bluetoothField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("H.323")]
        public string H323
        {
            get
            {
                return this.h323Field;
            }
            set
            {
                this.h323Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BGP
        {
            get
            {
                return this.bGPField;
            }
            set
            {
                this.bGPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RIP
        {
            get
            {
                return this.rIPField;
            }
            set
            {
                this.rIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PTP
        {
            get
            {
                return this.pTPField;
            }
            set
            {
                this.pTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HSRP
        {
            get
            {
                return this.hSRPField;
            }
            set
            {
                this.hSRPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NETFLOW
        {
            get
            {
                return this.nETFLOWField;
            }
            set
            {
                this.nETFLOWField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTTPS
        {
            get
            {
                return this.hTTPSField;
            }
            set
            {
                this.hTTPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CAPWAP
        {
            get
            {
                return this.cAPWAPField;
            }
            set
            {
                this.cAPWAPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PPP
        {
            get
            {
                return this.pPPField;
            }
            set
            {
                this.pPPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OSPFv6
        {
            get
            {
                return this.oSPFv6Field;
            }
            set
            {
                this.oSPFv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UDP
        {
            get
            {
                return this.uDPField;
            }
            set
            {
                this.uDPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LLDP
        {
            get
            {
                return this.lLDPField;
            }
            set
            {
                this.lLDPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERSACL_FILTERS
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERSACL_FILTERSACL_FILTER aCL_FILTERField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERSACL_FILTERSACL_FILTER ACL_FILTER
        {
            get
            {
                return this.aCL_FILTERField;
            }
            set
            {
                this.aCL_FILTERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5FILTERSACL_FILTERSACL_FILTER
    {

        private string nAMEField;

        private object sTATEMENTSField;

        private string eNABLEDField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public object STATEMENTS
        {
            get
            {
                return this.sTATEMENTSField;
            }
            set
            {
                this.sTATEMENTSField = value;
            }
        }

        /// <remarks/>
        public string ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERS
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTER rOOTCLUSTERField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTER ROOTCLUSTER
        {
            get
            {
                return this.rOOTCLUSTERField;
            }
            set
            {
                this.rOOTCLUSTERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTER
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTERNAME nAMEField;

        private string cLUSTERIDField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTERCLUSTER_BG_IMAGE cLUSTER_BG_IMAGEField;

        private object cLUSTER_EMBEDDED_BG_IMAGEField;

        private object cLUSTER_ICON_IMAGEField;

        private bool tILED_BGField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTERNAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string CLUSTERID
        {
            get
            {
                return this.cLUSTERIDField;
            }
            set
            {
                this.cLUSTERIDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTERCLUSTER_BG_IMAGE CLUSTER_BG_IMAGE
        {
            get
            {
                return this.cLUSTER_BG_IMAGEField;
            }
            set
            {
                this.cLUSTER_BG_IMAGEField = value;
            }
        }

        /// <remarks/>
        public object CLUSTER_EMBEDDED_BG_IMAGE
        {
            get
            {
                return this.cLUSTER_EMBEDDED_BG_IMAGEField;
            }
            set
            {
                this.cLUSTER_EMBEDDED_BG_IMAGEField = value;
            }
        }

        /// <remarks/>
        public object CLUSTER_ICON_IMAGE
        {
            get
            {
                return this.cLUSTER_ICON_IMAGEField;
            }
            set
            {
                this.cLUSTER_ICON_IMAGEField = value;
            }
        }

        /// <remarks/>
        public bool TILED_BG
        {
            get
            {
                return this.tILED_BGField;
            }
            set
            {
                this.tILED_BGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTERNAME
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5CLUSTERSROOTCLUSTERCLUSTER_BG_IMAGE
    {

        private bool isanimField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isanim
        {
            get
            {
                return this.isanimField;
            }
            set
            {
                this.isanimField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5USER_PROFILE
    {

        private string nAMEField;

        private object eMAILField;

        private object aDDITIONAL_INFOField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public object EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public object ADDITIONAL_INFO
        {
            get
            {
                return this.aDDITIONAL_INFOField;
            }
            set
            {
                this.aDDITIONAL_INFOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5MULTIUSER
    {

        private object rEMOTE_NETWORKSField;

        private object pORT_VISIBILITYField;

        /// <remarks/>
        public object REMOTE_NETWORKS
        {
            get
            {
                return this.rEMOTE_NETWORKSField;
            }
            set
            {
                this.rEMOTE_NETWORKSField = value;
            }
        }

        /// <remarks/>
        public object PORT_VISIBILITY
        {
            get
            {
                return this.pORT_VISIBILITYField;
            }
            set
            {
                this.pORT_VISIBILITYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5GEOVIEW_GRAPHICSITEMS
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5GEOVIEW_GRAPHICSITEMSParentPhyObject parentPhyObjectField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5GEOVIEW_GRAPHICSITEMSParentPhyObject ParentPhyObject
        {
            get
            {
                return this.parentPhyObjectField;
            }
            set
            {
                this.parentPhyObjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5GEOVIEW_GRAPHICSITEMSParentPhyObject
    {

        private string pathField;

        private object geoConnectionItemsField;

        private object breakPointItemsField;

        private object groupPointItemsField;

        private object ellipticalShapesField;

        private object rectangularShapesField;

        private object lineShapesField;

        private object noteEditsField;

        private object polygonShapesField;

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public object GeoConnectionItems
        {
            get
            {
                return this.geoConnectionItemsField;
            }
            set
            {
                this.geoConnectionItemsField = value;
            }
        }

        /// <remarks/>
        public object BreakPointItems
        {
            get
            {
                return this.breakPointItemsField;
            }
            set
            {
                this.breakPointItemsField = value;
            }
        }

        /// <remarks/>
        public object GroupPointItems
        {
            get
            {
                return this.groupPointItemsField;
            }
            set
            {
                this.groupPointItemsField = value;
            }
        }

        /// <remarks/>
        public object EllipticalShapes
        {
            get
            {
                return this.ellipticalShapesField;
            }
            set
            {
                this.ellipticalShapesField = value;
            }
        }

        /// <remarks/>
        public object RectangularShapes
        {
            get
            {
                return this.rectangularShapesField;
            }
            set
            {
                this.rectangularShapesField = value;
            }
        }

        /// <remarks/>
        public object LineShapes
        {
            get
            {
                return this.lineShapesField;
            }
            set
            {
                this.lineShapesField = value;
            }
        }

        /// <remarks/>
        public object NoteEdits
        {
            get
            {
                return this.noteEditsField;
            }
            set
            {
                this.noteEditsField = value;
            }
        }

        /// <remarks/>
        public object PolygonShapes
        {
            get
            {
                return this.polygonShapesField;
            }
            set
            {
                this.polygonShapesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULE
    {

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULEPT_APP_META pT_APP_METAField;

        private object pASSWORDField;

        private bool oPEN_IF_DENIEDField;

        private PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULESCRIPTS sCRIPTSField;

        private object iNTERFACESField;

        private object nEW_DEVICE_CUSTOM_INTERFACESField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULEPT_APP_META PT_APP_META
        {
            get
            {
                return this.pT_APP_METAField;
            }
            set
            {
                this.pT_APP_METAField = value;
            }
        }

        /// <remarks/>
        public object PASSWORD
        {
            get
            {
                return this.pASSWORDField;
            }
            set
            {
                this.pASSWORDField = value;
            }
        }

        /// <remarks/>
        public bool OPEN_IF_DENIED
        {
            get
            {
                return this.oPEN_IF_DENIEDField;
            }
            set
            {
                this.oPEN_IF_DENIEDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULESCRIPTS SCRIPTS
        {
            get
            {
                return this.sCRIPTSField;
            }
            set
            {
                this.sCRIPTSField = value;
            }
        }

        /// <remarks/>
        public object INTERFACES
        {
            get
            {
                return this.iNTERFACESField;
            }
            set
            {
                this.iNTERFACESField = value;
            }
        }

        /// <remarks/>
        public object NEW_DEVICE_CUSTOM_INTERFACES
        {
            get
            {
                return this.nEW_DEVICE_CUSTOM_INTERFACESField;
            }
            set
            {
                this.nEW_DEVICE_CUSTOM_INTERFACESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULEPT_APP_META
    {

        private object pT_VERSIONField;

        private object iPC_VERSIONField;

        private object nAMEField;

        private object vERSIONField;

        private object idField;

        private object dESCRIPTIONField;

        private object aUTHORField;

        private object cONTACTField;

        private object eXECUTABLE_PATHField;

        private bool dETACHEDField;

        private object kEYField;

        private object sECURITY_SETTINGSField;

        private string lOADINGField;

        private string sAVINGField;

        private byte iNSTANCESField;

        private bool mANDATORYField;

        /// <remarks/>
        public object PT_VERSION
        {
            get
            {
                return this.pT_VERSIONField;
            }
            set
            {
                this.pT_VERSIONField = value;
            }
        }

        /// <remarks/>
        public object IPC_VERSION
        {
            get
            {
                return this.iPC_VERSIONField;
            }
            set
            {
                this.iPC_VERSIONField = value;
            }
        }

        /// <remarks/>
        public object NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public object VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        public object ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public object AUTHOR
        {
            get
            {
                return this.aUTHORField;
            }
            set
            {
                this.aUTHORField = value;
            }
        }

        /// <remarks/>
        public object CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public object EXECUTABLE_PATH
        {
            get
            {
                return this.eXECUTABLE_PATHField;
            }
            set
            {
                this.eXECUTABLE_PATHField = value;
            }
        }

        /// <remarks/>
        public bool DETACHED
        {
            get
            {
                return this.dETACHEDField;
            }
            set
            {
                this.dETACHEDField = value;
            }
        }

        /// <remarks/>
        public object KEY
        {
            get
            {
                return this.kEYField;
            }
            set
            {
                this.kEYField = value;
            }
        }

        /// <remarks/>
        public object SECURITY_SETTINGS
        {
            get
            {
                return this.sECURITY_SETTINGSField;
            }
            set
            {
                this.sECURITY_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public string LOADING
        {
            get
            {
                return this.lOADINGField;
            }
            set
            {
                this.lOADINGField = value;
            }
        }

        /// <remarks/>
        public string SAVING
        {
            get
            {
                return this.sAVINGField;
            }
            set
            {
                this.sAVINGField = value;
            }
        }

        /// <remarks/>
        public byte INSTANCES
        {
            get
            {
                return this.iNSTANCESField;
            }
            set
            {
                this.iNSTANCESField = value;
            }
        }

        /// <remarks/>
        public bool MANDATORY
        {
            get
            {
                return this.mANDATORYField;
            }
            set
            {
                this.mANDATORYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYPACKETTRACER5SCRIPT_MODULESCRIPTS
    {

        private object sCRIPT_DATA_STORESField;

        /// <remarks/>
        public object SCRIPT_DATA_STORES
        {
            get
            {
                return this.sCRIPT_DATA_STORESField;
            }
            set
            {
                this.sCRIPT_DATA_STORESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONS
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODE nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENAME nAMEField;

        private string idField;

        private object cOMPONENTSField;

        private object pOINTSField;

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public object POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private byte pOINTSField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public byte POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYCOMPARISONSNODENODENODENODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUP
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODE nODEField;

        private bool lOAD_INIT_TREEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        public bool LOAD_INIT_TREE
        {
            get
            {
                return this.lOAD_INIT_TREEField;
            }
            set
            {
                this.lOAD_INIT_TREEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODE
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENAME nAMEField;

        private string idField;

        private object cOMPONENTSField;

        private object pOINTSField;

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public object POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODE
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENAME nAMEField;

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODEID idField;

        private object cOMPONENTSField;

        private object pOINTSField;

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODEID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public object POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODEID
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODE
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private string pOINTSField;

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODE[] nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public string POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private byte pOINTSField;

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENODE nODEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public byte POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENODENAME nAMEField;

        private string idField;

        private string cOMPONENTSField;

        private byte pOINTSField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENODENAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string COMPONENTS
        {
            get
            {
                return this.cOMPONENTSField;
            }
            set
            {
                this.cOMPONENTSField = value;
            }
        }

        /// <remarks/>
        public byte POINTS
        {
            get
            {
                return this.pOINTSField;
            }
            set
            {
                this.pOINTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYINITIALSETUPNODENODENODENODENODENODENAME
    {

        private bool variableEnabledField;

        private string nodeValueField;

        private string variableNameField;

        private byte eclassField;

        private bool headNodeField;

        private byte checkTypeField;

        private string incorrectFeedbackField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool variableEnabled
        {
            get
            {
                return this.variableEnabledField;
            }
            set
            {
                this.variableEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeValue
        {
            get
            {
                return this.nodeValueField;
            }
            set
            {
                this.nodeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte eclass
        {
            get
            {
                return this.eclassField;
            }
            set
            {
                this.eclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool headNode
        {
            get
            {
                return this.headNodeField;
            }
            set
            {
                this.headNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte checkType
        {
            get
            {
                return this.checkTypeField;
            }
            set
            {
                this.checkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string incorrectFeedback
        {
            get
            {
                return this.incorrectFeedbackField;
            }
            set
            {
                this.incorrectFeedbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREE
    {

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODE nODEField;

        private string enabledField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODE
    {

        private string idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODE[] nODEField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODE
    {

        private string idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODE[] nODEField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODE
    {

        private string idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODE[] nODEField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODE
    {

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODEID idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODE[] nODEField;

        private string onField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODEID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODEID
    {

        private bool translateField;

        private bool translateFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool translateSpecified
        {
            get
            {
                return this.translateFieldSpecified;
            }
            set
            {
                this.translateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODE
    {

        private string idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODE[] nODEField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODE
    {

        private string idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODENODE[] nODEField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NODE")]
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODENODE[] NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODENODE
    {

        private string idField;

        private string tEXTField;

        private PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODENODENODE nODEField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODENODENODE NODE
        {
            get
            {
                return this.nODEField;
            }
            set
            {
                this.nODEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYLOCKINGTREENODENODENODENODENODENODENODENODE
    {

        private string idField;

        private string tEXTField;

        private string onField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string TEXT
        {
            get
            {
                return this.tEXTField;
            }
            set
            {
                this.tEXTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONS
    {

        private string lANGUAGEField;

        private bool aNIMATIONField;

        private bool lOGICALALIGNField;

        private bool pHYSICALALIGNField;

        private bool sOUNDField;

        private bool tELEPHONESOUNDField;

        private bool dOCKField;

        private bool lOGGINGField;

        private object pASSField;

        private string cONFIGPATHField;

        private bool mODELSHOWNField;

        private bool lINKLIGHTSSHOWNField;

        private bool pORTSHOWNField;

        private object bACKGROUNDSField;

        private bool hIDEPHYSICALField;

        private bool hIDEATTRIBUTESField;

        private bool hIDECONFIGField;

        private bool hIDECONFIGOFROUTERANDSWITCHField;

        private bool hIDECLIOFROUTERANDSWITCHField;

        private bool hIDESERVICESField;

        private bool hIDECLIField;

        private bool hIDEDESKTOPField;

        private bool hIDEGUIField;

        private bool hIDEDEVICELABELField;

        private bool bUFFER_FILTERED_EVENTS_ONLYField;

        private bool aCCESSIBLEField;

        private PACKETTRACER5_ACTIVITYOPTIONSCOLOR cOLORField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONT fONTField;

        private byte bUFFER_FULL_ACTIONField;

        private PACKETTRACER5_ACTIVITYOPTIONSMULTIUSER mULTIUSERField;

        private PACKETTRACER5_ACTIVITYOPTIONSIPC_MANAGER iPC_MANAGERField;

        private bool iPC_ALLOWREMOTEAPPSField;

        private string[] rECENT_FILESField;

        private bool pORTNOTSHOWNONMOUSEOVERField;

        private string iNTERFACE_LOCKField;

        private PACKETTRACER5_ACTIVITYOPTIONSALGORITHM_SETTINGS aLGORITHM_SETTINGSField;

        private bool hIDEQOSSTAMPField;

        private bool iPCLISTENSTARTUPField;

        private bool eNABLE_CABLE_LENGTH_EFFECTSField;

        private bool dISABLE_AUTO_CABLEField;

        private bool uSE_METRICField;

        private bool sHOW_DEV_TASKBARField;

        private bool eNABLE_EXTERNAL_NETWORK_ACCESSField;

        private bool sHOW_WIRELESS_GRIDField;

        private bool fILL_WIRELESS_GRIDField;

        private bool hIDE_WIRELESS_COVERAGE_RANGEField;

        private bool sHOW_BOTTOM_TOOLBARField;

        private bool sHOW_RIGHT_TOOLBARField;

        private bool sHOW_MAIN_TOOLBARField;

        private bool sHOW_DEV_MODEL_LABELField;

        private PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGER sCRIPT_MODULE_MANAGERField;

        private bool uSE_CLI_DEFAULT_TABField;

        private object nEW_DEVICE_CUSTOM_INTERFACESField;

        private object cUSTOM_HIDE_OPTIONSField;

        private bool hIDE_WIRELESS_CONNECTIONField;

        private bool hIDE_LEGACY_EQUIPMENTField;

        private bool tHING_ADVANCED_MODE_DEFAULTField;

        private bool cABLE_POPUP_IN_PHYSICALField;

        private byte gUEST_SAVES_COUNTField;

        private byte aUTOSAVE_INTERVALField;

        private byte aNSWER_TREE_SELECTEDField;

        private uint lAST_LOGON_TIMEField;

        private object aNSWER_TREE_CHECK_BOXField;

        private PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGER uSER_APP_MANAGERField;

        private string cOLORSCHEMEField;

        /// <remarks/>
        public string LANGUAGE
        {
            get
            {
                return this.lANGUAGEField;
            }
            set
            {
                this.lANGUAGEField = value;
            }
        }

        /// <remarks/>
        public bool ANIMATION
        {
            get
            {
                return this.aNIMATIONField;
            }
            set
            {
                this.aNIMATIONField = value;
            }
        }

        /// <remarks/>
        public bool LOGICALALIGN
        {
            get
            {
                return this.lOGICALALIGNField;
            }
            set
            {
                this.lOGICALALIGNField = value;
            }
        }

        /// <remarks/>
        public bool PHYSICALALIGN
        {
            get
            {
                return this.pHYSICALALIGNField;
            }
            set
            {
                this.pHYSICALALIGNField = value;
            }
        }

        /// <remarks/>
        public bool SOUND
        {
            get
            {
                return this.sOUNDField;
            }
            set
            {
                this.sOUNDField = value;
            }
        }

        /// <remarks/>
        public bool TELEPHONESOUND
        {
            get
            {
                return this.tELEPHONESOUNDField;
            }
            set
            {
                this.tELEPHONESOUNDField = value;
            }
        }

        /// <remarks/>
        public bool DOCK
        {
            get
            {
                return this.dOCKField;
            }
            set
            {
                this.dOCKField = value;
            }
        }

        /// <remarks/>
        public bool LOGGING
        {
            get
            {
                return this.lOGGINGField;
            }
            set
            {
                this.lOGGINGField = value;
            }
        }

        /// <remarks/>
        public object PASS
        {
            get
            {
                return this.pASSField;
            }
            set
            {
                this.pASSField = value;
            }
        }

        /// <remarks/>
        public string CONFIGPATH
        {
            get
            {
                return this.cONFIGPATHField;
            }
            set
            {
                this.cONFIGPATHField = value;
            }
        }

        /// <remarks/>
        public bool MODELSHOWN
        {
            get
            {
                return this.mODELSHOWNField;
            }
            set
            {
                this.mODELSHOWNField = value;
            }
        }

        /// <remarks/>
        public bool LINKLIGHTSSHOWN
        {
            get
            {
                return this.lINKLIGHTSSHOWNField;
            }
            set
            {
                this.lINKLIGHTSSHOWNField = value;
            }
        }

        /// <remarks/>
        public bool PORTSHOWN
        {
            get
            {
                return this.pORTSHOWNField;
            }
            set
            {
                this.pORTSHOWNField = value;
            }
        }

        /// <remarks/>
        public object BACKGROUNDS
        {
            get
            {
                return this.bACKGROUNDSField;
            }
            set
            {
                this.bACKGROUNDSField = value;
            }
        }

        /// <remarks/>
        public bool HIDEPHYSICAL
        {
            get
            {
                return this.hIDEPHYSICALField;
            }
            set
            {
                this.hIDEPHYSICALField = value;
            }
        }

        /// <remarks/>
        public bool HIDEATTRIBUTES
        {
            get
            {
                return this.hIDEATTRIBUTESField;
            }
            set
            {
                this.hIDEATTRIBUTESField = value;
            }
        }

        /// <remarks/>
        public bool HIDECONFIG
        {
            get
            {
                return this.hIDECONFIGField;
            }
            set
            {
                this.hIDECONFIGField = value;
            }
        }

        /// <remarks/>
        public bool HIDECONFIGOFROUTERANDSWITCH
        {
            get
            {
                return this.hIDECONFIGOFROUTERANDSWITCHField;
            }
            set
            {
                this.hIDECONFIGOFROUTERANDSWITCHField = value;
            }
        }

        /// <remarks/>
        public bool HIDECLIOFROUTERANDSWITCH
        {
            get
            {
                return this.hIDECLIOFROUTERANDSWITCHField;
            }
            set
            {
                this.hIDECLIOFROUTERANDSWITCHField = value;
            }
        }

        /// <remarks/>
        public bool HIDESERVICES
        {
            get
            {
                return this.hIDESERVICESField;
            }
            set
            {
                this.hIDESERVICESField = value;
            }
        }

        /// <remarks/>
        public bool HIDECLI
        {
            get
            {
                return this.hIDECLIField;
            }
            set
            {
                this.hIDECLIField = value;
            }
        }

        /// <remarks/>
        public bool HIDEDESKTOP
        {
            get
            {
                return this.hIDEDESKTOPField;
            }
            set
            {
                this.hIDEDESKTOPField = value;
            }
        }

        /// <remarks/>
        public bool HIDEGUI
        {
            get
            {
                return this.hIDEGUIField;
            }
            set
            {
                this.hIDEGUIField = value;
            }
        }

        /// <remarks/>
        public bool HIDEDEVICELABEL
        {
            get
            {
                return this.hIDEDEVICELABELField;
            }
            set
            {
                this.hIDEDEVICELABELField = value;
            }
        }

        /// <remarks/>
        public bool BUFFER_FILTERED_EVENTS_ONLY
        {
            get
            {
                return this.bUFFER_FILTERED_EVENTS_ONLYField;
            }
            set
            {
                this.bUFFER_FILTERED_EVENTS_ONLYField = value;
            }
        }

        /// <remarks/>
        public bool ACCESSIBLE
        {
            get
            {
                return this.aCCESSIBLEField;
            }
            set
            {
                this.aCCESSIBLEField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLOR COLOR
        {
            get
            {
                return this.cOLORField;
            }
            set
            {
                this.cOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONT FONT
        {
            get
            {
                return this.fONTField;
            }
            set
            {
                this.fONTField = value;
            }
        }

        /// <remarks/>
        public byte BUFFER_FULL_ACTION
        {
            get
            {
                return this.bUFFER_FULL_ACTIONField;
            }
            set
            {
                this.bUFFER_FULL_ACTIONField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSMULTIUSER MULTIUSER
        {
            get
            {
                return this.mULTIUSERField;
            }
            set
            {
                this.mULTIUSERField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSIPC_MANAGER IPC_MANAGER
        {
            get
            {
                return this.iPC_MANAGERField;
            }
            set
            {
                this.iPC_MANAGERField = value;
            }
        }

        /// <remarks/>
        public bool IPC_ALLOWREMOTEAPPS
        {
            get
            {
                return this.iPC_ALLOWREMOTEAPPSField;
            }
            set
            {
                this.iPC_ALLOWREMOTEAPPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FILE", IsNullable = false)]
        public string[] RECENT_FILES
        {
            get
            {
                return this.rECENT_FILESField;
            }
            set
            {
                this.rECENT_FILESField = value;
            }
        }

        /// <remarks/>
        public bool PORTNOTSHOWNONMOUSEOVER
        {
            get
            {
                return this.pORTNOTSHOWNONMOUSEOVERField;
            }
            set
            {
                this.pORTNOTSHOWNONMOUSEOVERField = value;
            }
        }

        /// <remarks/>
        public string INTERFACE_LOCK
        {
            get
            {
                return this.iNTERFACE_LOCKField;
            }
            set
            {
                this.iNTERFACE_LOCKField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSALGORITHM_SETTINGS ALGORITHM_SETTINGS
        {
            get
            {
                return this.aLGORITHM_SETTINGSField;
            }
            set
            {
                this.aLGORITHM_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public bool HIDEQOSSTAMP
        {
            get
            {
                return this.hIDEQOSSTAMPField;
            }
            set
            {
                this.hIDEQOSSTAMPField = value;
            }
        }

        /// <remarks/>
        public bool IPCLISTENSTARTUP
        {
            get
            {
                return this.iPCLISTENSTARTUPField;
            }
            set
            {
                this.iPCLISTENSTARTUPField = value;
            }
        }

        /// <remarks/>
        public bool ENABLE_CABLE_LENGTH_EFFECTS
        {
            get
            {
                return this.eNABLE_CABLE_LENGTH_EFFECTSField;
            }
            set
            {
                this.eNABLE_CABLE_LENGTH_EFFECTSField = value;
            }
        }

        /// <remarks/>
        public bool DISABLE_AUTO_CABLE
        {
            get
            {
                return this.dISABLE_AUTO_CABLEField;
            }
            set
            {
                this.dISABLE_AUTO_CABLEField = value;
            }
        }

        /// <remarks/>
        public bool USE_METRIC
        {
            get
            {
                return this.uSE_METRICField;
            }
            set
            {
                this.uSE_METRICField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_DEV_TASKBAR
        {
            get
            {
                return this.sHOW_DEV_TASKBARField;
            }
            set
            {
                this.sHOW_DEV_TASKBARField = value;
            }
        }

        /// <remarks/>
        public bool ENABLE_EXTERNAL_NETWORK_ACCESS
        {
            get
            {
                return this.eNABLE_EXTERNAL_NETWORK_ACCESSField;
            }
            set
            {
                this.eNABLE_EXTERNAL_NETWORK_ACCESSField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_WIRELESS_GRID
        {
            get
            {
                return this.sHOW_WIRELESS_GRIDField;
            }
            set
            {
                this.sHOW_WIRELESS_GRIDField = value;
            }
        }

        /// <remarks/>
        public bool FILL_WIRELESS_GRID
        {
            get
            {
                return this.fILL_WIRELESS_GRIDField;
            }
            set
            {
                this.fILL_WIRELESS_GRIDField = value;
            }
        }

        /// <remarks/>
        public bool HIDE_WIRELESS_COVERAGE_RANGE
        {
            get
            {
                return this.hIDE_WIRELESS_COVERAGE_RANGEField;
            }
            set
            {
                this.hIDE_WIRELESS_COVERAGE_RANGEField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_BOTTOM_TOOLBAR
        {
            get
            {
                return this.sHOW_BOTTOM_TOOLBARField;
            }
            set
            {
                this.sHOW_BOTTOM_TOOLBARField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_RIGHT_TOOLBAR
        {
            get
            {
                return this.sHOW_RIGHT_TOOLBARField;
            }
            set
            {
                this.sHOW_RIGHT_TOOLBARField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_MAIN_TOOLBAR
        {
            get
            {
                return this.sHOW_MAIN_TOOLBARField;
            }
            set
            {
                this.sHOW_MAIN_TOOLBARField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_DEV_MODEL_LABEL
        {
            get
            {
                return this.sHOW_DEV_MODEL_LABELField;
            }
            set
            {
                this.sHOW_DEV_MODEL_LABELField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGER SCRIPT_MODULE_MANAGER
        {
            get
            {
                return this.sCRIPT_MODULE_MANAGERField;
            }
            set
            {
                this.sCRIPT_MODULE_MANAGERField = value;
            }
        }

        /// <remarks/>
        public bool USE_CLI_DEFAULT_TAB
        {
            get
            {
                return this.uSE_CLI_DEFAULT_TABField;
            }
            set
            {
                this.uSE_CLI_DEFAULT_TABField = value;
            }
        }

        /// <remarks/>
        public object NEW_DEVICE_CUSTOM_INTERFACES
        {
            get
            {
                return this.nEW_DEVICE_CUSTOM_INTERFACESField;
            }
            set
            {
                this.nEW_DEVICE_CUSTOM_INTERFACESField = value;
            }
        }

        /// <remarks/>
        public object CUSTOM_HIDE_OPTIONS
        {
            get
            {
                return this.cUSTOM_HIDE_OPTIONSField;
            }
            set
            {
                this.cUSTOM_HIDE_OPTIONSField = value;
            }
        }

        /// <remarks/>
        public bool HIDE_WIRELESS_CONNECTION
        {
            get
            {
                return this.hIDE_WIRELESS_CONNECTIONField;
            }
            set
            {
                this.hIDE_WIRELESS_CONNECTIONField = value;
            }
        }

        /// <remarks/>
        public bool HIDE_LEGACY_EQUIPMENT
        {
            get
            {
                return this.hIDE_LEGACY_EQUIPMENTField;
            }
            set
            {
                this.hIDE_LEGACY_EQUIPMENTField = value;
            }
        }

        /// <remarks/>
        public bool THING_ADVANCED_MODE_DEFAULT
        {
            get
            {
                return this.tHING_ADVANCED_MODE_DEFAULTField;
            }
            set
            {
                this.tHING_ADVANCED_MODE_DEFAULTField = value;
            }
        }

        /// <remarks/>
        public bool CABLE_POPUP_IN_PHYSICAL
        {
            get
            {
                return this.cABLE_POPUP_IN_PHYSICALField;
            }
            set
            {
                this.cABLE_POPUP_IN_PHYSICALField = value;
            }
        }

        /// <remarks/>
        public byte GUEST_SAVES_COUNT
        {
            get
            {
                return this.gUEST_SAVES_COUNTField;
            }
            set
            {
                this.gUEST_SAVES_COUNTField = value;
            }
        }

        /// <remarks/>
        public byte AUTOSAVE_INTERVAL
        {
            get
            {
                return this.aUTOSAVE_INTERVALField;
            }
            set
            {
                this.aUTOSAVE_INTERVALField = value;
            }
        }

        /// <remarks/>
        public byte ANSWER_TREE_SELECTED
        {
            get
            {
                return this.aNSWER_TREE_SELECTEDField;
            }
            set
            {
                this.aNSWER_TREE_SELECTEDField = value;
            }
        }

        /// <remarks/>
        public uint LAST_LOGON_TIME
        {
            get
            {
                return this.lAST_LOGON_TIMEField;
            }
            set
            {
                this.lAST_LOGON_TIMEField = value;
            }
        }

        /// <remarks/>
        public object ANSWER_TREE_CHECK_BOX
        {
            get
            {
                return this.aNSWER_TREE_CHECK_BOXField;
            }
            set
            {
                this.aNSWER_TREE_CHECK_BOXField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGER USER_APP_MANAGER
        {
            get
            {
                return this.uSER_APP_MANAGERField;
            }
            set
            {
                this.uSER_APP_MANAGERField = value;
            }
        }

        /// <remarks/>
        public string COLORSCHEME
        {
            get
            {
                return this.cOLORSCHEMEField;
            }
            set
            {
                this.cOLORSCHEMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLOR
    {

        private PACKETTRACER5_ACTIVITYOPTIONSCOLORIOSTEXTCOLOR iOSTEXTCOLORField;

        private PACKETTRACER5_ACTIVITYOPTIONSCOLORIOSBACKGROUNDCOLOR iOSBACKGROUNDCOLORField;

        private PACKETTRACER5_ACTIVITYOPTIONSCOLORCONSOLETEXTCOLOR cONSOLETEXTCOLORField;

        private PACKETTRACER5_ACTIVITYOPTIONSCOLORCONSOLEBACKGROUNDCOLOR cONSOLEBACKGROUNDCOLORField;

        private PACKETTRACER5_ACTIVITYOPTIONSCOLORTOOLTIPBACKGROUNDCOLOR tOOLTIPBACKGROUNDCOLORField;

        private PACKETTRACER5_ACTIVITYOPTIONSCOLORTOOLTIPTEXTCOLOR tOOLTIPTEXTCOLORField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLORIOSTEXTCOLOR IOSTEXTCOLOR
        {
            get
            {
                return this.iOSTEXTCOLORField;
            }
            set
            {
                this.iOSTEXTCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLORIOSBACKGROUNDCOLOR IOSBACKGROUNDCOLOR
        {
            get
            {
                return this.iOSBACKGROUNDCOLORField;
            }
            set
            {
                this.iOSBACKGROUNDCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLORCONSOLETEXTCOLOR CONSOLETEXTCOLOR
        {
            get
            {
                return this.cONSOLETEXTCOLORField;
            }
            set
            {
                this.cONSOLETEXTCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLORCONSOLEBACKGROUNDCOLOR CONSOLEBACKGROUNDCOLOR
        {
            get
            {
                return this.cONSOLEBACKGROUNDCOLORField;
            }
            set
            {
                this.cONSOLEBACKGROUNDCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLORTOOLTIPBACKGROUNDCOLOR TOOLTIPBACKGROUNDCOLOR
        {
            get
            {
                return this.tOOLTIPBACKGROUNDCOLORField;
            }
            set
            {
                this.tOOLTIPBACKGROUNDCOLORField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSCOLORTOOLTIPTEXTCOLOR TOOLTIPTEXTCOLOR
        {
            get
            {
                return this.tOOLTIPTEXTCOLORField;
            }
            set
            {
                this.tOOLTIPTEXTCOLORField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLORIOSTEXTCOLOR
    {

        private string iosTextColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string iosTextColor
        {
            get
            {
                return this.iosTextColorField;
            }
            set
            {
                this.iosTextColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLORIOSBACKGROUNDCOLOR
    {

        private string iosBackgroundColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string iosBackgroundColor
        {
            get
            {
                return this.iosBackgroundColorField;
            }
            set
            {
                this.iosBackgroundColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLORCONSOLETEXTCOLOR
    {

        private string consoleTextColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string consoleTextColor
        {
            get
            {
                return this.consoleTextColorField;
            }
            set
            {
                this.consoleTextColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLORCONSOLEBACKGROUNDCOLOR
    {

        private string consoleBackgroundColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string consoleBackgroundColor
        {
            get
            {
                return this.consoleBackgroundColorField;
            }
            set
            {
                this.consoleBackgroundColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLORTOOLTIPBACKGROUNDCOLOR
    {

        private string tooltipBackgroundColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tooltipBackgroundColor
        {
            get
            {
                return this.tooltipBackgroundColorField;
            }
            set
            {
                this.tooltipBackgroundColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSCOLORTOOLTIPTEXTCOLOR
    {

        private string tooltipTextColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tooltipTextColor
        {
            get
            {
                return this.tooltipTextColorField;
            }
            set
            {
                this.tooltipTextColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONT
    {

        private PACKETTRACER5_ACTIVITYOPTIONSFONTCLIFONT cLIFONTField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTHEADERFONT hEADERFONTField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTWORKSPACEFONT wORKSPACEFONTField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTACTIVITYFONT aCTIVITYFONTField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTFILEMENUFONT fILEMENUFONTField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTTABSWITCH tABSWITCHField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTTOOLTIP tOOLTIPField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTBUTTONLABELS bUTTONLABELSField;

        private PACKETTRACER5_ACTIVITYOPTIONSFONTAPPLICATION aPPLICATIONField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTCLIFONT CLIFONT
        {
            get
            {
                return this.cLIFONTField;
            }
            set
            {
                this.cLIFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTHEADERFONT HEADERFONT
        {
            get
            {
                return this.hEADERFONTField;
            }
            set
            {
                this.hEADERFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTWORKSPACEFONT WORKSPACEFONT
        {
            get
            {
                return this.wORKSPACEFONTField;
            }
            set
            {
                this.wORKSPACEFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTACTIVITYFONT ACTIVITYFONT
        {
            get
            {
                return this.aCTIVITYFONTField;
            }
            set
            {
                this.aCTIVITYFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTFILEMENUFONT FILEMENUFONT
        {
            get
            {
                return this.fILEMENUFONTField;
            }
            set
            {
                this.fILEMENUFONTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTTABSWITCH TABSWITCH
        {
            get
            {
                return this.tABSWITCHField;
            }
            set
            {
                this.tABSWITCHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTTOOLTIP TOOLTIP
        {
            get
            {
                return this.tOOLTIPField;
            }
            set
            {
                this.tOOLTIPField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTBUTTONLABELS BUTTONLABELS
        {
            get
            {
                return this.bUTTONLABELSField;
            }
            set
            {
                this.bUTTONLABELSField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSFONTAPPLICATION APPLICATION
        {
            get
            {
                return this.aPPLICATIONField;
            }
            set
            {
                this.aPPLICATIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTCLIFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTHEADERFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTWORKSPACEFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTACTIVITYFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTFILEMENUFONT
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTTABSWITCH
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTTOOLTIP
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTBUTTONLABELS
    {

        private string familyField;

        private byte pointsizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pointsize
        {
            get
            {
                return this.pointsizeField;
            }
            set
            {
                this.pointsizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSFONTAPPLICATION
    {

        private byte scaleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSMULTIUSER
    {

        private object nAMEField;

        private bool aLLOWREMOTESAVINGField;

        private bool aLWAYSLISTENATSTARTUPField;

        private bool sHOW_CONNECTED_PORT_NAMESField;

        private PACKETTRACER5_ACTIVITYOPTIONSMULTIUSERMU_PEERS mU_PEERSField;

        private byte rEMOTE_SAVING_DEPTHField;

        private string mU_PASSWORDField;

        private byte mU_ACCEPT_MODEField;

        private byte mU_NEW_RNET_ACCEPT_MODEField;

        private bool mU_ALLOW_PTMP_BROADCASTField;

        /// <remarks/>
        public object NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public bool ALLOWREMOTESAVING
        {
            get
            {
                return this.aLLOWREMOTESAVINGField;
            }
            set
            {
                this.aLLOWREMOTESAVINGField = value;
            }
        }

        /// <remarks/>
        public bool ALWAYSLISTENATSTARTUP
        {
            get
            {
                return this.aLWAYSLISTENATSTARTUPField;
            }
            set
            {
                this.aLWAYSLISTENATSTARTUPField = value;
            }
        }

        /// <remarks/>
        public bool SHOW_CONNECTED_PORT_NAMES
        {
            get
            {
                return this.sHOW_CONNECTED_PORT_NAMESField;
            }
            set
            {
                this.sHOW_CONNECTED_PORT_NAMESField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSMULTIUSERMU_PEERS MU_PEERS
        {
            get
            {
                return this.mU_PEERSField;
            }
            set
            {
                this.mU_PEERSField = value;
            }
        }

        /// <remarks/>
        public byte REMOTE_SAVING_DEPTH
        {
            get
            {
                return this.rEMOTE_SAVING_DEPTHField;
            }
            set
            {
                this.rEMOTE_SAVING_DEPTHField = value;
            }
        }

        /// <remarks/>
        public string MU_PASSWORD
        {
            get
            {
                return this.mU_PASSWORDField;
            }
            set
            {
                this.mU_PASSWORDField = value;
            }
        }

        /// <remarks/>
        public byte MU_ACCEPT_MODE
        {
            get
            {
                return this.mU_ACCEPT_MODEField;
            }
            set
            {
                this.mU_ACCEPT_MODEField = value;
            }
        }

        /// <remarks/>
        public byte MU_NEW_RNET_ACCEPT_MODE
        {
            get
            {
                return this.mU_NEW_RNET_ACCEPT_MODEField;
            }
            set
            {
                this.mU_NEW_RNET_ACCEPT_MODEField = value;
            }
        }

        /// <remarks/>
        public bool MU_ALLOW_PTMP_BROADCAST
        {
            get
            {
                return this.mU_ALLOW_PTMP_BROADCASTField;
            }
            set
            {
                this.mU_ALLOW_PTMP_BROADCASTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSMULTIUSERMU_PEERS
    {

        private string pEERField;

        /// <remarks/>
        public string PEER
        {
            get
            {
                return this.pEERField;
            }
            set
            {
                this.pEERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSIPC_MANAGER
    {

        private string[] mETAFILE_PATHField;

        private object dISABLED_CEPSField;

        private string[] tRUSTED_PUBLISHERSField;

        private object uNTRUSTED_PUBLISHERSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("METAFILE_PATH")]
        public string[] METAFILE_PATH
        {
            get
            {
                return this.mETAFILE_PATHField;
            }
            set
            {
                this.mETAFILE_PATHField = value;
            }
        }

        /// <remarks/>
        public object DISABLED_CEPS
        {
            get
            {
                return this.dISABLED_CEPSField;
            }
            set
            {
                this.dISABLED_CEPSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CERTIFICATE", IsNullable = false)]
        public string[] TRUSTED_PUBLISHERS
        {
            get
            {
                return this.tRUSTED_PUBLISHERSField;
            }
            set
            {
                this.tRUSTED_PUBLISHERSField = value;
            }
        }

        /// <remarks/>
        public object UNTRUSTED_PUBLISHERS
        {
            get
            {
                return this.uNTRUSTED_PUBLISHERSField;
            }
            set
            {
                this.uNTRUSTED_PUBLISHERSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSALGORITHM_SETTINGS
    {

        private bool uSE_GLOBALField;

        private byte cBAC_HALF_OPEN_SESSION_MULTIPLIERField;

        private byte tCP_MAX_CONNECTING_SESSIONSField;

        private ushort tCP_MAX_OPENED_SESSIONSField;

        private byte iNTERFACE_QUEUE_SIZEField;

        private byte sTORM_CONTROL_MULTIPLIERField;

        private ushort tCP_MAX_RETRANSMISSION_TIMEOUTField;

        /// <remarks/>
        public bool USE_GLOBAL
        {
            get
            {
                return this.uSE_GLOBALField;
            }
            set
            {
                this.uSE_GLOBALField = value;
            }
        }

        /// <remarks/>
        public byte CBAC_HALF_OPEN_SESSION_MULTIPLIER
        {
            get
            {
                return this.cBAC_HALF_OPEN_SESSION_MULTIPLIERField;
            }
            set
            {
                this.cBAC_HALF_OPEN_SESSION_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public byte TCP_MAX_CONNECTING_SESSIONS
        {
            get
            {
                return this.tCP_MAX_CONNECTING_SESSIONSField;
            }
            set
            {
                this.tCP_MAX_CONNECTING_SESSIONSField = value;
            }
        }

        /// <remarks/>
        public ushort TCP_MAX_OPENED_SESSIONS
        {
            get
            {
                return this.tCP_MAX_OPENED_SESSIONSField;
            }
            set
            {
                this.tCP_MAX_OPENED_SESSIONSField = value;
            }
        }

        /// <remarks/>
        public byte INTERFACE_QUEUE_SIZE
        {
            get
            {
                return this.iNTERFACE_QUEUE_SIZEField;
            }
            set
            {
                this.iNTERFACE_QUEUE_SIZEField = value;
            }
        }

        /// <remarks/>
        public byte STORM_CONTROL_MULTIPLIER
        {
            get
            {
                return this.sTORM_CONTROL_MULTIPLIERField;
            }
            set
            {
                this.sTORM_CONTROL_MULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public ushort TCP_MAX_RETRANSMISSION_TIMEOUT
        {
            get
            {
                return this.tCP_MAX_RETRANSMISSION_TIMEOUTField;
            }
            set
            {
                this.tCP_MAX_RETRANSMISSION_TIMEOUTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGER
    {

        private PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULE[] sCRIPT_MODULESField;

        private object dISABLED_SCRIPT_MODULESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SCRIPT_MODULE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULE[] SCRIPT_MODULES
        {
            get
            {
                return this.sCRIPT_MODULESField;
            }
            set
            {
                this.sCRIPT_MODULESField = value;
            }
        }

        /// <remarks/>
        public object DISABLED_SCRIPT_MODULES
        {
            get
            {
                return this.dISABLED_SCRIPT_MODULESField;
            }
            set
            {
                this.dISABLED_SCRIPT_MODULESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULE
    {

        private string fILE_PATHField;

        private PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATA sCRIPT_MODULE_DATAField;

        /// <remarks/>
        public string FILE_PATH
        {
            get
            {
                return this.fILE_PATHField;
            }
            set
            {
                this.fILE_PATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATA SCRIPT_MODULE_DATA
        {
            get
            {
                return this.sCRIPT_MODULE_DATAField;
            }
            set
            {
                this.sCRIPT_MODULE_DATAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATA
    {

        private PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATADATA_STORE[] sCRIPT_DATA_STORESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DATA_STORE", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATADATA_STORE[] SCRIPT_DATA_STORES
        {
            get
            {
                return this.sCRIPT_DATA_STORESField;
            }
            set
            {
                this.sCRIPT_DATA_STORESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSSCRIPT_MODULE_MANAGERSCRIPT_MODULESCRIPT_MODULE_DATADATA_STORE
    {

        private string idField;

        private string cONTENTField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string CONTENT
        {
            get
            {
                return this.cONTENTField;
            }
            set
            {
                this.cONTENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGER
    {

        private PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APP[] gLOBAL_APPSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("USER_APP", IsNullable = false)]
        public PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APP[] GLOBAL_APPS
        {
            get
            {
                return this.gLOBAL_APPSField;
            }
            set
            {
                this.gLOBAL_APPSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APP
    {

        private string fILE_PATHField;

        private PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APPSETTINGS sETTINGSField;

        /// <remarks/>
        public string FILE_PATH
        {
            get
            {
                return this.fILE_PATHField;
            }
            set
            {
                this.fILE_PATHField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APPSETTINGS SETTINGS
        {
            get
            {
                return this.sETTINGSField;
            }
            set
            {
                this.sETTINGSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APPSETTINGS
    {

        private PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APPSETTINGSSettings settingsField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APPSETTINGSSettings settings
        {
            get
            {
                return this.settingsField;
            }
            set
            {
                this.settingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOPTIONSUSER_APP_MANAGERUSER_APPSETTINGSSettings
    {

        private object autoinstallField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("auto-install")]
        public object autoinstall
        {
            get
            {
                return this.autoinstallField;
            }
            set
            {
                this.autoinstallField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYACTIVITY
    {

        private PACKETTRACER5_ACTIVITYACTIVITYINSTRUCTIONS iNSTRUCTIONSField;

        private byte tIMERTYPEField;

        private string eNABLEDField;

        private string pASSField;

        private byte fORWARD_ANS_SIM_MSField;

        private string vALUEField;

        private ushort cOUNTDOWNMSField;

        private ushort eLAPSEDField;

        private ushort cOUNTDOWNLEFTField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYACTIVITYINSTRUCTIONS INSTRUCTIONS
        {
            get
            {
                return this.iNSTRUCTIONSField;
            }
            set
            {
                this.iNSTRUCTIONSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TIMERTYPE
        {
            get
            {
                return this.tIMERTYPEField;
            }
            set
            {
                this.tIMERTYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ENABLED
        {
            get
            {
                return this.eNABLEDField;
            }
            set
            {
                this.eNABLEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PASS
        {
            get
            {
                return this.pASSField;
            }
            set
            {
                this.pASSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FORWARD_ANS_SIM_MS
        {
            get
            {
                return this.fORWARD_ANS_SIM_MSField;
            }
            set
            {
                this.fORWARD_ANS_SIM_MSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort COUNTDOWNMS
        {
            get
            {
                return this.cOUNTDOWNMSField;
            }
            set
            {
                this.cOUNTDOWNMSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ELAPSED
        {
            get
            {
                return this.eLAPSEDField;
            }
            set
            {
                this.eLAPSEDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort COUNTDOWNLEFT
        {
            get
            {
                return this.cOUNTDOWNLEFTField;
            }
            set
            {
                this.cOUNTDOWNLEFTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYACTIVITYINSTRUCTIONS
    {

        private PACKETTRACER5_ACTIVITYACTIVITYINSTRUCTIONSPAGE pAGEField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYACTIVITYINSTRUCTIONSPAGE PAGE
        {
            get
            {
                return this.pAGEField;
            }
            set
            {
                this.pAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYACTIVITYINSTRUCTIONSPAGE
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYVARIABLE_MANAGER
    {

        private object sEED_POOLSField;

        private object nUMBER_POOLSField;

        private object sTRING_POOLSField;

        private object iP_POOLSField;

        private object vARIABLES_POOLSField;

        /// <remarks/>
        public object SEED_POOLS
        {
            get
            {
                return this.sEED_POOLSField;
            }
            set
            {
                this.sEED_POOLSField = value;
            }
        }

        /// <remarks/>
        public object NUMBER_POOLS
        {
            get
            {
                return this.nUMBER_POOLSField;
            }
            set
            {
                this.nUMBER_POOLSField = value;
            }
        }

        /// <remarks/>
        public object STRING_POOLS
        {
            get
            {
                return this.sTRING_POOLSField;
            }
            set
            {
                this.sTRING_POOLSField = value;
            }
        }

        /// <remarks/>
        public object IP_POOLS
        {
            get
            {
                return this.iP_POOLSField;
            }
            set
            {
                this.iP_POOLSField = value;
            }
        }

        /// <remarks/>
        public object VARIABLES_POOLS
        {
            get
            {
                return this.vARIABLES_POOLSField;
            }
            set
            {
                this.vARIABLES_POOLSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOVERALL_INCOMPLETE_FEEDBACK
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOVERALL_COMPLETE_FEEDBACK
    {

        private bool translateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYDYNAMIC_PERCENTAGE_FEEDBACK
    {

        private byte tYPEField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYSCRIPT_MODULE
    {

        private PACKETTRACER5_ACTIVITYSCRIPT_MODULEPT_APP_META pT_APP_METAField;

        private object pASSWORDField;

        private bool oPEN_IF_DENIEDField;

        private PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTS sCRIPTSField;

        private object iNTERFACESField;

        private object nEW_DEVICE_CUSTOM_INTERFACESField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYSCRIPT_MODULEPT_APP_META PT_APP_META
        {
            get
            {
                return this.pT_APP_METAField;
            }
            set
            {
                this.pT_APP_METAField = value;
            }
        }

        /// <remarks/>
        public object PASSWORD
        {
            get
            {
                return this.pASSWORDField;
            }
            set
            {
                this.pASSWORDField = value;
            }
        }

        /// <remarks/>
        public bool OPEN_IF_DENIED
        {
            get
            {
                return this.oPEN_IF_DENIEDField;
            }
            set
            {
                this.oPEN_IF_DENIEDField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTS SCRIPTS
        {
            get
            {
                return this.sCRIPTSField;
            }
            set
            {
                this.sCRIPTSField = value;
            }
        }

        /// <remarks/>
        public object INTERFACES
        {
            get
            {
                return this.iNTERFACESField;
            }
            set
            {
                this.iNTERFACESField = value;
            }
        }

        /// <remarks/>
        public object NEW_DEVICE_CUSTOM_INTERFACES
        {
            get
            {
                return this.nEW_DEVICE_CUSTOM_INTERFACESField;
            }
            set
            {
                this.nEW_DEVICE_CUSTOM_INTERFACESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYSCRIPT_MODULEPT_APP_META
    {

        private object pT_VERSIONField;

        private object iPC_VERSIONField;

        private object nAMEField;

        private object vERSIONField;

        private object idField;

        private object dESCRIPTIONField;

        private object aUTHORField;

        private object cONTACTField;

        private object eXECUTABLE_PATHField;

        private bool dETACHEDField;

        private object kEYField;

        private object sECURITY_SETTINGSField;

        private string lOADINGField;

        private string sAVINGField;

        private byte iNSTANCESField;

        private bool mANDATORYField;

        /// <remarks/>
        public object PT_VERSION
        {
            get
            {
                return this.pT_VERSIONField;
            }
            set
            {
                this.pT_VERSIONField = value;
            }
        }

        /// <remarks/>
        public object IPC_VERSION
        {
            get
            {
                return this.iPC_VERSIONField;
            }
            set
            {
                this.iPC_VERSIONField = value;
            }
        }

        /// <remarks/>
        public object NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public object VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        public object ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public object AUTHOR
        {
            get
            {
                return this.aUTHORField;
            }
            set
            {
                this.aUTHORField = value;
            }
        }

        /// <remarks/>
        public object CONTACT
        {
            get
            {
                return this.cONTACTField;
            }
            set
            {
                this.cONTACTField = value;
            }
        }

        /// <remarks/>
        public object EXECUTABLE_PATH
        {
            get
            {
                return this.eXECUTABLE_PATHField;
            }
            set
            {
                this.eXECUTABLE_PATHField = value;
            }
        }

        /// <remarks/>
        public bool DETACHED
        {
            get
            {
                return this.dETACHEDField;
            }
            set
            {
                this.dETACHEDField = value;
            }
        }

        /// <remarks/>
        public object KEY
        {
            get
            {
                return this.kEYField;
            }
            set
            {
                this.kEYField = value;
            }
        }

        /// <remarks/>
        public object SECURITY_SETTINGS
        {
            get
            {
                return this.sECURITY_SETTINGSField;
            }
            set
            {
                this.sECURITY_SETTINGSField = value;
            }
        }

        /// <remarks/>
        public string LOADING
        {
            get
            {
                return this.lOADINGField;
            }
            set
            {
                this.lOADINGField = value;
            }
        }

        /// <remarks/>
        public string SAVING
        {
            get
            {
                return this.sAVINGField;
            }
            set
            {
                this.sAVINGField = value;
            }
        }

        /// <remarks/>
        public byte INSTANCES
        {
            get
            {
                return this.iNSTANCESField;
            }
            set
            {
                this.iNSTANCESField = value;
            }
        }

        /// <remarks/>
        public bool MANDATORY
        {
            get
            {
                return this.mANDATORYField;
            }
            set
            {
                this.mANDATORYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTS
    {

        private PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT[] sCRIPTField;

        private PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT_DATA_STORES sCRIPT_DATA_STORESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SCRIPT")]
        public PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT[] SCRIPT
        {
            get
            {
                return this.sCRIPTField;
            }
            set
            {
                this.sCRIPTField = value;
            }
        }

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT_DATA_STORES SCRIPT_DATA_STORES
        {
            get
            {
                return this.sCRIPT_DATA_STORESField;
            }
            set
            {
                this.sCRIPT_DATA_STORESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT
    {

        private string idField;

        private string cONTENTField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string CONTENT
        {
            get
            {
                return this.cONTENTField;
            }
            set
            {
                this.cONTENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT_DATA_STORES
    {

        private PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT_DATA_STORESDATA_STORE dATA_STOREField;

        /// <remarks/>
        public PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT_DATA_STORESDATA_STORE DATA_STORE
        {
            get
            {
                return this.dATA_STOREField;
            }
            set
            {
                this.dATA_STOREField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYSCRIPT_MODULESCRIPTSSCRIPT_DATA_STORESDATA_STORE
    {

        private string idField;

        private string cONTENTField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string CONTENT
        {
            get
            {
                return this.cONTENTField;
            }
            set
            {
                this.cONTENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYAUTHOR
    {

        private string iNFOField;

        /// <remarks/>
        public string INFO
        {
            get
            {
                return this.iNFOField;
            }
            set
            {
                this.iNFOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PACKETTRACER5_ACTIVITYOBJECT_LOCATIONS
    {

        private string iNDEXField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string INDEX
        {
            get
            {
                return this.iNDEXField;
            }
            set
            {
                this.iNDEXField = value;
            }
        }
    }
}
