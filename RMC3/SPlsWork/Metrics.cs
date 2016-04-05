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
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput STARTUP_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput CONFIRM_SYSTEM_OFF;
        Crestron.Logos.SplusObjects.DigitalInput PROGRAM_VOLUME_DOWN;
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
        Crestron.Logos.SplusObjects.DigitalInput HELP_MENU_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput HOME_BUTTON;
        Crestron.Logos.SplusObjects.DigitalInput PROGRAM_VOLUME_SLIDER_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput AUDIO_ONLY_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput CLIENTCONNECTED;
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMREADY;
        Crestron.Logos.SplusObjects.StringInput DMPSHOSTNAME;
        Crestron.Logos.SplusObjects.StringInput DMPSIP;
        Crestron.Logos.SplusObjects.StringInput DMPSMACADDR;
        Crestron.Logos.SplusObjects.StringInput DEVBUILDING;
        Crestron.Logos.SplusObjects.StringInput DEVROOM;
        Crestron.Logos.SplusObjects.StringInput DEVFLOOR;
        Crestron.Logos.SplusObjects.StringInput DEVLATITUDE;
        Crestron.Logos.SplusObjects.StringInput DEVLONGITUDE;
        Crestron.Logos.SplusObjects.StringInput VOLUMELEVEL;
        Crestron.Logos.SplusObjects.StringInput SESSIONID;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL1;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL2;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL3;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL4;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL5;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL6;
        Crestron.Logos.SplusObjects.StringInput INPUTLABEL7;
        Crestron.Logos.SplusObjects.BufferInput CLIENTBUFFER;
        Crestron.Logos.SplusObjects.DigitalOutput _CLIENTCONNECTED;
        Crestron.Logos.SplusObjects.StringOutput TODEVBUILDING;
        Crestron.Logos.SplusObjects.StringOutput TODEVROOM;
        Crestron.Logos.SplusObjects.StringOutput TODEVFLOOR;
        Crestron.Logos.SplusObjects.StringOutput TODEVLAT;
        Crestron.Logos.SplusObjects.StringOutput TODEVLON;
        Crestron.Logos.SplusObjects.StringOutput TOCLIENTBUFFER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput STORESESSIONID;
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
        CrestronString SESSION;
        CrestronString INPUT1;
        CrestronString INPUT2;
        CrestronString INPUT3;
        CrestronString INPUT4;
        CrestronString INPUT5;
        CrestronString INPUT6;
        CrestronString INPUT7;
        CrestronString MESSAGE;
        ushort REPORTINGHOSTPORT = 0;
        ushort RECONNECTTIME = 0;
        private void LOG (  SplusExecutionContext __context__, CrestronString MSG ) 
            { 
            
            __context__.SourceCodeLine = 85;
            Print( "\r\n{0}", MSG ) ; 
            
            }
            
        private void ERROR (  SplusExecutionContext __context__, CrestronString MSG ) 
            { 
            
            __context__.SourceCodeLine = 91;
            LOG (  __context__ , MSG) ; 
            
            }
            
        private void SEND (  SplusExecutionContext __context__, CrestronString MSG ) 
            { 
            
            __context__.SourceCodeLine = 96;
            Print( "Sending: {0}", MSG ) ; 
            __context__.SourceCodeLine = 97;
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
            
            
            __context__.SourceCodeLine = 105;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "building" , INPUTSTRING ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "roomNumber" , INPUTSTRING ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "floor" , INPUTSTRING ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "building" , INPUTSTRING ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 107;
                TRASH  .UpdateValue ( Functions.Remove ( ":[" , INPUTSTRING )  ) ; 
                __context__.SourceCodeLine = 108;
                PARSETHISSTRING  .UpdateValue ( INPUTSTRING  ) ; 
                __context__.SourceCodeLine = 111;
                HOSTLON  .UpdateValue ( Functions.Remove ( "," , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 114;
                HOSTLAT  .UpdateValue ( Functions.Remove ( "]," , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 117;
                TRASH  .UpdateValue ( Functions.Remove ( ":\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 118;
                HOSTROOM  .UpdateValue ( Functions.Remove ( "\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 121;
                TRASH  .UpdateValue ( Functions.Remove ( ":\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 122;
                HOSTFLOOR  .UpdateValue ( Functions.Remove ( "," , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 126;
                TRASH  .UpdateValue ( Functions.Remove ( ":\"" , PARSETHISSTRING )  ) ; 
                __context__.SourceCodeLine = 127;
                TEMP  .UpdateValue ( PARSETHISSTRING  ) ; 
                __context__.SourceCodeLine = 128;
                HOSTBLDG  .UpdateValue ( Functions.Remove ( "\"" , TEMP )  ) ; 
                } 
            
            
            }
            
        private void BUILDHTTPMESSAGE (  SplusExecutionContext __context__, CrestronString EVENTACTOR , CrestronString EVENTACTION , CrestronString USERORSYSTEM , CrestronString SESSN ) 
            { 
            short OFFSET = 0;
            short MNUM = 0;
            short YNUM = 0;
            short DNUM = 0;
            short CONTENTLENGTH = 0;
            
            int PORTNUMBER = 0;
            
            CrestronString TIMESTAMP;
            TIMESTAMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            
            CrestronString DATESTR;
            DATESTR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            
            CrestronString TIMESTR;
            TIMESTR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            
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
            
            ushort SPACEPOSITION = 0;
            
            
            __context__.SourceCodeLine = 157;
            DESCRIPTION  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 158;
            IPADDRESS  .UpdateValue ( HOSTIP  ) ; 
            __context__.SourceCodeLine = 159;
            MAC  .UpdateValue ( HOSTMAC  ) ; 
            __context__.SourceCodeLine = 160;
            BUILDING  .UpdateValue ( HOSTBLDG  ) ; 
            __context__.SourceCodeLine = 161;
            ROOMNUMBER  .UpdateValue ( HOSTROOM  ) ; 
            __context__.SourceCodeLine = 162;
            LAT  .UpdateValue ( HOSTLAT  ) ; 
            __context__.SourceCodeLine = 163;
            LON  .UpdateValue ( HOSTLON  ) ; 
            __context__.SourceCodeLine = 164;
            FLR  .UpdateValue ( HOSTFLOOR  ) ; 
            __context__.SourceCodeLine = 165;
            ACTOR  .UpdateValue ( EVENTACTOR  ) ; 
            __context__.SourceCodeLine = 166;
            DESC  .UpdateValue ( EVENTACTION  ) ; 
            __context__.SourceCodeLine = 167;
            TYPE  .UpdateValue ( USERORSYSTEM  ) ; 
            __context__.SourceCodeLine = 169;
            SPACEPOSITION = (ushort) ( Functions.Find( " " , HOSTNAME ) ) ; 
            __context__.SourceCodeLine = 170;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SPACEPOSITION == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 171;
                HOSTNAME  .UpdateValue ( Functions.Right ( HOSTNAME ,  (int) ( (Functions.Length( HOSTNAME ) - 1) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 174;
            OFFSET = (short) ( Functions.GetGmtOffset() ) ; 
            __context__.SourceCodeLine = 175;
            MNUM = (short) ( Functions.GetMonthNum() ) ; 
            __context__.SourceCodeLine = 176;
            YNUM = (short) ( Functions.GetYearNum() ) ; 
            __context__.SourceCodeLine = 177;
            DNUM = (short) ( Functions.GetDateNum() ) ; 
            __context__.SourceCodeLine = 179;
            DATESTR  .UpdateValue ( Functions.ItoA (  (int) ( YNUM ) ) + "-" + Functions.ItoA (  (int) ( MNUM ) ) + "-" + Functions.ItoA (  (int) ( DNUM ) )  ) ; 
            __context__.SourceCodeLine = 180;
            TIMESTR  .UpdateValue ( Functions.Time ( )  ) ; 
            __context__.SourceCodeLine = 182;
            TIMESTAMP  .UpdateValue ( DATESTR + "T" + TIMESTR + "Z"  ) ; 
            __context__.SourceCodeLine = 184;
            INNERMSG1  .UpdateValue ( "{\"type\": \"" + TYPE + "\",\"timestamp\": \"" + TIMESTAMP + "\",\"eventTime\": \"" + TIMESTR + "\",\"eventDate\": \"" + DATESTR + "\",\"device\": {\"hostname\": \"" + HOSTNAME + "\", \"description\": \""  ) ; 
            __context__.SourceCodeLine = 185;
            INNERMSG2  .UpdateValue ( "" + DESCRIPTION + "\", \"ipAddress\": \"" + IPADDRESS + "\", \"macAddress\": \"" + MAC + "\"}, \"room\": { \"building\": \"" + BUILDING  ) ; 
            __context__.SourceCodeLine = 186;
            INNERMSG3  .UpdateValue ( "\", \"roomNumber\": \"" + ROOMNUMBER + "\",\"coordinates\": \"" + LAT + "," + LON + "\", \"floor\": \"" + FLR + "\""  ) ; 
            __context__.SourceCodeLine = 187;
            INNERMSG4  .UpdateValue ( "},\"action\": {\"actor\": \"" + ACTOR + "\", \"description\": \"" + DESC + "\"}, \"session\": \"" + SESSION + "\"}"  ) ; 
            __context__.SourceCodeLine = 188;
            CONTENTLENGTH = (short) ( (((Functions.Length( INNERMSG1 ) + Functions.Length( INNERMSG2 )) + Functions.Length( INNERMSG3 )) + Functions.Length( INNERMSG4 )) ) ; 
            __context__.SourceCodeLine = 189;
            CLSTRING  .UpdateValue ( Functions.ItoA (  (int) ( CONTENTLENGTH ) )  ) ; 
            __context__.SourceCodeLine = 191;
            HEADER1  .UpdateValue ( "POST events/" + USERORSYSTEM + "/ HTTP/1.1" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 192;
            HEADER2  .UpdateValue ( "Host: " + REPORTINGHOST + ":" + Functions.ItoA (  (int) ( REPORTINGHOSTPORT ) ) + "\r\n"  ) ; 
            __context__.SourceCodeLine = 193;
            HEADER3  .UpdateValue ( "Connection: keep-alive" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 194;
            HEADER4  .UpdateValue ( "Content-Length: " + CLSTRING + "\r\n"  ) ; 
            __context__.SourceCodeLine = 195;
            HEADER5  .UpdateValue ( "Content-type: text/plain;charset=UTF-8" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 196;
            HEADER6  .UpdateValue ( "Accept: */*" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 197;
            Print( "{0}", HEADER1 ) ; 
            __context__.SourceCodeLine = 198;
            Print( "{0}", HEADER1 ) ; 
            __context__.SourceCodeLine = 199;
            Print( "{0}", HEADER2 ) ; 
            __context__.SourceCodeLine = 200;
            Print( "{0}", HEADER3 ) ; 
            __context__.SourceCodeLine = 201;
            Print( "{0}", HEADER4 ) ; 
            __context__.SourceCodeLine = 202;
            Print( "{0}", HEADER5 ) ; 
            __context__.SourceCodeLine = 203;
            Print( "{0}", HEADER6 ) ; 
            __context__.SourceCodeLine = 204;
            Print( "{0}", "\r\n" ) ; 
            __context__.SourceCodeLine = 205;
            Print( "{0}", INNERMSG1 ) ; 
            __context__.SourceCodeLine = 206;
            Print( "{0}", INNERMSG2 ) ; 
            __context__.SourceCodeLine = 207;
            Print( "{0}", INNERMSG3 ) ; 
            __context__.SourceCodeLine = 208;
            Print( "{0}", INNERMSG4 ) ; 
            __context__.SourceCodeLine = 210;
            SEND (  __context__ , HEADER1) ; 
            __context__.SourceCodeLine = 211;
            SEND (  __context__ , HEADER2) ; 
            __context__.SourceCodeLine = 212;
            SEND (  __context__ , HEADER3) ; 
            __context__.SourceCodeLine = 213;
            SEND (  __context__ , HEADER4) ; 
            __context__.SourceCodeLine = 214;
            SEND (  __context__ , HEADER5) ; 
            __context__.SourceCodeLine = 215;
            SEND (  __context__ , HEADER6) ; 
            __context__.SourceCodeLine = 216;
            SEND (  __context__ , "\r\n") ; 
            __context__.SourceCodeLine = 217;
            SEND (  __context__ , INNERMSG1) ; 
            __context__.SourceCodeLine = 218;
            SEND (  __context__ , INNERMSG2) ; 
            __context__.SourceCodeLine = 219;
            SEND (  __context__ , INNERMSG3) ; 
            __context__.SourceCodeLine = 220;
            SEND (  __context__ , INNERMSG4) ; 
            
            }
            
        private void STARTSESSION (  SplusExecutionContext __context__ ) 
            { 
            short MNUM = 0;
            short YNUM = 0;
            short DNUM = 0;
            
            ushort TICKS = 0;
            ushort CH = 0;
            ushort COUNTER = 0;
            ushort PERIOD = 0;
            
            CrestronString GENSESSION;
            CrestronString MSG;
            CrestronString TMPMAC;
            CrestronString LEFTOVER;
            CrestronString TMP;
            GENSESSION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            TMPMAC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
            LEFTOVER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
            TMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
            
            
            __context__.SourceCodeLine = 229;
            TMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 230;
            LEFTOVER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 231;
            TICKS = (ushort) ( Functions.GetTicks() ) ; 
            __context__.SourceCodeLine = 233;
            GENSESSION  .UpdateValue ( Functions.ItoA (  (int) ( TICKS ) )  ) ; 
            __context__.SourceCodeLine = 234;
            TMPMAC  .UpdateValue ( HOSTMAC  ) ; 
            __context__.SourceCodeLine = 235;
            MNUM = (short) ( Functions.GetMonthNum() ) ; 
            __context__.SourceCodeLine = 236;
            YNUM = (short) ( Functions.GetYearNum() ) ; 
            __context__.SourceCodeLine = 237;
            DNUM = (short) ( Functions.GetDateNum() ) ; 
            __context__.SourceCodeLine = 239;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( TMPMAC ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "." , TMPMAC ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 241;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 242;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 243;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 244;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 245;
                PERIOD = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 247;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 248;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 249;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 250;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 251;
                PERIOD = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 253;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 254;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 255;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 256;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 257;
                PERIOD = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 259;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 260;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 261;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 262;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 263;
                PERIOD = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 265;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 266;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 267;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 268;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 269;
                PERIOD = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 271;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 272;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                __context__.SourceCodeLine = 273;
                CH = (ushort) ( Functions.GetC( TMPMAC ) ) ; 
                __context__.SourceCodeLine = 274;
                LEFTOVER  .UpdateValue ( LEFTOVER + Functions.Chr (  (int) ( CH ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 276;
            TMPMAC  .UpdateValue ( LEFTOVER  ) ; 
            __context__.SourceCodeLine = 277;
            HOSTMAC  .UpdateValue ( TMPMAC  ) ; 
            __context__.SourceCodeLine = 278;
            STORESESSIONID  .UpdateValue ( TMPMAC + "-" + GENSESSION + "-" + Functions.ItoA (  (int) ( YNUM ) ) + Functions.ItoA (  (int) ( MNUM ) ) + Functions.ItoA (  (int) ( DNUM ) )  ) ; 
            __context__.SourceCodeLine = 279;
            MSG  .UpdateValue ( "Session START: " + GENSESSION  ) ; 
            __context__.SourceCodeLine = 281;
            BUILDHTTPMESSAGE (  __context__ , "session", MSG, "user", SESSION) ; 
            
            }
            
        private void ENDSESSION (  SplusExecutionContext __context__ ) 
            { 
            CrestronString MSG;
            MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 288;
            MSG  .UpdateValue ( "Session STOP: " + SESSION  ) ; 
            __context__.SourceCodeLine = 290;
            STORESESSIONID  .UpdateValue ( " "  ) ; 
            __context__.SourceCodeLine = 293;
            BUILDHTTPMESSAGE (  __context__ , "session", MSG, "user", SESSION) ; 
            
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
            
            
            __context__.SourceCodeLine = 302;
            CONTENTLENGTH = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 303;
            CLSTRING  .UpdateValue ( Functions.ItoA (  (int) ( CONTENTLENGTH ) )  ) ; 
            __context__.SourceCodeLine = 305;
            HEADER1  .UpdateValue ( "GET configuration/device/" + HOSTNAME + "?_source_include=" + FIELD + " HTTP/1.1" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 306;
            HEADER2  .UpdateValue ( "Host: " + REPORTINGHOST + ":" + Functions.ItoA (  (int) ( REPORTINGHOSTPORT ) ) + "\r\n"  ) ; 
            __context__.SourceCodeLine = 307;
            HEADER3  .UpdateValue ( "Connection: keep-alive" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 308;
            HEADER4  .UpdateValue ( "Content-Length: " + CLSTRING + "\r\n"  ) ; 
            __context__.SourceCodeLine = 309;
            HEADER5  .UpdateValue ( "Content-type: text/plain;charset=UTF-8" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 310;
            HEADER6  .UpdateValue ( "Accept: */*" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 312;
            SEND (  __context__ , HEADER1) ; 
            __context__.SourceCodeLine = 313;
            SEND (  __context__ , HEADER2) ; 
            __context__.SourceCodeLine = 314;
            SEND (  __context__ , HEADER3) ; 
            __context__.SourceCodeLine = 315;
            SEND (  __context__ , HEADER4) ; 
            __context__.SourceCodeLine = 316;
            SEND (  __context__ , HEADER5) ; 
            __context__.SourceCodeLine = 317;
            SEND (  __context__ , HEADER6) ; 
            __context__.SourceCodeLine = 318;
            SEND (  __context__ , "\r\n") ; 
            
            }
            
        object STARTUP_PRESS_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 338;
                STARTSESSION (  __context__  ) ; 
                __context__.SourceCodeLine = 341;
                BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Startup", "user", SESSION) ; 
                
                
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
            
            __context__.SourceCodeLine = 348;
            BUILDHTTPMESSAGE (  __context__ , "touchpanel", "System Off", "user", SESSION) ; 
            __context__.SourceCodeLine = 352;
            ENDSESSION (  __context__  ) ; 
            
            
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
        
        __context__.SourceCodeLine = 358;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Volume Down", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 365;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Volume Up", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 372;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Blank", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 379;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Device Control - IPTV", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 386;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "HDMI Cable", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 393;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "HDMI Jack", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 400;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "IPTV", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 407;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Local Input", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 414;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", INPUT6, "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 420;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", INPUT7, "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 426;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "VGA Cable", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 433;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Help Menu", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 440;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Home Button", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 447;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "AV Jack", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 454;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Blu-ray", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 461;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Device Control - Blu-ray", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 468;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "PA Control", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 475;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Volume Slider", "user", SESSION) ; 
        
        
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
        
        __context__.SourceCodeLine = 482;
        STARTSESSION (  __context__  ) ; 
        __context__.SourceCodeLine = 486;
        BUILDHTTPMESSAGE (  __context__ , "touchpanel", "Audio Only", "user", SESSION) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DMPSHOSTNAME_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 505;
        HOSTNAME  .UpdateValue ( DMPSHOSTNAME  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DMPSIP_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TRASH;
        TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        
        
        __context__.SourceCodeLine = 512;
        TRASH  .UpdateValue ( Functions.Remove ( " " , DMPSIP )  ) ; 
        __context__.SourceCodeLine = 513;
        HOSTIP  .UpdateValue ( DMPSIP  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DMPSMACADDR_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TRASH;
        CrestronString TEMP;
        TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
        
        
        __context__.SourceCodeLine = 520;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( " " , DMPSMACADDR ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 522;
            TEMP  .UpdateValue ( Functions.Left ( DMPSMACADDR ,  (int) ( (Functions.Length( DMPSMACADDR ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 523;
            HOSTMAC  .UpdateValue ( TEMP  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 527;
            HOSTMAC  .UpdateValue ( DMPSMACADDR  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SESSIONID_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 533;
        SESSION  .UpdateValue ( SESSIONID  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL1_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 538;
        INPUT1  .UpdateValue ( INPUTLABEL1  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL2_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 543;
        INPUT2  .UpdateValue ( INPUTLABEL2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL3_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 547;
        INPUT3  .UpdateValue ( INPUTLABEL3  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL4_OnChange_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 551;
        INPUT4  .UpdateValue ( INPUTLABEL4  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL5_OnChange_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 555;
        INPUT5  .UpdateValue ( INPUTLABEL5  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL6_OnChange_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 559;
        INPUT6  .UpdateValue ( INPUTLABEL6  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTLABEL7_OnChange_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 563;
        INPUT7  .UpdateValue ( INPUTLABEL7  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENTCONNECTED_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 570;
        STATUS = (short) ( Functions.SocketConnectClient( CLIENT , REPORTINGHOST , (ushort)( REPORTINGHOSTPORT ) , (ushort)( 0 ) ) ) ; 
        __context__.SourceCodeLine = 573;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 574;
            Print( "Error connecting socket to address {0} on port  {1:d}", REPORTINGHOST , (short)REPORTINGHOSTPORT) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENTCONNECTED_OnRelease_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 582;
        STATUS = (short) ( Functions.SocketDisconnectClient( CLIENT ) ) ; 
        __context__.SourceCodeLine = 584;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 585;
            Print( "Error disconnecting socket to address {0} on port {1:d}", REPORTINGHOST , (short)REPORTINGHOSTPORT) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SYSTEMREADY_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 590;
        _CLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 591;
        BUILDHTTPMESSAGE (  __context__ , "controlProcessor", "System rebooted", "system", "") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIENT_OnSocketConnect_35 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short LOCALSTATUS = 0;
        short PORTNUMBER = 0;
        
        
        __context__.SourceCodeLine = 605;
        Print( "OnConnect: input buffer size is: {0:d}\r\n", (short)Functions.Length( CLIENT.SocketRxBuf )) ; 
        __context__.SourceCodeLine = 607;
        LOCALSTATUS = (short) ( Functions.SocketGetRemoteIPAddress( CLIENT , ref REPORTINGHOST ) ) ; 
        __context__.SourceCodeLine = 608;
        PORTNUMBER = (short) ( Functions.SocketGetPortNumber( CLIENT ) ) ; 
        __context__.SourceCodeLine = 610;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LOCALSTATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 611;
            Print( "Error getting remote ip address. {0:d}\r\n", (short)LOCALSTATUS) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 612;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PORTNUMBER < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 613;
                Print( "Error getting client port number. {0:d}\r\n", (int)REPORTINGHOSTPORT) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 615;
                Print( "OnConnect: Connected to port {0:d} on address {1}\r\n", (int)REPORTINGHOSTPORT, REPORTINGHOST ) ; 
                }
            
            }
        
        __context__.SourceCodeLine = 618;
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
        
            
            __context__.SourceCodeLine = 620;
            _CLIENTCONNECTED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 621;
            _CLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object CLIENT_OnSocketDisconnect_36 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 628;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CLIENTCONNECTED  .Value == 0))  ) ) 
            {
            __context__.SourceCodeLine = 629;
            Print( "Socket disconnected remotely") ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 631;
            Print( "Local socket disconnect complete.") ; 
            }
        
        __context__.SourceCodeLine = 632;
        _CLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 634;
        CancelWait ( "RECONNECTTIMER" ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENT_OnSocketReceive_37 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 640;
        RetimeWait ( (int)RECONNECTTIME, "RECONNECTTIMER" ) ; 
        __context__.SourceCodeLine = 644;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CLIENT.SocketRxBuf ) < 256 ))  ) ) 
            {
            __context__.SourceCodeLine = 645;
            Print( "Rx: {0}", CLIENT .  SocketRxBuf ) ; 
            }
        
        __context__.SourceCodeLine = 651;
        Functions.ClearBuffer ( CLIENT .  SocketRxBuf ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CLIENT_OnSocketStatus_38 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 658;
        STATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 659;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)STATUS);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 663;
                    LOG (  __context__ , "SOCKET STATUS: Not Connected") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 668;
                    LOG (  __context__ , "SOCKET STATUS: Waiting for Connection") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 672;
                    LOG (  __context__ , "SOCKET STATUS: Connected") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 676;
                    LOG (  __context__ , "SOCKET STATUS: Connection Failed") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 681;
                    LOG (  __context__ , "SOCKET STATUS: Connection Broken Remotely") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 686;
                    LOG (  __context__ , "SOCKET STATUS: Connection Broken Locally") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 691;
                    LOG (  __context__ , "SOCKET STATUS: Performing DNS Lookup") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 695;
                    LOG (  __context__ , "SOCKET STATUS: DNS Lookup Failed") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 700;
                    LOG (  __context__ , "SOCKET STATUS: DNS Name Resolved") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 1 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 704;
                    LOG (  __context__ , "SOCKET STATUS: Client, Server or UDP variable not a TCP/IP or UDP variable.") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 2 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 709;
                    LOG (  __context__ , "SOCKET STATUS: Could not create the connection task") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 3 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 714;
                    LOG (  __context__ , "SOCKET STATUS: Could not resolve address") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 4 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 719;
                    LOG (  __context__ , "SOCKET STATUS: Port not in range of 0-65535.") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 5 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 724;
                    LOG (  __context__ , "SOCKET STATUS: No connection has been established") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.ToLongInteger( -( 6 ) )) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 728;
                    LOG (  __context__ , "SOCKET STATUS: Not enough room in string parameter to hold IP address.") ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 733;
                    LOG (  __context__ , "Socket Status Undefined") ; 
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 735;
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
        
        __context__.SourceCodeLine = 753;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 755;
        REPORTINGHOST  .UpdateValue ( "avreports.byu.edu"  ) ; 
        __context__.SourceCodeLine = 756;
        REPORTINGHOSTPORT = (ushort) ( 9200 ) ; 
        __context__.SourceCodeLine = 757;
        RECONNECTTIME = (ushort) ( 9000 ) ; 
        __context__.SourceCodeLine = 758;
        HOSTNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 759;
        HOSTIP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 760;
        HOSTMAC  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 761;
        HOSTBLDG  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 762;
        HOSTROOM  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 763;
        HOSTFLOOR  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 764;
        HOSTLAT  .UpdateValue ( "40.249719"  ) ; 
        __context__.SourceCodeLine = 765;
        HOSTLON  .UpdateValue ( "-111.649265"  ) ; 
        __context__.SourceCodeLine = 766;
        SESSION  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 767;
        INPUT1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 768;
        INPUT2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 769;
        INPUT3  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 770;
        INPUT4  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 771;
        INPUT5  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 772;
        INPUT6  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 773;
        INPUT7  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    REPORTINGHOST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    HOSTNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    HOSTIP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    HOSTMAC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    HOSTBLDG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    HOSTROOM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
    HOSTFLOOR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    HOSTLAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
    HOSTLON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
    SESSION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    INPUT1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    INPUT2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    INPUT3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    INPUT4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    INPUT5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    INPUT6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    INPUT7  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    MESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65534, this );
    CLIENT  = new SplusTcpClient ( 1024, this );
    
    STARTUP_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( STARTUP_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( STARTUP_PRESS__DigitalInput__, STARTUP_PRESS );
    
    CONFIRM_SYSTEM_OFF = new Crestron.Logos.SplusObjects.DigitalInput( CONFIRM_SYSTEM_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( CONFIRM_SYSTEM_OFF__DigitalInput__, CONFIRM_SYSTEM_OFF );
    
    PROGRAM_VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( PROGRAM_VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PROGRAM_VOLUME_DOWN__DigitalInput__, PROGRAM_VOLUME_DOWN );
    
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
    
    HELP_MENU_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( HELP_MENU_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( HELP_MENU_PRESS__DigitalInput__, HELP_MENU_PRESS );
    
    HOME_BUTTON = new Crestron.Logos.SplusObjects.DigitalInput( HOME_BUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( HOME_BUTTON__DigitalInput__, HOME_BUTTON );
    
    PROGRAM_VOLUME_SLIDER_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( PROGRAM_VOLUME_SLIDER_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( PROGRAM_VOLUME_SLIDER_PRESS__DigitalInput__, PROGRAM_VOLUME_SLIDER_PRESS );
    
    AUDIO_ONLY_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( AUDIO_ONLY_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( AUDIO_ONLY_PRESS__DigitalInput__, AUDIO_ONLY_PRESS );
    
    CLIENTCONNECTED = new Crestron.Logos.SplusObjects.DigitalInput( CLIENTCONNECTED__DigitalInput__, this );
    m_DigitalInputList.Add( CLIENTCONNECTED__DigitalInput__, CLIENTCONNECTED );
    
    SYSTEMREADY = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEMREADY__DigitalInput__, this );
    m_DigitalInputList.Add( SYSTEMREADY__DigitalInput__, SYSTEMREADY );
    
    _CLIENTCONNECTED = new Crestron.Logos.SplusObjects.DigitalOutput( _CLIENTCONNECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( _CLIENTCONNECTED__DigitalOutput__, _CLIENTCONNECTED );
    
    DMPSHOSTNAME = new Crestron.Logos.SplusObjects.StringInput( DMPSHOSTNAME__AnalogSerialInput__, 32, this );
    m_StringInputList.Add( DMPSHOSTNAME__AnalogSerialInput__, DMPSHOSTNAME );
    
    DMPSIP = new Crestron.Logos.SplusObjects.StringInput( DMPSIP__AnalogSerialInput__, 15, this );
    m_StringInputList.Add( DMPSIP__AnalogSerialInput__, DMPSIP );
    
    DMPSMACADDR = new Crestron.Logos.SplusObjects.StringInput( DMPSMACADDR__AnalogSerialInput__, 18, this );
    m_StringInputList.Add( DMPSMACADDR__AnalogSerialInput__, DMPSMACADDR );
    
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
    
    VOLUMELEVEL = new Crestron.Logos.SplusObjects.StringInput( VOLUMELEVEL__AnalogSerialInput__, 4, this );
    m_StringInputList.Add( VOLUMELEVEL__AnalogSerialInput__, VOLUMELEVEL );
    
    SESSIONID = new Crestron.Logos.SplusObjects.StringInput( SESSIONID__AnalogSerialInput__, 256, this );
    m_StringInputList.Add( SESSIONID__AnalogSerialInput__, SESSIONID );
    
    INPUTLABEL1 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL1__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL1__AnalogSerialInput__, INPUTLABEL1 );
    
    INPUTLABEL2 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL2__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL2__AnalogSerialInput__, INPUTLABEL2 );
    
    INPUTLABEL3 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL3__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL3__AnalogSerialInput__, INPUTLABEL3 );
    
    INPUTLABEL4 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL4__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL4__AnalogSerialInput__, INPUTLABEL4 );
    
    INPUTLABEL5 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL5__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL5__AnalogSerialInput__, INPUTLABEL5 );
    
    INPUTLABEL6 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL6__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL6__AnalogSerialInput__, INPUTLABEL6 );
    
    INPUTLABEL7 = new Crestron.Logos.SplusObjects.StringInput( INPUTLABEL7__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( INPUTLABEL7__AnalogSerialInput__, INPUTLABEL7 );
    
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
    
    STORESESSIONID = new Crestron.Logos.SplusObjects.StringOutput( STORESESSIONID__AnalogSerialOutput__, this );
    m_StringOutputList.Add( STORESESSIONID__AnalogSerialOutput__, STORESESSIONID );
    
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
    DMPSHOSTNAME.OnSerialChange.Add( new InputChangeHandlerWrapper( DMPSHOSTNAME_OnChange_21, false ) );
    DMPSIP.OnSerialChange.Add( new InputChangeHandlerWrapper( DMPSIP_OnChange_22, false ) );
    DMPSMACADDR.OnSerialChange.Add( new InputChangeHandlerWrapper( DMPSMACADDR_OnChange_23, false ) );
    SESSIONID.OnSerialChange.Add( new InputChangeHandlerWrapper( SESSIONID_OnChange_24, false ) );
    INPUTLABEL1.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL1_OnChange_25, false ) );
    INPUTLABEL2.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL2_OnChange_26, false ) );
    INPUTLABEL3.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL3_OnChange_27, false ) );
    INPUTLABEL4.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL4_OnChange_28, false ) );
    INPUTLABEL5.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL5_OnChange_29, false ) );
    INPUTLABEL6.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL6_OnChange_30, false ) );
    INPUTLABEL7.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUTLABEL7_OnChange_31, false ) );
    CLIENTCONNECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLIENTCONNECTED_OnPush_32, false ) );
    CLIENTCONNECTED.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CLIENTCONNECTED_OnRelease_33, false ) );
    SYSTEMREADY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMREADY_OnPush_34, false ) );
    CLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( CLIENT_OnSocketConnect_35, true ) );
    CLIENT.OnSocketDisconnect.Add( new SocketHandlerWrapper( CLIENT_OnSocketDisconnect_36, false ) );
    CLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( CLIENT_OnSocketReceive_37, false ) );
    CLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( CLIENT_OnSocketStatus_38, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_METRICS ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction RECONNECTTIMER_Callback;


const uint STARTUP_PRESS__DigitalInput__ = 0;
const uint CONFIRM_SYSTEM_OFF__DigitalInput__ = 1;
const uint PROGRAM_VOLUME_DOWN__DigitalInput__ = 2;
const uint PROGRAM_VOLUME_UP__DigitalInput__ = 3;
const uint SELECT_AV_JACK__DigitalInput__ = 4;
const uint SELECT_BLANK__DigitalInput__ = 5;
const uint SELECT_BLURAY__DigitalInput__ = 6;
const uint SELECT_DEVICE_CONTROL_BLURAY__DigitalInput__ = 7;
const uint SELECT_DEVICE_CONTROL_IPTV__DigitalInput__ = 8;
const uint SELECT_HDMI_CABLE__DigitalInput__ = 9;
const uint SELECT_HDMI_JACK__DigitalInput__ = 10;
const uint SELECT_IPTV__DigitalInput__ = 11;
const uint SELECT_LOCAL_INPUT__DigitalInput__ = 12;
const uint SELECT_PA_CONTROL__DigitalInput__ = 13;
const uint SELECT_REMOTE_INPUT1__DigitalInput__ = 14;
const uint SELECT_REMOTE_INPUT2__DigitalInput__ = 15;
const uint SELECT_VGA_CABLE__DigitalInput__ = 16;
const uint HELP_MENU_PRESS__DigitalInput__ = 17;
const uint HOME_BUTTON__DigitalInput__ = 18;
const uint PROGRAM_VOLUME_SLIDER_PRESS__DigitalInput__ = 19;
const uint AUDIO_ONLY_PRESS__DigitalInput__ = 20;
const uint CLIENTCONNECTED__DigitalInput__ = 21;
const uint SYSTEMREADY__DigitalInput__ = 22;
const uint DMPSHOSTNAME__AnalogSerialInput__ = 0;
const uint DMPSIP__AnalogSerialInput__ = 1;
const uint DMPSMACADDR__AnalogSerialInput__ = 2;
const uint DEVBUILDING__AnalogSerialInput__ = 3;
const uint DEVROOM__AnalogSerialInput__ = 4;
const uint DEVFLOOR__AnalogSerialInput__ = 5;
const uint DEVLATITUDE__AnalogSerialInput__ = 6;
const uint DEVLONGITUDE__AnalogSerialInput__ = 7;
const uint VOLUMELEVEL__AnalogSerialInput__ = 8;
const uint SESSIONID__AnalogSerialInput__ = 9;
const uint INPUTLABEL1__AnalogSerialInput__ = 10;
const uint INPUTLABEL2__AnalogSerialInput__ = 11;
const uint INPUTLABEL3__AnalogSerialInput__ = 12;
const uint INPUTLABEL4__AnalogSerialInput__ = 13;
const uint INPUTLABEL5__AnalogSerialInput__ = 14;
const uint INPUTLABEL6__AnalogSerialInput__ = 15;
const uint INPUTLABEL7__AnalogSerialInput__ = 16;
const uint CLIENTBUFFER__AnalogSerialInput__ = 17;
const uint _CLIENTCONNECTED__DigitalOutput__ = 0;
const uint TODEVBUILDING__AnalogSerialOutput__ = 0;
const uint TODEVROOM__AnalogSerialOutput__ = 1;
const uint TODEVFLOOR__AnalogSerialOutput__ = 2;
const uint TODEVLAT__AnalogSerialOutput__ = 3;
const uint TODEVLON__AnalogSerialOutput__ = 4;
const uint TOCLIENTBUFFER__DOLLAR____AnalogSerialOutput__ = 5;
const uint STORESESSIONID__AnalogSerialOutput__ = 6;

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
