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

namespace UserModule_BSS_AUDIO_SOUNDWEB_LONDON_NODE
{
    public class UserModuleClass_BSS_AUDIO_SOUNDWEB_LONDON_NODE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.BufferInput COMRX__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput MODULESTX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput COMTX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MODULESRX__DOLLAR__;
        StringParameter NODE__DOLLAR__;
        private void SEND (  SplusExecutionContext __context__, CrestronString STR1 ) 
            { 
            
            __context__.SourceCodeLine = 126;
            _SplusNVRAM.CHECKSUM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 127;
            _SplusNVRAM.SENDSTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 128;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR1 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _SplusNVRAM.I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.I  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.I  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 130;
                _SplusNVRAM.CHECKSUM = (ushort) ( (_SplusNVRAM.CHECKSUM ^ Byte( STR1 , (int)( _SplusNVRAM.I ) )) ) ; 
                __context__.SourceCodeLine = 131;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( _SplusNVRAM.I ) ) == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( _SplusNVRAM.I ) ) == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( _SplusNVRAM.I ) ) == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( _SplusNVRAM.I ) ) == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( _SplusNVRAM.I ) ) == 27) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 133;
                    MakeString ( _SplusNVRAM.SENDSTRING , "{0}\u001B{1}", _SplusNVRAM.SENDSTRING , Functions.Chr (  (int) ( (Byte( STR1 , (int)( _SplusNVRAM.I ) ) + 128) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 137;
                    MakeString ( _SplusNVRAM.SENDSTRING , "{0}{1}", _SplusNVRAM.SENDSTRING , Functions.Chr (  (int) ( Byte( STR1 , (int)( _SplusNVRAM.I ) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 128;
                } 
            
            __context__.SourceCodeLine = 140;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.CHECKSUM == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.CHECKSUM == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.CHECKSUM == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.CHECKSUM == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.CHECKSUM == 27) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 142;
                MakeString ( COMTX__DOLLAR__ , "\u0002{0}\u001B{1}\u0003", _SplusNVRAM.SENDSTRING , Functions.Chr (  (int) ( (_SplusNVRAM.CHECKSUM + 128) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 146;
                MakeString ( COMTX__DOLLAR__ , "\u0002{0}{1}\u0003", _SplusNVRAM.SENDSTRING , Functions.Chr (  (int) ( _SplusNVRAM.CHECKSUM ) ) ) ; 
                } 
            
            
            }
            
        private CrestronString RECEIVE (  SplusExecutionContext __context__, CrestronString STR2 ) 
            { 
            
            __context__.SourceCodeLine = 153;
            _SplusNVRAM.RECEIVESTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 154;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR2 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _SplusNVRAM.J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.J  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.J  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.J  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.J  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 156;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( STR2 , (int)( _SplusNVRAM.J ) ) == 27))  ) ) 
                    { 
                    __context__.SourceCodeLine = 158;
                    _SplusNVRAM.RECEIVESTRING  .UpdateValue ( _SplusNVRAM.RECEIVESTRING + Functions.Chr (  (int) ( (Byte( STR2 , (int)( (_SplusNVRAM.J + 1) ) ) - 128) ) )  ) ; 
                    __context__.SourceCodeLine = 159;
                    _SplusNVRAM.J = (ushort) ( (_SplusNVRAM.J + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 163;
                    _SplusNVRAM.RECEIVESTRING  .UpdateValue ( _SplusNVRAM.RECEIVESTRING + Functions.Chr (  (int) ( Byte( STR2 , (int)( _SplusNVRAM.J ) ) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 154;
                } 
            
            __context__.SourceCodeLine = 166;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _SplusNVRAM.RECEIVESTRING , (int)( 1 ) ) == 6))  ) ) 
                { 
                __context__.SourceCodeLine = 168;
                _SplusNVRAM.RECEIVESTRING  .UpdateValue ( Functions.Right ( _SplusNVRAM.RECEIVESTRING ,  (int) ( (Functions.Length( _SplusNVRAM.RECEIVESTRING ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 166;
                } 
            
            __context__.SourceCodeLine = 170;
            return ( _SplusNVRAM.RECEIVESTRING ) ; 
            
            }
            
        object MODULESTX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 216;
                if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOK1)  ) ) 
                    { 
                    __context__.SourceCodeLine = 218;
                    _SplusNVRAM.XOK1 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 219;
                    while ( Functions.TestForTrue  ( ( Functions.Length( MODULESTX__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 221;
                        _SplusNVRAM.MARKER1 = (ushort) ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , MODULESTX__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 222;
                        _SplusNVRAM.MARKER2 = (ushort) ( (_SplusNVRAM.MARKER1 + 5) ) ; 
                        __context__.SourceCodeLine = 223;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.MARKER2 <= Functions.Length( MODULESTX__DOLLAR__ ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 225;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MODULESTX__DOLLAR__ , (int)( _SplusNVRAM.MARKER2 ) ) == 3))  ) ) 
                                { 
                                __context__.SourceCodeLine = 227;
                                _SplusNVRAM.MARKER1 = (ushort) ( (_SplusNVRAM.MARKER1 + 1) ) ; 
                                __context__.SourceCodeLine = 228;
                                _SplusNVRAM.MARKER2 = (ushort) ( (_SplusNVRAM.MARKER2 + 1) ) ; 
                                __context__.SourceCodeLine = 229;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.MARKER2 > Functions.Length( MODULESTX__DOLLAR__ ) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 231;
                                    break ; 
                                    } 
                                
                                __context__.SourceCodeLine = 225;
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 235;
                        if ( Functions.TestForTrue  ( ( _SplusNVRAM.MARKER1)  ) ) 
                            { 
                            __context__.SourceCodeLine = 237;
                            _SplusNVRAM.MARKER1 = (ushort) ( (_SplusNVRAM.MARKER1 + 4) ) ; 
                            __context__.SourceCodeLine = 238;
                            _SplusNVRAM.TEMPSTRING1  .UpdateValue ( Functions.Remove ( Functions.Mid ( MODULESTX__DOLLAR__ ,  (int) ( 1 ) ,  (int) ( _SplusNVRAM.MARKER1 ) ) , MODULESTX__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 239;
                            MakeString ( _SplusNVRAM.TEMPSTRING1 , "{0}{1}{2}", Functions.Left ( _SplusNVRAM.TEMPSTRING1 ,  (int) ( 1 ) ) , NODE__DOLLAR__ , Functions.Right ( _SplusNVRAM.TEMPSTRING1 ,  (int) ( (Functions.Length( _SplusNVRAM.TEMPSTRING1 ) - 3) ) ) ) ; 
                            __context__.SourceCodeLine = 240;
                            SEND (  __context__ , Functions.Left( _SplusNVRAM.TEMPSTRING1 , (int)( (Functions.Length( _SplusNVRAM.TEMPSTRING1 ) - 5) ) )) ; 
                            __context__.SourceCodeLine = 241;
                            Functions.ClearBuffer ( _SplusNVRAM.TEMPSTRING1 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 219;
                        } 
                    
                    __context__.SourceCodeLine = 244;
                    _SplusNVRAM.XOK1 = (ushort) ( 1 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object COMRX__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort SDUMP = 0;
            
            
            __context__.SourceCodeLine = 252;
            if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOK2)  ) ) 
                { 
                __context__.SourceCodeLine = 254;
                _SplusNVRAM.XOK2 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 255;
                while ( Functions.TestForTrue  ( ( Functions.Length( COMRX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 257;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( COMRX__DOLLAR__ , (int)( 1 ) ) == 6))  ) ) 
                        { 
                        __context__.SourceCodeLine = 259;
                        _SplusNVRAM.TEMPSTRING2  .UpdateValue ( Functions.Remove ( "\u0006" , COMRX__DOLLAR__ )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 261;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( COMRX__DOLLAR__ , (int)( 1 ) ) == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 263;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003" , COMRX__DOLLAR__ ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 265;
                                _SplusNVRAM.TEMPSTRING2  .UpdateValue ( Functions.Remove ( "\u0003" , COMRX__DOLLAR__ )  ) ; 
                                __context__.SourceCodeLine = 272;
                                _SplusNVRAM.TEMPSTRING3  .UpdateValue ( RECEIVE (  __context__ , _SplusNVRAM.TEMPSTRING2)  ) ; 
                                __context__.SourceCodeLine = 274;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( _SplusNVRAM.TEMPSTRING3 , (int)( 3 ) ) == Byte( NODE__DOLLAR__  , (int)( 1 ) )) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _SplusNVRAM.TEMPSTRING3 , (int)( 4 ) ) == Byte( NODE__DOLLAR__  , (int)( 2 ) )) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 275;
                                    MODULESRX__DOLLAR__  .UpdateValue ( _SplusNVRAM.TEMPSTRING3 + "\u0003\u0003\u0003\u0003"  ) ; 
                                    }
                                
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 280;
                            SDUMP = (ushort) ( Functions.GetC( COMRX__DOLLAR__ ) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 283;
                    Functions.ClearBuffer ( _SplusNVRAM.TEMPSTRING2 ) ; 
                    __context__.SourceCodeLine = 284;
                    Functions.ClearBuffer ( _SplusNVRAM.TEMPSTRING3 ) ; 
                    __context__.SourceCodeLine = 255;
                    } 
                
                __context__.SourceCodeLine = 286;
                _SplusNVRAM.XOK2 = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 306;
        _SplusNVRAM.XOK1 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 307;
        _SplusNVRAM.XOK2 = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.TEMPSTRING1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    _SplusNVRAM.SENDSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    _SplusNVRAM.TEMPSTRING2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    _SplusNVRAM.TEMPSTRING3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    _SplusNVRAM.RECEIVESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    
    COMTX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( COMTX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMTX__DOLLAR____AnalogSerialOutput__, COMTX__DOLLAR__ );
    
    MODULESRX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MODULESRX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MODULESRX__DOLLAR____AnalogSerialOutput__, MODULESRX__DOLLAR__ );
    
    COMRX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( COMRX__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( COMRX__DOLLAR____AnalogSerialInput__, COMRX__DOLLAR__ );
    
    MODULESTX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( MODULESTX__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( MODULESTX__DOLLAR____AnalogSerialInput__, MODULESTX__DOLLAR__ );
    
    NODE__DOLLAR__ = new StringParameter( NODE__DOLLAR____Parameter__, this );
    m_ParameterList.Add( NODE__DOLLAR____Parameter__, NODE__DOLLAR__ );
    
    
    MODULESTX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MODULESTX__DOLLAR___OnChange_0, false ) );
    COMRX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( COMRX__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_AUDIO_SOUNDWEB_LONDON_NODE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint COMRX__DOLLAR____AnalogSerialInput__ = 0;
const uint MODULESTX__DOLLAR____AnalogSerialInput__ = 1;
const uint COMTX__DOLLAR____AnalogSerialOutput__ = 0;
const uint MODULESRX__DOLLAR____AnalogSerialOutput__ = 1;
const uint NODE__DOLLAR____Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort XOK1 = 0;
            [SplusStructAttribute(1, false, true)]
            public CrestronString TEMPSTRING1;
            [SplusStructAttribute(2, false, true)]
            public ushort CHECKSUM = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort I = 0;
            [SplusStructAttribute(4, false, true)]
            public CrestronString SENDSTRING;
            [SplusStructAttribute(5, false, true)]
            public ushort XOK2 = 0;
            [SplusStructAttribute(6, false, true)]
            public CrestronString TEMPSTRING2;
            [SplusStructAttribute(7, false, true)]
            public CrestronString TEMPSTRING3;
            [SplusStructAttribute(8, false, true)]
            public ushort J = 0;
            [SplusStructAttribute(9, false, true)]
            public CrestronString RECEIVESTRING;
            [SplusStructAttribute(10, false, true)]
            public ushort MARKER1 = 0;
            [SplusStructAttribute(11, false, true)]
            public ushort MARKER2 = 0;
            
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
