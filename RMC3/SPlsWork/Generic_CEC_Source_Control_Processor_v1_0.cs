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

namespace CrestronModule_GENERIC_CEC_SOURCE_CONTROL_PROCESSOR_V1_0
{
    public class CrestronModuleClass_GENERIC_CEC_SOURCE_CONTROL_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput POWERSTATUS;
        Crestron.Logos.SplusObjects.StringOutput OSDNAME;
        StringParameter ADDRESS;
        ushort AADDRESSREV = 0;
        ushort AADDRESSIN = 0;
        CrestronString SADDRESS;
        CrestronString SOSDNAMETEMP;
        CrestronString SOSDNAMEOUT;
        object FROM_DEVICE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 163;
                AADDRESSIN = (ushort) ( Byte( FROM_DEVICE , (int)( 1 ) ) ) ; 
                __context__.SourceCodeLine = 164;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AADDRESSIN == AADDRESSREV))  ) ) 
                    { 
                    __context__.SourceCodeLine = 166;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( FROM_DEVICE , (int)( 2 ) ) == 144))  ) ) 
                        { 
                        __context__.SourceCodeLine = 168;
                        POWERSTATUS  .Value = (ushort) ( Byte( FROM_DEVICE , (int)( 3 ) ) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 170;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( FROM_DEVICE , (int)( 2 ) ) == 71))  ) ) 
                            { 
                            __context__.SourceCodeLine = 172;
                            SOSDNAMETEMP  .UpdateValue ( Functions.Mid ( FROM_DEVICE ,  (int) ( 3 ) ,  (int) ( (Functions.Length( FROM_DEVICE ) - 2) ) )  ) ; 
                            __context__.SourceCodeLine = 173;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOSDNAMETEMP != SOSDNAMEOUT))  ) ) 
                                { 
                                __context__.SourceCodeLine = 175;
                                SOSDNAMEOUT  .UpdateValue ( SOSDNAMETEMP  ) ; 
                                __context__.SourceCodeLine = 176;
                                OSDNAME  .UpdateValue ( SOSDNAMEOUT  ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 190;
            AADDRESSREV = (ushort) ( (((Byte( ADDRESS  , (int)( 1 ) ) << 4) + (Byte( ADDRESS  , (int)( 1 ) ) >> 4)) & 255) ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        SADDRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        SOSDNAMETEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        SOSDNAMEOUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        
        POWERSTATUS = new Crestron.Logos.SplusObjects.AnalogOutput( POWERSTATUS__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( POWERSTATUS__AnalogSerialOutput__, POWERSTATUS );
        
        FROM_DEVICE = new Crestron.Logos.SplusObjects.StringInput( FROM_DEVICE__AnalogSerialInput__, 20, this );
        m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
        
        OSDNAME = new Crestron.Logos.SplusObjects.StringOutput( OSDNAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( OSDNAME__AnalogSerialOutput__, OSDNAME );
        
        ADDRESS = new StringParameter( ADDRESS__Parameter__, this );
        m_ParameterList.Add( ADDRESS__Parameter__, ADDRESS );
        
        
        FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_GENERIC_CEC_SOURCE_CONTROL_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint FROM_DEVICE__AnalogSerialInput__ = 0;
    const uint POWERSTATUS__AnalogSerialOutput__ = 0;
    const uint OSDNAME__AnalogSerialOutput__ = 1;
    const uint ADDRESS__Parameter__ = 10;
    
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
