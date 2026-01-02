using CreateAudioVideos.DR;
using CreateAudioVideos.DT;

namespace CreateAudioVideos.Builders
{
    internal class XmemlBuilder
    {
        public xmeml CreateDemo()
        {
            xmeml xmeml = new xmeml();
            xmeml.version = 5;
            xmeml.sequence = new xmemlSequence();
            xmeml.sequence.name = "New test";
            xmeml.sequence.duration = 1467;
            xmeml.sequence.rate = new xmemlSequenceRate();
            xmeml.sequence.rate.timebase = 24;
            xmeml.sequence.rate.ntsc = "false";
            xmeml.sequence.@in = -1;
            xmeml.sequence.@out = -1;
            xmeml.sequence.timecode = CreateTikmeCodes();

            xmeml.sequence.media = CreateMedia();
            return xmeml;
        }

        public xmemlSequenceTimecodeRate SequenceRate()
        {
            xmemlSequenceTimecodeRate rate = new xmemlSequenceTimecodeRate();
            rate.timebase = 24;
            rate.ntsc = "false";
            return rate;
        }

        private xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdata CreateAppspecificdata()
        {
            xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdata apps = new xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdata();
            apps.appname = "Final Cut Pro";
            apps.appmanufacturer = "Apple Inc.";
            apps.data = CreateData();
            return apps;
        }

        private xmemlSequenceMediaAudioTrack CreateAudioTrack()
        {
            xmemlSequenceMediaAudioTrack track = new xmemlSequenceMediaAudioTrack();
            track.clipitem = CreateClipItem();
            track.enabled = "TRUE";
            track.locked = "FALSE";
            return track;
        }

        private xmemlSequenceMediaAudioTrackClipitemFile CreateClipFile()
        {
            xmemlSequenceMediaAudioTrackClipitemFile file = new xmemlSequenceMediaAudioTrackClipitemFile();
            file.id = "DemoTack.mp3 1";
            file.duration = 1468;
            file.rate = CreateFileRate();
            file.name = "DemoTack.mp3";
            file.pathurl = "file://localhost/E:/Projects/GitHub/eWolfCoreApps/Tools/CreateAudioVideos/DemoData/DemoTack.mp3";
            file.media = CreateTrackMedia();

            return file;
        }

        private xmemlSequenceMediaVideoTrackClipitemFile CreateClipFileThumb()
        {
            xmemlSequenceMediaVideoTrackClipitemFile clip = new xmemlSequenceMediaVideoTrackClipitemFile();

            clip.id = "1.png 2";
            clip.duration = 1;
            clip.rate = CreateThumbNailRate();
            clip.name = "1.png";
            clip.pathurl = "file://localhost/E:/_AudioTemp/Scifi/NEXT/Mix/A%20Plague%20Of%20Goodness/thumbnails/1.png";
            clip.timecode = CreateThumbNailTimeCode();
            clip.media = CreateThumbNailMedia();

            return clip;
        }

        private xmemlSequenceMediaAudioTrackClipitem[] CreateClipItem()
        {
            List<xmemlSequenceMediaAudioTrackClipitem> list = new List<xmemlSequenceMediaAudioTrackClipitem>();

            xmemlSequenceMediaAudioTrackClipitem clip = new xmemlSequenceMediaAudioTrackClipitem();
            clip.id = "DemoTack.mp3 0";
            clip.name = "DemoTack.mp3";
            clip.duration = 1468;
            clip.rate = CreateClipRate();
            clip.start = 0;
            clip.end = 1468;
            clip.enabled = "TRUE";
            clip.@in = 0;
            clip.@out = 1468;
            clip.file = CreateClipFile();
            clip.sourcetrack = CreateSourceTrack();
            clip.filter = CreateFilter();

            list.Add(clip);
            return list.ToArray();
        }

        private xmemlSequenceMediaVideoTrackClipitemRate CreateClipItemRate()
        {
            xmemlSequenceMediaVideoTrackClipitemRate rate = new xmemlSequenceMediaVideoTrackClipitemRate();
            rate.timebase = 24;
            rate.ntsc = "False";
            return rate;
        }

        private xmemlSequenceMediaAudioTrackClipitemRate CreateClipRate()
        {
            xmemlSequenceMediaAudioTrackClipitemRate rate = new xmemlSequenceMediaAudioTrackClipitemRate();
            rate.timebase = 24;
            rate.ntsc = "FALSE";

            return rate;
        }

