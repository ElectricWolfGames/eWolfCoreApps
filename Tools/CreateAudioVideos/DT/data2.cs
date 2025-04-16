using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAudioVideos.DT
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class parameterKeyFrame
    {

        private string nameField;

        private string parameteridField;

        private parameterKeyframe[] keyframeField;

        private byte valueminField;

        private byte valuemaxField;

        private parameterInterpolation interpolationField;

        /// <remarks/>
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

        /// <remarks/>
        public string parameterid
        {
            get
            {
                return this.parameteridField;
            }
            set
            {
                this.parameteridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keyframe")]
        public parameterKeyframe[] keyframe
        {
            get
            {
                return this.keyframeField;
            }
            set
            {
                this.keyframeField = value;
            }
        }

        /// <remarks/>
        public byte valuemin
        {
            get
            {
                return this.valueminField;
            }
            set
            {
                this.valueminField = value;
            }
        }

        /// <remarks/>
        public byte valuemax
        {
            get
            {
                return this.valuemaxField;
            }
            set
            {
                this.valuemaxField = value;
            }
        }

        /// <remarks/>
        public parameterInterpolation interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class parameterKeyframe
    {

        private uint whenField;

        private byte valueField;

        private string speedvirtualkfField;

        private string speedkfendField;

        private string speedkfoutField;

        private string speedkfinField;

        private string speedkfstartField;

        /// <remarks/>
        public uint when
        {
            get
            {
                return this.whenField;
            }
            set
            {
                this.whenField = value;
            }
        }

        /// <remarks/>
        public byte value
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

        /// <remarks/>
        public string speedvirtualkf
        {
            get
            {
                return this.speedvirtualkfField;
            }
            set
            {
                this.speedvirtualkfField = value;
            }
        }

        /// <remarks/>
        public string speedkfend
        {
            get
            {
                return this.speedkfendField;
            }
            set
            {
                this.speedkfendField = value;
            }
        }

        /// <remarks/>
        public string speedkfout
        {
            get
            {
                return this.speedkfoutField;
            }
            set
            {
                this.speedkfoutField = value;
            }
        }

        /// <remarks/>
        public string speedkfin
        {
            get
            {
                return this.speedkfinField;
            }
            set
            {
                this.speedkfinField = value;
            }
        }

        /// <remarks/>
        public string speedkfstart
        {
            get
            {
                return this.speedkfstartField;
            }
            set
            {
                this.speedkfstartField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class parameterInterpolation
    {

        private string nameField;

        /// <remarks/>
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


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class parameterValueString
    {

        private string nameField;

        private string parameteridField;

        private string valueField;

        /// <remarks/>
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

        /// <remarks/>
        public string parameterid
        {
            get
            {
                return this.parameteridField;
            }
            set
            {
                this.parameteridField = value;
            }
        }

        /// <remarks/>
        public string value
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


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class parameterHorizVert
    {
        private string nameField;

        private string parameteridField;

        private parameterValue valueField;

        /// <remarks/>
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

        /// <remarks/>
        public string parameterid
        {
            get
            {
                return this.parameteridField;
            }
            set
            {
                this.parameteridField = value;
            }
        }

        /// <remarks/>
        public parameterValue value
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
    public partial class parameterValue
    {

        private byte horizField;

        private byte vertField;

        /// <remarks/>
        public byte horiz
        {
            get
            {
                return this.horizField;
            }
            set
            {
                this.horizField = value;
            }
        }

        /// <remarks/>
        public byte vert
        {
            get
            {
                return this.vertField;
            }
            set
            {
                this.vertField = value;
            }
        }
    }



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class parameterValueInt
    {

        private string nameField;

        private string parameteridField;

        private byte valueField;

        private int valueminField;

        private int valuemaxField;

        /// <remarks/>
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

        /// <remarks/>
        public string parameterid
        {
            get
            {
                return this.parameteridField;
            }
            set
            {
                this.parameteridField = value;
            }
        }

        /// <remarks/>
        public byte value
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

        /// <remarks/>
        public int valuemin
        {
            get
            {
                return this.valueminField;
            }
            set
            {
                this.valueminField = value;
            }
        }

        /// <remarks/>
        public int valuemax
        {
            get
            {
                return this.valuemaxField;
            }
            set
            {
                this.valuemaxField = value;
            }
        }
    }



}
