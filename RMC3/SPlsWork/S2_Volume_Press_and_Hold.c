#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Volume_Press_and_Hold.h"

FUNCTION_MAIN( S2_Volume_Press_and_Hold );
EVENT_HANDLER( S2_Volume_Press_and_Hold );
DEFINE_ENTRYPOINT( S2_Volume_Press_and_Hold );



DEFINE_INDEPENDENT_EVENTHANDLER( S2_Volume_Press_and_Hold, 00000 /*Up_Press*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Volume_Press_and_Hold ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 33 );
    SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_UP_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 34 );
    Delay ( 50) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 35 );
    SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_UP_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 37 );
    while ( GetDigitalInput( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_UP_PRESS_DIG_INPUT )) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 40 );
        SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_UP_DIG_OUTPUT, 1) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 41 );
        Delay ( 25) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 42 );
        SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_UP_DIG_OUTPUT, 0) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 43 );
        Delay ( 25) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 37 );
        } 
    
    
    S2_Volume_Press_and_Hold_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Volume_Press_and_Hold, 00001 /*Down_Press*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Volume_Press_and_Hold ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 51 );
    SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_DOWN_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 52 );
    Delay ( 50) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 53 );
    SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_DOWN_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 55 );
    while ( GetDigitalInput( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_DOWN_PRESS_DIG_INPUT )) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 58 );
        SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_DOWN_DIG_OUTPUT, 1) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 59 );
        Delay ( 25) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 60 );
        SetDigital ( INSTANCE_PTR( S2_Volume_Press_and_Hold ), __S2_Volume_Press_and_Hold_VOLUME_DOWN_DIG_OUTPUT, 0) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 61 );
        Delay ( 25) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 55 );
        } 
    
    
    S2_Volume_Press_and_Hold_Exit__Event_1:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}


    
    

/********************************************************************************
  Constructor
********************************************************************************/

/********************************************************************************
  Destructor
********************************************************************************/

/********************************************************************************
  static void ProcessDigitalEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessDigitalEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        case __S2_Volume_Press_and_Hold_UP_PRESS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Volume_Press_and_Hold, 00000 /*Up_Press*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
                
            }
            break;
            
        case __S2_Volume_Press_and_Hold_DOWN_PRESS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Volume_Press_and_Hold, 00001 /*Down_Press*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessAnalogEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessAnalogEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Volume_Press_and_Hold ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketConnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketConnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Volume_Press_and_Hold ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketStatusEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketStatusEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Volume_Press_and_Hold )
********************************************************************************/
EVENT_HANDLER( S2_Volume_Press_and_Hold )
    {
    SAVE_GLOBAL_POINTERS ;
    switch ( Signal->Type )
        {
        case e_SIGNAL_TYPE_DIGITAL :
            ProcessDigitalEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_ANALOG :
            ProcessAnalogEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STRING :
            ProcessStringEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_CONNECT :
            ProcessSocketConnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_DISCONNECT :
            ProcessSocketDisconnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_RECEIVE :
            ProcessSocketReceiveEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STATUS :
            ProcessSocketStatusEvent( Signal );
            break ;
        }
        
    RESTORE_GLOBAL_POINTERS ;
    
    }
    
/********************************************************************************
  FUNCTION_MAIN( S2_Volume_Press_and_Hold )
********************************************************************************/
FUNCTION_MAIN( S2_Volume_Press_and_Hold )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Volume_Press_and_Hold );
    
    
    /* End local function variable declarations */
    
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Volume_Press_and_Hold, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Volume_Press_and_Hold ), 71 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_Volume_Press_and_Hold ) ) ; 
    
    S2_Volume_Press_and_Hold_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