        private xmemlSequenceMediaVideoFormatSamplecharacteristicsCodec CreateCodec()
        {
            xmemlSequenceMediaVideoFormatSamplecharacteristicsCodec code = new xmemlSequenceMediaVideoFormatSamplecharacteristicsCodec();
            code.appspecificdata = CreateAppspecificdata();

            return code;
        }

        private xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdataData CreateData()
        {
            xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdataData data = new xmemlSequenceMediaVideoFormatSamplecharacteristicsCodecAppspecificdataData();
            return data;
        }

        private xmemlSequenceMediaAudioTrackClipitemFilterEffect CreateEffectAudioLevels()
        {
            xmemlSequenceMediaAudioTrackClipitemFilterEffect effect = new xmemlSequenceMediaAudioTrackClipitemFilterEffect();
            effect.name = "Audio Levels";
            effect.effectid = "audiolevels";
            effect.effecttype = "audiolevels";
            effect.mediatype = "audio";
            effect.effectcategory = "audiolevels";
            effect.parameter = CreateParemterAudioLevels();

            return effect;
        }

        private xmemlSequenceMediaAudioTrackClipitemFilterEffect CreateEffectAudioPan()
        {
            xmemlSequenceMediaAudioTrackClipitemFilterEffect effect = new xmemlSequenceMediaAudioTrackClipitemFilterEffect();
            effect.name = "Audio Pan";
            effect.effectid = "audiopan";
            effect.effecttype = "audiopan";
            effect.mediatype = "audio";
            effect.effectcategory = "audiopan";
            effect.parameter = CreateParemterAudioPan();

            return effect;
        }

        private xmemlSequenceMediaAudioTrackClipitemFileRate CreateFileRate()
        {
            xmemlSequenceMediaAudioTrackClipitemFileRate rate = new xmemlSequenceMediaAudioTrackClipitemFileRate();
            rate.timebase = 24;
            rate.ntsc = "false";
            return rate;
        }

        private xmemlSequenceMediaAudioTrackClipitemFilter[] CreateFilter()
        {
            List<xmemlSequenceMediaAudioTrackClipitemFilter> list = new List<xmemlSequenceMediaAudioTrackClipitemFilter>();

            // Audio Levels
            xmemlSequenceMediaAudioTrackClipitemFilter filter = new xmemlSequenceMediaAudioTrackClipitemFilter();
            filter.enabled = "true";
            filter.start = 0;
            filter.end = 1468;
            filter.effect = CreateEffectAudioLevels();
            list.Add(filter);

            filter = new xmemlSequenceMediaAudioTrackClipitemFilter();
            filter.enabled = "true";
            filter.start = 0;
            filter.end = 1468;
            filter.effect = CreateEffectAudioPan();
            list.Add(filter);
            return list.ToArray();
        }

        private parameterKeyframe[] CreateFilterKeyFrames()
        {
            List<parameterKeyframe> list = new List<parameterKeyframe>();
            parameterKeyframe kf = new parameterKeyframe();
            kf.when = 0;
            kf.value = 0;
            kf.speedvirtualkf = "TRUE";
            kf.speedkfstart = "TRUE";
            list.Add(kf);

            kf = new parameterKeyframe();
            kf.when = 68400;
            kf.value = 0;
            kf.speedvirtualkf = "TRUE";
            kf.speedkfstart = "TRUE";
            list.Add(kf);

            kf = new parameterKeyframe();
            kf.when = 87868;
            kf.value = 0;
            kf.speedvirtualkf = "TRUE";
            kf.speedkfstart = "TRUE";
            list.Add(kf);

            kf = new parameterKeyframe();
            kf.when = 1440001;
            kf.value = 1;
            kf.speedvirtualkf = "TRUE";
            kf.speedkfstart = "TRUE";
            list.Add(kf);

            return list.ToArray();
        }

        private object[] CreateFilterParameters()
        {
            List<object> paras = new List<object>();

            var parScale = new parameterValueInt();
            parScale.name = "Scale";
            parScale.parameterid = "scale";
            parScale.value = 100;
            parScale.valuemin = 0;
            parScale.valuemax = 10000;
            paras.Add(parScale);

            var parCenter = new parameterHorizVert();
            parCenter.name = "Center";
            parCenter.parameterid = "Center";
            parCenter.value = new parameterValue();
            parCenter.value.horiz = 0;
            parCenter.value.vert = 0;
            paras.Add(parCenter);

