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

namespace UserModule_BSS_SOUNDWEB_LONDON_GAIN
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_GAIN : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNSUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput MUTE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNMUTE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput POLARITYON__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput POLARITYOFF__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput GAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POLARITY_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput GAIN_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        StringParameter OBJECTID__DOLLAR__;
        private CrestronString ITOVOLUMEPERCENT (  SplusExecutionContext __context__, ushort INT ) 
            { 
            
            __context__.SourceCodeLine = 136;
            _SplusNVRAM.VOLUME = (ushort) ( ((INT * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 137;
            _SplusNVRAM.RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( _SplusNVRAM.VOLUME ) ) + "\u0000\u0000"  ) ; 
            __context__.SourceCodeLine = 138;
            return ( _SplusNVRAM.RETURNSTRING ) ; 
            
            }
            
        private ushort VOLUMEPERCENTTOI (  SplusExecutionContext __context__, CrestronString STR ) 
            { 
            ushort FRACTION = 0;
            
            
            __context__.SourceCodeLine = 145;
            FRACTION = (ushort) ( ((Byte( STR , (int)( 3 ) ) * 256) + Byte( STR , (int)( 4 ) )) ) ; 
            __context__.SourceCodeLine = 146;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRACTION > 32767 ))  ) ) 
                { 
                __context__.SourceCodeLine = 147;
                _SplusNVRAM.VOLUME = (ushort) ( (((Byte( STR , (int)( 2 ) ) + 1) * 65535) / 100) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 150;
                _SplusNVRAM.VOLUME = (ushort) ( ((Byte( STR , (int)( 2 ) ) * 65535) / 100) ) ; 
                } 
            
            __context__.SourceCodeLine = 152;
            _SplusNVRAM.RETURNI = (ushort) ( _SplusNVRAM.VOLUME ) ; 
            __context__.SourceCodeLine = 154;
            return (ushort)( _SplusNVRAM.RETURNI) ; 
            
            }
            
        object MUTE__DOLLAR___OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 166;
                MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 171;
                    Functions.ProcessLogic ( ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object UNMUTE__DOLLAR___OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 178;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 180;
            if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 182;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 183;
                Functions.ProcessLogic ( ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POLARITYON__DOLLAR___OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 191;
        MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 193;
        if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 195;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 196;
            Functions.ProcessLogic ( ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLARITYOFF__DOLLAR___OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 203;
        MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 205;
        if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 207;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 208;
            Functions.ProcessLogic ( ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GAIN__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 215;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.VOLUMEINPUT != GAIN__DOLLAR__  .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 217;
            if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOKGAIN)  ) ) 
                { 
                __context__.SourceCodeLine = 219;
                _SplusNVRAM.XOKGAIN = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 220;
                _SplusNVRAM.VOLUMEINPUT = (ushort) ( GAIN__DOLLAR__  .UshortValue ) ; 
                __context__.SourceCodeLine = 221;
                GAIN_FB__DOLLAR__  .Value = (ushort) ( GAIN__DOLLAR__  .UshortValue ) ; 
                __context__.SourceCodeLine = 222;
                MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}\u0000\u0000{1}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , ITOVOLUMEPERCENT (  __context__ , (ushort)( GAIN__DOLLAR__  .UshortValue )) ) ; 
                __context__.SourceCodeLine = 223;
                _SplusNVRAM.XOKGAIN = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBSCRIBE__DOLLAR___OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 244;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 20 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 246;
            if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOKSUBSCRIBE)  ) ) 
                { 
                __context__.SourceCodeLine = 248;
                _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 249;
                MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}\u0000\u0000\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 250;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 251;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 252;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 253;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 254;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 255;
                _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 1 ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object UNSUBSCRIBE__DOLLAR___OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 263;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOKSUBSCRIBE)  ) ) 
            { 
            __context__.SourceCodeLine = 265;
            _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 266;
            MakeString ( TX__DOLLAR__ , "\u008F\u0000\u0000\u0003{0}\u0000\u0000\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 267;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 268;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 269;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 270;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 271;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 272;
            _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 287;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOK)  ) ) 
            { 
            __context__.SourceCodeLine = 289;
            _SplusNVRAM.XOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 290;
            while ( Functions.TestForTrue  ( ( Functions.Length( RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 292;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 294;
                    _SplusNVRAM.TEMPSTRING  .UpdateValue ( Functions.Remove ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 295;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == OBJECTID__DOLLAR__ ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 297;
                        
                            {
                            int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( _SplusNVRAM.TEMPSTRING , (int)( 10 ) ));
                            
                                { 
                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 301;
                                    _SplusNVRAM.VOLUMEINPUT = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                                    __context__.SourceCodeLine = 302;
                                    GAIN_FB__DOLLAR__  .Value = (ushort) ( _SplusNVRAM.VOLUMEINPUT ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 306;
                                    MUTE_FB__DOLLAR__  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 310;
                                    POLARITY_FB__DOLLAR__  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                    } 
                                
                                } 
                                
                            }
                            
                        
                        } 
                    
                    __context__.SourceCodeLine = 314;
                    Functions.ClearBuffer ( _SplusNVRAM.TEMPSTRING ) ; 
                    } 
                
                __context__.SourceCodeLine = 290;
                } 
            
            __context__.SourceCodeLine = 317;
            _SplusNVRAM.XOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 337;
        _SplusNVRAM.XOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 338;
        _SplusNVRAM.XOKGAIN = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 339;
        _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 340;
        _SplusNVRAM.SUBSCRIBE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.RETURNSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _SplusNVRAM.TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    UNSUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNSUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNSUBSCRIBE__DOLLAR____DigitalInput__, UNSUBSCRIBE__DOLLAR__ );
    
    MUTE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( MUTE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( MUTE__DOLLAR____DigitalInput__, MUTE__DOLLAR__ );
    
    UNMUTE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNMUTE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNMUTE__DOLLAR____DigitalInput__, UNMUTE__DOLLAR__ );
    
    POLARITYON__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( POLARITYON__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( POLARITYON__DOLLAR____DigitalInput__, POLARITYON__DOLLAR__ );
    
    POLARITYOFF__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( POLARITYOFF__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( POLARITYOFF__DOLLAR____DigitalInput__, POLARITYOFF__DOLLAR__ );
    
    MUTE_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_FB__DOLLAR____DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_FB__DOLLAR____DigitalOutput__, MUTE_FB__DOLLAR__ );
    
    POLARITY_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalOutput( POLARITY_FB__DOLLAR____DigitalOutput__, this );
    m_DigitalOutputList.Add( POLARITY_FB__DOLLAR____DigitalOutput__, POLARITY_FB__DOLLAR__ );
    
    GAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( GAIN__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( GAIN__DOLLAR____AnalogSerialInput__, GAIN__DOLLAR__ );
    
    GAIN_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogOutput( GAIN_FB__DOLLAR____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GAIN_FB__DOLLAR____AnalogSerialOutput__, GAIN_FB__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 400, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    OBJECTID__DOLLAR__ = new StringParameter( OBJECTID__DOLLAR____Parameter__, this );
    m_ParameterList.Add( OBJECTID__DOLLAR____Parameter__, OBJECTID__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    
    MUTE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE__DOLLAR___OnPush_0, false ) );
    UNMUTE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNMUTE__DOLLAR___OnPush_1, false ) );
    POLARITYON__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLARITYON__DOLLAR___OnPush_2, false ) );
    POLARITYOFF__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLARITYOFF__DOLLAR___OnPush_3, false ) );
    GAIN__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( GAIN__DOLLAR___OnChange_4, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_5, false ) );
    UNSUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNSUBSCRIBE__DOLLAR___OnPush_6, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_GAIN ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;


