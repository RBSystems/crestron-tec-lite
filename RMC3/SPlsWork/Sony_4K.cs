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

namespace UserModule_SONY_4K
{
    public class UserModuleClass_SONY_4K : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput CEC_RECEIVE;
        Crestron.Logos.SplusObjects.StringOutput CEC_TRANSMIT;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSTATUS_FROMDISPLAY;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSTATUS_TODISPLAY;
        private CrestronString TRANSLATECODE (  SplusExecutionContext __context__, CrestronString CODE ) 
            { 
            CrestronString STRIPPEDCODE;
            STRIPPEDCODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            CrestronString GARBAGE;
            GARBAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            
            __context__.SourceCodeLine = 150;
            GARBAGE  .UpdateValue ( Functions.Remove ( "x" , STRIPPEDCODE )  ) ; 
            __context__.SourceCodeLine = 153;
            return ( STRIPPEDCODE ) ; 
            
            }
            
        object CEC_RECEIVE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString STR;
                STR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
                
                
                __context__.SourceCodeLine = 160;
                STR  .UpdateValue ( TRANSLATECODE (  __context__ , CEC_RECEIVE)  ) ; 
                __context__.SourceCodeLine = 161;
                Print( "{0}", STR ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        
        CEC_RECEIVE = new Crestron.Logos.SplusObjects.StringInput( CEC_RECEIVE__AnalogSerialInput__, 1024, this );
        m_StringInputList.Add( CEC_RECEIVE__AnalogSerialInput__, CEC_RECEIVE );
        
        CEC_TRANSMIT = new Crestron.Logos.SplusObjects.StringOutput( CEC_TRANSMIT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( CEC_TRANSMIT__AnalogSerialOutput__, CEC_TRANSMIT );
        
        CURRENTSTATUS_FROMDISPLAY = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSTATUS_FROMDISPLAY__AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENTSTATUS_FROMDISPLAY__AnalogSerialOutput__, CURRENTSTATUS_FROMDISPLAY );
        
        CURRENTSTATUS_TODISPLAY = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSTATUS_TODISPLAY__AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENTSTATUS_TODISPLAY__AnalogSerialOutput__, CURRENTSTATUS_TODISPLAY );
        
        
        CEC_RECEIVE.OnSerialChange.Add( new InputChangeHandlerWrapper( CEC_RECEIVE_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SONY_4K ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint CEC_RECEIVE__AnalogSerialInput__ = 0;
    const uint CEC_TRANSMIT__AnalogSerialOutput__ = 0;
    const uint CURRENTSTATUS_FROMDISPLAY__AnalogSerialOutput__ = 1;
    const uint CURRENTSTATUS_TODISPLAY__AnalogSerialOutput__ = 2;
    
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
