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

namespace UserModule_METRICS
{
    public class UserModuleClass_METRICS : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput AUDIO_ONLY_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput CONFIRM_SYSTEM_OFF;
        Crestron.Logos.SplusObjects.DigitalInput HELP_MENU_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput HOME_BUTTON;
        Crestron.Logos.SplusObjects.DigitalInput PROGRAM_VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput PROGRAM_VOLUME_SLIDER_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput PROGRAM_VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_AV_JACK;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_BLANK;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_BLURAY;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DEVICE_CONTROL_BLURAY;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DEVICE_CONTROL_IPTV;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_HDMI_CABLE;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_HDMI_JACK;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_IPTV;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_LOCAL_INPUT;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_PA_CONTROL;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_REMOTE_INPUT1;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_REMOTE_INPUT2;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_VGA_CABLE;
        Crestron.Logos.SplusObjects.DigitalInput STARTUP_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput CLIENTCONNECTED;
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMREADY;
        Crestron.Logos.SplusObjects.StringInput CONTROLLERHOSTNAME;
        Crestron.Logos.SplusObjects.StringInput CONTROLLERIP;
        Crestron.Logos.SplusObjects.StringInput CONTROLLERMACADDR;
        Crestron.Logos.SplusObjects.StringInput DEVBUILDING;
        Crestron.Logos.SplusObjects.StringInput DEVROOM;
        Crestron.Logos.SplusObjects.StringInput DEVFLOOR;
        Crestron.Logos.SplusObjects.StringInput DEVLATITUDE;
        Crestron.Logos.SplusObjects.StringInput DEVLONGITUDE;
        Crestron.Logos.SplusObjects.AnalogInput VOLUMELEVEL;
        Crestron.Logos.SplusObjects.BufferInput CLIENTBUFFER;
        Crestron.Logos.SplusObjects.DigitalOutput _CLIENTCONNECTED;
        Crestron.Logos.SplusObjects.StringOutput TODEVBUILDING;
        Crestron.Logos.SplusObjects.StringOutput TODEVROOM;
        Crestron.Logos.SplusObjects.StringOutput TODEVFLOOR;
        Crestron.Logos.SplusObjects.StringOutput TODEVLAT;
        Crestron.Logos.SplusObjects.StringOutput TODEVLON;
        Crestron.Logos.SplusObjects.StringOutput TOCLIENTBUFFER__DOLLAR__;
        SplusTcpClient CLIENT;
        short CONFIGFILEHANDLE = 0;
        CrestronString REPORTINGHOST;
        CrestronString HOSTNAME;
        CrestronString HOSTIP;
        CrestronString HOSTMAC;
        CrestronString HOSTBLDG;
        CrestronString HOSTROOM;
        CrestronString HOSTFLOOR;
        CrestronString HOSTLAT;
        CrestronString HOSTLON;
        CrestronString MESSAGE;
        ushort REPORTINGHOSTPORT = 0;
        ushort RECONNECTTIME = 0;
        private void LOG (  SplusExecutionContext __context__, CrestronString MSG ) 
            { 
            
            __context__.SourceCodeLine = 89;
            Print( "\r\n{0}", MSG ) ; 
            
            }
            
        private void ERROR (  SplusExecutionContext __context__, CrestronString MSG ) 
            { 
            
            __context__.SourceCodeLine = 95;
            LOG (  __context__ , MSG) ; 
            
            }
            
        private void SEND (  SplusExecutionContext __context__, CrestronString MSG ) 
            { 
            
            __context__.SourceCodeLine = 100;
            Print( "Sending: {0}", MSG ) ; 
            __context__.SourceCodeLine = 101;
            Functions.SocketSend ( CLIENT , MSG ) ; 
            
            }
            