const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 0;
const uint UNSUBSCRIBE__DOLLAR____DigitalInput__ = 1;
const uint MUTE__DOLLAR____DigitalInput__ = 2;
const uint UNMUTE__DOLLAR____DigitalInput__ = 3;
const uint POLARITYON__DOLLAR____DigitalInput__ = 4;
const uint POLARITYOFF__DOLLAR____DigitalInput__ = 5;
const uint GAIN__DOLLAR____AnalogSerialInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 1;
const uint MUTE_FB__DOLLAR____DigitalOutput__ = 0;
const uint POLARITY_FB__DOLLAR____DigitalOutput__ = 1;
const uint GAIN_FB__DOLLAR____AnalogSerialOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 1;
const uint OBJECTID__DOLLAR____Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort I = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort SUBSCRIBE = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort VOLUME = 0;
            [SplusStructAttribute(3, false, true)]
            public CrestronString RETURNSTRING;
            [SplusStructAttribute(4, false, true)]
            public ushort RETURNI = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort XOK = 0;
            [SplusStructAttribute(6, false, true)]
            public ushort XOKSUBSCRIBE = 0;
            [SplusStructAttribute(7, false, true)]
            public ushort VOLUMEINPUT = 0;
            [SplusStructAttribute(8, false, true)]
            public ushort XOKGAIN = 0;
            [SplusStructAttribute(9, false, true)]
            public CrestronString TEMPSTRING;
            
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
