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

namespace UserModule_WIRELESS_MIC_MONITORING
{
    public class UserModuleClass_WIRELESS_MIC_MONITORING : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput GET_ALL;
        Crestron.Logos.SplusObjects.DigitalInput TCP_IP_CLIENT_CONNECT_F;
        Crestron.Logos.SplusObjects.BufferInput FROM_WIRELESS__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput TCP_IP_CLIENT_CONNECT;
        Crestron.Logos.SplusObjects.DigitalOutput MIC1_ON;
        Crestron.Logos.SplusObjects.DigitalOutput MIC1LESSTHEN5;
        Crestron.Logos.SplusObjects.DigitalOutput MIC1LESSTHEN3;
        Crestron.Logos.SplusObjects.DigitalOutput MIC1LESSTHEN1ANDAHALF;
        Crestron.Logos.SplusObjects.DigitalOutput MIC1_RF_INT_DET;
        Crestron.Logos.SplusObjects.DigitalOutput MIC2_ON;
        Crestron.Logos.SplusObjects.DigitalOutput MIC2LESSTHEN5;
        Crestron.Logos.SplusObjects.DigitalOutput MIC2LESSTHEN3;
        Crestron.Logos.SplusObjects.DigitalOutput MIC2LESSTHEN1ANDAHALF;
        Crestron.Logos.SplusObjects.DigitalOutput MIC2_RF_INT_DET;
        Crestron.Logos.SplusObjects.AnalogOutput B1TIME;
        Crestron.Logos.SplusObjects.AnalogOutput B1PERCENT;
        Crestron.Logos.SplusObjects.AnalogOutput B1BARS;
        Crestron.Logos.SplusObjects.AnalogOutput B2TIME;
        Crestron.Logos.SplusObjects.AnalogOutput B2PERCENT;
        Crestron.Logos.SplusObjects.AnalogOutput B2BARS;
        Crestron.Logos.SplusObjects.StringOutput TO_WIRELESS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DEVICE_ID;
        Crestron.Logos.SplusObjects.StringOutput FREQUENCY_DIVERSITY_MODE;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_SUMMING_MODE;
        Crestron.Logos.SplusObjects.StringOutput HIGH_DENSITY;
        Crestron.Logos.SplusObjects.StringOutput ENCRYPTION;
        Crestron.Logos.SplusObjects.StringOutput ENCRYPTION_REGENERATE_KEY;
        Crestron.Logos.SplusObjects.StringOutput CHAN_NAME1;
        Crestron.Logos.SplusObjects.StringOutput METER_RATE1;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_GAIN1;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_MUTE1;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_LVL1;
        Crestron.Logos.SplusObjects.StringOutput GROUP_CHAN1;
        Crestron.Logos.SplusObjects.StringOutput FREQUENCY1;
        Crestron.Logos.SplusObjects.StringOutput RF_INT_DET1;
        Crestron.Logos.SplusObjects.StringOutput RX_RF_LVL1;
        Crestron.Logos.SplusObjects.StringOutput RF_ANTENNA1;
        Crestron.Logos.SplusObjects.StringOutput BATT_BARS1;
        Crestron.Logos.SplusObjects.StringOutput TX_OFFSET1;
        Crestron.Logos.SplusObjects.StringOutput TX_RF_PWR1;
        Crestron.Logos.SplusObjects.StringOutput TX_TYPE1;
        Crestron.Logos.SplusObjects.StringOutput BATT_TYPE1;
        Crestron.Logos.SplusObjects.StringOutput BATT_RUN_TIME1;
        Crestron.Logos.SplusObjects.StringOutput BATT_CHARGE1;
        Crestron.Logos.SplusObjects.StringOutput BATT_CYCLE1;
        Crestron.Logos.SplusObjects.StringOutput BATT_TEMP_C1;
        Crestron.Logos.SplusObjects.StringOutput BATT_TEMP_F1;
        Crestron.Logos.SplusObjects.StringOutput TX_PWR_LOCK1;
        Crestron.Logos.SplusObjects.StringOutput TX_MENU_LOCK1;
        Crestron.Logos.SplusObjects.StringOutput ENCRYPTION_WARNING1;
        Crestron.Logos.SplusObjects.StringOutput B1HRMIN;
        Crestron.Logos.SplusObjects.StringOutput M1ONDAT;
        Crestron.Logos.SplusObjects.StringOutput M1OFFDAT;
        Crestron.Logos.SplusObjects.StringOutput CHAN_NAME2;
        Crestron.Logos.SplusObjects.StringOutput METER_RATE2;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_GAIN2;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_MUTE2;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_LVL2;
        Crestron.Logos.SplusObjects.StringOutput GROUP_CHAN2;
        Crestron.Logos.SplusObjects.StringOutput FREQUENCY2;
        Crestron.Logos.SplusObjects.StringOutput RF_INT_DET2;
        Crestron.Logos.SplusObjects.StringOutput RX_RF_LVL2;
        Crestron.Logos.SplusObjects.StringOutput RF_ANTENNA2;
        Crestron.Logos.SplusObjects.StringOutput BATT_BARS2;
        Crestron.Logos.SplusObjects.StringOutput TX_OFFSET2;
        Crestron.Logos.SplusObjects.StringOutput TX_RF_PWR2;
        Crestron.Logos.SplusObjects.StringOutput TX_TYPE2;
        Crestron.Logos.SplusObjects.StringOutput BATT_TYPE2;
        Crestron.Logos.SplusObjects.StringOutput BATT_RUN_TIME2;
        Crestron.Logos.SplusObjects.StringOutput BATT_CHARGE2;
        Crestron.Logos.SplusObjects.StringOutput BATT_CYCLE2;
        Crestron.Logos.SplusObjects.StringOutput BATT_TEMP_C2;
        Crestron.Logos.SplusObjects.StringOutput BATT_TEMP_F2;
        Crestron.Logos.SplusObjects.StringOutput TX_PWR_LOCK2;
        Crestron.Logos.SplusObjects.StringOutput TX_MENU_LOCK2;
        Crestron.Logos.SplusObjects.StringOutput ENCRYPTION_WARNING2;
        Crestron.Logos.SplusObjects.StringOutput B2HRMIN;
        Crestron.Logos.SplusObjects.StringOutput M2ONDAT;
        Crestron.Logos.SplusObjects.StringOutput M2OFFDAT;
        Crestron.Logos.SplusObjects.DigitalOutput MIC2_EXISTS;
        Crestron.Logos.SplusObjects.AnalogOutput B1STATUS;
        Crestron.Logos.SplusObjects.AnalogOutput B2STATUS;
        CrestronString BATTTYPE1__DOLLAR__;
        CrestronString BATTTYPE2__DOLLAR__;
        object GET_ALL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 187;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TCP_IP_CLIENT_CONNECT_F  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 189;
                    TCP_IP_CLIENT_CONNECT  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 193;
                    TO_WIRELESS__DOLLAR__  .UpdateValue ( "< GET 0 ALL >"  ) ; 
                    __context__.SourceCodeLine = 194;
                    Functions.Delay (  (int) ( 200 ) ) ; 
                    __context__.SourceCodeLine = 195;
                    TO_WIRELESS__DOLLAR__  .UpdateValue ( ""  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object TCP_IP_CLIENT_CONNECT_F_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 202;
            TO_WIRELESS__DOLLAR__  .UpdateValue ( "< GET 0 ALL >"  ) ; 
            __context__.SourceCodeLine = 203;
            Functions.Delay (  (int) ( 200 ) ) ; 
            __context__.SourceCodeLine = 205;
            TO_WIRELESS__DOLLAR__  .UpdateValue ( ""  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object FROM_WIRELESS__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort STARTPOSITION = 0;
        ushort HRS1 = 0;
        ushort HRS2 = 0;
        
        CrestronString TEMPSTRING1;
        CrestronString TEMPSTRING2;
        CrestronString SEARCHSTRING;
        TEMPSTRING1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        TEMPSTRING2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        SEARCHSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        
        __context__.SourceCodeLine = 221;
        while ( Functions.TestForTrue  ( ( Functions.Find( ">" , FROM_WIRELESS__DOLLAR__ ))  ) ) 
            { 
            __context__.SourceCodeLine = 224;
            TEMPSTRING1  .UpdateValue ( Functions.Remove ( ">" , FROM_WIRELESS__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 226;
            if ( Functions.TestForTrue  ( ( Functions.Find( "DEVICE_ID " , TEMPSTRING1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 229;
                SEARCHSTRING  .UpdateValue ( "DEVICE_ID "  ) ; 
                __context__.SourceCodeLine = 230;
                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                __context__.SourceCodeLine = 231;
                DEVICE_ID  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                __context__.SourceCodeLine = 232;
                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 235;
                if ( Functions.TestForTrue  ( ( Functions.Find( "FREQUENCY_DIVERSITY_MODE " , TEMPSTRING1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 238;
                    SEARCHSTRING  .UpdateValue ( "FREQUENCY_DIVERSITY_MODE "  ) ; 
                    __context__.SourceCodeLine = 239;
                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                    __context__.SourceCodeLine = 240;
                    FREQUENCY_DIVERSITY_MODE  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                    __context__.SourceCodeLine = 241;
                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 244;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "AUDIO_SUMMING_MODE " , TEMPSTRING1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 247;
                        SEARCHSTRING  .UpdateValue ( "AUDIO_SUMMING_MODE "  ) ; 
                        __context__.SourceCodeLine = 248;
                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                        __context__.SourceCodeLine = 249;
                        AUDIO_SUMMING_MODE  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                        __context__.SourceCodeLine = 250;
                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 253;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "HIGH_DENSITY " , TEMPSTRING1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 256;
                            SEARCHSTRING  .UpdateValue ( "HIGH_DENSITY "  ) ; 
                            __context__.SourceCodeLine = 257;
                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                            __context__.SourceCodeLine = 258;
                            HIGH_DENSITY  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                            __context__.SourceCodeLine = 259;
                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 262;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "ENCRYPTION_REGENERATE_KEY " , TEMPSTRING1 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 265;
                                SEARCHSTRING  .UpdateValue ( "ENCRYPTION_REGENERATE_KEY "  ) ; 
                                __context__.SourceCodeLine = 266;
                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                __context__.SourceCodeLine = 267;
                                ENCRYPTION_REGENERATE_KEY  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                __context__.SourceCodeLine = 268;
                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 271;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 ENCRYPTION_WARNING " , TEMPSTRING1 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 274;
                                    SEARCHSTRING  .UpdateValue ( "REP 1 ENCRYPTION_WARNING "  ) ; 
                                    __context__.SourceCodeLine = 275;
                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                    __context__.SourceCodeLine = 276;
                                    ENCRYPTION_WARNING1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                    __context__.SourceCodeLine = 277;
                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 280;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 ENCRYPTION_WARNING " , TEMPSTRING1 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 283;
                                        MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 284;
                                        SEARCHSTRING  .UpdateValue ( "REP 2 ENCRYPTION_WARNING "  ) ; 
                                        __context__.SourceCodeLine = 285;
                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                        __context__.SourceCodeLine = 286;
                                        ENCRYPTION_WARNING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                        __context__.SourceCodeLine = 287;
                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 290;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "ENCRYPTION " , TEMPSTRING1 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 293;
                                            SEARCHSTRING  .UpdateValue ( "ENCRYPTION "  ) ; 
                                            __context__.SourceCodeLine = 294;
                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                            __context__.SourceCodeLine = 295;
                                            ENCRYPTION  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                            __context__.SourceCodeLine = 296;
                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 299;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 CHAN_NAME " , TEMPSTRING1 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 302;
                                                SEARCHSTRING  .UpdateValue ( "REP 1 CHAN_NAME "  ) ; 
                                                __context__.SourceCodeLine = 303;
                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                __context__.SourceCodeLine = 304;
                                                CHAN_NAME1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                __context__.SourceCodeLine = 305;
                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 309;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 CHAN_NAME " , TEMPSTRING1 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 312;
                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 313;
                                                    SEARCHSTRING  .UpdateValue ( "REP 2 CHAN_NAME "  ) ; 
                                                    __context__.SourceCodeLine = 314;
                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                    __context__.SourceCodeLine = 315;
                                                    CHAN_NAME2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                    __context__.SourceCodeLine = 316;
                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 319;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 METER_RATE " , TEMPSTRING1 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 322;
                                                        SEARCHSTRING  .UpdateValue ( "REP 1 METER_RATE "  ) ; 
                                                        __context__.SourceCodeLine = 323;
                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                        __context__.SourceCodeLine = 324;
                                                        METER_RATE1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                        __context__.SourceCodeLine = 325;
                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 328;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 METER_RATE " , TEMPSTRING1 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 331;
                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                            __context__.SourceCodeLine = 332;
                                                            SEARCHSTRING  .UpdateValue ( "REP 2 METER_RATE "  ) ; 
                                                            __context__.SourceCodeLine = 333;
                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                            __context__.SourceCodeLine = 334;
                                                            METER_RATE2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                            __context__.SourceCodeLine = 335;
                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 338;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 AUDIO_GAIN " , TEMPSTRING1 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 341;
                                                                SEARCHSTRING  .UpdateValue ( "REP 1 AUDIO_GAIN "  ) ; 
                                                                __context__.SourceCodeLine = 342;
                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                __context__.SourceCodeLine = 343;
                                                                AUDIO_GAIN1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                __context__.SourceCodeLine = 344;
                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 347;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 AUDIO_GAIN " , TEMPSTRING1 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 350;
                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                    __context__.SourceCodeLine = 351;
                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 AUDIO_GAIN "  ) ; 
                                                                    __context__.SourceCodeLine = 352;
                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                    __context__.SourceCodeLine = 353;
                                                                    AUDIO_GAIN2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                    __context__.SourceCodeLine = 354;
                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 357;
                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 AUDIO_MUTE " , TEMPSTRING1 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 360;
                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 AUDIO_MUTE "  ) ; 
                                                                        __context__.SourceCodeLine = 361;
                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                        __context__.SourceCodeLine = 362;
                                                                        AUDIO_MUTE1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                        __context__.SourceCodeLine = 363;
                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 367;
                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 AUDIO_MUTE " , TEMPSTRING1 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 370;
                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                            __context__.SourceCodeLine = 371;
                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 AUDIO_MUTE "  ) ; 
                                                                            __context__.SourceCodeLine = 372;
                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                            __context__.SourceCodeLine = 373;
                                                                            AUDIO_MUTE1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 374;
                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 377;
                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 AUDIO_LVL " , TEMPSTRING1 ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 380;
                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 AUDIO_LVL "  ) ; 
                                                                                __context__.SourceCodeLine = 381;
                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                __context__.SourceCodeLine = 382;
                                                                                AUDIO_LVL1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                __context__.SourceCodeLine = 383;
                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 386;
                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 AUDIO_LVL " , TEMPSTRING1 ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 389;
                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                    __context__.SourceCodeLine = 390;
                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 AUDIO_LVL "  ) ; 
                                                                                    __context__.SourceCodeLine = 391;
                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                    __context__.SourceCodeLine = 392;
                                                                                    AUDIO_LVL2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 393;
                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 396;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 GROUP_CHAN " , TEMPSTRING1 ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 399;
                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 GROUP_CHAN "  ) ; 
                                                                                        __context__.SourceCodeLine = 400;
                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                        __context__.SourceCodeLine = 401;
                                                                                        GROUP_CHAN1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 402;
                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 406;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 GROUP_CHAN " , TEMPSTRING1 ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 409;
                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                            __context__.SourceCodeLine = 410;
                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 GROUP_CHAN "  ) ; 
                                                                                            __context__.SourceCodeLine = 411;
                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                            __context__.SourceCodeLine = 412;
                                                                                            GROUP_CHAN2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 413;
                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 416;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 FREQUENCY " , TEMPSTRING1 ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 419;
                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 FREQUENCY "  ) ; 
                                                                                                __context__.SourceCodeLine = 420;
                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                __context__.SourceCodeLine = 421;
                                                                                                FREQUENCY1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                __context__.SourceCodeLine = 422;
                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 425;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 FREQUENCY " , TEMPSTRING1 ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 428;
                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                    __context__.SourceCodeLine = 429;
                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 FREQUENCY "  ) ; 
                                                                                                    __context__.SourceCodeLine = 430;
                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                    __context__.SourceCodeLine = 431;
                                                                                                    FREQUENCY2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                    __context__.SourceCodeLine = 432;
                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 435;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 RF_INT_DET " , TEMPSTRING1 ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 438;
                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 RF_INT_DET "  ) ; 
                                                                                                        __context__.SourceCodeLine = 439;
                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                        __context__.SourceCodeLine = 440;
                                                                                                        TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 441;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 == "NONE"))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 443;
                                                                                                            MIC1_RF_INT_DET  .Value = (ushort) ( 0 ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 445;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 == "CRITICAL"))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 447;
                                                                                                                MIC1_RF_INT_DET  .Value = (ushort) ( 1 ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        __context__.SourceCodeLine = 449;
                                                                                                        RF_INT_DET1  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                        __context__.SourceCodeLine = 450;
                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 454;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 RF_INT_DET " , TEMPSTRING1 ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 457;
                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                            __context__.SourceCodeLine = 458;
                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 RF_INT_DET "  ) ; 
                                                                                                            __context__.SourceCodeLine = 459;
                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                            __context__.SourceCodeLine = 460;
                                                                                                            TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 461;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 == "NONE"))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 463;
                                                                                                                MIC2_RF_INT_DET  .Value = (ushort) ( 0 ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 465;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 == "CRITICAL"))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 467;
                                                                                                                    MIC2_RF_INT_DET  .Value = (ushort) ( 1 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 469;
                                                                                                            RF_INT_DET2  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                            __context__.SourceCodeLine = 470;
                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 473;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 RX_RF_LVL " , TEMPSTRING1 ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 476;
                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 RX_RF_LVL "  ) ; 
                                                                                                                __context__.SourceCodeLine = 477;
                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                __context__.SourceCodeLine = 478;
                                                                                                                RX_RF_LVL1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 479;
                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 482;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 RX_RF_LVL " , TEMPSTRING1 ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 485;
                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                    __context__.SourceCodeLine = 486;
                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 RX_RF_LVL "  ) ; 
                                                                                                                    __context__.SourceCodeLine = 487;
                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                    __context__.SourceCodeLine = 488;
                                                                                                                    RX_RF_LVL2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                    __context__.SourceCodeLine = 489;
                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 492;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 RF_ANTENNA " , TEMPSTRING1 ))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 495;
                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 RF_ANTENNA "  ) ; 
                                                                                                                        __context__.SourceCodeLine = 496;
                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                        __context__.SourceCodeLine = 497;
                                                                                                                        RF_ANTENNA1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                        __context__.SourceCodeLine = 498;
                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 501;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 RF_ANTENNA " , TEMPSTRING1 ))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 504;
                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                            __context__.SourceCodeLine = 505;
                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 RF_ANTENNA "  ) ; 
                                                                                                                            __context__.SourceCodeLine = 506;
                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                            __context__.SourceCodeLine = 507;
                                                                                                                            RF_ANTENNA2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                            __context__.SourceCodeLine = 508;
                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 511;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_BARS " , TEMPSTRING1 ))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 514;
                                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 BATT_BARS "  ) ; 
                                                                                                                                __context__.SourceCodeLine = 515;
                                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                __context__.SourceCodeLine = 516;
                                                                                                                                TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                __context__.SourceCodeLine = 517;
                                                                                                                                if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( TEMPSTRING2, "251" ) > 0))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 519;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MIC1_ON  .Value == 1))  ) ) 
                                                                                                                                        {
                                                                                                                                        __context__.SourceCodeLine = 519;
                                                                                                                                        MakeString ( M1OFFDAT , "{0} {1}", Functions.Date (  (int) ( 3 ) ) , Functions.Time ( ) ) ; 
                                                                                                                                        }
                                                                                                                                    
                                                                                                                                    __context__.SourceCodeLine = 520;
                                                                                                                                    MIC1_ON  .Value = (ushort) ( 0 ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 524;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MIC1_ON  .Value == 0))  ) ) 
                                                                                                                                        {
                                                                                                                                        __context__.SourceCodeLine = 524;
                                                                                                                                        MakeString ( M1ONDAT , "{0} {1}", Functions.Date (  (int) ( 3 ) ) , Functions.Time ( ) ) ; 
                                                                                                                                        }
                                                                                                                                    