            var parRotation = new parameterValueInt();
            parRotation.name = "Rotation";
            parRotation.parameterid = "Rotation";
            parRotation.valuemin = -100000;
            parRotation.valuemax = 100000;
            paras.Add(parRotation);

            var parAnchorPoint = new parameterHorizVert();
            parAnchorPoint.name = "Anchor Point";
            parAnchorPoint.parameterid = "centerOffset";
            parAnchorPoint.value = new parameterValue();
            parAnchorPoint.value.horiz = 0;
            parAnchorPoint.value.vert = 0;
            paras.Add(parAnchorPoint);

            return paras.ToArray();
        }

        private xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter[] CreateFilterParametersCrop()
        {
            List<xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter> paras = new List<xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter>();
            xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter par = new xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter();
            par.name = "left";
            par.parameterid = "left";
            par.value = 0;
            par.valuemin = 0;
            par.valuemax = 100;
            paras.Add(par);

            par = new xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter();
            par.name = "right";
            par.parameterid = "right";
            par.value = 0;
            par.valuemin = 0;
            par.valuemax = 100;
            paras.Add(par);

            par = new xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter();
            par.name = "top";
            par.parameterid = "top";
            par.value = 0;
            par.valuemin = 0;
            par.valuemax = 100;
            paras.Add(par);

            par = new xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter();
            par.name = "bottom";
            par.parameterid = "bottom";
            par.value = 0;
            par.valuemin = 0;
            par.valuemax = 100;
            paras.Add(par);

            return paras.ToArray();
        }

        private xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter[] CreateFilterParametersOpacity()
        {
            List<xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter> paras = new List<xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter>();
            xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter par = new xmemlSequenceMediaVideoTrackClipitemFilterEffectParameter();
            par.name = "opacity";
            par.parameterid = "opacity";
            par.value = 0;
            par.valuemin = 0;
            par.valuemax = 100;
            paras.Add(par);

            return paras.ToArray();
        }

        private object[] CreateFilterParametersTimeRemap()
        {
            List<object> paras = new List<object>();

            var par = new parameterValueInt();
            par.name = "speed";
            par.parameterid = "speed";
            par.value = 0;
            par.valuemin = -10000;
            par.valuemax = 10000;
            paras.Add(par);

            var parReverse = new parameterValueString();
            parReverse.name = "reverse";
            parReverse.parameterid = "reverse";
            parReverse.value = "False";
            paras.Add(parReverse);

            var parFrameblending = new parameterValueString();
            parFrameblending.name = "frameblending";
            parFrameblending.parameterid = "frameblending";
            parFrameblending.value = "false";
            paras.Add(parFrameblending);

            var parVariablespeed = new parameterValueInt();
            parVariablespeed.name = "variablespeed";
            parVariablespeed.parameterid = "variablespeed";
            parVariablespeed.value = 0;
            parVariablespeed.valuemin = 0;
            parVariablespeed.valuemax = 1;
            paras.Add(parVariablespeed);

            var parKeyFrame = new parameterKeyFrame();
            parKeyFrame.name = "graphdict";
            parKeyFrame.parameterid = "graphdict";
            parKeyFrame.keyframe = CreateFilterKeyFrames();
            parKeyFrame.valuemin = 0;
            parKeyFrame.valuemax = 0;
            parKeyFrame.interpolation = new parameterInterpolation();
            parKeyFrame.interpolation.name = "FCPCurve";

            return paras.ToArray();
        }

        private xmemlSequenceMedia CreateMedia()
        {
            xmemlSequenceMedia media = new xmemlSequenceMedia();
            media.video = CreateMediaVideo();
            media.audio = CreateMediaAudio();
            return media;
        }

        private xmemlSequenceMediaAudio CreateMediaAudio()
        {
            xmemlSequenceMediaAudio audio = new xmemlSequenceMediaAudio();
            audio.track = CreateAudioTrack();
            return audio;
        }

        private xmemlSequenceMediaVideo CreateMediaVideo()
        {
            xmemlSequenceMediaVideo video = new xmemlSequenceMediaVideo();
            video.track = CreatTrack();
            video.format = CreratFormat();

            return video;
        }

        private xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter CreateParemterAudioLevels()
        {
            xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter parameter = new xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter();
            parameter.name = "Level";
            parameter.parameterid = "level";
            parameter.value = 1;
            parameter.valuemin = 1e-05f;
            parameter.valuemax = 31.6228m;
            return parameter;
        }

