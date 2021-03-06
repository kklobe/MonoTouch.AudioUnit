﻿//
// AudioComponentDescription.cs: AudioComponentDescription wrapper class
//
// Author:
//   AKIHIRO Uehara (u-akihiro@reinforce-lab.com)
//
// Copyright 2010 Reinforce Lab.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MonoTouch.AudioToolbox
{
    [StructLayout(LayoutKind.Sequential)]
    public class AudioComponentDescription
    {
        [MarshalAs(UnmanagedType.U4)] 
        public AudioComponentType componentType;
        
        [MarshalAs(UnmanagedType.U4)]
        public AudioComponentSubType componentSubType;
        
        [MarshalAs(UnmanagedType.U4)] 
        public AudioComponentManufacturerType componentManufacturer;

        public uint componentFlags;
        
        public uint componentFlagsMask;

        public AudioComponentDescription() {}

        public enum AudioComponentType
        {
            kAudioUnitType_Output = 0x61756f75, //'auou',
            kAudioUnitType_Mixer  = 0x61756d78, // 'aumx',
            /*
                    kAudioUnitType_MusicDevice				= 'aumu',
                    kAudioUnitType_MusicEffect				= 'aumf',
                    kAudioUnitType_FormatConverter			= 'aufc',
                    kAudioUnitType_Effect					= 'aufx',
                    
                    kAudioUnitType_Panner					= 'aupn',
                    kAudioUnitType_Generator				= 'augn',
                    kAudioUnitType_OfflineEffect			= 'auol'*/
        }
        
        public enum AudioComponentSubType
        {
            kAudioUnitSubType_GenericOutput	= 0x67656e72,// 'genr',            
            kAudioUnitSubType_RemoteIO = 0x72696f63, //'rioc',        
            kAudioUnitSubType_VoiceProcessingIO = 0x7670696f, // 'vpio'
            kAudioUnitSubType_MultiChannelMixer = 0x6d636d78 // 'mcmx',
        }

        public enum AudioComponentManufacturerType
        {
            kAudioUnitManufacturer_Apple = 0x6170706c // little endian 0x6c707061 //'appl'
        }
    }
}