                                                                                                                                    __context__.SourceCodeLine = 525;
                                                                                                                                    MIC1_ON  .Value = (ushort) ( 1 ) ; 
                                                                                                                                    __context__.SourceCodeLine = 526;
                                                                                                                                    B1BARS  .Value = (ushort) ( Functions.Atoi( TEMPSTRING2 ) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 527;
                                                                                                                                    BATT_BARS1  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 528;
                                                                                                                                    /* Trace( "1 B1Bars is {0:d} and BattType1$ is {1}", (short)B1BARS  .Value, BATTTYPE1__DOLLAR__ ) */ ; 
                                                                                                                                    __context__.SourceCodeLine = 529;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( B1BARS  .Value < 2 ) ) && Functions.TestForTrue ( Functions.BoolToInt (BATTTYPE1__DOLLAR__ == "ALKA") )) ))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 531;
                                                                                                                                        MIC1LESSTHEN1ANDAHALF  .Value = (ushort) ( 1 ) ; 
                                                                                                                                        __context__.SourceCodeLine = 532;
                                                                                                                                        B1STATUS  .Value = (ushort) ( 3 ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                __context__.SourceCodeLine = 535;
                                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 538;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_BARS " , TEMPSTRING1 ))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 541;
                                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                    __context__.SourceCodeLine = 542;
                                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 BATT_BARS "  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 543;
                                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 544;
                                                                                                                                    TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 545;
                                                                                                                                    if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( TEMPSTRING2, "251" ) > 0))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 547;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MIC2_ON  .Value == 1))  ) ) 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 547;
                                                                                                                                            MakeString ( M2OFFDAT , "{0} {1}", Functions.Date (  (int) ( 3 ) ) , Functions.Time ( ) ) ; 
                                                                                                                                            }
                                                                                                                                        
                                                                                                                                        __context__.SourceCodeLine = 548;
                                                                                                                                        MIC2_ON  .Value = (ushort) ( 0 ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    else 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 552;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MIC2_ON  .Value == 0))  ) ) 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 552;
                                                                                                                                            MakeString ( M2ONDAT , "{0} {1}", Functions.Date (  (int) ( 3 ) ) , Functions.Time ( ) ) ; 
                                                                                                                                            }
                                                                                                                                        
                                                                                                                                        __context__.SourceCodeLine = 553;
                                                                                                                                        MIC2_ON  .Value = (ushort) ( 1 ) ; 
                                                                                                                                        __context__.SourceCodeLine = 554;
                                                                                                                                        B2BARS  .Value = (ushort) ( Functions.Atoi( TEMPSTRING2 ) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 555;
                                                                                                                                        BATT_BARS2  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 556;
                                                                                                                                        /* Trace( "2 B2Bars is {0:d} and BattType2$ is {1}", (short)B2BARS  .Value, BATTTYPE2__DOLLAR__ ) */ ; 
                                                                                                                                        __context__.SourceCodeLine = 557;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( B2BARS  .Value < 2 ) ) && Functions.TestForTrue ( Functions.BoolToInt (BATTTYPE2__DOLLAR__ == "ALKA") )) ))  ) ) 
                                                                                                                                            { 
                                                                                                                                            __context__.SourceCodeLine = 559;
                                                                                                                                            MIC2LESSTHEN1ANDAHALF  .Value = (ushort) ( 1 ) ; 
                                                                                                                                            __context__.SourceCodeLine = 560;
                                                                                                                                            B2STATUS  .Value = (ushort) ( 3 ) ; 
                                                                                                                                            } 
                                                                                                                                        
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    __context__.SourceCodeLine = 563;
                                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 566;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 TX_OFFSET " , TEMPSTRING1 ))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 569;
                                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 TX_OFFSET "  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 570;
                                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 571;
                                                                                                                                        TX_OFFSET1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 572;
                                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    else 
                                                                                                                                        {
                                                                                                                                        __context__.SourceCodeLine = 575;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 TX_OFFSET " , TEMPSTRING1 ))  ) ) 
                                                                                                                                            { 
                                                                                                                                            __context__.SourceCodeLine = 578;
                                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                            __context__.SourceCodeLine = 579;
                                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 TX_OFFSET "  ) ; 
                                                                                                                                            __context__.SourceCodeLine = 580;
                                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                            __context__.SourceCodeLine = 581;
                                                                                                                                            TX_OFFSET2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                            __context__.SourceCodeLine = 582;
                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                            } 
                                                                                                                                        
                                                                                                                                        else 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 585;
                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 TX_RF_PWR " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                { 
                                                                                                                                                __context__.SourceCodeLine = 588;
                                                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 TX_RF_PWR "  ) ; 
                                                                                                                                                __context__.SourceCodeLine = 589;
                                                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                __context__.SourceCodeLine = 590;
                                                                                                                                                TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                __context__.SourceCodeLine = 591;
                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 != "UNKN"))  ) ) 
                                                                                                                                                    { 
                                                                                                                                                    __context__.SourceCodeLine = 593;
                                                                                                                                                    TX_RF_PWR1  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                    } 
                                                                                                                                                
                                                                                                                                                __context__.SourceCodeLine = 595;
                                                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                } 
                                                                                                                                            
                                                                                                                                            else 
                                                                                                                                                {
                                                                                                                                                __context__.SourceCodeLine = 598;
                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 TX_RF_PWR " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                    { 
                                                                                                                                                    __context__.SourceCodeLine = 601;
                                                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                    __context__.SourceCodeLine = 602;
                                                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 TX_RF_PWR "  ) ; 
                                                                                                                                                    __context__.SourceCodeLine = 603;
                                                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                    __context__.SourceCodeLine = 604;
                                                                                                                                                    TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                    __context__.SourceCodeLine = 605;
                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 != "UNKN"))  ) ) 
                                                                                                                                                        { 
                                                                                                                                                        __context__.SourceCodeLine = 607;
                                                                                                                                                        TX_RF_PWR2  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                        } 
                                                                                                                                                    
                                                                                                                                                    __context__.SourceCodeLine = 609;
                                                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                    } 
                                                                                                                                                
                                                                                                                                                else 
                                                                                                                                                    {
                                                                                                                                                    __context__.SourceCodeLine = 612;
                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 TX_TYPE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                        { 
                                                                                                                                                        __context__.SourceCodeLine = 615;
                                                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 TX_TYPE "  ) ; 
                                                                                                                                                        __context__.SourceCodeLine = 616;
                                                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                        __context__.SourceCodeLine = 617;
                                                                                                                                                        TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                        __context__.SourceCodeLine = 618;
                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 != "UNKN"))  ) ) 
                                                                                                                                                            { 
                                                                                                                                                            __context__.SourceCodeLine = 620;
                                                                                                                                                            TX_TYPE1  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                            } 
                                                                                                                                                        
                                                                                                                                                        __context__.SourceCodeLine = 622;
                                                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                        } 
                                                                                                                                                    
                                                                                                                                                    else 
                                                                                                                                                        {
                                                                                                                                                        __context__.SourceCodeLine = 625;
                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 TX_TYPE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                            { 
                                                                                                                                                            __context__.SourceCodeLine = 628;
                                                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                            __context__.SourceCodeLine = 629;
                                                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 TX_TYPE "  ) ; 
                                                                                                                                                            __context__.SourceCodeLine = 630;
                                                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                            __context__.SourceCodeLine = 631;
                                                                                                                                                            TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                            __context__.SourceCodeLine = 632;
                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 != "UNKN"))  ) ) 
                                                                                                                                                                { 
                                                                                                                                                                __context__.SourceCodeLine = 634;
                                                                                                                                                                TX_TYPE2  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                } 
                                                                                                                                                            
                                                                                                                                                            __context__.SourceCodeLine = 636;
                                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                            } 
                                                                                                                                                        
                                                                                                                                                        else 
                                                                                                                                                            {
                                                                                                                                                            __context__.SourceCodeLine = 639;
                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_TYPE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                { 
                                                                                                                                                                __context__.SourceCodeLine = 642;
                                                                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 BATT_TYPE "  ) ; 
                                                                                                                                                                __context__.SourceCodeLine = 643;
                                                                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                __context__.SourceCodeLine = 644;
                                                                                                                                                                TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                __context__.SourceCodeLine = 645;
                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 != "UNKN"))  ) ) 
                                                                                                                                                                    { 
                                                                                                                                                                    __context__.SourceCodeLine = 647;
                                                                                                                                                                    BATT_TYPE1  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                    } 
                                                                                                                                                                
                                                                                                                                                                __context__.SourceCodeLine = 649;
                                                                                                                                                                BATTTYPE1__DOLLAR__  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                __context__.SourceCodeLine = 650;
                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BATTTYPE1__DOLLAR__ == "ALKA"))  ) ) 
                                                                                                                                                                    { 
                                                                                                                                                                    __context__.SourceCodeLine = 652;
                                                                                                                                                                    B1HRMIN  .UpdateValue ( "AA"  ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 653;
                                                                                                                                                                    B1STATUS  .Value = (ushort) ( 2 ) ; 
                                                                                                                                                                    } 
                                                                                                                                                                
                                                                                                                                                                __context__.SourceCodeLine = 660;
                                                                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                __context__.SourceCodeLine = 661;
                                                                                                                                                                /* Trace( "3 B1Bars is {0:d} and BattType1$ is {1}", (short)B1BARS  .Value, BATTTYPE1__DOLLAR__ ) */ ; 
                                                                                                                                                                __context__.SourceCodeLine = 662;
                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( B1BARS  .Value < 2 ) ) && Functions.TestForTrue ( Functions.BoolToInt (BATTTYPE1__DOLLAR__ == "ALKA") )) ))  ) ) 
                                                                                                                                                                    { 
                                                                                                                                                                    __context__.SourceCodeLine = 664;
                                                                                                                                                                    MIC1LESSTHEN1ANDAHALF  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 665;
                                                                                                                                                                    B1STATUS  .Value = (ushort) ( 3 ) ; 
                                                                                                                                                                    } 
                                                                                                                                                                
                                                                                                                                                                } 
                                                                                                                                                            
                                                                                                                                                            else 
                                                                                                                                                                {
                                                                                                                                                                __context__.SourceCodeLine = 669;
                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_TYPE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                    { 
                                                                                                                                                                    __context__.SourceCodeLine = 672;
                                                                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 673;
                                                                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 BATT_TYPE "  ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 674;
                                                                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 675;
                                                                                                                                                                    TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 676;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 != "UNKN"))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 678;
                                                                                                                                                                        BATT_TYPE2  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    __context__.SourceCodeLine = 680;
                                                                                                                                                                    BATTTYPE2__DOLLAR__  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 681;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BATTTYPE2__DOLLAR__ == "ALKA"))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 683;
                                                                                                                                                                        B2HRMIN  .UpdateValue ( "AA"  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 684;
                                                                                                                                                                        B2STATUS  .Value = (ushort) ( 2 ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    __context__.SourceCodeLine = 691;
                                                                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                    __context__.SourceCodeLine = 692;
                                                                                                                                                                    /* Trace( "4 B2Bars is {0:d} and BattType2$ is {1}", (short)B2BARS  .Value, BATTTYPE2__DOLLAR__ ) */ ; 
                                                                                                                                                                    __context__.SourceCodeLine = 693;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( B2BARS  .Value < 2 ) ) && Functions.TestForTrue ( Functions.BoolToInt (BATTTYPE2__DOLLAR__ == "ALKA") )) ))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 695;
                                                                                                                                                                        MIC2LESSTHEN1ANDAHALF  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 696;
                                                                                                                                                                        B2STATUS  .Value = (ushort) ( 3 ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    } 
                                                                                                                                                                
                                                                                                                                                                else 
                                                                                                                                                                    {
                                                                                                                                                                    __context__.SourceCodeLine = 700;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_RUN_TIME " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 703;
                                                                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 BATT_RUN_TIME "  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 704;
                                                                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 705;
                                                                                                                                                                        TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 706;
                                                                                                                                                                        BATT_RUN_TIME1  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 707;
                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 == "65534"))  ) ) 
                                                                                                                                                                            { 
                                                                                                                                                                            __context__.SourceCodeLine = 709;
                                                                                                                                                                            B1HRMIN  .UpdateValue ( "Calc"  ) ; 
                                                                                                                                                                            __context__.SourceCodeLine = 710;
                                                                                                                                                                            B1STATUS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                            } 
                                                                                                                                                                        
                                                                                                                                                                        else 
                                                                                                                                                                            {
                                                                                                                                                                            __context__.SourceCodeLine = 712;
                                                                                                                                                                            if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( TEMPSTRING2 , "65532" ) < 0))  ) ) 
                                                                                                                                                                                { 
                                                                                                                                                                                __context__.SourceCodeLine = 714;
                                                                                                                                                                                B1TIME  .Value = (ushort) ( Functions.Atoi( TEMPSTRING2 ) ) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 715;
                                                                                                                                                                                HRS1 = (ushort) ( (B1TIME  .Value / 60) ) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 716;
                                                                                                                                                                                MakeString ( B1HRMIN , "{0:d}:{1:d2}", (short)HRS1, (short)Mod( B1TIME  .Value , 60 )) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 718;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HRS1 < 3 ))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 720;
                                                                                                                                                                                    MIC1LESSTHEN3  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 721;
                                                                                                                                                                                    B1STATUS  .Value = (ushort) ( 2 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                else 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 725;
                                                                                                                                                                                    MIC1LESSTHEN3  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                __context__.SourceCodeLine = 727;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HRS1 < 5 ))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 729;
                                                                                                                                                                                    MIC1LESSTHEN5  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 730;
                                                                                                                                                                                    B1STATUS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                else 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 734;
                                                                                                                                                                                    MIC1LESSTHEN5  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 735;
                                                                                                                                                                                    B1STATUS  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                __context__.SourceCodeLine = 737;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( B1TIME  .Value < 90 ))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 739;
                                                                                                                                                                                    MIC1LESSTHEN1ANDAHALF  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 740;
                                                                                                                                                                                    B1STATUS  .Value = (ushort) ( 3 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                else 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 744;
                                                                                                                                                                                    MIC1LESSTHEN1ANDAHALF  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                } 
                                                                                                                                                                            
                                                                                                                                                                            }
                                                                                                                                                                        
                                                                                                                                                                        __context__.SourceCodeLine = 747;
                                                                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    else 
                                                                                                                                                                        {
                                                                                                                                                                        __context__.SourceCodeLine = 750;
                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_RUN_TIME " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                            { 
                                                                                                                                                                            __context__.SourceCodeLine = 753;
                                                                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                            __context__.SourceCodeLine = 754;
                                                                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 BATT_RUN_TIME "  ) ; 
                                                                                                                                                                            __context__.SourceCodeLine = 755;
                                                                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                            __context__.SourceCodeLine = 756;
                                                                                                                                                                            TEMPSTRING2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                            __context__.SourceCodeLine = 757;
                                                                                                                                                                            BATT_RUN_TIME2  .UpdateValue ( TEMPSTRING2  ) ; 
                                                                                                                                                                            __context__.SourceCodeLine = 758;
                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING2 == "65534"))  ) ) 
                                                                                                                                                                                { 
                                                                                                                                                                                __context__.SourceCodeLine = 760;
                                                                                                                                                                                B2HRMIN  .UpdateValue ( "Calc"  ) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 761;
                                                                                                                                                                                B2STATUS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                } 
                                                                                                                                                                            
                                                                                                                                                                            else 
                                                                                                                                                                                {
                                                                                                                                                                                __context__.SourceCodeLine = 763;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( TEMPSTRING2 , "65532" ) < 0))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 765;
                                                                                                                                                                                    B2TIME  .Value = (ushort) ( Functions.Atoi( TEMPSTRING2 ) ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 766;
                                                                                                                                                                                    HRS2 = (ushort) ( (B2TIME  .Value / 60) ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 767;
                                                                                                                                                                                    MakeString ( B2HRMIN , "{0:d}:{1:d2}", (short)HRS2, (short)Mod( B2TIME  .Value , 60 )) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 768;
                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HRS2 < 3 ))  ) ) 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 770;
                                                                                                                                                                                        MIC2LESSTHEN3  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 771;
                                                                                                                                                                                        B2STATUS  .Value = (ushort) ( 2 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    else 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 775;
                                                                                                                                                                                        MIC2LESSTHEN3  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    __context__.SourceCodeLine = 777;
                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HRS2 < 5 ))  ) ) 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 779;
                                                                                                                                                                                        MIC2LESSTHEN5  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 780;
                                                                                                                                                                                        B2STATUS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    else 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 784;
                                                                                                                                                                                        MIC2LESSTHEN5  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 785;
                                                                                                                                                                                        B2STATUS  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    __context__.SourceCodeLine = 787;
                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( B2TIME  .Value < 90 ))  ) ) 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 789;
                                                                                                                                                                                        MIC2LESSTHEN1ANDAHALF  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 790;
                                                                                                                                                                                        B2STATUS  .Value = (ushort) ( 3 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    else 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 794;
                                                                                                                                                                                        MIC2LESSTHEN1ANDAHALF  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                }
                                                                                                                                                                            
                                                                                                                                                                            __context__.SourceCodeLine = 797;
                                                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                            } 
                                                                                                                                                                        
                                                                                                                                                                        else 
                                                                                                                                                                            {
                                                                                                                                                                            __context__.SourceCodeLine = 800;
                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_CHARGE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                { 
                                                                                                                                                                                __context__.SourceCodeLine = 803;
                                                                                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 BATT_CHARGE "  ) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 804;
                                                                                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 805;
                                                                                                                                                                                BATT_CHARGE1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                __context__.SourceCodeLine = 806;
                                                                                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                } 
                                                                                                                                                                            
                                                                                                                                                                            else 
                                                                                                                                                                                {
                                                                                                                                                                                __context__.SourceCodeLine = 808;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_CHARGE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 811;
                                                                                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 812;
                                                                                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 BATT_CHARGE "  ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 813;
                                                                                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 814;
                                                                                                                                                                                    BATT_CHARGE2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                    __context__.SourceCodeLine = 815;
                                                                                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                else 
                                                                                                                                                                                    {
                                                                                                                                                                                    __context__.SourceCodeLine = 818;
                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_CYCLE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 821;
                                                                                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 BATT_CYCLE "  ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 822;
                                                                                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 823;
                                                                                                                                                                                        BATT_CYCLE1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 824;
                                                                                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    else 
                                                                                                                                                                                        {
                                                                                                                                                                                        __context__.SourceCodeLine = 827;
                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_CYCLE " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                            { 
                                                                                                                                                                                            __context__.SourceCodeLine = 830;
                                                                                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                            __context__.SourceCodeLine = 831;
                                                                                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 BATT_CYCLE "  ) ; 
                                                                                                                                                                                            __context__.SourceCodeLine = 832;
                                                                                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                            __context__.SourceCodeLine = 833;
                                                                                                                                                                                            BATT_CYCLE2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                            __context__.SourceCodeLine = 834;
                                                                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                            } 
                                                                                                                                                                                        
                                                                                                                                                                                        else 
                                                                                                                                                                                            {
                                                                                                                                                                                            __context__.SourceCodeLine = 837;
                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_TEMP_C " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                { 
                                                                                                                                                                                                __context__.SourceCodeLine = 840;
                                                                                                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 BATT_TEMP_C "  ) ; 
                                                                                                                                                                                                __context__.SourceCodeLine = 841;
                                                                                                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                __context__.SourceCodeLine = 842;
                                                                                                                                                                                                BATT_TEMP_C1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                __context__.SourceCodeLine = 843;
                                                                                                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                } 
                                                                                                                                                                                            
                                                                                                                                                                                            else 
                                                                                                                                                                                                {
                                                                                                                                                                                                __context__.SourceCodeLine = 846;
                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_TEMP_C " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                    { 
                                                                                                                                                                                                    __context__.SourceCodeLine = 849;
                                                                                                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                    __context__.SourceCodeLine = 850;
                                                                                                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 BATT_TEMP_C "  ) ; 
                                                                                                                                                                                                    __context__.SourceCodeLine = 851;
                                                                                                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                    __context__.SourceCodeLine = 852;
                                                                                                                                                                                                    BATT_TEMP_C2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                    __context__.SourceCodeLine = 853;
                                                                                                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                    } 
                                                                                                                                                                                                
                                                                                                                                                                                                else 
                                                                                                                                                                                                    {
                                                                                                                                                                                                    __context__.SourceCodeLine = 856;
                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 BATT_TEMP_F " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                        { 
                                                                                                                                                                                                        __context__.SourceCodeLine = 859;
                                                                                                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 BATT_TEMP_F "  ) ; 
                                                                                                                                                                                                        __context__.SourceCodeLine = 860;
                                                                                                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                        __context__.SourceCodeLine = 861;
                                                                                                                                                                                                        BATT_TEMP_F1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                        __context__.SourceCodeLine = 862;
                                                                                                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                        } 
                                                                                                                                                                                                    
                                                                                                                                                                                                    else 
                                                                                                                                                                                                        {
                                                                                                                                                                                                        __context__.SourceCodeLine = 865;
                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 BATT_TEMP_F " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                            { 
                                                                                                                                                                                                            __context__.SourceCodeLine = 868;
                                                                                                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                            __context__.SourceCodeLine = 869;
                                                                                                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 BATT_TEMP_F "  ) ; 
                                                                                                                                                                                                            __context__.SourceCodeLine = 870;
                                                                                                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                            __context__.SourceCodeLine = 871;
                                                                                                                                                                                                            BATT_TEMP_F2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                            __context__.SourceCodeLine = 872;
                                                                                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                            } 
                                                                                                                                                                                                        
                                                                                                                                                                                                        else 
                                                                                                                                                                                                            {
                                                                                                                                                                                                            __context__.SourceCodeLine = 875;
                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 TX_PWR_LOCK " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                                { 
                                                                                                                                                                                                                __context__.SourceCodeLine = 878;
                                                                                                                                                                                                                SEARCHSTRING  .UpdateValue ( "REP 1 TX_PWR_LOCK "  ) ; 
                                                                                                                                                                                                                __context__.SourceCodeLine = 879;
                                                                                                                                                                                                                STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                                __context__.SourceCodeLine = 880;
                                                                                                                                                                                                                TX_PWR_LOCK1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                                __context__.SourceCodeLine = 881;
                                                                                                                                                                                                                TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                } 
                                                                                                                                                                                                            
                                                                                                                                                                                                            else 
                                                                                                                                                                                                                {
                                                                                                                                                                                                                __context__.SourceCodeLine = 884;
                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 TX_PWR_LOCK " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                    __context__.SourceCodeLine = 887;
                                                                                                                                                                                                                    MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                                    __context__.SourceCodeLine = 888;
                                                                                                                                                                                                                    SEARCHSTRING  .UpdateValue ( "REP 2 TX_PWR_LOCK "  ) ; 
                                                                                                                                                                                                                    __context__.SourceCodeLine = 889;
                                                                                                                                                                                                                    STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                                    __context__.SourceCodeLine = 890;
                                                                                                                                                                                                                    TX_PWR_LOCK2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                                    __context__.SourceCodeLine = 891;
                                                                                                                                                                                                                    TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                
                                                                                                                                                                                                                else 
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                    __context__.SourceCodeLine = 894;
                                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "REP 1 TX_MENU_LOCK " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                        __context__.SourceCodeLine = 897;
                                                                                                                                                                                                                        SEARCHSTRING  .UpdateValue ( "REP 1 TX_MENU_LOCK "  ) ; 
                                                                                                                                                                                                                        __context__.SourceCodeLine = 898;
                                                                                                                                                                                                                        STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                                        __context__.SourceCodeLine = 899;
                                                                                                                                                                                                                        TX_MENU_LOCK1  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                                        __context__.SourceCodeLine = 900;
                                                                                                                                                                                                                        TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                    
                                                                                                                                                                                                                    else 
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                        __context__.SourceCodeLine = 903;
                                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "REP 2 TX_MENU_LOCK " , TEMPSTRING1 ))  ) ) 
                                                                                                                                                                                                                            { 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 906;
                                                                                                                                                                                                                            MIC2_EXISTS  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 907;
                                                                                                                                                                                                                            SEARCHSTRING  .UpdateValue ( "REP 2 TX_MENU_LOCK "  ) ; 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 908;
                                                                                                                                                                                                                            STARTPOSITION = (ushort) ( (Functions.Find( SEARCHSTRING , TEMPSTRING1 ) + Functions.Length( SEARCHSTRING )) ) ; 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 909;
                                                                                                                                                                                                                            TX_MENU_LOCK2  .UpdateValue ( Functions.Mid ( TEMPSTRING1 ,  (int) ( STARTPOSITION ) ,  (int) ( (Functions.Find( " >" , TEMPSTRING1 , STARTPOSITION ) - STARTPOSITION) ) )  ) ; 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 910;
                                                                                                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                            } 
                                                                                                                                                                                                                        
                                                                                                                                                                                                                        else 
                                                                                                                                                                                                                            { 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 916;
                                                                                                                                                                                                                            TEMPSTRING1  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                            } 
                                                                                                                                                                                                                        
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                
                                                                                                                                                                                                                }
                                                                                                                                                                                                            
                                                                                                                                                                                                            }
                                                                                                                                                                                                        
                                                                                                                                                                                                        }
                                                                                                                                                                                                    
                                                                                                                                                                                                    }
                                                                                                                                                                                                
                                                                                                                                                                                                }
                                                                                                                                                                                            
                                                                                                                                                                                            }
                                                                                                                                                                                        
                                                                                                                                                                                        }
                                                                                                                                                                                    
                                                                                                                                                                                    }
                                                                                                                                                                                
                                                                                                                                                                                }
                                                                                                                                                                            
                                                                                                                                                                            }
                                                                                                                                                                        
                                                                                                                                                                        }
                                                                                                                                                                    
                                                                                                                                                                    }
                                                                                                                                                                
                                                                                                                                                                }
                                                                                                                                                            
                                                                                                                                                            }
                                                                                                                                                        
                                                                                                                                                        }
                                                                                                                                                    
                                                                                                                                                    }
                                                                                                                                                
                                                                                                                                                }
                                                                                                                                            
                                                                                                                                            }
                                                                                                                                        
                                                                                                                                        }
                                                                                                                                    
                                                                                                                                    }
                                                                                                                                
                                                                                                                                }
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 221;
            } 
        
        __context__.SourceCodeLine = 919;
        FROM_WIRELESS__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 969;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 970;
        TCP_IP_CLIENT_CONNECT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 971;
        MIC1LESSTHEN1ANDAHALF  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 972;
        MIC1LESSTHEN3  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 973;
        MIC1LESSTHEN5  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 974;
        MIC2LESSTHEN1ANDAHALF  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 975;
        MIC2LESSTHEN3  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 976;
        MIC2LESSTHEN5  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 977;
        MIC2_EXISTS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 978;
        B1STATUS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 979;
        B2STATUS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 980;
        BATTTYPE1__DOLLAR__  .UpdateValue ( "UNKN"  ) ; 
        __context__.SourceCodeLine = 981;
        BATTTYPE2__DOLLAR__  .UpdateValue ( "UNKN"  ) ; 
        
        
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
    BATTTYPE1__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    BATTTYPE2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    GET_ALL = new Crestron.Logos.SplusObjects.DigitalInput( GET_ALL__DigitalInput__, this );
    m_DigitalInputList.Add( GET_ALL__DigitalInput__, GET_ALL );
    
    TCP_IP_CLIENT_CONNECT_F = new Crestron.Logos.SplusObjects.DigitalInput( TCP_IP_CLIENT_CONNECT_F__DigitalInput__, this );
    m_DigitalInputList.Add( TCP_IP_CLIENT_CONNECT_F__DigitalInput__, TCP_IP_CLIENT_CONNECT_F );
    
    TCP_IP_CLIENT_CONNECT = new Crestron.Logos.SplusObjects.DigitalOutput( TCP_IP_CLIENT_CONNECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( TCP_IP_CLIENT_CONNECT__DigitalOutput__, TCP_IP_CLIENT_CONNECT );
    
    MIC1_ON = new Crestron.Logos.SplusObjects.DigitalOutput( MIC1_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC1_ON__DigitalOutput__, MIC1_ON );
    
    MIC1LESSTHEN5 = new Crestron.Logos.SplusObjects.DigitalOutput( MIC1LESSTHEN5__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC1LESSTHEN5__DigitalOutput__, MIC1LESSTHEN5 );
    
    MIC1LESSTHEN3 = new Crestron.Logos.SplusObjects.DigitalOutput( MIC1LESSTHEN3__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC1LESSTHEN3__DigitalOutput__, MIC1LESSTHEN3 );
    
    MIC1LESSTHEN1ANDAHALF = new Crestron.Logos.SplusObjects.DigitalOutput( MIC1LESSTHEN1ANDAHALF__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC1LESSTHEN1ANDAHALF__DigitalOutput__, MIC1LESSTHEN1ANDAHALF );
    
    MIC1_RF_INT_DET = new Crestron.Logos.SplusObjects.DigitalOutput( MIC1_RF_INT_DET__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC1_RF_INT_DET__DigitalOutput__, MIC1_RF_INT_DET );
    
    MIC2_ON = new Crestron.Logos.SplusObjects.DigitalOutput( MIC2_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC2_ON__DigitalOutput__, MIC2_ON );
    
    MIC2LESSTHEN5 = new Crestron.Logos.SplusObjects.DigitalOutput( MIC2LESSTHEN5__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC2LESSTHEN5__DigitalOutput__, MIC2LESSTHEN5 );
    
    MIC2LESSTHEN3 = new Crestron.Logos.SplusObjects.DigitalOutput( MIC2LESSTHEN3__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC2LESSTHEN3__DigitalOutput__, MIC2LESSTHEN3 );
    
    MIC2LESSTHEN1ANDAHALF = new Crestron.Logos.SplusObjects.DigitalOutput( MIC2LESSTHEN1ANDAHALF__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC2LESSTHEN1ANDAHALF__DigitalOutput__, MIC2LESSTHEN1ANDAHALF );
    
    MIC2_RF_INT_DET = new Crestron.Logos.SplusObjects.DigitalOutput( MIC2_RF_INT_DET__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC2_RF_INT_DET__DigitalOutput__, MIC2_RF_INT_DET );
    
    MIC2_EXISTS = new Crestron.Logos.SplusObjects.DigitalOutput( MIC2_EXISTS__DigitalOutput__, this );
    m_DigitalOutputList.Add( MIC2_EXISTS__DigitalOutput__, MIC2_EXISTS );
    
    B1TIME = new Crestron.Logos.SplusObjects.AnalogOutput( B1TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B1TIME__AnalogSerialOutput__, B1TIME );
    
    B1PERCENT = new Crestron.Logos.SplusObjects.AnalogOutput( B1PERCENT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B1PERCENT__AnalogSerialOutput__, B1PERCENT );
    
    B1BARS = new Crestron.Logos.SplusObjects.AnalogOutput( B1BARS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B1BARS__AnalogSerialOutput__, B1BARS );
    
    B2TIME = new Crestron.Logos.SplusObjects.AnalogOutput( B2TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B2TIME__AnalogSerialOutput__, B2TIME );
    
    B2PERCENT = new Crestron.Logos.SplusObjects.AnalogOutput( B2PERCENT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B2PERCENT__AnalogSerialOutput__, B2PERCENT );
    
    B2BARS = new Crestron.Logos.SplusObjects.AnalogOutput( B2BARS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B2BARS__AnalogSerialOutput__, B2BARS );
    
    B1STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( B1STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B1STATUS__AnalogSerialOutput__, B1STATUS );
    
    B2STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( B2STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( B2STATUS__AnalogSerialOutput__, B2STATUS );
    
    TO_WIRELESS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_WIRELESS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_WIRELESS__DOLLAR____AnalogSerialOutput__, TO_WIRELESS__DOLLAR__ );
    
    DEVICE_ID = new Crestron.Logos.SplusObjects.StringOutput( DEVICE_ID__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEVICE_ID__AnalogSerialOutput__, DEVICE_ID );
    
    FREQUENCY_DIVERSITY_MODE = new Crestron.Logos.SplusObjects.StringOutput( FREQUENCY_DIVERSITY_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FREQUENCY_DIVERSITY_MODE__AnalogSerialOutput__, FREQUENCY_DIVERSITY_MODE );
    
    AUDIO_SUMMING_MODE = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_SUMMING_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_SUMMING_MODE__AnalogSerialOutput__, AUDIO_SUMMING_MODE );
    
    HIGH_DENSITY = new Crestron.Logos.SplusObjects.StringOutput( HIGH_DENSITY__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HIGH_DENSITY__AnalogSerialOutput__, HIGH_DENSITY );
    
    ENCRYPTION = new Crestron.Logos.SplusObjects.StringOutput( ENCRYPTION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENCRYPTION__AnalogSerialOutput__, ENCRYPTION );
    
    ENCRYPTION_REGENERATE_KEY = new Crestron.Logos.SplusObjects.StringOutput( ENCRYPTION_REGENERATE_KEY__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENCRYPTION_REGENERATE_KEY__AnalogSerialOutput__, ENCRYPTION_REGENERATE_KEY );
    
    CHAN_NAME1 = new Crestron.Logos.SplusObjects.StringOutput( CHAN_NAME1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHAN_NAME1__AnalogSerialOutput__, CHAN_NAME1 );
    
    METER_RATE1 = new Crestron.Logos.SplusObjects.StringOutput( METER_RATE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( METER_RATE1__AnalogSerialOutput__, METER_RATE1 );
    
    AUDIO_GAIN1 = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_GAIN1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_GAIN1__AnalogSerialOutput__, AUDIO_GAIN1 );
    
    AUDIO_MUTE1 = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_MUTE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_MUTE1__AnalogSerialOutput__, AUDIO_MUTE1 );
    
    AUDIO_LVL1 = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_LVL1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_LVL1__AnalogSerialOutput__, AUDIO_LVL1 );
    
    GROUP_CHAN1 = new Crestron.Logos.SplusObjects.StringOutput( GROUP_CHAN1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GROUP_CHAN1__AnalogSerialOutput__, GROUP_CHAN1 );
    
    FREQUENCY1 = new Crestron.Logos.SplusObjects.StringOutput( FREQUENCY1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FREQUENCY1__AnalogSerialOutput__, FREQUENCY1 );
    
    RF_INT_DET1 = new Crestron.Logos.SplusObjects.StringOutput( RF_INT_DET1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RF_INT_DET1__AnalogSerialOutput__, RF_INT_DET1 );
    
    RX_RF_LVL1 = new Crestron.Logos.SplusObjects.StringOutput( RX_RF_LVL1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RX_RF_LVL1__AnalogSerialOutput__, RX_RF_LVL1 );
    
    RF_ANTENNA1 = new Crestron.Logos.SplusObjects.StringOutput( RF_ANTENNA1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RF_ANTENNA1__AnalogSerialOutput__, RF_ANTENNA1 );
    
    BATT_BARS1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_BARS1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_BARS1__AnalogSerialOutput__, BATT_BARS1 );
    
    TX_OFFSET1 = new Crestron.Logos.SplusObjects.StringOutput( TX_OFFSET1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_OFFSET1__AnalogSerialOutput__, TX_OFFSET1 );
    
    TX_RF_PWR1 = new Crestron.Logos.SplusObjects.StringOutput( TX_RF_PWR1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_RF_PWR1__AnalogSerialOutput__, TX_RF_PWR1 );
    
    TX_TYPE1 = new Crestron.Logos.SplusObjects.StringOutput( TX_TYPE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_TYPE1__AnalogSerialOutput__, TX_TYPE1 );
    
    BATT_TYPE1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_TYPE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_TYPE1__AnalogSerialOutput__, BATT_TYPE1 );
    
    BATT_RUN_TIME1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_RUN_TIME1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_RUN_TIME1__AnalogSerialOutput__, BATT_RUN_TIME1 );
    
    BATT_CHARGE1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_CHARGE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_CHARGE1__AnalogSerialOutput__, BATT_CHARGE1 );
    
    BATT_CYCLE1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_CYCLE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_CYCLE1__AnalogSerialOutput__, BATT_CYCLE1 );
    
    BATT_TEMP_C1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_TEMP_C1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_TEMP_C1__AnalogSerialOutput__, BATT_TEMP_C1 );
    
    BATT_TEMP_F1 = new Crestron.Logos.SplusObjects.StringOutput( BATT_TEMP_F1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_TEMP_F1__AnalogSerialOutput__, BATT_TEMP_F1 );
    
    TX_PWR_LOCK1 = new Crestron.Logos.SplusObjects.StringOutput( TX_PWR_LOCK1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_PWR_LOCK1__AnalogSerialOutput__, TX_PWR_LOCK1 );
    
    TX_MENU_LOCK1 = new Crestron.Logos.SplusObjects.StringOutput( TX_MENU_LOCK1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_MENU_LOCK1__AnalogSerialOutput__, TX_MENU_LOCK1 );
    
    ENCRYPTION_WARNING1 = new Crestron.Logos.SplusObjects.StringOutput( ENCRYPTION_WARNING1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENCRYPTION_WARNING1__AnalogSerialOutput__, ENCRYPTION_WARNING1 );
    
    B1HRMIN = new Crestron.Logos.SplusObjects.StringOutput( B1HRMIN__AnalogSerialOutput__, this );
    m_StringOutputList.Add( B1HRMIN__AnalogSerialOutput__, B1HRMIN );
    
    M1ONDAT = new Crestron.Logos.SplusObjects.StringOutput( M1ONDAT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( M1ONDAT__AnalogSerialOutput__, M1ONDAT );
    
    M1OFFDAT = new Crestron.Logos.SplusObjects.StringOutput( M1OFFDAT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( M1OFFDAT__AnalogSerialOutput__, M1OFFDAT );
    
    CHAN_NAME2 = new Crestron.Logos.SplusObjects.StringOutput( CHAN_NAME2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHAN_NAME2__AnalogSerialOutput__, CHAN_NAME2 );
    
    METER_RATE2 = new Crestron.Logos.SplusObjects.StringOutput( METER_RATE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( METER_RATE2__AnalogSerialOutput__, METER_RATE2 );
    
    AUDIO_GAIN2 = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_GAIN2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_GAIN2__AnalogSerialOutput__, AUDIO_GAIN2 );
    
    AUDIO_MUTE2 = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_MUTE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_MUTE2__AnalogSerialOutput__, AUDIO_MUTE2 );
    
    AUDIO_LVL2 = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_LVL2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_LVL2__AnalogSerialOutput__, AUDIO_LVL2 );
    
    GROUP_CHAN2 = new Crestron.Logos.SplusObjects.StringOutput( GROUP_CHAN2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GROUP_CHAN2__AnalogSerialOutput__, GROUP_CHAN2 );
    
    FREQUENCY2 = new Crestron.Logos.SplusObjects.StringOutput( FREQUENCY2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FREQUENCY2__AnalogSerialOutput__, FREQUENCY2 );
    
    RF_INT_DET2 = new Crestron.Logos.SplusObjects.StringOutput( RF_INT_DET2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RF_INT_DET2__AnalogSerialOutput__, RF_INT_DET2 );
    
    RX_RF_LVL2 = new Crestron.Logos.SplusObjects.StringOutput( RX_RF_LVL2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RX_RF_LVL2__AnalogSerialOutput__, RX_RF_LVL2 );
    
    RF_ANTENNA2 = new Crestron.Logos.SplusObjects.StringOutput( RF_ANTENNA2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RF_ANTENNA2__AnalogSerialOutput__, RF_ANTENNA2 );
    
    BATT_BARS2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_BARS2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_BARS2__AnalogSerialOutput__, BATT_BARS2 );
    
    TX_OFFSET2 = new Crestron.Logos.SplusObjects.StringOutput( TX_OFFSET2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_OFFSET2__AnalogSerialOutput__, TX_OFFSET2 );
    
    TX_RF_PWR2 = new Crestron.Logos.SplusObjects.StringOutput( TX_RF_PWR2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_RF_PWR2__AnalogSerialOutput__, TX_RF_PWR2 );
    
    TX_TYPE2 = new Crestron.Logos.SplusObjects.StringOutput( TX_TYPE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_TYPE2__AnalogSerialOutput__, TX_TYPE2 );
    
    BATT_TYPE2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_TYPE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_TYPE2__AnalogSerialOutput__, BATT_TYPE2 );
    
    BATT_RUN_TIME2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_RUN_TIME2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_RUN_TIME2__AnalogSerialOutput__, BATT_RUN_TIME2 );
    
    BATT_CHARGE2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_CHARGE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_CHARGE2__AnalogSerialOutput__, BATT_CHARGE2 );
    
    BATT_CYCLE2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_CYCLE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_CYCLE2__AnalogSerialOutput__, BATT_CYCLE2 );
    
    BATT_TEMP_C2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_TEMP_C2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_TEMP_C2__AnalogSerialOutput__, BATT_TEMP_C2 );
    
    BATT_TEMP_F2 = new Crestron.Logos.SplusObjects.StringOutput( BATT_TEMP_F2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BATT_TEMP_F2__AnalogSerialOutput__, BATT_TEMP_F2 );
    
    TX_PWR_LOCK2 = new Crestron.Logos.SplusObjects.StringOutput( TX_PWR_LOCK2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_PWR_LOCK2__AnalogSerialOutput__, TX_PWR_LOCK2 );
    
    TX_MENU_LOCK2 = new Crestron.Logos.SplusObjects.StringOutput( TX_MENU_LOCK2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX_MENU_LOCK2__AnalogSerialOutput__, TX_MENU_LOCK2 );
    
    ENCRYPTION_WARNING2 = new Crestron.Logos.SplusObjects.StringOutput( ENCRYPTION_WARNING2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENCRYPTION_WARNING2__AnalogSerialOutput__, ENCRYPTION_WARNING2 );
    
    B2HRMIN = new Crestron.Logos.SplusObjects.StringOutput( B2HRMIN__AnalogSerialOutput__, this );
    m_StringOutputList.Add( B2HRMIN__AnalogSerialOutput__, B2HRMIN );
    
    M2ONDAT = new Crestron.Logos.SplusObjects.StringOutput( M2ONDAT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( M2ONDAT__AnalogSerialOutput__, M2ONDAT );
    
    M2OFFDAT = new Crestron.Logos.SplusObjects.StringOutput( M2OFFDAT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( M2OFFDAT__AnalogSerialOutput__, M2OFFDAT );
    
    FROM_WIRELESS__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_WIRELESS__DOLLAR____AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( FROM_WIRELESS__DOLLAR____AnalogSerialInput__, FROM_WIRELESS__DOLLAR__ );
    
    
    GET_ALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_ALL_OnPush_0, false ) );
    TCP_IP_CLIENT_CONNECT_F.OnDigitalPush.Add( new InputChangeHandlerWrapper( TCP_IP_CLIENT_CONNECT_F_OnPush_1, false ) );
    FROM_WIRELESS__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_WIRELESS__DOLLAR___OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_WIRELESS_MIC_MONITORING ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint GET_ALL__DigitalInput__ = 0;
