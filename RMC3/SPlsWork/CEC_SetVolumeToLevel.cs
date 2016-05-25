using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_CEC_SETVOLUMETOLEVEL
{
    public class UserModuleClass_CEC_SETVOLUMETOLEVEL : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput VOLUMETOSET;
        Crestron.Logos.SplusObjects.StringOutput VOLUMEUP;
        Crestron.Logos.SplusObjects.StringOutput VOLUMEDOWN;
        ushort CURRENTVOLUME = 0;
        ushort DESIREDVOLUME = 0;
        private void STEPTOLEVEL (  SplusExecutionContext __context__, ushort LEVEL ) 
            { 
            
            
            }
            
        
        public override void LogosSplusInitialize()
        {
            SocketInfo __socketinfo__ = new SocketInfo( 1, this );
            InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
            _SplusNVRAM = new SplusNVRAM( this );
            
            VOLUMETOSET = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMETOSET__AnalogSerialInput__, this );
            m_AnalogInputList.Add( VOLUMETOSET__AnalogSerialInput__, VOLUMETOSET );
            
            VOLUMEUP = new Crestron.Logos.SplusObjects.StringOutput( VOLUMEUP__AnalogSerialOutput__, this );
            m_StringOutputList.Add( VOLUMEUP__AnalogSerialOutput__, VOLUMEUP );
            
            VOLUMEDOWN = new Crestron.Logos.SplusObjects.StringOutput( VOLUMEDOWN__AnalogSerialOutput__, this );
            m_StringOutputList.Add( VOLUMEDOWN__AnalogSerialOutput__, VOLUMEDOWN );
            
            
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_CEC_SETVOLUMETOLEVEL ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint VOLUMETOSET__AnalogSerialInput__ = 0;
        const uint VOLUMEUP__AnalogSerialOutput__ = 0;
        const uint VOLUMEDOWN__AnalogSerialOutput__ = 1;
        
        [SplusStructAttribute(-1, true, false)]
        public class SplusNVRAM : SplusStructureBase
        {
        
            public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
            
            
        }
        
        SplusNVRAM _SplusNVRAM = null;
        
        public class __CEvent__ : CEvent
        {
            public __CEvent__() {}
            public void Close() { base.Close(); }
            public int Reset() { return base.Reset() ? 1 : 0; }
            public int Set() { return base.Set() ? 1 : 0; }
            public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
        }
        public class __CMutex__ : CMutex
        {
            public __CMutex__() {}
            public void Close() { base.Close(); }
            public void ReleaseMutex() { base.ReleaseMutex(); }
            public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
        }
         public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
    }
    
    
}