        private xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter CreateParemterAudioPan()
        {
            xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter parameter = new xmemlSequenceMediaAudioTrackClipitemFilterEffectParameter();
            parameter.name = "Pan";
            parameter.parameterid = "pan";
            parameter.value = 0;
            parameter.valuemin = -1;
            parameter.valuemax = 1;
            return parameter;
        }

        private xmemlSequenceMediaVideoFormatSamplecharacteristics CreateSample()
        {
            xmemlSequenceMediaVideoFormatSamplecharacteristics sample = new xmemlSequenceMediaVideoFormatSamplecharacteristics();
            sample.width = 1920;
            sample.height = 1080;
            sample.pixelaspectratio = "square";
            sample.rate = CreateSampleRate();
            sample.codec = CreateCodec();

            return sample;
        }

        private xmemlSequenceMediaVideoFormatSamplecharacteristicsRate CreateSampleRate()
        {
            xmemlSequenceMediaVideoFormatSamplecharacteristicsRate rate = new xmemlSequenceMediaVideoFormatSamplecharacteristicsRate();
            rate.timebase = 24;
            rate.ntsc = "FALSE";

            return rate;
        }

        private xmemlSequenceMediaAudioTrackClipitemSourcetrack CreateSourceTrack()
        {
            xmemlSequenceMediaAudioTrackClipitemSourcetrack soundTrack = new xmemlSequenceMediaAudioTrackClipitemSourcetrack();
            soundTrack.mediatype = "audio";
            soundTrack.trackindex = 1;

            return soundTrack;
        }

        private xmemlSequenceMediaVideoTrackClipitemFilter[] CreateThumbFilter()
        {
            List<xmemlSequenceMediaVideoTrackClipitemFilter> list = new List<xmemlSequenceMediaVideoTrackClipitemFilter>();

            xmemlSequenceMediaVideoTrackClipitemFilter filterA = new xmemlSequenceMediaVideoTrackClipitemFilter();
            filterA.enabled = "TRUE";
            filterA.start = 0;
            filterA.end = 1440001;
            filterA.effect = new xmemlSequenceMediaVideoTrackClipitemFilterEffect();
            filterA.effect.name = "Basic Motion";
            filterA.effect.effectid = "basic";
            filterA.effect.effecttype = "motion";
            filterA.effect.mediatype = "Video";
            filterA.effect.effectcategory = "motion";
            filterA.effect.parameter = CreateFilterParameters();
            list.Add(filterA);

            xmemlSequenceMediaVideoTrackClipitemFilter filterB = new xmemlSequenceMediaVideoTrackClipitemFilter();
            filterB.enabled = "TRUE";
            filterB.start = 0;
            filterB.end = 1440001;
            filterB.effect = new xmemlSequenceMediaVideoTrackClipitemFilterEffect();
            filterB.effect.name = "Crop";
            filterB.effect.effectid = "crop";
            filterB.effect.effecttype = "motion";
            filterB.effect.mediatype = "Video";
            filterB.effect.effectcategory = "motion";
            filterB.effect.parameter = CreateFilterParametersCrop();
            list.Add(filterB);

            xmemlSequenceMediaVideoTrackClipitemFilter filterC = new xmemlSequenceMediaVideoTrackClipitemFilter();
            filterC.enabled = "TRUE";
            filterC.start = 0;
            filterC.end = 1440001;
            filterC.effect = new xmemlSequenceMediaVideoTrackClipitemFilterEffect();
            filterC.effect.name = "Opacity";
            filterC.effect.effectid = "opacity";
            filterC.effect.effecttype = "motion";
            filterC.effect.mediatype = "Video";
            filterC.effect.effectcategory = "motion";
            filterC.effect.parameter = CreateFilterParametersOpacity();
            list.Add(filterC);

            xmemlSequenceMediaVideoTrackClipitemFilter filterD = new xmemlSequenceMediaVideoTrackClipitemFilter();
            filterD.enabled = "TRUE";
            filterD.start = -1;
            filterD.end = -1;
            filterD.effect = new xmemlSequenceMediaVideoTrackClipitemFilterEffect();
            filterD.effect.name = "Time Remap";
            filterD.effect.effectid = "timeremap";
            filterD.effect.effecttype = "motion";
            filterD.effect.mediatype = "Video";
            filterD.effect.effectcategory = "motion";
            filterD.effect.parameter = CreateFilterParametersTimeRemap();
            list.Add(filterD);

            return list.ToArray();
        }

