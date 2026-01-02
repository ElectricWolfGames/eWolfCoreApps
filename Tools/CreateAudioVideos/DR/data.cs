namespace CreateAudioVideos.DR
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class xmeml
    {
        private xmemlSequence sequenceField;

        private byte versionField;

        /// <remarks/>
        public xmemlSequence sequence
        {
            get
            {
                return this.sequenceField;
            }
            set
            {
                this.sequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequence
    {
        private uint durationField;
        private sbyte inField;
        private xmemlSequenceMedia mediaField;
        private string nameField;
        private sbyte outField;
        private xmemlSequenceRate rateField;
        private xmemlSequenceTimecode timecodeField;

        /// <remarks/>
        public sbyte @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        /// <remarks/>
        public sbyte @out
        {
            get
            {
                return this.outField;
            }
            set
            {
                this.outField = value;
            }
        }

        /// <remarks/>
        public uint duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMedia media
        {
            get
            {
                return this.mediaField;
            }
            set
            {
                this.mediaField = value;
            }
        }

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
        public xmemlSequenceRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceTimecode timecode
        {
            get
            {
                return this.timecodeField;
            }
            set
            {
                this.timecodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMedia
    {
        private xmemlSequenceMediaAudio audioField;
        private xmemlSequenceMediaVideo videoField;

        /// <remarks/>
        public xmemlSequenceMediaAudio audio
        {
            get
            {
                return this.audioField;
            }
            set
            {
                this.audioField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideo video
        {
            get
            {
                return this.videoField;
            }
            set
            {
                this.videoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudio
    {
        private xmemlSequenceMediaAudioTrack trackField;

        /// <remarks/>
        public xmemlSequenceMediaAudioTrack track
        {
            get
            {
                return this.trackField;
            }
            set
            {
                this.trackField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrack
    {
        private xmemlSequenceMediaAudioTrackClipitem[] clipitemField;

        private string enabledField;

        private string lockedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clipitem")]
        public xmemlSequenceMediaAudioTrackClipitem[] clipitem
        {
            get
            {
                return this.clipitemField;
            }
            set
            {
                this.clipitemField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public string locked
        {
            get
            {
                return this.lockedField;
            }
            set
            {
                this.lockedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitem
    {
        private object commentsField;
        private ushort durationField;
        private string enabledField;
        private uint endField;
        private xmemlSequenceMediaAudioTrackClipitemFile fileField;
        private xmemlSequenceMediaAudioTrackClipitemFilter[] filterField;
        private string idField;
        private byte inField;
        private string nameField;
        private ushort outField;
        private xmemlSequenceMediaAudioTrackClipitemRate rateField;

        private xmemlSequenceMediaAudioTrackClipitemSourcetrack sourcetrackField;
        private uint startField;

        /// <remarks/>
        public byte @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        /// <remarks/>
        public ushort @out
        {
            get
            {
                return this.outField;
            }
            set
            {
                this.outField = value;
            }
        }

        /// <remarks/>
        public object comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public ushort duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public uint end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaAudioTrackClipitemFile file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public xmemlSequenceMediaAudioTrackClipitemFilter[] filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
        public xmemlSequenceMediaAudioTrackClipitemRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaAudioTrackClipitemSourcetrack sourcetrack
        {
            get
            {
                return this.sourcetrackField;
            }
            set
            {
                this.sourcetrackField = value;
            }
        }

        /// <remarks/>
        public uint start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFile
    {
        private ushort durationField;

        private string idField;
        private xmemlSequenceMediaAudioTrackClipitemFileMedia mediaField;
        private string nameField;
        private string pathurlField;
        private xmemlSequenceMediaAudioTrackClipitemFileRate rateField;

        /// <remarks/>
        public ushort duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
        public xmemlSequenceMediaAudioTrackClipitemFileMedia media
        {
            get
            {
                return this.mediaField;
            }
            set
            {
                this.mediaField = value;
            }
        }

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
        public string pathurl
        {
            get
            {
                return this.pathurlField;
            }
            set
            {
                this.pathurlField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaAudioTrackClipitemFileRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFileMedia
    {
        private xmemlSequenceMediaAudioTrackClipitemFileMediaAudio audioField;

        /// <remarks/>
        public xmemlSequenceMediaAudioTrackClipitemFileMediaAudio audio
        {
            get
            {
                return this.audioField;
            }
            set
            {
                this.audioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFileMediaAudio
    {
        private byte channelcountField;

        /// <remarks/>
        public byte channelcount
        {
            get
            {
                return this.channelcountField;
            }
            set
            {
                this.channelcountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFileRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFilter
    {
        private xmemlSequenceMediaAudioTrackClipitemFilterEffect effectField;
        private string enabledField;

        private ushort endField;
        private byte startField;

        /// <remarks/>
        public xmemlSequenceMediaAudioTrackClipitemFilterEffect effect
        {
            get
            {
                return this.effectField;
            }
            set
            {
                this.effectField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public ushort end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public byte start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFilterEffect
    {
        private string effectcategoryField;
        private string effectidField;
        private string effecttypeField;
        private string mediatypeField;
        private string nameField;
        private xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter parameterField;

        /// <remarks/>
        public string effectcategory
        {
            get
            {
                return this.effectcategoryField;
            }
            set
            {
                this.effectcategoryField = value;
            }
        }

        /// <remarks/>
        public string effectid
        {
            get
            {
                return this.effectidField;
            }
            set
            {
                this.effectidField = value;
            }
        }

        /// <remarks/>
        public string effecttype
        {
            get
            {
                return this.effecttypeField;
            }
            set
            {
                this.effecttypeField = value;
            }
        }

        /// <remarks/>
        public string mediatype
        {
            get
            {
                return this.mediatypeField;
            }
            set
            {
                this.mediatypeField = value;
            }
        }

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
        public xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter
    {
        private string nameField;

        private string parameteridField;

        private byte valueField;

        private decimal valuemaxField;
        private float valueminField;

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
        public decimal valuemax
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
        public float valuemin
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaAudioTrackClipitemSourcetrack
    {
        private string mediatypeField;

        private byte trackindexField;

        /// <remarks/>
        public string mediatype
        {
            get
            {
                return this.mediatypeField;
            }
            set
            {
                this.mediatypeField = value;
            }
        }

        /// <remarks/>
        public byte trackindex
        {
            get
            {
                return this.trackindexField;
            }
            set
            {
                this.trackindexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideo
    {
        private xmemlSequenceMediaVideoFormat formatField;
        private xmemlSequenceMediaVideoTrack trackField;

        /// <remarks/>
        public xmemlSequenceMediaVideoFormat format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoTrack track
        {
            get
            {
                return this.trackField;
            }
            set
            {
                this.trackField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoFormat
    {
        private xmemlSequenceMediaVideoFormatSamplecharacteristics samplecharacteristicsField;

        /// <remarks/>
        public xmemlSequenceMediaVideoFormatSamplecharacteristics samplecharacteristics
        {
            get
            {
                return this.samplecharacteristicsField;
            }
            set
            {
                this.samplecharacteristicsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoFormatSamplecharacteristics
    {
        private xmemlSequenceMediaVideoFormatSamplecharacteristicsCodec codecField;
        private ushort heightField;
        private string pixelaspectratioField;
        private xmemlSequenceMediaVideoFormatSamplecharacteristicsRate rateField;
        private ushort widthField;

        /// <remarks/>
        public xmemlSequenceMediaVideoFormatSamplecharacteristicsCodec codec
        {
            get
            {
                return this.codecField;
            }
            set
            {
                this.codecField = value;
            }
        }

        /// <remarks/>
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public string pixelaspectratio
        {
            get
            {
                return this.pixelaspectratioField;
            }
            set
            {
                this.pixelaspectratioField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoFormatSamplecharacteristicsRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoFormatSamplecharacteristicsCodec
    {
        private xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdata appspecificdataField;

        /// <remarks/>
        public xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdata appspecificdata
        {
            get
            {
                return this.appspecificdataField;
            }
            set
            {
                this.appspecificdataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdata
    {
        private string appmanufacturerField;
        private string appnameField;
        private xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdataData dataField;

        /// <remarks/>
        public string appmanufacturer
        {
            get
            {
                return this.appmanufacturerField;
            }
            set
            {
                this.appmanufacturerField = value;
            }
        }

        /// <remarks/>
        public string appname
        {
            get
            {
                return this.appnameField;
            }
            set
            {
                this.appnameField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdataData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdataData
    {
        private object qtcodecField;

        /// <remarks/>
        public object qtcodec
        {
            get
            {
                return this.qtcodecField;
            }
            set
            {
                this.qtcodecField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoFormatSamplecharacteristicsRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrack
    {
        private xmemlSequenceMediaVideoTrackClipitem[] clipitemField;

        private string enabledField;

        private string lockedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clipitem")]
        public xmemlSequenceMediaVideoTrackClipitem[] clipitem
        {
            get
            {
                return this.clipitemField;
            }
            set
            {
                this.clipitemField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public string locked
        {
            get
            {
                return this.lockedField;
            }
            set
            {
                this.lockedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitem
    {
        private object commentsField;
        private string compositemodeField;
        private uint durationField;
        private string enabledField;
        private uint endField;
        private xmemlSequenceMediaVideoTrackClipitemFile fileField;
        private xmemlSequenceMediaVideoTrackClipitemFilter[] filterField;
        private string idField;
        private uint inField;
        private string nameField;
        private uint outField;
        private xmemlSequenceMediaVideoTrackClipitemRate rateField;

        private uint startField;

        /// <remarks/>
        public uint @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        /// <remarks/>
        public uint @out
        {
            get
            {
                return this.outField;
            }
            set
            {
                this.outField = value;
            }
        }

        /// <remarks/>
        public object comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public string compositemode
        {
            get
            {
                return this.compositemodeField;
            }
            set
            {
                this.compositemodeField = value;
            }
        }

        /// <remarks/>
        public uint duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public uint end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFile file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public xmemlSequenceMediaVideoTrackClipitemFilter[] filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
        public xmemlSequenceMediaVideoTrackClipitemRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public uint start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFile
    {
        private byte durationField;

        private string idField;
        private xmemlSequenceMediaVideoTrackClipitemFileMedia mediaField;
        private string nameField;
        private string pathurlField;
        private xmemlSequenceMediaVideoTrackClipitemFileRate rateField;
        private xmemlSequenceMediaVideoTrackClipitemFileTimecode timecodeField;

        /// <remarks/>
        public byte duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
        public xmemlSequenceMediaVideoTrackClipitemFileMedia media
        {
            get
            {
                return this.mediaField;
            }
            set
            {
                this.mediaField = value;
            }
        }

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
        public string pathurl
        {
            get
            {
                return this.pathurlField;
            }
            set
            {
                this.pathurlField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFileRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFileTimecode timecode
        {
            get
            {
                return this.timecodeField;
            }
            set
            {
                this.timecodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFileMedia
    {
        private xmemlSequenceMediaVideoTrackClipitemFileMediaVideo videoField;

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFileMediaVideo video
        {
            get
            {
                return this.videoField;
            }
            set
            {
                this.videoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFileMediaVideo
    {
        private byte durationField;

        private xmemlSequenceMediaVideoTrackClipitemFileMediaVideoSamplecharacteristics samplecharacteristicsField;

        /// <remarks/>
        public byte duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFileMediaVideoSamplecharacteristics samplecharacteristics
        {
            get
            {
                return this.samplecharacteristicsField;
            }
            set
            {
                this.samplecharacteristicsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFileMediaVideoSamplecharacteristics
    {
        private ushort heightField;
        private ushort widthField;

        /// <remarks/>
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFileRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFileTimecode
    {
        private string displayformatField;
        private xmemlSequenceMediaVideoTrackClipitemFileTimecodeRate rateField;
        private string stringField;

        /// <remarks/>
        public string @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }

        /// <remarks/>
        public string displayformat
        {
            get
            {
                return this.displayformatField;
            }
            set
            {
                this.displayformatField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFileTimecodeRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFileTimecodeRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFilter
    {
        private xmemlSequenceMediaVideoTrackClipitemFilterEffect effectField;
        private string enabledField;

        private int endField;
        private sbyte startField;

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFilterEffect effect
        {
            get
            {
                return this.effectField;
            }
            set
            {
                this.effectField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public int end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public sbyte start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFilterEffect
    {
        private string effectcategoryField;
        private string effectidField;
        private string effecttypeField;
        private string mediatypeField;
        private string nameField;
        private object[] parameterField;

        /// <remarks/>
        public string effectcategory
        {
            get
            {
                return this.effectcategoryField;
            }
            set
            {
                this.effectcategoryField = value;
            }
        }

        /// <remarks/>
        public string effectid
        {
            get
            {
                return this.effectidField;
            }
            set
            {
                this.effectidField = value;
            }
        }

        /// <remarks/>
        public string effecttype
        {
            get
            {
                return this.effecttypeField;
            }
            set
            {
                this.effecttypeField = value;
            }
        }

        /// <remarks/>
        public string mediatype
        {
            get
            {
                return this.mediatypeField;
            }
            set
            {
                this.mediatypeField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public object[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter
    {
        private xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterInterpolation interpolationField;
        private xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterKeyframe[] keyframeField;
        private string nameField;

        private string parameteridField;
        private int valueField;

        private uint valuemaxField;
        private bool valuemaxFieldSpecified;
        private int valueminField;

        private bool valueminFieldSpecified;

        /// <remarks/>
        public xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterInterpolation interpolation
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keyframe")]
        public xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterKeyframe[] keyframe
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
        public int value
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
        public uint valuemax
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valuemaxSpecified
        {
            get
            {
                return this.valuemaxFieldSpecified;
            }
            set
            {
                this.valuemaxFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueminSpecified
        {
            get
            {
                return this.valueminFieldSpecified;
            }
            set
            {
                this.valueminFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterInterpolation
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterKeyframe
    {
        private string speedkfendField;
        private string speedkfinField;
        private string speedkfoutField;
        private string speedkfstartField;
        private string speedvirtualkfField;
        private byte valueField;
        private uint whenField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemFilterEffectParameterValue
    {
        private byte horizField;

        private string[] textField;
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceMediaVideoTrackClipitemRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceTimecode
    {
        private string displayformatField;
        private uint frameField;
        private xmemlSequenceTimecodeRate rateField;
        private string stringField;

        /// <remarks/>
        public string @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }

        /// <remarks/>
        public string displayformat
        {
            get
            {
                return this.displayformatField;
            }
            set
            {
                this.displayformatField = value;
            }
        }

        /// <remarks/>
        public uint frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }

        /// <remarks/>
        public xmemlSequenceTimecodeRate rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class xmemlSequenceTimecodeRate
    {
        private string ntscField;
        private byte timebaseField;

        /// <remarks/>
        public string ntsc
        {
            get
            {
                return this.ntscField;
            }
            set
            {
                this.ntscField = value;
            }
        }

        /// <remarks/>
        public byte timebase
        {
            get
            {
                return this.timebaseField;
            }
            set
            {
                this.timebaseField = value;
            }
        }
    }
}