const uint TCP_IP_CLIENT_CONNECT_F__DigitalInput__ = 1;
const uint FROM_WIRELESS__DOLLAR____AnalogSerialInput__ = 0;
const uint TCP_IP_CLIENT_CONNECT__DigitalOutput__ = 0;
const uint MIC1_ON__DigitalOutput__ = 1;
const uint MIC1LESSTHEN5__DigitalOutput__ = 2;
const uint MIC1LESSTHEN3__DigitalOutput__ = 3;
const uint MIC1LESSTHEN1ANDAHALF__DigitalOutput__ = 4;
const uint MIC1_RF_INT_DET__DigitalOutput__ = 5;
const uint MIC2_ON__DigitalOutput__ = 6;
const uint MIC2LESSTHEN5__DigitalOutput__ = 7;
const uint MIC2LESSTHEN3__DigitalOutput__ = 8;
const uint MIC2LESSTHEN1ANDAHALF__DigitalOutput__ = 9;
const uint MIC2_RF_INT_DET__DigitalOutput__ = 10;
const uint B1TIME__AnalogSerialOutput__ = 0;
const uint B1PERCENT__AnalogSerialOutput__ = 1;
const uint B1BARS__AnalogSerialOutput__ = 2;
const uint B2TIME__AnalogSerialOutput__ = 3;
const uint B2PERCENT__AnalogSerialOutput__ = 4;
const uint B2BARS__AnalogSerialOutput__ = 5;
const uint TO_WIRELESS__DOLLAR____AnalogSerialOutput__ = 6;
const uint DEVICE_ID__AnalogSerialOutput__ = 7;
const uint FREQUENCY_DIVERSITY_MODE__AnalogSerialOutput__ = 8;
const uint AUDIO_SUMMING_MODE__AnalogSerialOutput__ = 9;
const uint HIGH_DENSITY__AnalogSerialOutput__ = 10;
const uint ENCRYPTION__AnalogSerialOutput__ = 11;
const uint ENCRYPTION_REGENERATE_KEY__AnalogSerialOutput__ = 12;
const uint CHAN_NAME1__AnalogSerialOutput__ = 13;
const uint METER_RATE1__AnalogSerialOutput__ = 14;
const uint AUDIO_GAIN1__AnalogSerialOutput__ = 15;
const uint AUDIO_MUTE1__AnalogSerialOutput__ = 16;
const uint AUDIO_LVL1__AnalogSerialOutput__ = 17;
const uint GROUP_CHAN1__AnalogSerialOutput__ = 18;
const uint FREQUENCY1__AnalogSerialOutput__ = 19;
const uint RF_INT_DET1__AnalogSerialOutput__ = 20;
const uint RX_RF_LVL1__AnalogSerialOutput__ = 21;
const uint RF_ANTENNA1__AnalogSerialOutput__ = 22;
const uint BATT_BARS1__AnalogSerialOutput__ = 23;
const uint TX_OFFSET1__AnalogSerialOutput__ = 24;
const uint TX_RF_PWR1__AnalogSerialOutput__ = 25;
const uint TX_TYPE1__AnalogSerialOutput__ = 26;
const uint BATT_TYPE1__AnalogSerialOutput__ = 27;
const uint BATT_RUN_TIME1__AnalogSerialOutput__ = 28;
const uint BATT_CHARGE1__AnalogSerialOutput__ = 29;
const uint BATT_CYCLE1__AnalogSerialOutput__ = 30;
const uint BATT_TEMP_C1__AnalogSerialOutput__ = 31;
const uint BATT_TEMP_F1__AnalogSerialOutput__ = 32;
const uint TX_PWR_LOCK1__AnalogSerialOutput__ = 33;
const uint TX_MENU_LOCK1__AnalogSerialOutput__ = 34;
const uint ENCRYPTION_WARNING1__AnalogSerialOutput__ = 35;
const uint B1HRMIN__AnalogSerialOutput__ = 36;
const uint M1ONDAT__AnalogSerialOutput__ = 37;
const uint M1OFFDAT__AnalogSerialOutput__ = 38;
const uint CHAN_NAME2__AnalogSerialOutput__ = 39;
const uint METER_RATE2__AnalogSerialOutput__ = 40;
const uint AUDIO_GAIN2__AnalogSerialOutput__ = 41;
const uint AUDIO_MUTE2__AnalogSerialOutput__ = 42;
const uint AUDIO_LVL2__AnalogSerialOutput__ = 43;
const uint GROUP_CHAN2__AnalogSerialOutput__ = 44;
const uint FREQUENCY2__AnalogSerialOutput__ = 45;
const uint RF_INT_DET2__AnalogSerialOutput__ = 46;
const uint RX_RF_LVL2__AnalogSerialOutput__ = 47;
const uint RF_ANTENNA2__AnalogSerialOutput__ = 48;
const uint BATT_BARS2__AnalogSerialOutput__ = 49;
const uint TX_OFFSET2__AnalogSerialOutput__ = 50;
const uint TX_RF_PWR2__AnalogSerialOutput__ = 51;
const uint TX_TYPE2__AnalogSerialOutput__ = 52;
const uint BATT_TYPE2__AnalogSerialOutput__ = 53;
const uint BATT_RUN_TIME2__AnalogSerialOutput__ = 54;
const uint BATT_CHARGE2__AnalogSerialOutput__ = 55;
const uint BATT_CYCLE2__AnalogSerialOutput__ = 56;
const uint BATT_TEMP_C2__AnalogSerialOutput__ = 57;
const uint BATT_TEMP_F2__AnalogSerialOutput__ = 58;
const uint TX_PWR_LOCK2__AnalogSerialOutput__ = 59;
const uint TX_MENU_LOCK2__AnalogSerialOutput__ = 60;
const uint ENCRYPTION_WARNING2__AnalogSerialOutput__ = 61;
const uint B2HRMIN__AnalogSerialOutput__ = 62;
const uint M2ONDAT__AnalogSerialOutput__ = 63;
const uint M2OFFDAT__AnalogSerialOutput__ = 64;
const uint MIC2_EXISTS__DigitalOutput__ = 11;
const uint B1STATUS__AnalogSerialOutput__ = 65;
const uint B2STATUS__AnalogSerialOutput__ = 66;

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