        private xmemlSequenceMediaVideoTrackClipitem[] CreateThumbNail()
        {
            List<xmemlSequenceMediaVideoTrackClipitem> list = new List<xmemlSequenceMediaVideoTrackClipitem>();
            xmemlSequenceMediaVideoTrackClipitem clip = new xmemlSequenceMediaVideoTrackClipitem();

            clip.id = "1.png 0";
            clip.name = "1.png";
            clip.duration = 1440001;
            clip.rate = CreateClipItemRate();
            clip.start = 0;
            clip.end = 1468;
            clip.enabled = "TRUE";
            clip.@in = 86400;
            clip.@out = 87868;
            clip.file = CreateClipFileThumb();
            clip.compositemode = "Normal";
            clip.filter = CreateThumbFilter();

            list.Add(clip);
            return list.ToArray();
        }

        private xmemlSequenceMediaVideoTrackClipitemFileMedia CreateThumbNailMedia()
        {
            xmemlSequenceMediaVideoTrackClipitemFileMedia media = new xmemlSequenceMediaVideoTrackClipitemFileMedia();
            media.video = CreateThumbNailVideo();

            return media;
        }

        private xmemlSequenceMediaVideoTrackClipitemFileRate CreateThumbNailRate()
        {
            xmemlSequenceMediaVideoTrackClipitemFileRate rate = new xmemlSequenceMediaVideoTrackClipitemFileRate();
            rate.timebase = 24;
            rate.ntsc = "False";
            return rate;
        }

        private xmemlSequenceMediaVideoTrackClipitemFileTimecode CreateThumbNailTimeCode()
        {
            xmemlSequenceMediaVideoTrackClipitemFileTimecode timecode = new xmemlSequenceMediaVideoTrackClipitemFileTimecode();
            timecode.@string = "00:00:00:00";
            timecode.displayformat = "NDF";
            timecode.rate = CreateTimeCodeRate();

            return timecode;
        }

        private xmemlSequenceMediaVideoTrackClipitemFileMediaVideo CreateThumbNailVideo()
        {
            xmemlSequenceMediaVideoTrackClipitemFileMediaVideo video = new xmemlSequenceMediaVideoTrackClipitemFileMediaVideo();
            video.duration = 1;
            video.samplecharacteristics = new xmemlSequenceMediaVideoTrackClipitemFileMediaVideoSamplecharacteristics();
            video.samplecharacteristics.width = 1920;
            video.samplecharacteristics.height = 1080;
            return video;
        }

        private xmemlSequenceTimecode CreateTikmeCodes()
        {
            xmemlSequenceTimecode xmemlSequenceTimecode = new xmemlSequenceTimecode();
            xmemlSequenceTimecode.@string = "01:00:00:00";
            xmemlSequenceTimecode.frame = 86400;
            xmemlSequenceTimecode.displayformat = "NDF";
            xmemlSequenceTimecode.rate = SequenceRate();

            return xmemlSequenceTimecode;
        }

        private xmemlSequenceMediaVideoTrackClipitemFileTimecodeRate CreateTimeCodeRate()
        {
            xmemlSequenceMediaVideoTrackClipitemFileTimecodeRate rate = new xmemlSequenceMediaVideoTrackClipitemFileTimecodeRate();
            rate.timebase = 24;
            rate.ntsc = "FALSE";
            return rate;
        }

        private xmemlSequenceMediaAudioTrackClipitemFileMedia CreateTrackMedia()
        {
            xmemlSequenceMediaAudioTrackClipitemFileMedia media = new xmemlSequenceMediaAudioTrackClipitemFileMedia();
            media.audio = new xmemlSequenceMediaAudioTrackClipitemFileMediaAudio();
            media.audio.channelcount = 2;
            return media;
        }

        private xmemlSequenceMediaVideoTrack CreatTrack()
        {
            xmemlSequenceMediaVideoTrack track = new xmemlSequenceMediaVideoTrack();
            track.enabled = "true";
            track.locked = "false";
            track.clipitem = CreateThumbNail();
            return track;
        }

        private xmemlSequenceMediaVideoFormat CreratFormat()
        {
            xmemlSequenceMediaVideoFormat format = new xmemlSequenceMediaVideoFormat();
            format.samplecharacteristics = CreateSample();

            return format;
        }
    }
}