        private void STOREGLOBALVARS (  SplusExecutionContext __context__, CrestronString INPUTSTRING ) 
            { 
            CrestronString TRASH;
            CrestronString PARSETHISSTRING;
            CrestronString TEMP;
            TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            PARSETHISSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            
            __context__.SourceCodeLine = 109;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "building" , INPUTSTRING ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "roomNumber" , INPUTSTRING ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "floor" , INPUTSTRING ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "building" , INPUTSTRING ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 111;
                TRASH  .UpdateValue ( Functions.Remove ( ":[" , INPUTSTRING )  ) ; 
                __context__.SourceCodeLine = 112;
                PARSETHISSTRING  .UpdateValue ( INPUTSTRING  ) ; 
                __context__.SourceCodeLine = 115;
                HOSTLON  .UpdateValue ( Functions.Remove ( "," , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 118;
                HOSTLAT  .UpdateValue ( Functions.Remove ( "]," , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 121;
                TRASH  .UpdateValue ( Functions.Remove ( ":\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 122;
                HOSTROOM  .UpdateValue ( Functions.Remove ( "\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 125;
                TRASH  .UpdateValue ( Functions.Remove ( ":\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 126;
                HOSTFLOOR  .UpdateValue ( Functions.Remove ( "," , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 130;
                TRASH  .UpdateValue ( Functions.Remove ( ":\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 131;
                TEMP  .UpdateValue ( PARSETHISSTRING  ) ; 
                __context__.SourceCodeLine = 132;
                HOSTBLDG  .UpdateValue ( Functions.Remove ( "\"" , TEMP )  ) ; 
                } 
            
            
            }
            
        private void BUILDHTTPMESSAGE (  SplusExecutionContext __context__, CrestronString EVENTHOSTNAME , CrestronString EVENTIP , CrestronString EVENTMAC , CrestronString EVENTBLDG , CrestronString EVENTROOM , CrestronString EVENTFLOOR , CrestronString EVENTLAT , CrestronString EVENTLON , CrestronString EVENTACTOR , CrestronString EVENTACTION , CrestronString USERORSYSTEM ) 
            { 
            short OFFSET = 0;
            short MNUM = 0;
            short YNUM = 0;
            short DNUM = 0;
            short CONTENTLENGTH = 0;
            
            int PORTNUMBER = 0;
            
            CrestronString TIMESTAMP;
            TIMESTAMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            
            CrestronString HOSTNAME;
            HOSTNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
            
            CrestronString DESCRIPTION;
            DESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString IPADDRESS;
            IPADDRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
            
            CrestronString MAC;
            MAC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 17, this );
            
            CrestronString BUILDING;
            BUILDING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            CrestronString ROOMNUMBER;
            ROOMNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            CrestronString LAT;
            LAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
            
            CrestronString LON;
            LON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
            
            CrestronString FLR;
            FLR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            CrestronString ACTOR;
            ACTOR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
            
            CrestronString DESC;
            DESC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString TYPE;
            TYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
            
            CrestronString HEADER1;
            CrestronString HEADER2;
            CrestronString HEADER3;
            CrestronString HEADER4;
            CrestronString HEADER5;
            CrestronString HEADER6;
            HEADER1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            CrestronString INNERMSG1;
            CrestronString INNERMSG2;
            CrestronString INNERMSG3;
            CrestronString INNERMSG4;
            INNERMSG1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            INNERMSG2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            INNERMSG3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            INNERMSG4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            CrestronString CLSTRING;
            CLSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            
            __context__.SourceCodeLine = 203;
            HOSTNAME  .UpdateValue ( EVENTHOSTNAME  ) ; 
            __context__.SourceCodeLine = 204;
            DESCRIPTION  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 205;
            IPADDRESS  .UpdateValue ( EVENTIP  ) ; 
            __context__.SourceCodeLine = 206;
            MAC  .UpdateValue ( EVENTMAC  ) ; 
            __context__.SourceCodeLine = 207;
            BUILDING  .UpdateValue ( EVENTBLDG  ) ; 
            __context__.SourceCodeLine = 208;
            ROOMNUMBER  .UpdateValue ( EVENTROOM  ) ; 
            __context__.SourceCodeLine = 209;
            LAT  .UpdateValue ( EVENTLAT  ) ; 
            __context__.SourceCodeLine = 210;
            LON  .UpdateValue ( EVENTLON  ) ; 
            __context__.SourceCodeLine = 211;
            FLR  .UpdateValue ( EVENTFLOOR  ) ; 
            __context__.SourceCodeLine = 212;
            ACTOR  .UpdateValue ( EVENTACTOR  ) ; 
            __context__.SourceCodeLine = 213;
            DESC  .UpdateValue ( EVENTACTION  ) ; 
            __context__.SourceCodeLine = 214;
            TYPE  .UpdateValue ( USERORSYSTEM  ) ; 
            __context__.SourceCodeLine = 216;
            OFFSET = (short) ( Functions.GetGmtOffset() ) ; 
            __context__.SourceCodeLine = 217;
            MNUM = (short) ( Functions.GetMonthNum() ) ; 
            __context__.SourceCodeLine = 218;
            YNUM = (short) ( Functions.GetYearNum() ) ; 
            __context__.SourceCodeLine = 219;
            DNUM = (short) ( Functions.GetDateNum() ) ; 
            __context__.SourceCodeLine = 222;
            TIMESTAMP  .UpdateValue ( Functions.ItoA (  (int) ( YNUM ) ) + "-" + Functions.ItoA (  (int) ( MNUM ) ) + "-" + Functions.ItoA (  (int) ( DNUM ) ) + "T" + Functions.Time ( ) + "Z"  ) ; 
            __context__.SourceCodeLine = 224;
            INNERMSG1  .UpdateValue ( "{\"type\": \"" + TYPE + "\",\"timestamp\": \"" + TIMESTAMP + "\",\"device\": {\"hostname\": \"" + HOSTNAME + "\", \"description\": \""  ) ; 
            __context__.SourceCodeLine = 225;
            INNERMSG2  .UpdateValue ( "" + DESCRIPTION + "\", \"ipAddress\": \"" + IPADDRESS + "\", \"macAddress\": \"" + MAC + "\"}, \"room\": { \"building\": \"" + BUILDING  ) ; 
            __context__.SourceCodeLine = 226;
            INNERMSG3  .UpdateValue ( "\", \"roomNumber\": \"" + ROOMNUMBER + "\",\"coordinates\": \"" + LAT + "," + LON + "\", \"floor\": \"" + FLR + "\""  ) ; 
            __context__.SourceCodeLine = 227;
            INNERMSG4  .UpdateValue ( "},\"actions\": [{\"actor\": \"" + ACTOR + "\", \"description\": \"" + DESC + "\"}]}"  ) ; 
            __context__.SourceCodeLine = 228;
            CONTENTLENGTH = (short) ( (((Functions.Length( INNERMSG1 ) + Functions.Length( INNERMSG2 )) + Functions.Length( INNERMSG3 )) + Functions.Length( INNERMSG4 )) ) ; 
            __context__.SourceCodeLine = 229;
            CLSTRING  .UpdateValue ( Functions.ItoA (  (int) ( CONTENTLENGTH ) )  ) ; 
            __context__.SourceCodeLine = 231;
            HEADER1  .UpdateValue ( "POST events/" + USERORSYSTEM + "/ HTTP/1.1" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 232;
            HEADER2  .UpdateValue ( "Host: " + REPORTINGHOST + ":" + Functions.ItoA (  (int) ( REPORTINGHOSTPORT ) ) + "\r\n"  ) ; 
            __context__.SourceCodeLine = 233;
            HEADER3  .UpdateValue ( "Connection: keep-alive" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 234;
            HEADER4  .UpdateValue ( "Content-Length: " + CLSTRING + "\r\n"  ) ; 
            __context__.SourceCodeLine = 235;
            HEADER5  .UpdateValue ( "Content-type: text/plain;charset=UTF-8" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 236;
            HEADER6  .UpdateValue ( "Accept: */*" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 237;
            Print( "{0}", HEADER1 ) ; 
            __context__.SourceCodeLine = 238;
            Print( "{0}", HEADER1 ) ; 
            __context__.SourceCodeLine = 239;
            Print( "{0}", HEADER2 ) ; 
            __context__.SourceCodeLine = 240;
            Print( "{0}", HEADER3 ) ; 
            __context__.SourceCodeLine = 241;
            Print( "{0}", HEADER4 ) ; 
            __context__.SourceCodeLine = 242;
            Print( "{0}", HEADER5 ) ; 
            __context__.SourceCodeLine = 243;
            Print( "{0}", HEADER6 ) ; 
            __context__.SourceCodeLine = 244;
            Print( "{0}", "\r\n" ) ; 
            __context__.SourceCodeLine = 245;
            Print( "{0}", INNERMSG1 ) ; 
            __context__.SourceCodeLine = 246;
            Print( "{0}", INNERMSG2 ) ; 
            __context__.SourceCodeLine = 247;
            Print( "{0}", INNERMSG3 ) ; 
            __context__.SourceCodeLine = 248;
            Print( "{0}", INNERMSG4 ) ; 
            __context__.SourceCodeLine = 250;
            SEND (  __context__ , HEADER1) ; 
            __context__.SourceCodeLine = 251;
            SEND (  __context__ , HEADER2) ; 
            __context__.SourceCodeLine = 252;
            SEND (  __context__ , HEADER3) ; 
            __context__.SourceCodeLine = 253;
            SEND (  __context__ , HEADER4) ; 
            __context__.SourceCodeLine = 254;
            SEND (  __context__ , HEADER5) ; 
            __context__.SourceCodeLine = 255;
            SEND (  __context__ , HEADER6) ; 
            __context__.SourceCodeLine = 256;
            SEND (  __context__ , "\r\n") ; 
            __context__.SourceCodeLine = 257;
            SEND (  __context__ , INNERMSG1) ; 
            __context__.SourceCodeLine = 258;
            SEND (  __context__ , INNERMSG2) ; 
            __context__.SourceCodeLine = 259;
            SEND (  __context__ , INNERMSG3) ; 
            __context__.SourceCodeLine = 260;
            SEND (  __context__ , INNERMSG4) ; 
            
            }
            
        private void GETCONFIGURATIONVALUE (  SplusExecutionContext __context__, CrestronString FIELD ) 
            { 
            short OFFSET = 0;
            short MNUM = 0;
            short YNUM = 0;
            short DNUM = 0;
            short CONTENTLENGTH = 0;
            
            int PORTNUMBER = 0;
            
            CrestronString HEADER1;
            CrestronString HEADER2;
            CrestronString HEADER3;
            CrestronString HEADER4;
            CrestronString HEADER5;
            CrestronString HEADER6;
            HEADER1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            HEADER6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            CrestronString CLSTRING;
            CLSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            
            __context__.SourceCodeLine = 269;
            CONTENTLENGTH = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 270;
            CLSTRING  .UpdateValue ( Functions.ItoA (  (int) ( CONTENTLENGTH ) )  ) ; 
            __context__.SourceCodeLine = 272;
            HEADER1  .UpdateValue ( "GET configuration/device/" + HOSTNAME + "?_source_include=" + FIELD + " HTTP/1.1" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 273;
            HEADER2  .UpdateValue ( "Host: " + REPORTINGHOST + ":" + Functions.ItoA (  (int) ( REPORTINGHOSTPORT ) ) + "\r\n"  ) ; 
            __context__.SourceCodeLine = 274;
            HEADER3  .UpdateValue ( "Connection: keep-alive" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 275;
            HEADER4  .UpdateValue ( "Content-Length: " + CLSTRING + "\r\n"  ) ; 
            __context__.SourceCodeLine = 276;
            HEADER5  .UpdateValue ( "Content-type: text/plain;charset=UTF-8" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 277;
            HEADER6  .UpdateValue ( "Accept: */*" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 279;
            SEND (  __context__ , HEADER1) ; 
            __context__.SourceCodeLine = 280;
            SEND (  __context__ , HEADER2) ; 
            __context__.SourceCodeLine = 281;
            SEND (  __context__ , HEADER3) ; 
            __context__.SourceCodeLine = 282;
            SEND (  __context__ , HEADER4) ; 
            __context__.SourceCodeLine = 283;
            SEND (  __context__ , HEADER5) ; 
            __context__.SourceCodeLine = 284;
            SEND (  __context__ , HEADER6) ; 
            __context__.SourceCodeLine = 285;
            SEND (  __context__ , "\r\n") ; 
            
            }
            
        object STARTUP_PRESS_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 307;
                BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "session", "Session START", "user") ; 
                __context__.SourceCodeLine = 310;
                BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Startup_press", "user") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CONFIRM_SYSTEM_OFF_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 316;
            BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Confirm_System_Off", "user") ; 
            __context__.SourceCodeLine = 319;
            BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "session", "Session STOP", "user") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object PROGRAM_VOLUME_DOWN_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 325;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Program_Volume_Down", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PROGRAM_VOLUME_UP_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 331;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Program_Volume_Up", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_BLANK_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 337;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Blank", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DEVICE_CONTROL_IPTV_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 343;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Device_Control_IPTV", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_HDMI_CABLE_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 349;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_HDMI_Cable", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_HDMI_JACK_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 355;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_HDMI_Jack", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_IPTV_OnRelease_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 361;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_IPTV", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_LOCAL_INPUT_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 367;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Local_Input", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_REMOTE_INPUT1_OnRelease_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 373;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Remote_Input1", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_REMOTE_INPUT2_OnRelease_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 379;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Remote_Input2", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_VGA_CABLE_OnRelease_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 385;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_VGA_Cable", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HELP_MENU_PRESS_OnRelease_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 391;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Help_Menu_Press", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOME_BUTTON_OnRelease_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 397;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Home_button", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_AV_JACK_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 403;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_AV_Jack", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_BLURAY_OnRelease_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 409;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Blu-Ray", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DEVICE_CONTROL_BLURAY_OnRelease_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 415;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_Device_Control_Blu-Ray", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_PA_CONTROL_OnRelease_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 421;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Select_PA_Control", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PROGRAM_VOLUME_SLIDER_PRESS_OnRelease_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 427;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Program_Volume_Slider_Press", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUDIO_ONLY_PRESS_OnRelease_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 433;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "session", "Session START", "user") ; 
        __context__.SourceCodeLine = 436;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "touchpanel", "Audio_Only_Press", "user") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTROLLERHOSTNAME_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TRASH;
        TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        
        
        __context__.SourceCodeLine = 451;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( " " , CONTROLLERHOSTNAME ) <= 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 453;
            TRASH  .UpdateValue ( Functions.Remove ( " " , CONTROLLERHOSTNAME )  ) ; 
            } 
        
        __context__.SourceCodeLine = 455;
        HOSTNAME  .UpdateValue ( CONTROLLERHOSTNAME  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTROLLERIP_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TRASH;
        CrestronString TEMP;
        CrestronString FINAL;
        TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        FINAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        
        
        __context__.SourceCodeLine = 462;
        TRASH  .UpdateValue ( Functions.Remove ( " " , CONTROLLERIP )  ) ; 
        __context__.SourceCodeLine = 463;
        TEMP  .UpdateValue ( CONTROLLERIP  ) ; 
        __context__.SourceCodeLine = 464;
        FINAL  .UpdateValue ( Functions.Remove ( " " , TEMP )  ) ; 
        __context__.SourceCodeLine = 465;
        HOSTIP  .UpdateValue ( FINAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTROLLERMACADDR_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TRASH;
        CrestronString TEMP;
        TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
        
        
        __context__.SourceCodeLine = 472;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( " " , CONTROLLERMACADDR ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 474;
            TEMP  .UpdateValue ( Functions.Left ( CONTROLLERMACADDR ,  (int) ( (Functions.Length( CONTROLLERMACADDR ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 475;
            HOSTMAC  .UpdateValue ( TEMP  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 479;
            HOSTMAC  .UpdateValue ( CONTROLLERMACADDR  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENTCONNECTED_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 487;
        STATUS = (short) ( Functions.SocketConnectClient( CLIENT , REPORTINGHOST , (ushort)( REPORTINGHOSTPORT ) , (ushort)( 0 ) ) ) ; 
        __context__.SourceCodeLine = 490;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 491;
            Print( "Error connecting socket to address {0} on port  {1:d}", REPORTINGHOST , (short)REPORTINGHOSTPORT) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENTCONNECTED_OnRelease_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 499;
        STATUS = (short) ( Functions.SocketDisconnectClient( CLIENT ) ) ; 
        __context__.SourceCodeLine = 501;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 502;
            Print( "Error disconnecting socket to address {0} on port {1:d}", REPORTINGHOST , (short)REPORTINGHOSTPORT) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SYSTEMREADY_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 507;
        _CLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 508;
        BUILDHTTPMESSAGE (  __context__ , HOSTNAME, HOSTIP, HOSTMAC, HOSTBLDG, HOSTROOM, HOSTFLOOR, HOSTLAT, HOSTLON, "controlProcessor", "System rebooted", "system") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENT_OnSocketConnect_27 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short LOCALSTATUS = 0;
        short PORTNUMBER = 0;
        
        
        __context__.SourceCodeLine = 521;
        Print( "OnConnect: input buffer size is: {0:d}\r\n", (short)Functions.Length( CLIENT.SocketRxBuf )) ; 
        __context__.SourceCodeLine = 523;
        LOCALSTATUS = (short) ( Functions.SocketGetRemoteIPAddress( CLIENT , ref REPORTINGHOST ) ) ; 
        __context__.SourceCodeLine = 524;
        PORTNUMBER = (short) ( Functions.SocketGetPortNumber( CLIENT ) ) ; 
        __context__.SourceCodeLine = 526;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LOCALSTATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 527;
            Print( "Error getting remote ip address. {0:d}\r\n", (short)LOCALSTATUS) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 528;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PORTNUMBER < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 529;
                Print( "Error getting client port number. {0:d}\r\n", (int)REPORTINGHOSTPORT) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 531;
                Print( "OnConnect: Connected to port {0:d} on address {1}\r\n", (int)REPORTINGHOSTPORT, REPORTINGHOST ) ; 
                }
            
            }
        
        __context__.SourceCodeLine = 534;
        CreateWait ( "RECONNECTTIMER" , RECONNECTTIME , RECONNECTTIMER_Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public void RECONNECTTIMER_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 536;
            _CLIENTCONNECTED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 537;
            _CLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object CLIENT_OnSocketDisconnect_28 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 544;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CLIENTCONNECTED  .Value == 0))  ) ) 
            {
            __context__.SourceCodeLine = 545;
            Print( "Socket disconnected remotely") ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 547;
            Print( "Local socket disconnect complete.") ; 
            }
        
        __context__.SourceCodeLine = 548;
        _CLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 550;
        CancelWait ( "RECONNECTTIMER" ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENT_OnSocketReceive_29 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 556;
        RetimeWait ( (int)RECONNECTTIME, "RECONNECTTIMER" ) ; 
        __context__.SourceCodeLine = 560;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CLIENT.SocketRxBuf ) < 256 ))  ) ) 
            {
            __context__.SourceCodeLine = 561;
            Print( "Rx: {0}", CLIENT .  SocketRxBuf ) ; 
            }
        
        __context__.SourceCodeLine = 567;
        Functions.ClearBuffer ( CLIENT .  SocketRxBuf ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENT_OnSocketStatus_30 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 574;
        STATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 575;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)STATUS);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 579;
                    LOG (  __context__ , "SOCKET STATUS: Not Connected") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 584;
                    LOG (  __context__ , "SOCKET STATUS: Waiting for Connection") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 588;
                    LOG (  __context__ , "SOCKET STATUS: Connected") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 592;
                    LOG (  __context__ , "SOCKET STATUS: Connection Failed") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 597;
                    LOG (  __context__ , "SOCKET STATUS: Connection Broken Remotely") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 602;
                    LOG (  __context__ , "SOCKET STATUS: Connection Broken Locally") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 607;
                    LOG (  __context__ , "SOCKET STATUS: Performing DNS Lookup") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 611;
                    LOG (  __context__ , "SOCKET STATUS: DNS Lookup Failed") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 616;
                    LOG (  __context__ , "SOCKET STATUS: DNS Name Resolved") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 1 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 620;
                    LOG (  __context__ , "SOCKET STATUS: Client, Server or UDP variable not a TCP/IP or UDP variable.") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 2 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 625;
                    LOG (  __context__ , "SOCKET STATUS: Could not create the connection task") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 3 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 630;
                    LOG (  __context__ , "SOCKET STATUS: Could not resolve address") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 4 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 635;
                    LOG (  __context__ , "SOCKET STATUS: Port not in range of 0-65535.") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 5 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 640;
                    LOG (  __context__ , "SOCKET STATUS: No connection has been established") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 6 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 644;
                    LOG (  __context__ , "SOCKET STATUS: Not enough room in string parameter to hold IP address.") ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 649;
                    LOG (  __context__ , "Socket Status Undefined") ; 
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 651;
        ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 669;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 672;
        REPORTINGHOST  .UpdateValue ( "10.5.34.215"  ) ; 
        __context__.SourceCodeLine = 673;
        REPORTINGHOSTPORT = (ushort) ( 9200 ) ; 
        __context__.SourceCodeLine = 674;
        RECONNECTTIME = (ushort) ( 9000 ) ; 
        __context__.SourceCodeLine = 675;
        HOSTNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 676;
        HOSTIP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 677;
        HOSTMAC  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 678;
        HOSTBLDG  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 679;
        HOSTROOM  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 680;
        HOSTFLOOR  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 681;
        HOSTLAT  .UpdateValue ( "40.249719"  ) ; 
        __context__.SourceCodeLine = 682;
        HOSTLON  .UpdateValue ( "-111.649265"  ) ; 
        
        
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
    REPORTINGHOST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    HOSTNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    HOSTIP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    HOSTMAC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 18, this );
    HOSTBLDG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    HOSTROOM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
    HOSTFLOOR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    HOSTLAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
    HOSTLON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
    MESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65534, this );
    CLIENT  = new SplusTcpClient ( 1024, this );
    
    AUDIO_ONLY_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( AUDIO_ONLY_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( AUDIO_ONLY_PRESS__DigitalInput__, AUDIO_ONLY_PRESS );
    
    CONFIRM_SYSTEM_OFF = new Crestron.Logos.SplusObjects.DigitalInput( CONFIRM_SYSTEM_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIRM_SYSTEM_OFF__DigitalInput__, CONFIRM_SYSTEM_OFF );
    
    HELP_MENU_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( HELP_MENU_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( HELP_MENU_PRESS__DigitalInput__, HELP_MENU_PRESS );
    
    HOME_BUTTON = new Crestron.Logos.SplusObjects.DigitalInput( HOME_BUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( HOME_BUTTON__DigitalInput__, HOME_BUTTON );
    
    PROGRAM_VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( PROGRAM_VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PROGRAM_VOLUME_DOWN__DigitalInput__, PROGRAM_VOLUME_DOWN );
    
    PROGRAM_VOLUME_SLIDER_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( PROGRAM_VOLUME_SLIDER_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( PROGRAM_VOLUME_SLIDER_PRESS__DigitalInput__, PROGRAM_VOLUME_SLIDER_PRESS );
    
    PROGRAM_VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( PROGRAM_VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( PROGRAM_VOLUME_UP__DigitalInput__, PROGRAM_VOLUME_UP );
    
    SELECT_AV_JACK = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_AV_JACK__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_AV_JACK__DigitalInput__, SELECT_AV_JACK );
    
    SELECT_BLANK = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_BLANK__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_BLANK__DigitalInput__, SELECT_BLANK );
    
    SELECT_BLURAY = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_BLURAY__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_BLURAY__DigitalInput__, SELECT_BLURAY );
    
    SELECT_DEVICE_CONTROL_BLURAY = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DEVICE_CONTROL_BLURAY__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DEVICE_CONTROL_BLURAY__DigitalInput__, SELECT_DEVICE_CONTROL_BLURAY );
    
    SELECT_DEVICE_CONTROL_IPTV = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DEVICE_CONTROL_IPTV__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DEVICE_CONTROL_IPTV__DigitalInput__, SELECT_DEVICE_CONTROL_IPTV );
    
    SELECT_HDMI_CABLE = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_HDMI_CABLE__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_HDMI_CABLE__DigitalInput__, SELECT_HDMI_CABLE );
    
    SELECT_HDMI_JACK = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_HDMI_JACK__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_HDMI_JACK__DigitalInput__, SELECT_HDMI_JACK );
    
    SELECT_IPTV = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_IPTV__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_IPTV__DigitalInput__, SELECT_IPTV );
    
    SELECT_LOCAL_INPUT = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_LOCAL_INPUT__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_LOCAL_INPUT__DigitalInput__, SELECT_LOCAL_INPUT );
    
    SELECT_PA_CONTROL = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_PA_CONTROL__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_PA_CONTROL__DigitalInput__, SELECT_PA_CONTROL );
    
    SELECT_REMOTE_INPUT1 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_REMOTE_INPUT1__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_REMOTE_INPUT1__DigitalInput__, SELECT_REMOTE_INPUT1 );
    
    SELECT_REMOTE_INPUT2 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_REMOTE_INPUT2__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_REMOTE_INPUT2__DigitalInput__, SELECT_REMOTE_INPUT2 );
    
    SELECT_VGA_CABLE = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_VGA_CABLE__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_VGA_CABLE__DigitalInput__, SELECT_VGA_CABLE );
    
    STARTUP_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( STARTUP_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( STARTUP_PRESS__DigitalInput__, STARTUP_PRESS );
    
    CLIENTCONNECTED = new Crestron.Logos.SplusObjects.DigitalInput( CLIENTCONNECTED__DigitalInput__, this );
    m_DigitalInputList.Add( CLIENTCONNECTED__DigitalInput__, CLIENTCONNECTED );
    
    SYSTEMREADY = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEMREADY__DigitalInput__, this );
    m_DigitalInputList.Add( SYSTEMREADY__DigitalInput__, SYSTEMREADY );
    
    _CLIENTCONNECTED = new Crestron.Logos.SplusObjects.DigitalOutput( _CLIENTCONNECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( _CLIENTCONNECTED__DigitalOutput__, _CLIENTCONNECTED );
    
    VOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMELEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMELEVEL__AnalogSerialInput__, VOLUMELEVEL );
    
    CONTROLLERHOSTNAME = new Crestron.Logos.SplusObjects.StringInput( CONTROLLERHOSTNAME__AnalogSerialInput__, 32, this );
    m_StringInputList.Add( CONTROLLERHOSTNAME__AnalogSerialInput__, CONTROLLERHOSTNAME );
    
    CONTROLLERIP = new Crestron.Logos.SplusObjects.StringInput( CONTROLLERIP__AnalogSerialInput__, 15, this );
    m_StringInputList.Add( CONTROLLERIP__AnalogSerialInput__, CONTROLLERIP );
    
    CONTROLLERMACADDR = new Crestron.Logos.SplusObjects.StringInput( CONTROLLERMACADDR__AnalogSerialInput__, 18, this );
    m_StringInputList.Add( CONTROLLERMACADDR__AnalogSerialInput__, CONTROLLERMACADDR );
    
    DEVBUILDING = new Crestron.Logos.SplusObjects.StringInput( DEVBUILDING__AnalogSerialInput__, 8, this );
    m_StringInputList.Add( DEVBUILDING__AnalogSerialInput__, DEVBUILDING );
    
    DEVROOM = new Crestron.Logos.SplusObjects.StringInput( DEVROOM__AnalogSerialInput__, 16, this );
    m_StringInputList.Add( DEVROOM__AnalogSerialInput__, DEVROOM );
    
    DEVFLOOR = new Crestron.Logos.SplusObjects.StringInput( DEVFLOOR__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( DEVFLOOR__AnalogSerialInput__, DEVFLOOR );
    
    DEVLATITUDE = new Crestron.Logos.SplusObjects.StringInput( DEVLATITUDE__AnalogSerialInput__, 11, this );
    m_StringInputList.Add( DEVLATITUDE__AnalogSerialInput__, DEVLATITUDE );
    
    DEVLONGITUDE = new Crestron.Logos.SplusObjects.StringInput( DEVLONGITUDE__AnalogSerialInput__, 11, this );
    m_StringInputList.Add( DEVLONGITUDE__AnalogSerialInput__, DEVLONGITUDE );
    
    TODEVBUILDING = new Crestron.Logos.SplusObjects.StringOutput( TODEVBUILDING__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVBUILDING__AnalogSerialOutput__, TODEVBUILDING );
    
    TODEVROOM = new Crestron.Logos.SplusObjects.StringOutput( TODEVROOM__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVROOM__AnalogSerialOutput__, TODEVROOM );
    
    TODEVFLOOR = new Crestron.Logos.SplusObjects.StringOutput( TODEVFLOOR__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVFLOOR__AnalogSerialOutput__, TODEVFLOOR );
    
    TODEVLAT = new Crestron.Logos.SplusObjects.StringOutput( TODEVLAT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVLAT__AnalogSerialOutput__, TODEVLAT );
    
    TODEVLON = new Crestron.Logos.SplusObjects.StringOutput( TODEVLON__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVLON__AnalogSerialOutput__, TODEVLON );
    
    TOCLIENTBUFFER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOCLIENTBUFFER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TOCLIENTBUFFER__DOLLAR____AnalogSerialOutput__, TOCLIENTBUFFER__DOLLAR__ );
    
    CLIENTBUFFER = new Crestron.Logos.SplusObjects.BufferInput( CLIENTBUFFER__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( CLIENTBUFFER__AnalogSerialInput__, CLIENTBUFFER );
    
    RECONNECTTIMER_Callback = new WaitFunction( RECONNECTTIMER_CallbackFn );
    
    STARTUP_PRESS.OnDigitalRelease.Add( new InputChangeHandlerWrapper( STARTUP_PRESS_OnRelease_0, false ) );
    CONFIRM_SYSTEM_OFF.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CONFIRM_SYSTEM_OFF_OnRelease_1, false ) );
    PROGRAM_VOLUME_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PROGRAM_VOLUME_DOWN_OnRelease_2, false ) );
    PROGRAM_VOLUME_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PROGRAM_VOLUME_UP_OnRelease_3, false ) );
    SELECT_BLANK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_BLANK_OnRelease_4, false ) );
    SELECT_DEVICE_CONTROL_IPTV.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_DEVICE_CONTROL_IPTV_OnRelease_5, false ) );
    SELECT_HDMI_CABLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_HDMI_CABLE_OnRelease_6, false ) );
    SELECT_HDMI_JACK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_HDMI_JACK_OnRelease_7, false ) );
    SELECT_IPTV.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_IPTV_OnRelease_8, false ) );
    SELECT_LOCAL_INPUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_LOCAL_INPUT_OnRelease_9, false ) );
    SELECT_REMOTE_INPUT1.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_REMOTE_INPUT1_OnRelease_10, false ) );
    SELECT_REMOTE_INPUT2.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_REMOTE_INPUT2_OnRelease_11, false ) );
    SELECT_VGA_CABLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_VGA_CABLE_OnRelease_12, false ) );
    HELP_MENU_PRESS.OnDigitalRelease.Add( new InputChangeHandlerWrapper( HELP_MENU_PRESS_OnRelease_13, false ) );
    HOME_BUTTON.OnDigitalRelease.Add( new InputChangeHandlerWrapper( HOME_BUTTON_OnRelease_14, false ) );
    SELECT_AV_JACK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_AV_JACK_OnRelease_15, false ) );
    SELECT_BLURAY.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_BLURAY_OnRelease_16, false ) );
    SELECT_DEVICE_CONTROL_BLURAY.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_DEVICE_CONTROL_BLURAY_OnRelease_17, false ) );
    SELECT_PA_CONTROL.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_PA_CONTROL_OnRelease_18, false ) );
    PROGRAM_VOLUME_SLIDER_PRESS.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PROGRAM_VOLUME_SLIDER_PRESS_OnRelease_19, false ) );
    AUDIO_ONLY_PRESS.OnDigitalRelease.Add( new InputChangeHandlerWrapper( AUDIO_ONLY_PRESS_OnRelease_20, false ) );
    CONTROLLERHOSTNAME.OnSerialChange.Add( new InputChangeHandlerWrapper( CONTROLLERHOSTNAME_OnChange_21, false ) );
    CONTROLLERIP.OnSerialChange.Add( new InputChangeHandlerWrapper( CONTROLLERIP_OnChange_22, false ) );
    CONTROLLERMACADDR.OnSerialChange.Add( new InputChangeHandlerWrapper( CONTROLLERMACADDR_OnChange_23, false ) );
    CLIENTCONNECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLIENTCONNECTED_OnPush_24, false ) );
    CLIENTCONNECTED.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CLIENTCONNECTED_OnRelease_25, false ) );
    SYSTEMREADY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMREADY_OnPush_26, false ) );
    CLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( CLIENT_OnSocketConnect_27, true ) );
    CLIENT.OnSocketDisconnect.Add( new SocketHandlerWrapper( CLIENT_OnSocketDisconnect_28, false ) );
    CLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( CLIENT_OnSocketReceive_29, false ) );
    CLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( CLIENT_OnSocketStatus_30, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_METRICS ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction RECONNECTTIMER_Callback;


const uint AUDIO_ONLY_PRESS__DigitalInput__ = 0;
const uint CONFIRM_SYSTEM_OFF__DigitalInput__ = 1;
const uint HELP_MENU_PRESS__DigitalInput__ = 2;
const uint HOME_BUTTON__DigitalInput__ = 3;
const uint PROGRAM_VOLUME_DOWN__DigitalInput__ = 4;
const uint PROGRAM_VOLUME_SLIDER_PRESS__DigitalInput__ = 5;
const uint PROGRAM_VOLUME_UP__DigitalInput__ = 6;
const uint SELECT_AV_JACK__DigitalInput__ = 7;
const uint SELECT_BLANK__DigitalInput__ = 8;
const uint SELECT_BLURAY__DigitalInput__ = 9;
const uint SELECT_DEVICE_CONTROL_BLURAY__DigitalInput__ = 10;
const uint SELECT_DEVICE_CONTROL_IPTV__DigitalInput__ = 11;
const uint SELECT_HDMI_CABLE__DigitalInput__ = 12;
const uint SELECT_HDMI_JACK__DigitalInput__ = 13;
const uint SELECT_IPTV__DigitalInput__ = 14;
const uint SELECT_LOCAL_INPUT__DigitalInput__ = 15;
const uint SELECT_PA_CONTROL__DigitalInput__ = 16;
const uint SELECT_REMOTE_INPUT1__DigitalInput__ = 17;
const uint SELECT_REMOTE_INPUT2__DigitalInput__ = 18;
const uint SELECT_VGA_CABLE__DigitalInput__ = 19;
const uint STARTUP_PRESS__DigitalInput__ = 20;
const uint CLIENTCONNECTED__DigitalInput__ = 21;
const uint SYSTEMREADY__DigitalInput__ = 22;
const uint CONTROLLERHOSTNAME__AnalogSerialInput__ = 0;
const uint CONTROLLERIP__AnalogSerialInput__ = 1;
const uint CONTROLLERMACADDR__AnalogSerialInput__ = 2;
const uint DEVBUILDING__AnalogSerialInput__ = 3;
const uint DEVROOM__AnalogSerialInput__ = 4;
const uint DEVFLOOR__AnalogSerialInput__ = 5;
const uint DEVLATITUDE__AnalogSerialInput__ = 6;
const uint DEVLONGITUDE__AnalogSerialInput__ = 7;
const uint VOLUMELEVEL__AnalogSerialInput__ = 8;
const uint CLIENTBUFFER__AnalogSerialInput__ = 9;
const uint _CLIENTCONNECTED__DigitalOutput__ = 0;
const uint TODEVBUILDING__AnalogSerialOutput__ = 0;
const uint TODEVROOM__AnalogSerialOutput__ = 1;
const uint TODEVFLOOR__AnalogSerialOutput__ = 2;
const uint TODEVLAT__AnalogSerialOutput__ = 3;
const uint TODEVLON__AnalogSerialOutput__ = 4;
const uint TOCLIENTBUFFER__DOLLAR____AnalogSerialOutput__ = 5;

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

[SplusStructAttribute(-1, true, false)]
public class QUEUEDEVENT : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  USERORSYSTEM;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  HEADER1;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  HEADER2;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  HEADER3;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  HEADER4;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  HEADER5;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  HEADER6;
    
    [SplusStructAttribute(7, false, false)]
    public CrestronString  INNERMSG1;
    
    [SplusStructAttribute(8, false, false)]
    public CrestronString  INNERMSG2;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  INNERMSG3;
    
    [SplusStructAttribute(10, false, false)]
    public CrestronString  INNERMSG4;
    
    
    public QUEUEDEVENT( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        USERORSYSTEM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, Owner );
        HEADER1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        HEADER2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        HEADER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        HEADER4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        HEADER5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        HEADER6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        INNERMSG1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        INNERMSG2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        INNERMSG3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        INNERMSG4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        
        
    }
    
}

}
